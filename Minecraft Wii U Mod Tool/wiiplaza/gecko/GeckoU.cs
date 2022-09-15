using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MetroFramework.Controls;
using Minecraft_Wii_U_Mod_Tool;

namespace wiiplaza.gecko
{
    public class GeckoUCore
    {
        #region todo
        /* Todo
         * Clean up some stuff to make the code look "nice"
         * Stuff i guess
         * Find a girlfriend
         * Get a life
         */
        #endregion todo

        #region base vars

        public GeckoUConnect GUC;

        private static int default_port = 7331;

        private const uint packetsize = 0x400;
        private const uint uplpacketsize = 0x400;
        private uint maximumMemoryChunkSize = 0x400;

        public enum FTDICommand
        {
            CMD_ResultError,
            CMD_FatalError,
            CMD_OK
        }

        #endregion base vars

        #region init
        /// <summary>
        /// Initialize the GeckoUConnection Class
        /// </summary>
        /// <param name="host">Wii U IP Address</param>
        public GeckoUCore(string host)
        {
            GUC = new GeckoUConnect(host, default_port);
        }

        /// <summary>
        /// Initialize the GeckoUConnection Class
        /// </summary>
        /// <param name="host">Wii U IP Address</param>
        /// <param name="port">Wii U Port</param>
        public GeckoUCore(string host, int port)
        {
            GUC = new GeckoUConnect(host, port);
        }
        #endregion connection

        #region the magic
        protected FTDICommand GeckoURead(byte[] recbyte, uint nobytes)
        {
            uint bytes_read = 0;

            try
            {
                GUC.Read(recbyte, nobytes, ref bytes_read);
            }
            catch (IOException)
            {
                GUC.Close();
                return FTDICommand.CMD_FatalError;
            }
            if (bytes_read != nobytes)
            {
                return FTDICommand.CMD_ResultError;
            }

            return FTDICommand.CMD_OK;
        }

        protected FTDICommand GeckoUWrite(byte[] sendbyte, Int32 nobytes)
        {
            uint bytes_written = 0;

            try
            {
                GUC.Write(sendbyte, nobytes, ref bytes_written);
            }
            catch (IOException)
            {
                GUC.Close();
                return FTDICommand.CMD_FatalError;
            }
            if (bytes_written != nobytes)
            {
                return FTDICommand.CMD_ResultError;
            }

            return FTDICommand.CMD_OK;
        }

        /// <summary>
        /// Send a Raw Command to the Wii U
        /// </summary>
        /// <param name="id">The raw command id</param>
        /// <returns>FTDICommand</returns>
        public FTDICommand RawCommand(Byte id)
        {
            return GeckoUWrite(BitConverter.GetBytes(id), 1);
        }

        /// <summary>
        /// Sends a command to the Wii U
        /// </summary>
        /// <param name="command">Command to send</param>
        private void SendCommand(GeckoUCommands.Command command)
        {
            uint bytesWritten = 0;
            GUC.Write(new[] { (byte)command }, 1, ref bytesWritten);
        }

