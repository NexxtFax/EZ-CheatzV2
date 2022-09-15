﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace wiiplaza.gecko
{
    class StringUtils
    {
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new System.IO.StringReader(hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] =
                      Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            }
            return bytes;
        }

        internal static string InsertStrings(object text, int v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}