        /// <summary>
        /// Read bytes from the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="length">Length of the bytes</param>
        /// <returns></returns>
        public byte[] ReadBytes(uint address, uint length)
        {
            try
            {
                RequestBytes(address, length);

                uint bytesRead = 0;
                var response = new byte[1];
                GUC.Read(response, 1, ref bytesRead);

                var ms = new MemoryStream();

                if (response[0] == 0xB0)
                {
                    return ms.ToArray();
                }

                uint remainingBytesCount = length;
                while (remainingBytesCount > 0)
                {
                    uint chunkSize = remainingBytesCount;

                    if (chunkSize > maximumMemoryChunkSize)
                    {
                        chunkSize = maximumMemoryChunkSize;
                    }

                    var buffer = new byte[chunkSize];
                    bytesRead = 0;
                    GUC.Read(buffer, chunkSize, ref bytesRead);

                    ms.Write(buffer, 0, (int)chunkSize);

                    remainingBytesCount -= chunkSize;
                }

                return ms.ToArray();
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Reads memory (bytes) from the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="length">Length of the bytes</param>
        private void RequestBytes(uint address, uint length)
        {
            try
            {
                SendCommand(GeckoUCommands.Command.COMMAND_READ_MEMORY);

                uint bytesRead = 0;
                var bytes = BitConverter.GetBytes(ByteSwap.Swap(address));
                var bytes2 = BitConverter.GetBytes(ByteSwap.Swap(address + length));
                GUC.Write(bytes, 4, ref bytesRead);
                GUC.Write(bytes2, 4, ref bytesRead);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Upload Bytes to the Wii U
        /// </summary>
        /// <param name="address">Address to read</param>
        /// <param name="bytes">Bytes to write</param>
        /// <returns></returns>
        public uint UploadBytes(uint address, byte[] bytes)
        {
            var length = bytes.Length;

            uint endAddress = address + (uint)bytes.Length;
            uint bytesRead = 0;
            GUC.Write(bytes, length, ref bytesRead);

            return endAddress;
        }

        /// <summary>
        /// Write Paritioned Bytes to the Wii U
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="byteChunks">Partitioned Bytes to write</param>
        private void WritePartitionedBytes(uint address, IEnumerable<byte[]> byteChunks)
        {
            IEnumerable<byte[]> enumerable = byteChunks as IList<byte[]> ?? byteChunks.ToList();
            var length = (uint)enumerable.Sum(chunk => chunk.Length);

            try
            {
                SendCommand(GeckoUCommands.Command.COMMAND_UPLOAD_MEMORY);

                uint bytesRead = 0;
                var start = BitConverter.GetBytes(ByteSwap.Swap(address));
                var end = BitConverter.GetBytes(ByteSwap.Swap(address + length));

                GUC.Write(start, 4, ref bytesRead);
                GUC.Write(end, 4, ref bytesRead);

                enumerable.Aggregate(address, UploadBytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
        }

        /// <summary>
        /// Paritition the given Bytes
        /// </summary>
        /// <param name="bytes">Bytes to partition</param>
        /// <param name="chunkSize">Size of the Chunk</param>
        /// <returns></returns>
        private static IEnumerable<byte[]> Partition(byte[] bytes, uint chunkSize)
        {
            var byteArrayChunks = new List<byte[]>();
            uint startingIndex = 0;

            while (startingIndex < bytes.Length)
            {
                var end = Math.Min(bytes.Length, startingIndex + chunkSize);
                byteArrayChunks.Add(CopyOfRange(bytes, startingIndex, end));
                startingIndex += chunkSize;
            }

            return byteArrayChunks;
        }

        /// <summary>
        /// Copy a range of bytes
        /// </summary>
        /// <param name="src">The Bytes to copy from</param>
        /// <param name="start">Start of the range</param>
        /// <param name="end">End of the Range</param>
        /// <returns>Bytes</returns>
        private static byte[] CopyOfRange(byte[] src, long start, long end)
        {
            var len = end - start;
            var dest = new byte[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }

        /// <summary>
        /// Write bytes the specified address
        /// </summary>
        /// <param name="address">Address to write</param>
        /// <param name="bytes">Bytes to write</param>
        public void WriteBytes(uint address, byte[] bytes) //Write bytes to the specified memory address
        {
            var partitionedBytes = Partition(bytes, maximumMemoryChunkSize);
            WritePartitionedBytes(address, partitionedBytes);
        }
        #endregion the magic

        #region rpc

        /*public uint GetSymbol(string rplName, string symbolName, bool isData, bool isPointer)
        {
            uint address = 0x000000;
            SendCommand(GeckoUCommands.Command.COMMAND_GET_SYMBOL);

            MemoryStream Request = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(Request);

            writer.Write(new byte[] { 0x00, 0x00, 0x00, 0x08 });

            int length = rplName.Length + 9;

            writer.Write(new byte[] { (byte)((length >> 24) & 0xFF), (byte)((length >> 16) & 0xFF), (byte)((length >> 8) & 0xFF), (byte)(length & 0xFF) });

            writer.Write(Encoding.UTF8.GetBytes(rplName));
            writer.Write(0);
            writer.Write(Encoding.UTF8.GetBytes(symbolName));
            writer.Write(0);

            uint bytesWritten = 0;

            GUC.Write(new byte[] { (byte)Request.Length }, 0, ref bytesWritten);
            GUC.Write(Request.ToArray(), 0, ref bytesWritten);
            GUC.Write(new byte[] { 0 }, 0, ref bytesWritten);
            Console.Write(Request.Length.ToString());

            address = readInteger();

            if (!isPointer)
            {
                address = PeekUInt(address);
            }

            return address;
        }*/

        /// <summary>
        /// Call a function from an RPL/RPX
        /// </summary>
        /// <param name="address">The function address to call</param>
        /// <param name="args">The arguements to pass through</param>
        /// <returns>uint</returns>
        public uint CallFunction(uint address, params uint[] args)
        {
            return (uint)(CallFunction64(address, args) >> 32);
        }

        /// <summary>
        /// Call a function from an RPL/RPX
        /// </summary>
        /// <param name="address">The function address to call</param>
        /// <param name="args">The arguements to pass through</param>
        /// <returns>UInt64</returns>
        public UInt64 CallFunction64(uint address, params uint[] args)
        {
            byte[] buffer = new Byte[4 + 8 * 4];

            address = ByteSwap.Swap(address);

            BitConverter.GetBytes(address).CopyTo(buffer, 0);

            for (int i = 0; i < 8; i++)
            {
                if (i < args.Length)
                {
                    BitConverter.GetBytes(ByteSwap.Swap(args[i])).CopyTo(buffer, 4 + i * 4);
                }
                else
                {
                    BitConverter.GetBytes(0xfecad0ba).CopyTo(buffer, 4 + i * 4);
                }
            }

            if (RawCommand(GeckoUCommands.cmd_rpc) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDICommandSendError);

            if (GeckoUWrite(buffer, buffer.Length) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDICommandSendError);

            if (GeckoURead(buffer, 8) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDICommandSendError);

            return ByteSwap.Swap(BitConverter.ToUInt64(buffer, 0));
        }

        public void RpcToggle(uint address1, uint address2, uint value1, uint value2, bool toggle)
        {
            switch (toggle)
            {
                case true:
                    CallFunction64(address1, value1);
                    break;

                case false:
                    CallFunction64(address2, value2);
                    break;
            }
        }

        public void RpcToggle(uint address, uint classAddress, uint[] value, bool toggle, int indexOn, int indexOff)
        {
            switch (toggle)
            {
                case true:
                    CallFunction64(address, classAddress, value[indexOn]);
                    break;

                case false:
                    CallFunction64(address, classAddress, value[indexOff]);
                    break;
            }
        }

        public uint getSymbol(string rplname, string sysname, byte data = 0)
        {
            byte[] rplnbuf = Encoding.UTF8.GetBytes(rplname);
            byte[] sysnbuf = Encoding.UTF8.GetBytes(sysname);
            byte[] startStuff = { 0x0, 0x0, 0x0, 0x8 };
            byte[] startStuff1 = BitConverter.GetBytes(8 + rplnbuf.Length + 1);
            Array.Reverse(startStuff1);

            byte[] size = { (byte)(rplnbuf.Length + sysnbuf.Length + 10) };
            var ms = new MemoryStream(new byte[size[0]], 0, size[0], true, true);
            ms.Write(startStuff, 0, startStuff.Length);
            ms.Write(startStuff1, 0, startStuff.Length);
            ms.Write(rplnbuf, 0, rplnbuf.Length);
            ms.Write(new byte[] { 0 }, 0, 1); // null terminator
            ms.Write(sysnbuf, 0, sysnbuf.Length);
            ms.Write(new byte[] { 0 }, 0, 1);
            byte[] buffer = ms.GetBuffer();
            byte[] Data = { data };

            if (RawCommand((byte)GeckoUCommands.Command.CommandGetSymbol) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDITransferSetError);

            if (GeckoUWrite(size, 1) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDITransferSetError);

            if (GeckoUWrite(buffer, buffer.Length) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDITransferSetError);

            if (GeckoUWrite(Data, 1) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDITransferSetError);

            if (GeckoURead(buffer, 4) != FTDICommand.CMD_OK)
                throw new GeckoUException(GeckoUException.ETCPErrorCode.FTDITransferSetError);

            return ByteSwap.Swap(BitConverter.ToUInt32(buffer, 0));
        }
        #endregion rpc

        #region writing
        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when Untoggled</param>
        /// <param name="checkBox">The CheckBox control to monitor</param>
        public void WriteUIntToggle(uint address, uint value, uint originalValue, bool toggle)
        {
            if (toggle)
            {
                WriteUInt(address, value);
            }
            else
            {
                WriteUInt(address, originalValue);
            }
        }

        public uint Mix(uint baseval, decimal val)
        {
            decimal value = 0m + val;
            return baseval + (uint)value;
        }

        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when Untoggled</param>
        /// <param name="checkBox">The CheckBox control to monitor</param>
        public void WriteLongToggle(uint address, long value, long originalValue, bool toggle)
        {
            if (toggle)
            {
                WriteLong(address, value);
            }
            else
            {
                WriteLong(address, originalValue);
            }
        }

        /// <summary>
        /// Writes a value to an address when toggled
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write to when toggled</param>
        /// <param name="originalValue">Value to write to when Untoggled</param>
        /// <param name="checkBox">The CheckBox control to monitor</param>
        public void WriteULongToggle(uint address, ulong value, ulong originalValue, bool toggle)
        {
            if (toggle)
            {
                WriteULong(address, value);
            }
            else
            {
                WriteULong(address, originalValue);
            }
        }

        /// <summary>
        /// Writes a uint to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteUInt(uint address, uint value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Long to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteLong(uint address, long value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Unsigned Long to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteULong(uint address, ulong value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a float to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteFloat(uint address, float value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (ArgumentNullException Error)
            {
                Console.Write(Error.Message);
            }
            catch (RankException Error)
            {
                Console.Write(Error.Message);
            }

            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a double to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteDouble(uint address, double value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (ArgumentNullException Error)
            {
                Console.Write(Error.Message);
            }
            catch (RankException Error)
            {
                Console.Write(Error.Message);
            }

            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Int32 to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteInt(uint address, int value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a Short to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">Value to write</param>
        public void WriteShort(uint address, short value)
        {
            var bytes = BitConverter.GetBytes(value);
            try
            {
                Array.Reverse(bytes);
            }
            catch (Exception Error)
            {
                Console.Write(Error.Message);
            }
            WriteBytes(address, bytes);
        }

        /// <summary>
        /// Writes a String to the given address
        /// </summary>
        /// <param name="address">Address to write to</param>
        /// <param name="value">String to write</param>
        public void WriteString(uint address, string value)
        {
            var bytes = System.Text.Encoding.ASCII.GetBytes(value);
            WriteBytes(address, bytes);
        }
        public void WriteString16(uint address, string value)
        {
            var bytes = Encoding.BigEndianUnicode.GetBytes(value);
            WriteBytes(address, bytes);
        }

        #endregion Writing, Poking

        #region reading

        /// <summary>
        /// Peeks a Unsigned Integer from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Unsigned Integer</returns>
        public uint PeekUInt(uint address)
        {
            var bytes = ReadBytes(address, 0x4);
            uint value;

            try
            {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToUInt32(bytes, 0);
            }
            catch (Exception)
            {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a long from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Long</returns>
        public long PeekLong(uint address)
        {
            var bytes = ReadBytes(address, 0x8);
            long value;

            try
            {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToInt64(bytes, 0);
            }
            catch (Exception)
            {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a Unsigned Long from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Unsigned Long</returns>
        public ulong PeekULong(uint address)
        {
            var bytes = ReadBytes(address, 0x8);
            ulong value;

            try
            {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToUInt64(bytes, 0);
            }
            catch (Exception)
            {
                return 0;
            }

            return value;
        }

        public uint Mix2(uint baseval, decimal val)
		{
			decimal value = 0x0 + val;
			return baseval + (uint)value;
		}

        /// <summary>
        /// Peeks a float from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Float</returns>
        public float PeekFloat(uint address)
        {
            var bytes = ReadBytes(address, 0x4);
            float value;

            try
            {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToSingle(bytes, 0);
            }
            catch (Exception)
            {
                return 0;
            }

            return value;
        }

        /// <summary>
        /// Peeks a double from the Wii U
        /// </summary>
        /// <param name="address">The address to peak</param>
        /// <returns>The peeked Double</returns>
        public double PeekDouble(uint address)
        {
            var bytes = ReadBytes(address, 0x4);
            double value;

            try
            {
                Array.Reverse(bytes);
                value = !bytes.Any() ? 0 : BitConverter.ToDouble(bytes, 0);
            }
            catch (Exception)
            {
                return 0;
            }

            return value;
        }

        public string PeekString(int length, uint address)
        {
            string peekedString = string.Empty;

            for (int i = 0; i < length; i += 4)
            {
                peekedString += PeekUInt(address += (uint)i).ToString("X");
            }

            byte[] ToUTF8 = StringUtils.StringToByteArray(peekedString);
            return Encoding.UTF8.GetString(ToUTF8).Replace("\0", "");
        }

        #endregion reading

        #region commands
        /// <summary>
        /// Reads the Data Buffer Size on the Wii U
        /// </summary>
        /// <returns>UInt</returns>

        public string ReadAccountName(uint address)
        {
            CallFunction(0x03863C8C, address);
            return PeekString(28, address);
        }

        public string ReadCountryCode(uint address)
        {
            CallFunction(0x0384E79C, address);
            return PeekString(4, address);
        }

        public string ReadTitleId()
        {
            return CallFunction64(0x0101F5CC).ToString("x8");
        }

        public byte[] method_7(string string_0)
        {
            byte[] array = new byte[string_0.Length / 2];
            int num = 0;
            for (int i = 0; i < string_0.Length; i += 2)
            {
                string value = string_0.Substring(i, 2);
                array[num] = Convert.ToByte(value, 16);
                num++;
            }
            return array;
        }

        #endregion Commands

        #region misc

        /// <summary>
        /// Fits in a value into the given value
        /// </summary>
        /// <param name="baseval">The base value</param>
        /// <param name="val">The value to fit in</param>
        /// <returns></returns>

        /// <summary>
        /// Clears a buffer
        /// </summary>
        /// <param name="buffer">The buffer to clear</param>
        public void ClearBuffer(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0;
            }
        }

        public void ClearString(uint address)
        {
            uint clearingAddress = address;

            while (PeekUInt(clearingAddress) != 0x00000000)
            {
                WriteUInt(clearingAddress, 0x00000000);
                clearingAddress += 4;
            }
        }

        public void WriteStringUTF16(uint address, string value)
        {
            byte[] bytes = Encoding.BigEndianUnicode.GetBytes(value);
            this.WriteBytes(address, bytes);
        }

        public void clearString2(uint startAddress, uint endAddress)
        {
            uint num = endAddress - startAddress;
            int num2 = 0;
            while ((long)num2 < (long)((ulong)num))
            {
                this.WriteUInt(startAddress + Convert.ToUInt32(num2), 0x00000000);
                num2 += 4;
            }
        }

        public void makeAssembly(uint adress, string input)
        {
            byte[] array = new byte[input.Length / 2];
            int num = 0;
            for (int i = 0; i < input.Length; i += 2)
            {
                string value = input.Substring(i, 2);
                array[num] = Convert.ToByte(value, 16);
                num++;
            }
            this.WriteBytes(adress, array);
        }

        public void ClearString(uint addressStart, uint addressEnd)
        {
            uint clearingAddress = addressStart;

            while (PeekUInt(clearingAddress) != 0x00000000)
            {
                if (clearingAddress == addressEnd)
                {
                    return;
                }
                WriteUInt(clearingAddress, 0x00000000);
                clearingAddress += 4;
            }
        }

        public void ClearString2(uint address)
        {
            var clearingAddress = address;

            while (PeekUInt(clearingAddress) != 0x00000000)
            {
                WriteUInt(clearingAddress, 0x00000000);
                clearingAddress += 4;
            }
        }

        public void ClearString3(uint addressStart, uint addressEnd)
        {
            ClearString(addressStart, (int)(addressEnd - addressStart));
        }

        public void ClearString(uint address, int length)
        {
            byte[] buffer = new byte[length];
            WriteBytes(address, buffer);
        }

        /// <summary>
        /// Checks if Gecko U is still connected to the Wii U
        /// </summary>
        /// <returns>Boolean</returns>
        public bool GeckoUConnected()
        {
            try
            {
                WriteUInt(0x12000090, 0x00000001);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal string WriteBytes(string text)
        {
            throw new NotImplementedException();
        }


        public uint malloc(uint size, uint alignment = 4)
        {
            uint symbol = getSymbol("coreinit.rpl", "MEMAllocFromDefaultHeapEx", 1);
            uint funcAddy = PeekUInt(symbol);
            return CallFunction(funcAddy, size, alignment);
        }

        public void free(uint address)
        {
            uint symbol = getSymbol("coreinit.rpl", "MEMFreeToDefaultHeap", 1);
            uint funcAddy = PeekUInt(symbol);
            CallFunction(funcAddy, address);
        }


        #endregion misc
    }
}
