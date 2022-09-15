
//A skidded mess I created a while ago.
//Do with it whatever you want, I don't care

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using MetroFramework.Controls;
using System.Timers;
using System.IO;
using Minecraft_Wii_U_Mod_Tool.theme;
using Minecraft_Wii_U_Mod_Tool.Properties;
using Minecraft_Wii_U_Mod_Tool.forms;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using static System.Windows.Forms.DialogResult;
using wiiplaza.gecko;

namespace Minecraft_Wii_U_Mod_Tool
{
    public partial class MainForm : MetroForm
    {
        //private DiscordRpc.EventHandlers handlers;
        //private DiscordRpc.RichPresence presence;

        public MainForm()
        {
            InitializeComponent();
            on = 0x38600001;
            off = 0x38600000;
            on2 = 0x3BE00001;
            off2 = 0x3BE00000;
            blr = 0x4E800020;
            mflr = 0x7C0802A6;
            nop = 0x60000000;
            appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Temp/";
            components = null;
            StyleManager = metroStyleManager1;


        }

        #region enchantments
        public static uint[] enchantments = {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            16,
            17,
            18,
            19,
            20,
            21,
            32,
            33,
            34,
            35,
            48,
            49,
            50,
            51,
            61,
            62,
            70,
            71,
            80,
            81,
            82,
            83
        };
        #endregion
        public static GeckoUCore GeckoU;
        public static GeckoUConnect GeckoUConnection;
        private uint off;
        private uint on;
        private uint on2;
        private uint off2;
        private uint blr;
        private uint mflr;
        private uint nop;
        private int s;
        private int m;
        private int h;
        private string appData;
        private string Text;
        public bool bool_0 = false;

        public static MainForm Injector = new MainForm();

        #region RAM Writing Values
        public List<uint> list_1 = new List<uint>
        {
            0x7C0802A6,
            0x3D801200,
            0x804C0010,
            0x38420001,
            0x904C0010,
            0x2F822400,
            0x409C0008,
            0x4800001C,
            0x38000000,
            0x44000002,
            0x38007C00,
            0x44000002,
            0x38000001,
            0x44000002,
            0x3D8002F1,
            0x618CA4F0,
            0x7D8903A6,
            0x4E800420
        };

        public List<uint> list_2 = new List<uint>
        {
            0x3C401002,
            0x60425000,
            0x90020000,
            0x90220004,
            0x90420008,
            0x9062000C,
            0x90820010,
            0x90A20014,
            0x90C20018,
            0x90E2001C,
            0x91020020,
            0x91220024,
            0x91420028,
            0x9162002C,
            0x91820030,
            0x91A20034,
            0x91C20038,
            0x91E2003C,
            0x92020040,
            0x92220044,
            0x92420048,
            0x9262004C,
            0x92820050,
            0x92A20054,
            0x92C20058,
            0x92E2005C,
            0x93020060,
            0x93220064,
            0x93420068,
            0x9362006C,
            0x93820070,
            0x93A20074,
            0x93C20078,
            0x93E2007C,
            0xD0020080,
            0xD0220084,
            0xD0420088,
            0xD062008C,
            0xD0820090,
            0xD0A20094,
            0xD0C20098,
            0xD0E2009C,
            0xD10200A0,
            0xD12200A4,
            0xD14200A8,
            0xD16200AC,
            0xD18200B0,
            0xD1A200B4,
            0xD1C200B8,
            0xD1E200BC,
            0xD20200C0,
            0xD22200C4,
            0xD24200C8,
            0xD26200CC,
            0xD28200D0,
            0xD2A200D4,
            0xD2C200D8,
            0xD2E200DC,
            0xD30200E0,
            0xD32200E4,
            0xD34200E8,
            0xD36200EC,
            0xD38200F0,
            0xD3A200F4,
            0xD3C200F8,
            0xD3E200FC,
            0x48000125,
            0x3C401002,
            0x60425000,
            0x80020000,
            0x80220004,
            0x80420008,
            0x8062000C,
            0x80820010,
            0x80A20014,
            0x80C20018,
            0x80E2001C,
            0x81020020,
            0x81220024,
            0x81420028,
            0x8162002C,
            0x81820030,
            0x81A20034,
            0x81C20038,
            0x81E2003C,
            0x82020040,
            0x82220044,
            0x82420048,
            0x8262004C,
            0x82820050,
            0x82A20054,
            0x82C20058,
            0x82E2005C,
            0x83020060,
            0x83220064,
            0x83420068,
            0x8362006C,
            0x83820070,
            0x83A20074,
            0x83C20078,
            0x83E2007C,
            0xC0020080,
            0xC0220084,
            0xC0420088,
            0xC062008C,
            0xC0820090,
            0xC0A20094,
            0xC0C20098,
            0xC0E2009C,
            0xC10200A0,
            0xC12200A4,
            0xC14200A8,
            0xC16200AC,
            0xC18200B0,
            0xC1A200B4,
            0xC1C200B8,
            0xC1E200BC,
            0xC20200C0,
            0xC22200C4,
            0xC24200C8,
            0xC26200CC,
            0xC28200D0,
            0xC2A200D4,
            0xC2C200D8,
            0xC2E200DC,
            0xC30200E0,
            0xC32200E4,
            0xC34200E8,
            0xC36200EC,
            0xC38200F0,
            0xC3A200F4,
            0xC3C200F8,
            0xC3E200FC,
            0x3C401050,
            0x6042A200,
            0x3D80031A,
            0x618C44F8,
            0x7D8903A6,
            0x4E800420,
            0x3C201200,
            0x7C0802A6,
            0x90010000,
            0x48000044,
            0x48000178,
            0x4800019C,
            0x480001C0,
            0x480001E4,
            0x48000220,
            0x48000240,
            0x48000260,
            0x48000294,
            0x48000380,
            0x480003B8,
            0x48000614,
            0x48000A6C,
            0x3C201200,
            0x80010000,
            0x7C0803A6,
            0x4BFFFE95,
            0x3C201100,
            0x3C40102E,
            0x6042F7C0,
            0x80420000,
            0x2F820000,
            0x419E0120,
            0x3C40102F,
            0x60426B40,
            0xC1420000,
            0xC1620004,
            0x3C404500,
            0x60422000,
            0x90410110,
            0x3C404469,
            0x6042C000,
            0x90410118,
            0x3C40BF80,
            0x60420000,
            0x9041011C,
            0x3C40BFB9,
            0x6042999A,
            0x90410120,
            0x3C403FB9,
            0x6042999A,
            0x90410114,
            0x3C403E99,
            0x6042999A,
            0x90410124,
            0xC1E10110,
            0xFD4A7828,
            0xC1E10114,
            0xFD4A7824,
            0xC1E10118,
            0xFD6B7828,
            0xC1E1011C,
            0xFD6B03F2,
            0xC1E10120,
            0xFD6B7824,
            0xD1410130,
            0xD1610134,
            0x3C4010A0,
            0x6042A610,
            0x80620000,
            0x80630104,
            0x2F830000,
            0x419E0080,
            0x3C4042B4,
            0x60420000,
            0x9043014C,
            0x3C404334,
            0x60420000,
            0x90430148,
            0x80630158,
            0xC3210124,
            0xFD595028,
            0xD1410140,
            0xFD59502A,
            0xFD59502A,
            0xD1410144,
            0xFD795828,
            0xD1610148,
            0xFD79582A,
            0xFD79582A,
            0xD161014C,
            0xC1E1011C,
            0xC1410140,
            0xFD4F02B2,
            0xD9430000,
            0xC1410144,
            0xFD4F02B2,
            0xD9430018,
            0xC1610148,
            0xFD6F02F2,
            0xD9630010,
            0xC161014C,
            0xFD6F02F2,
            0xD9630028,
            0x4BFFFE8C,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFE78,
            0x3C403CA3,
            0x6042D70A,
            0x904303F0,
            0x4BFFFE68,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFE54,
            0x3C400101,
            0x60420101,
            0x9043015C,
            0x4BFFFE44,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFE30,
            0x3C401000,
            0x9043013D,
            0x9043012F,
            0x4BFFFE20,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFE0C,
            0x38400000,
            0x2F820001,
            0x419E0010,
            0x38400000,
            0x904301DA,
            0x4BFFFDF4,
            0x3C400101,
            0x60420101,
            0x904301DA,
            0x4BFFFDE4,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFDD0,
            0x38400004,
            0x90430910,
            0x4BFFFDC4,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFDB0,
            0x38400000,
            0x904308F8,
            0x4BFFFDA4,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFD90,
            0x8043070C,
            0x2F820000,
            0x419E0008,
            0x4BFFFD80,
            0x3C400100,
            0x60420101,
            0x9043070C,
            0x4BFFFD70,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419EFD5C,
            0x3C201100,
            0x3C40102F,
            0x60426A80,
            0x80420000,
            0x70430800,
            0x2C020800,
            0x70440400,
            0x2C020400,
            0x70450200,
            0x2C020200,
            0x70460100,
            0x2C020100,
            0x7C631BD6,
            0x7C8423D6,
            0x7CA52BD6,
            0x7CC633D6,
            0x3CE04040,
            0x3D00C040,
            0x3D204040,
            0x3D40C040,
            0x7CE719D6,
            0x7D0821D6,
            0x7D2929D6,
            0x7D4A31D6,
            0x90E10000,
            0x91010004,
            0x91210008,
            0x9141000C,
            0xC0E10000,
            0xC1010004,
            0xC1210008,
            0xC141000C,
            0x3D6010A0,
            0x616BA610,
            0x816B0000,
            0x816B0104,
            0x816B0158,
            0xC98B0000,
            0xC9AB0018,
            0xC9CB0010,
            0xC9EB0028,
            0xFD87602A,
            0xFDA7682A,
            0xFD88602A,
            0xFDA8682A,
            0xFDC9702A,
            0xFDE9782A,
            0xFDCA702A,
            0xFDEA782A,
            0xD98B0000,
            0xD9AB0018,
            0xD9CB0010,
            0xD9EB0028,
            0x4BFFFC84,
            0x3C60109C,
            0x6063D8E4,
            0x80630000,
            0x80630004,
            0x2F830000,
            0x419EFC70,
            0x38400000,
            0x9043002C,
            0x90430028,
            0x3C400100,
            0x9043000C,
            0x3C40FFFF,
            0x6042FFFF,
            0x90430024,
            0x4BFFFC4C,
            0x3C201100,
            0x60210D00,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419E01E8,
            0x80410004,
            0x2F820000,
            0x419E0188,
            0x3C80109C,
            0x6084D8E4,
            0x80840000,
            0x8084002C,
            0x2F840000,
            0x419E01C4,
            0x80410004,
            0x2F820000,
            0x419E0164,
            0x80A40038,
            0x80C4003C,
            0x2F850000,
            0x419E01A8,
            0x80410004,
            0x1C420008,
            0x7C851214,
            0x7F843040,
            0x419E0194,
            0x409C0190,
            0x80840000,
            0xC9430118,
            0xC9630128,
            0x80A30158,
            0xC9C50020,
            0xC9840118,
            0xC9A40128,
            0x80A40158,
            0xC9E50020,
            0xFD8A6028,
            0xFDAB6828,
            0xFDCF7028,
            0xD1810030,
            0xD1A10034,
            0xD1C10038,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C310C,
            0xFC406090,
            0xFC206890,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x38210D00,
            0x3C404334,
            0x90410040,
            0xC0410040,
            0xFC220072,
            0x3C404048,
            0x6042F5C3,
            0x90410040,
            0xC0410040,
            0xFC211024,
            0x3C4042B4,
            0x90410040,
            0xC0410040,
            0xFC22082A,
            0xFC200818,
            0xD0230148,
            0xC1810030,
            0xC1A10034,
            0xFD8C0332,
            0xFDAD0372,
            0xFC2D602A,
            0x3C201108,
            0x6021F128,
            0x3D800383,
            0x618C23CC,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x60210D00,
            0xC0410038,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C310C,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x38210D00,
            0x3C404334,
            0x90410040,
            0xC0410040,
            0xFC220072,
            0x3C404048,
            0x6042F5C3,
            0x90410040,
            0xC0410040,
            0xFC211024,
            0x3C4042B4,
            0x90410040,
            0xC0410040,
            0xFC220828,
            0xFC200818,
            0xFC200850,
            0xD023014C,
            0x3C201100,
            0x38210D00,
            0x80410100,
            0x7C4803A6,
            0x3C40102E,
            0x6042FA64,
            0x80420000,
            0x70420800,
            0x2F820800,
            0x419E0028,
            0x3C40102E,
            0x6042FA64,
            0x80420000,
            0x70420200,
            0x2F820200,
            0x419E003C,
            0x38400000,
            0x90410000,
            0x48000064,
            0x38400000,
            0x90410008,
            0x80410008,
            0x2F820001,
            0x419E0010,
            0x38400000,
            0x90410004,
            0x48000044,
            0x38400001,
            0x90410004,
            0x48000038,
            0x38400001,
            0x90410008,
            0x81810000,
            0x2F8C0001,
            0x419EFFC0,
            0x39800001,
            0x7D8903A6,
            0x38400001,
            0x90410000,
            0x80410004,
            0x38420001,
            0x90410004,
            0x4200FFEC,
            0x4BFFF9F0,
            0x48000349,
            0x2F830001,
            0x419E0450,
            0x48000009,
            0x48000448,
            0x7C220B78,
            0x3C201100,
            0x60210DF0,
            0x90410004,
            0x7C4802A6,
            0x90410000,
            0x3C80109C,
            0x6084D8E4,
            0x80840000,
            0x8084002C,
            0x2F830000,
            0x80A40038,
            0x80C4003C,
            0x7CA53050,
            0x38C00008,
            0x7CA533D6,
            0x2F850001,
            0x419E0020,
            0x38400001,
            0x2F820000,
            0x419E0014,
            0x7F822840,
            0x409C000C,
            0x480001ED,
            0x4800002D,
            0x3C201100,
            0x60210E70,
            0x38400000,
            0x90410014,
            0x3C201100,
            0x60210DF0,
            0x80410000,
            0x80210004,
            0x7C4803A6,
            0x4E800020,
            0x7C220B78,
            0x3C201100,
            0x60210ED0,
            0x90410000,
            0x7C4802A6,
            0x90410004,
            0x3C201100,
            0x60210E70,
            0x80810014,
            0x2F840000,
            0x3C201100,
            0x60210ED0,
            0x419E017C,
            0x3C201100,
            0x60210ED0,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0xC9430118,
            0xC9630128,
            0x80A30158,
            0xC9850020,
            0xD1810020,
            0x80A40158,
            0xC9850020,
            0xD1810024,
            0xC9840118,
            0xC9A40128,
            0xFD8A6028,
            0xFDAB6828,
            0xD1810028,
            0xD1A1002C,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C310C,
            0xFC406090,
            0xFC206890,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x60210ED0,
            0x3C404334,
            0x90410030,
            0xC0410030,
            0xFC220072,
            0x3C404048,
            0x6042F5C3,
            0x90410030,
            0xC0410030,
            0xFC211024,
            0x3C4042B4,
            0x90410030,
            0xC0410030,
            0xFC22082A,
            0xFC200818,
            0xD0230148,
            0x3C201100,
            0x60210ED0,
            0xC1810028,
            0xC1A1002C,
            0xC1410020,
            0xC1610024,
            0xFD4B5028,
            0xD1410038,
            0xFD8C0332,
            0xFDAD0372,
            0xFD8D602A,
            0xFC206090,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C23CC,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x60210ED0,
            0xC0410038,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C310C,
            0x7D8903A6,
            0x4E800421,
            0x3C201100,
            0x60210ED0,
            0x3C404334,
            0x90410030,
            0xC0410030,
            0xFC220072,
            0x3C404048,
            0x6042F5C3,
            0x90410030,
            0xC0410030,
            0xFC211024,
            0x3C4042B4,
            0x90410030,
            0xC0410030,
            0xFC220828,
            0xFC200818,
            0xFC200850,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0xD023014C,
            0x80410004,
            0x80210000,
            0x7C4803A6,
            0x4E800020,
            0x7C220B78,
            0x3C201100,
            0x60210E50,
            0x90410010,
            0x7C4802A6,
            0x90410000,
            0x90810004,
            0x90A10008,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x419E009C,
            0x9061000C,
            0x7CBD2B78,
            0x7C9E2378,
            0x7C7F1B78,
            0x3C201100,
            0x60210E70,
            0x93C10004,
            0x93A10008,
            0x38400001,
            0x90410000,
            0x3C40447A,
            0x90410010,
            0x38400000,
            0x90410014,
            0x3C201100,
            0x60210E70,
            0x80410000,
            0x80810004,
            0x80A10008,
            0x7F822840,
            0x409C0040,
            0x1C420008,
            0x80810004,
            0x80840038,
            0x7C822214,
            0x80840000,
            0x48000075,
            0xC0410010,
            0xFF811000,
            0x409C000C,
            0xD0210010,
            0x90810014,
            0x80410000,
            0x38420001,
            0x90410000,
            0x4BFFFFAC,
            0x3C201100,
            0x60210E50,
            0x80A10008,
            0x80810004,
            0x8061000C,
            0x80410000,
            0x80210010,
            0x7C4803A6,
            0x4E800020,
            0x3C6010A0,
            0x6063A610,
            0x80630000,
            0x80630104,
            0x2F830000,
            0x38600000,
            0x419E0008,
            0x4E800020,
            0x38600001,
            0x4E800020,
            0x7C220B78,
            0x3C201100,
            0x60210EA0,
            0x90410000,
            0x7C4802A6,
            0x90410004,
            0x90610008,
            0x9081000C,
            0xC9430118,
            0xC9630128,
            0x80630158,
            0xC9840118,
            0xC9A40128,
            0x80840158,
            0x90610010,
            0x90810014,
            0xFD4C5028,
            0xFD6D5828,
            0xD1410018,
            0xD161001C,
            0xFD8A02B2,
            0xFDAB02F2,
            0xFD8C682A,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C23CC,
            0x7D8903A6,
            0xFC206090,
            0x4E800421,
            0x3C201100,
            0x60210EA0,
            0xFD400890,
            0x80610010,
            0x80810014,
            0xC9630020,
            0xC9840020,
            0xFD6C5828,
            0xD1610018,
            0xD181001C,
            0xFD8A02B2,
            0xFDAB02F2,
            0xFD8D602A,
            0x3C201108,
            0x6021F000,
            0x3D800383,
            0x618C23CC,
            0x7D8903A6,
            0xFC206090,
            0x4E800421,
            0x3C201100,
            0x60210EA0,
            0x8081000C,
            0x80610008,
            0x80410004,
            0x80210000,
            0x7C4803A6,
            0x4E800020,
            0x4BFFF598,
            0x3C201100,
            0x60212000,
            0x3C403C03,
            0x6042126F,
            0x90410004,
            0xC0410004,
            0xC0210000,
            0xFC22082A,
            0xD0210000,
            0x3C403F80,
            0x90410004,
            0xC0410004,
            0xC0210000,
            0xFF811000,
            0x409C0008,
            0x4800000C,
            0x38400000,
            0x90410000,
            0xC0210000,
            0x3C403F80,
            0x90410004,
            0xC0410004,
            0x3C403F80,
            0x90410004,
            0xC0610004,
            0x3D800262,
            0x618C4178,
            0x7D8903A6,
            0x4E800421,
            0x3C201000,
            0x90610000,
            0x4BFFF51C
        };
        #endregion

        public bool IsMinecraft()
        {
            string[] mcIds = new[] { "50000101d7500", "50000101d9d00", "50000101dbe00" };

            return mcIds.Contains(GeckoU.ReadTitleId());
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            WiiUDisconnected();
            ShowCredits();
            new Setup(this);
            Setup.SetupUserPrefs();
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            new credits(this).Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            //new LootTableSwitcher(this).ShowDialog();
            MetroMessageBox.Show(this, "Comming Soon","Soon",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async Task PutTaskDelay(int sleep)
        {
            await Task.Delay(sleep);
        }
        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            new ban(this).Show();
        }

        private void AppearanceChangerBtn_Click(object sender, EventArgs e)
        {
            new Aperance(this).Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            new Messaging(this).Show();
        }

        #region Memory Writing for Advanced Mods


        private void executeGiveItem()
        {
            string input = "9421ff887c0802a63ce031003d0031009001007c3d4031003d20310093c10070610802143bc00000614a02186129021c60e70210934100609381006893a1006c93e100743fe0109c80e7000063ffd8e48349000083a80000838a000093c1005493610064813f000093c1005081290034812900f8812900c87f69382e480000110067006900760065000000007c8802a63d20020b38610008612908d47d2903a64e8004213d20024661290e54814100107d2903a681210014800100187f47d378808100087f86e3788061000c7fa5eb788161001c3901002891410030912100348141002081210024900100389361004893c1004c90810028388100489061002c386100509161003c91410040912100444e800421811f0000814100503d200304810800346129a5d88161005438810058806808787d2903a6914100589161005c4e8004218001007c83410060836100647c0803a68381006883a1006c83c1007083e10074382100784e80002060000000";
            MainForm.GeckoU.makeAssembly(0x039156C0, input);
            MainForm.GeckoU.CallFunction(0x039156C0, new uint[1]);
        }

        private void checkBoxCT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCT.Checked)
            {
                bool flag = MainForm.GeckoU.PeekUInt(0x3FFFFFF8) == 0x1;
                if (!flag)
                {
                    for (int i = 0; i < this.list_2.Count; i++)
                    {
                        MainForm.GeckoU.WriteUInt(0x4000000 + uint.Parse(i.ToString()) * 0x4, this.list_2[i]);
                    }
                    for (int j = 0; j < this.list_1.Count; j++)
                    {
                        MainForm.GeckoU.WriteUInt(0x4400000 + uint.Parse(j.ToString()) * 0x4, this.list_1[j]);
                    }
                    MainForm.GeckoU.WriteUInt(0x4000238, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x400023C, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000240, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000244, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x400024C, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000250, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000254, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000258, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x400025C, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000260, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x3FFFFFC, 0x7C0802A6);
                    MainForm.GeckoU.WriteUInt(0x3FFFFFF8, 0x1);
                }
                MainForm.GeckoU.WriteUInt(0x31A44F4, 0x48E5BB08);
            }
        }

        private void poke_fnc(uint address, uint num)
        {
            checked
            {
                if (num == 0x0)
                {
                    MainForm.GeckoU.WriteUInt(address, on);
                    MainForm.GeckoU.WriteUInt(address + 0x4, blr);
                }
                if (num == 0x1)
                {
                    MainForm.GeckoU.WriteUInt(address, off);
                    MainForm.GeckoU.WriteUInt(address + 0x4, blr);
                }
                if (num == 0x2)
                {
                    MainForm.GeckoU.WriteUInt(address, on);
                }
                if (num == 0x3)
                {
                    MainForm.GeckoU.WriteUInt(address, off);
                }
                if (num == 0x4)
                {
                    MainForm.GeckoU.WriteUInt(address, 0x57C3063E);
                }
                if (num == 0x5)
                {
                    MainForm.GeckoU.WriteUInt(address, blr);
                }
                if (num == 0x63)
                {
                    MainForm.GeckoU.WriteUInt(address, 0x11002200);
                }
            }


        }

        private void String_poke(uint address, string name)
        {
            uint[] array = new uint[1];
            uint num = 0x0;
            int num2 = MainForm.smethod_5(name);
            checked
            {
                if (MainForm.smethod_5(name) % 2 == 1)
                {
                    name = MainForm.smethod_1(name, "");
                    num2++;
                }
                for (int i = 0; i < num2; i++)
                {
                    num = (num << 16 | (uint)MainForm.smethod_2(name, i));
                    if ((i + 1) % 2 == 0)
                    {
                        Array.Resize<uint>(ref array, array.Length + 1);
                        array[array.Length - 2] = num;
                        num = 0x0;
                    }
                }
                Array.Resize<uint>(ref array, array.Length - 1);
                uint num3 = 0x0;
                for (int j = 0; j < array.Length; j++)
                {
                    MainForm.GeckoU.WriteUInt(address + num3, array[j]);
                    num3 += 0x4;
                    MainForm.smethod_3(2);
                }
            }
        }

        private static char smethod_2(string string_0, int int_0)
        {
            return string_0[int_0];
        }

        private static string smethod_1(string string_0, string string_1)
        {
            return string_0 + string_1;
        }

        private static int smethod_5(string string_0)
        {
            return string_0.Length;
        }

        private static string smethod_4(Control control_0)
        {
            return control_0.Text;
        }

        private static void smethod_3(int int_0)
        {
            Thread.Sleep(int_0);
        }

        private void gck()
        {
            poke_fnc(0x10000000, 0x0);
            uint num = MainForm.GeckoU.PeekUInt(0x10000000);
            MainForm.GeckoU.WriteUInt(checked(num + 0x1000000), uint.MaxValue);
        }
        #endregion

        #region Functions

        private void ShowCredits()
        {
            if (File.Exists(appData + "firstrun2")){}
            else
            {
                new credits(this).ShowDialog();
                File.Create(appData + "firstrun2");
            }
        }

        public void WiiUConnected()
        {
            connectbtn.Visible = false;
            disconnbtn.Visible = true;
            PH.Enabled = true;
            MGS.Enabled = true;
            World.Enabled = true;
            GRL.Enabled = true;
            connectBox.Enabled = false;
            CDT.Enabled = true;
            BlockCH.Enabled = true;
            WRLD.Enabled = true;
        }

        public void WiiUDisconnected()
        {
            connectbtn.Visible = true;
            disconnbtn.Visible = false;
            PH.Enabled = false;
            MGS.Enabled = false;
            World.Enabled = false;
            GRL.Enabled = false;
            connectBox.Enabled = true;
            CDT.Enabled = false;
            BlockCH.Enabled = false;
            WRLD.Enabled = false;
        }
        #endregion

        #region Wii U Connection
        private void connectbtn_Click(object sender, EventArgs e)
        {
            GeckoU = new GeckoUCore(connectBox.Text);
            try
            {
                GeckoU.GUC.Connect();
                if (!IsMinecraft())
                {
                    MetroMessageBox.Show(this, "You need to start Minecraft Wii U Edition to be able to connect to your Wii U", "Please start Minecraft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GeckoU.GUC.Close();
                    WiiUDisconnected();
                }
                else
                {
                    WiiUConnected();
                    checkBoxCT.Checked = true;
                    string input = "9421FFF093E1000C3FE03B00813F00002C090001418200403D20025A7C0802A661291AD0900100147D2903A64E8004213D2002296129CFFC386000017D2903A64E8004218001001439200001913F00007C0803A683E1000C382100104E800020";
                    MainForm.GeckoU.makeAssembly(0x3900000, input);
                    MainForm.GeckoU.CallFunction(0x3900000, new uint[1]);
                    Config.WriteKey("WiiUIP", connectBox.Text, "WiiU");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "An error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnbtn_Click(object sender, EventArgs e)
        {
            try
            {
                GeckoU.GUC.Close();
                WiiUDisconnected();
                checkBoxCT.Checked = false;
            }
            catch
            {
                MetroMessageBox.Show(this, "An error has occurred while disconnecting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region RAM Writing

        private void metroButton20_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog { AllowFullOpen = true, AnyColor = true };

            if (colorDlg.ShowDialog() == OK)
            {
                GeckoU.WriteFloat(0x109C8E68, colorDlg.Color.R / 255.0F);
                GeckoU.WriteFloat(0x109C8E6C, colorDlg.Color.G / 255.0F);
                GeckoU.WriteFloat(0x109C8E70, colorDlg.Color.B / 255.0F);
                GeckoU.WriteFloat(0x109C8E74, colorDlg.Color.A / 255.0F);
            }
        }

        private void AllItemsStack_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x248881C, 0x4E800020, 0x7C0802A6, AllItemsStack.Checked);
        }

        private void metroCheckBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (UnlockAllAchivements.Checked)
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x19, uint.MaxValue);
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x1D, uint.MaxValue);
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x21, uint.MaxValue);
            }
            else
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x19, 0x0);
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x1D, 0x0);
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CED18) + 0x4C4) + 0x21, 0x0);
            }
        }

        private void metroCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0305d384, 0x41820038, nop, EnableAction.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x0305d364, 0x41820058, nop, EnableAction.Checked);

            MainForm.GeckoU.WriteUIntToggle(0x0305d384, nop, 0x41820038, EnableAction.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x0305d364, nop, 0x41820058, EnableAction.Checked);
        }

        private void DisableFallingBlocks_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteULongToggle(0x0235C624, 0x600000004E800020, 0x3D800236398CBDD8, DisableFallingBlocks.Checked);
        }

        private void metroCheckBox70_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteULongToggle(0x02D5731C, 0x386000014E800020, 0x7C0802A69421FFF0, BypassFriendOfFriend.Checked);
        }

        private void metroCheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108E0C8C, 0xBE800000, 0x3E800000, FastZR.Checked);
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            if (nukerType.SelectedIndex == 0)
            {
                string input = "9421ff603d2030126129303092e1007c82e90000938100903f80109c7d5700d0639cd8e4813c00007c17500091c10058812900349201006092a100749141004482a9005481c900588209005c418002507d3770507c0802a6912100507d37805091e1005c3de0028a9261006c3e608000932100843f20109c934100883f40028a9361008c3f60030493c100983fc05980900100a47eb7a8509221006463de000492410068627300019281007061efd6c492c10078637ba5d893010080633946a493a10094635aec5c93e1009c3dc04330912100489141004c812100443e958000830100509121004083e100483ed880008201004491c100303d5f80009281003438a0000093e1001038800000c82100307de903a693c100303860000092a100083ba00000c00100303a10000191c100283bff000192c1002cfc2100289301000cc841002893c10028c001002891c1002091410024fc420028c881002093c10020c001002091c100189261001cfc840028c861001893c10018c0010018fc6300284e800421815c0000388100387f6903a6814a0034814a08789061003893a1003c7d4353784e80042180d9000038e0000038a10008388000007f4903a6386000004e80042180d9000038a100087c721b7838e00000388000027f4903a6386000004e80042180fc0000388100387f6903a680e700347c711b78806708789241003893a1003c4e800421811c0000388100387f6903a681080034806808789221003893a1003c4e8004217c1780004080fec8812100403b180001392900017c174800912100404080fea48121004c3ab50001392900017c1748009121004c4080fe7c800100a481e1005c822100647c0803a6824100688261006c8281007082c100788301008083210084834100888361008c83a1009483c1009883e1009c81c100588201006082a1007482e1007c83810090382100a04e800020";
                MainForm.GeckoU.makeAssembly(0x3916AD8, input);
                MainForm.GeckoU.makeAssembly(0x3916AD8, input);
                MainForm.GeckoU.CallFunction(0x3916AD8, new uint[1]);
            }
            if (nukerType.SelectedIndex == 1)
            {
                string input2 = "9421ff403d20301261293030938100b03f80109c639cd8e481290000815c000091e1007c814a0034810a005481ea00587ce940507d084a147c0740009101006c90e10040810a005c408003347d4978507cef4a147c0a380090e100587ce9405092c10098914100687ec949d690e100547d484a14408003187c075000408003107d4900d0924100885529083c3e408000912100607c0802a67d0838506249000191c100783dc0028a920100803e005980932100a43f20109c934100a83f40028a936100ac3f600304900100c4621000049221008461ced6c49261008c637ba5d892810090633946a492a10094635aec5c92e1009c3de04330930100a093a100b493c100b893e100bc914100709101005c91410064912100488121006483a100687d2949d691210050812100709121004c812100403d298000912100448121004c3f1d8000826100607fc949d6812100508221005c824100547fde4a147d3189d67d29f2147c1648004081017c814100443d32800091e1003038a000009141003438800000814100407dc903a6c821003038600000920100303be0000091410008c001003091e100289301002cfc21002893a1000cc84100289201002892410010c001002891e1002091210024fc42002881210048c881002092010020c001002091e100189121001cfc840028c861001892010018c0010018fc6300284e800421813c0000388100387f6903a681290034812908789061003893e1003c7d234b784e80042180d9000038e0000038a10008388000007f4903a6386000004e80042180d900007c751b7838e0000038a10008388000017f4903a6386000004e80042180d9000038e0000038a100087c771b78388000027f4903a6386000004e800421811c0000388100387f6903a6810800347c741b788068087892a1003893e1003c4e800421815c0000388100387f6903a6814a0034806a087892e1003893e1003c4e800421813c0000388100387f6903a681290034806908789281003893e1003c4e8004213673ffff3a5200013a3100014082fe6c8121004c3bbd0001392900019121004c812100587c1d48004082fe308121004039490001812100649141004039290001912100648121006c7c0a48004082fde8800100c481c10078820100807c0803a682210084824100888261008c8281009082a1009482c1009882e1009c830100a0832100a4834100a8836100ac83a100b483c100b883e100bc81e1007c838100b0382100c04e80002082c1009881e1007c838100b0382100c04e800020";
                MainForm.GeckoU.makeAssembly(0x3915000, input2);
                MainForm.GeckoU.CallFunction(0x3915000, new uint[0x1]);
            }
        }

        private void nukerSize_ValueChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x30123030, MainForm.GeckoU.Mix(0x0, nukerSize.Value));
            MainForm.GeckoU.WriteUInt(0x30123040, MainForm.GeckoU.Mix(0x0, nukerSize.Value));
        }

        private void metroCheckBox1_CheckedChanged_3(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x4000238, 0x48000044, 0x60000000, MapTeleport.Checked);
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2F88110, 0x39400002, 0x39400003, CanWritePrargraph.Checked);
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0271AA74, on, 0x7FE3FB78, Flying.Checked);
        }

        private void metroComboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (aimbotBox.Text)
            {
                case "Normal":
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x60000000);
                    return;

                case "Players":
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x40008B8, 0x80A400C8);
                    MainForm.GeckoU.WriteUInt(0x40008BC, 0x80C400CC);
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x48000614);
                    return;

                case "Entitys":
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x60000000);
                    MainForm.GeckoU.WriteUInt(0x40008B8, 0x80A40038);
                    MainForm.GeckoU.WriteUInt(0x40008BC, 0x80C4003C);
                    MainForm.GeckoU.WriteUInt(0x4000B68, 0x80840038);
                    MainForm.GeckoU.WriteUInt(0x4000264, 0x48000614);
                    return;
            }
        }

        private void executeMoveInventoryOpen()
        {
            while (InventoryWalk.Checked)
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x10A90E70) + 0x31C, 0x0);
            }
        }

        private void InventoryWalk_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.executeMoveInventoryOpen));
            if (InventoryWalk.Checked)
            {
                thread.Start();
            }
            else
            {
                thread.Abort();
            }
        }

        private void dropStack_Click(object sender, EventArgs e)
        {
           MainForm.GeckoU.CallFunction(0x031E7534, MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A648) + 0x2C), 0x0);
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108E0C8C, 0x3E803E6A, 0xBE800000, FastAttack.Checked);
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108911B8, 0x40000000, 0x3FF00000, LargeFOV.Checked);
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02162F04, 0x3BE00001, 0x3BE00014, SpamBow.Checked);
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x030E4924, 0x38800000, 0x38800001, XRay.Checked);
        }

        private void metroCheckBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x107FC738, 0x3F000000, 0x3F800000, BigHUD.Checked);
        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02C57E94, this.on, 0x57E3063E, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C57E34, this.on, 0x57E3063E, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C51C20, this.on, 0x57E3063E, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C5CC84, this.on, 0x88630124, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C57D74, this.on, 0x57E3063E, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C57DD4, this.on, 0x57E3063E, AllPermissions.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x02C5EED8, this.off, this.on, AllPermissions.Checked);
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02456F4C, this.on, 0x5403063E, Creative.Checked);
        }

        private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            //MainForm.GeckoU.WriteUIntToggle(0x02AE8AC4, 0x3BE00001, 0x3BE00000, AllDLCFree.Checked);
            GeckoU.WriteUIntToggle(0x02AE8B30, on, 0x7FE3FB78, AllDLCFree.Checked);
            GeckoU.WriteUIntToggle(0x02AEF828, on, 0x7FE3FB78, AllDLCFree.Checked);
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x031B2B4C, this.on, 0x5403063E, SeeNNIDTags.Checked);
        }

        private void metroCheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02F5C874, on, off, SeeDebugText.Checked);
        }

        private void metroCheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0257D980, 0xFC00E838, 0xFC006378, SuperKnockback.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x0257D990, 0xFD20B890, 0xFD290372, SuperKnockback.Checked);
        }

        private void metroCheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x024872AC, on, 0x3D800248, InfiniteItems.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x024872B0, blr, 0x398C7294, InfiniteItems.Checked);
        }

        private void metroCheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0207F604, this.on, 0x7FC3F378, PlaceBlocksHead.Checked);
        }

        private void metroCheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02F70970, on, off, CraftAll.Checked);
        }

        private void metroCheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x105DDAF8, 0xC3B40000, 0xC2B40000, FUllRotation.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x105DDAFC, 0x43B40000, 0x42B40000, FUllRotation.Checked);
        }

        private void metroCheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0232F3A0, 0x38800001, 0x38800000, JumpAir.Checked);
        }

        private void metroCheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x10A2B3B4, 0xBE81C6A8, 0xEA801C8B, HostOption.Checked);
        }

        private void metroCheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2727824, 0xFC80F890, 0xFC20F890, Godmode.Checked);
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox2.Text)
            {
                case "x1":
                    MainForm.GeckoU.WriteUInt(0x1066ACC8, 0x3E26AD89);
                    return;

                case "x2":
                    MainForm.GeckoU.WriteUInt(0x1066ACC8, 0x3E96AD89);
                    return;

                case "x5":
                    MainForm.GeckoU.WriteUInt(0x1066ACC8, 0x3F56AD89);
                    return;

                case "x10":
                    MainForm.GeckoU.WriteUInt(0x1066ACC8, 0x4026AD89);
                    return;
            }
        }

        private void metroCheckBox24_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108F5620, 0x43E00000, 0x40800000, Reach.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x108E0BDC, 0x43E00000, 0x40A00000, Reach.Checked);
        }

        private void metroCheckBox25_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0253C71C, on, off, FreezeWorld.Checked);
        }

        private void metroCheckBox26_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x257D85C, this.blr, 0x9421FFA8, NoKnockback.Checked);
        }

        private void metroCheckBox27_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2C7DD38, off, on, NoKillBarrier.Checked);
        }

        private void metroCheckBox28_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2E3A950, off, 0x57E3063E, NoTumbleHUD.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x2C57EBC, off, 0x8863012A, NoTumbleHUD.Checked);
        }

        private void metroCheckBox29_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2C59E04, on, off, TNTBreaksBlocks.Checked);
        }

        private void metroCheckBox30_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02C9554C, off, on, NoEndGame.Checked);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.Text)
            {
                case "x1":
                    GeckoU.WriteUInt(0x10665E20, 0x3F000000);
                    return;

                case "x2":
                    GeckoU.WriteUInt(0x10665E20, 0x3F500000);
                    return;

                case "x5":
                    GeckoU.WriteUInt(0x10665E20, 0x3FF00000);
                    return;

                case "x10":
                    GeckoU.WriteUInt(0x10665E20, 0x41000000);
                    return;
            }
        }

        private void metroCheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2C7DDD0, on, off, HurtPlayers.Checked);
        }

        private void metroCheckBox34_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x20EA77C, on, 0x57C3063E, SilkTouch.Checked);
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox3.Text)
            {
                case "x1":
                    GeckoU.WriteUInt(0x109BF8E0, 0x3FF80000);
                    return;

                case "x2":
                    GeckoU.WriteUInt(0x109BF8E0, 0x3FF00000);
                    return;

                case "x5":
                    GeckoU.WriteUInt(0x109BF8E0, 0x3FEE0000);
                    return;

                case "x10":
                    GeckoU.WriteUInt(0x109BF8E0, 0x3FE90000);
                    return;
            }
        }

        private void metroCheckBox33_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x257E000, this.off, 0x57E3063E, BloodVision.Checked);
        }

        private void metroCheckBox35_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x31C06A4, this.on, this.off, Foggy.Checked);
        }

        private void metroCheckBox36_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x30DAB7C, 0x38800000, 0x38800001, NoFog.Checked);
        }

        private void metroCheckBox37_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x239A26C, this.nop, 0x4180000C, LargeXP.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x239A270, 0x38607FFF, 0x386009AD, LargeXP.Checked);
        }

        private void metroCheckBox39_CheckedChanged(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A72A94) + 0xC0);
            MainForm.GeckoU.WriteUIntToggle(num + 0x90, 0x1F000, 0x100000, VisibleBox.Checked);
        }

        private void metroCheckBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GameMods.Checked)
            {
                uint address = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C4CEC) + 0x4C);
                MainForm.GeckoU.WriteUInt(address, 0x5);
                return;
            }
            else
            {
                uint address2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C4CEC) + 0x4C);
                MainForm.GeckoU.WriteUInt(address2, 0x2);
            }
        }

        private void metroCheckBox41_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x271BA6C, this.on, 0x7FE3FB78, NoHunger.Checked);
        }

        private void metroCheckBox43_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x24FD7F4, this.on, this.off, DualWithEverything.Checked);
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "You are about to close the game, Press yes to confirm", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainForm.GeckoU.CallFunction64(0x2F50028, new uint[1]);
            }
        }

        private void metroCheckBox44_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x256CDFC, this.on, 0x5403063E, NoSpawnLimit.Checked);
        }

        private void metroCheckBox42_CheckedChanged_2(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x248909C, this.nop, 0x4181001C, ItemsNeverBreak.Checked);
        }

        private void metroCheckBox45_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x20E7BF4, this.blr, 0x9421FFE0, NoColision.Checked);
        }

        private void metroCheckBox46_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x258E4BC, this.off, this.on, IgnorePotions.Checked);
        }

        private void metroCheckBox32_CheckedChanged_2(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2576994, this.blr, 0x9421FF40, ForeverLastingPotion.Checked);
        }

        private void metroCheckBox47_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x105DD948, 0x41099999, 0x3F000000, PushEntitys.Checked);
        }

        private void metroCheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x25BF44C, on, 0x886300A9, DisableCreative.Checked);
        }

        private void metroCheckBox49_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x255E81C, 0x38000001, 0x38000000, WtaerFly.Checked);
        }

        private void metroCheckBox50_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2173790, 0x38800000, 0x38800001, UnlimitedBlocksFoodArrows.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x241467C, 0x38800000, 0x38800001, UnlimitedBlocksFoodArrows.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x21643CC, 0x38800000, 0x38800001, UnlimitedBlocksFoodArrows.Checked);
        }

        private void metroCheckBox51_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x255F818, 0x38000001, 0x38000000, Burning.Checked);
        }

        private void metroCheckBox52_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x10665EF0, 0x459C4000, 0x40400000, NoFallDamage.Checked);
        }

        private void metroCheckBox53_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x3409DF0, 0x2C030001, 0x2C030000, TVMode.Checked);
        }

        private void metroCheckBox54_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x10548CD0, 0x3FE00001, 0x0, AlwaysJumping.Checked);
        }

        private void metroCheckBox55_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2572AA4, this.blr, this.mflr, InfiniteAir.Checked);
        }

        private void metroCheckBox56_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x257DF90, this.on, off, SpiderMode.Checked);
        }

        private void metroCheckBox57_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2341E20, off, on, CantKillEntity.Checked);
        }

        private void metroCheckBox58_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x232C210, this.on, this.off, InfiniteRiptide.Checked);
        }

        private void metroCheckBox59_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x24D0268, blr, 0x7C0802A6, EverythingEnchanted.Checked);
        }

        private void metroCheckBox60_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x13A31654, 0x5C7A3E, 0x3030303, NoEnchantmentTexture.Checked);
        }

        private void metroCheckBox61_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x023404B0, 0x200A0000, 0x2C0A0000, DisableFlames.Checked);
        }

        private void metroCheckBox62_CheckedChanged(object sender, EventArgs e)
        {
            uint num2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A624) + 0x9C);
            num2 += 0x734;
            MainForm.GeckoU.WriteUIntToggle(num2, 0x3EA3D70A, 0x3CA3D70A, BunnyHop.Checked);

        }

        private void metroCheckBox63_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x105DCCE0, 0xC0000000, 0x0, KillAura.Checked);
        }

        private void metroCheckBox65_CheckedChanged(object sender, EventArgs e)
        {
            if (this.StackMax.Checked)
            {
                uint num = MainForm.GeckoU.PeekUInt(0x109C50E0);
                num += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num2 = MainForm.GeckoU.PeekUInt(0x109C50E4);
                num2 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num3 = MainForm.GeckoU.PeekUInt(0x109C50E8);
                num3 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num4 = MainForm.GeckoU.PeekUInt(0x109C50EC);
                num4 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num5 = MainForm.GeckoU.PeekUInt(0x109C50F0);
                num5 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num6 = MainForm.GeckoU.PeekUInt(0x109C50F4);
                num6 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num7 = MainForm.GeckoU.PeekUInt(0x109C50F8);
                num7 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
                uint num8 = MainForm.GeckoU.PeekUInt(0x109C50FC);
                num8 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x40);
            }
            else
            {
                uint num = MainForm.GeckoU.PeekUInt(0x109C50E0);
                num += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num2 = MainForm.GeckoU.PeekUInt(0x109C50E4);
                num2 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num3 = MainForm.GeckoU.PeekUInt(0x109C50E8);
                num3 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num4 = MainForm.GeckoU.PeekUInt(0x109C50EC);
                num4 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num5 = MainForm.GeckoU.PeekUInt(0x109C50F0);
                num5 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num6 = MainForm.GeckoU.PeekUInt(0x109C50F4);
                num6 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num7 = MainForm.GeckoU.PeekUInt(0x109C50F8);
                num7 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
                uint num8 = MainForm.GeckoU.PeekUInt(0x109C50FC);
                num8 += 0xC;
                MainForm.GeckoU.WriteUInt(num, 0x1);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A624) + 0x9C);
            num += 0x71C;
            MainForm.GeckoU.WriteUInt(num, (uint)Convert.ToByte(this.numericUpDown1.Value));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x2C7C004, MainForm.GeckoU.Mix((uint)0x38600000, PlayersRequierment.Value));
        }

        private void metroCheckBox64_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x23654B0, blr, 0x9421FFD8, SlowFalling.Checked);
        }

        private void metroCheckBox66_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x225458C, this.on, 0x88630009, BypassInvulnerability.Checked);
        }

        private void metroCheckBox71_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x253C3CC, 0x4E800020, 0x88630011, EffectUnderwater.Checked);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            new GiveItems(this).Show();
        }

        private void metroCheckBox73_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x31F5484, 0x38630A08, 0x88630A08, AlwaysRiptide.Checked);
        }

        private void metroCheckBox74_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02B49E24, 0x38800001, 0x38800000, LeftItemSlot.Checked);
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            uint bl = Convert.ToUInt32(Convert.ToInt32(metroTextBox1.Text, 16).ToString("X"));
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
            MainForm.GeckoU.WriteUInt(num + 0x288, bl);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            uint bl = Convert.ToUInt32(Convert.ToInt32("173", 16).ToString("X"));
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
            MainForm.GeckoU.WriteUInt(num + 0x288, bl);
            blockpre.Text = "Coalblock";
        }

        private void metroCheckBox72_CheckedChanged_1(object sender, EventArgs e)
        {
            if (EnableModCHK.Checked)
            {
                uint int1 = Convert.ToUInt32(addr.Text, 16);
                uint int2 = Convert.ToUInt32(val1.Text, 16);
                MainForm.GeckoU.WriteUInt(int1, int2);
            }
            else
            {
                uint int1 = Convert.ToUInt32(addr.Text, 16);
                uint int2 = Convert.ToUInt32(val2.Text, 16);
                MainForm.GeckoU.WriteUInt(int1, int2);
            }
        }

        private void metroCheckBox75_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2340620, 0x38A00000, 0x38A00001, SwimmingDisabled.Checked);
        }

        private void metroCheckBox76_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0333A648, 0x38600007, 0x38600003, ShulkerBox.Checked);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x2C5CC74, MainForm.GeckoU.Mix((uint)0x38600000, ChestRefill.Value));
        }

        private void metroCheckBox77_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x22740E4, blr, 0x7C0802A6, NoCreeperExplosion.Checked);
        }

        private void metroCheckBox78_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2346390, off, on, BlocksDontExplode.Checked);
        }

        private void metroCheckBox80_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02C5EED0, 0x540E063E, 0x5403063E, DisableHUD.Checked);
        }

        private void metroCheckBox81_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02496FEC, 0x38600001, 0x38600000, OldPotions.Checked);
        }

        private void metroCheckBox82_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02C57EBC, 0x8863012C, 0x8863012A, BlockInventory.Checked);
        }

        private void metroCheckBox84_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0241A1F8, 0x38A07FFF, 0x38A00064, GoldenAppleRegeneration.Checked);
        }

        private void metroCheckBox85_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x10A2B3B4, 0x0001FA10, 0x00000000, UnlockHostOptions.Checked);
        }

        private void metroCheckBox86_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0255F788, 0x3B200000, 0x3B200001, WalkLava.Checked);
        }

        private void metroCheckBox87_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x031AE8B4, on, off, NoHand.Checked);
        }

        private void metroCheckBox88_CheckedChanged_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02F70970, on, off, DebugMode.Checked);
        }

        private void metroCheckBox79_CheckedChanged_2(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x025795C0, 0xFC80F890, 0xFC20F890, NoDamage.Checked);
        }

        private void metroCheckBox89_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02479B08, on, off, NoItems.Checked);
        }

        private void metroCheckBox90_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02B47934, 0x2C1D0001, 0x2C1D0000, LevelX.Checked);
        }

        private void metroCheckBox91_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02B56BE8, 0x6C088001, 0x6C088000, NoEffects.Checked);
        }

        private void metroCheckBox92_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x0253C3CC, off, 0x88630011, NoUnderwaterFOG.Checked);
        }

        private void metroCheckBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (FastMinecraft.Checked)
            {
                uint address = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x20);
                MainForm.GeckoU.WriteUInt(address, 0x41F00005);
                return;
            }
            uint address2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x20);
            MainForm.GeckoU.WriteUInt(address2, 0x41A00000);
        }

        private void metroCheckBox93_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108E0E60, 0x3FFFFFFF, 0x3E4CCCCD, EatWhileRunning.Checked); //0x3FFFFFFF
        }

        private void metroCheckBox94_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2078964, on, off, NoBow.Checked);
        }

        private void metroCheckBox96_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x272B714, on, 0x7C0802A6, HostOptionsOnOthers.Checked);
            MainForm.GeckoU.WriteUIntToggle(0x272B718, blr, 0x90010004, HostOptionsOnOthers.Checked);
        }

        private void metroCheckBox99_CheckedChanged(object sender, EventArgs e)
        {
            //MainForm.GeckoU.WriteUIntToggle(0x1004F71C, 0x0, 0x1, Mute.Checked);
        }

        private void metroCheckBox105_CheckedChanged(object sender, EventArgs e)
        {
            if (Clip.Checked)
            {
                uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A624) + 0x9C);
                MainForm.GeckoU.WriteUInt(num + 0x1DC, 0x10000000);
                return;
            }
            uint num2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A624) + 0x9C);
            MainForm.GeckoU.WriteUInt(num2 + 0x1DC, 0x0);
        }

        private void metroCheckBox106_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x232D008, 0x38000001, 0x38000000, EntitysOnFire.Checked);
        }

        private void metroCheckBox98_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x23B58AC, blr, 0x7C0802A6, NoRain.Checked);
        }

        private void metroCheckBox97_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x24B16D4, off, on, NoNetherFog.Checked);
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void metroCheckBox104_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x23F66A4, on, off, Smelting.Checked);
        }

        private void metroCheckBox68_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void metroCheckBox107_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x257B724, blr, 0x7C0802A6, DisableTotems.Checked);
        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (blockpre.Text)
            {
                case "Barrier":
                    uint bl_ = Convert.ToUInt32(Convert.ToInt32("166", 16).ToString("X"));
                    uint num_ = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num_ + 0x288, bl_);
                    return;

                case "Command Block":
                    uint bl__ = Convert.ToUInt32(Convert.ToInt32("137", 16).ToString("X"));
                    uint num__ = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num__ + 0x288, bl__);
                    return;

                case "Repeating Command Block":
                    uint bl___ = Convert.ToUInt32(Convert.ToInt32("210", 16).ToString("X"));
                    uint num___ = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num___ + 0x288, bl___);
                    return;

                case "Chain Command Block":
                    uint bl____ = Convert.ToUInt32(Convert.ToInt32("211", 16).ToString("X"));
                    uint num____ = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num____ + 0x288, bl____);
                    return;

                case "Redstone Wire":
                    uint bl_____ = Convert.ToUInt32(Convert.ToInt32("55", 16).ToString("X"));
                    uint num_____ = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num_____ + 0x288, bl_____);
                    return;

                case "Water Block":
                    uint _bl = Convert.ToUInt32(Convert.ToInt32("9", 16).ToString("X"));
                    uint _num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(_num + 0x288, _bl);
                    return;

                case "Lava Block":
                    uint __bl = Convert.ToUInt32(Convert.ToInt32("11", 16).ToString("X"));
                    uint __num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(__num + 0x288, __bl);
                    return;

                case "Half Bed":
                    uint ___bl = Convert.ToUInt32(Convert.ToInt32("26", 16).ToString("X"));
                    uint ___num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(___num + 0x288, ___bl);
                    return;

                case "Piston Head":
                    uint ____bl = Convert.ToUInt32(Convert.ToInt32("34", 16).ToString("X"));
                    uint ____num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(____num + 0x288, ____bl);
                    return;

                case "Burning Furnace":
                    uint bl = Convert.ToUInt32(Convert.ToInt32("62", 16).ToString("X"));
                    uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num + 0x288, bl);
                    return;

                case "Farmland":
                    uint _____bl = Convert.ToUInt32(Convert.ToInt32("60", 16).ToString("X"));
                    uint _____num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(_____num + 0x288, _____bl);
                    return;

                case "Wheat Crops":
                    uint ______bl = Convert.ToUInt32(Convert.ToInt32("59", 16).ToString("X"));
                    uint ______num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(______num + 0x288, ______bl);
                    return;

                case "Redstone Repeater (On)":
                    uint bl2 = Convert.ToUInt32(Convert.ToInt32("94", 16).ToString("X"));
                    uint num2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num2 + 0x288, bl2);
                    return;

                case "Redstone Repeater (Off)":
                    uint bl3 = Convert.ToUInt32(Convert.ToInt32("93", 16).ToString("X"));
                    uint num3 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num3 + 0x288, bl3);
                    return;

                case "Redstone Lamp (On)":
                    uint bl4 = Convert.ToUInt32(Convert.ToInt32("124", 16).ToString("X"));
                    uint num4 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num4 + 0x288, bl4);
                    return;

                case "Spectral Arrow":
                    uint bl5 = Convert.ToUInt32(Convert.ToInt32("439", 16).ToString("X"));
                    uint num5 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109C50DC) + 0x234);
                    MainForm.GeckoU.WriteUInt(num5 + 0x288, bl5);
                    return;
            }
        }

        private void metroCheckBox108_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2F70970, on, off, CantJoin.Checked);
        }

        private void metroCheckBox103_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x108C7C2C, nop, 0x3CF5C28F, Fullbright.Checked); //0x60000000
        }


        private static bool smethod_8(string string_0, string string_1)
        {
            return string_0 == string_1;
        }

        private static string controlText_method(Control control_0)
        {
            return control_0.Text;
        }

        private void metroButton20_Click_1(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x10A0A614) + 0xD4);
            num += 0x814;
            MainForm.GeckoU.WriteUInt(num, 0x0);
        }

        private void metroComboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MainForm.GeckoU.WriteUInt(0x18BBFF48, 0x00000005);
            //MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xD1));
            if (blockpre2.Text == "Nether Portal")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x5A));
            }
            if (blockpre2.Text == "End Gateway")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xD1));
            }
            if (blockpre2.Text == "Barrier")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xA6));
            }
            if (blockpre2.Text == "Command Block")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x89));
            }
            if (blockpre2.Text == "Repeating Command Block")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xD2));
            }
            if (blockpre2.Text == "Chain Command Block")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xD3));
            }
            if (blockpre2.Text == "Redstone Wire")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x37));
            }
            if (blockpre2.Text == "Water Block")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x9));
            }
            if (blockpre2.Text == "Lava Block")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0xB));
            }
            if (blockpre2.Text == "Half Bed")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x1A));
            }
            if (blockpre2.Text == "Burning Furnace")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x3E));
            }
            if (blockpre2.Text == "Farmland")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x3C));
            }
            if (blockpre2.Text == "Redstone Repeater (On)")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x5E));
            }
            if (blockpre2.Text == "Redstone Repeater (Off)")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x5D));
            }
            if (blockpre2.Text == "Redstone Lamp (On)")
            {
                MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x7C));
            }
        }

        private void metroButton18_Click_1(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(MainForm.GeckoU.PeekUInt(0x109C3BC0) + 0x28, MainForm.GeckoU.Mix(0x0, 0x32));
        }

        private void metroCheckBox110_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x2162F04, 0x3BE00050, 0x3BE00014, LongBowCooldown.Checked);
        }


        private void metroCheckBox112_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x025A9850, on, 0x57C3063E, PickLiquedBlocks.Checked);
        }

        private void metroCheckBox38_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02DEC0B4, on, 0x57E3063E, TakeAll.Checked);
        }

        private void metroCheckBox67_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUIntToggle(0x02E9B1B0, 0x7FE4FB78, 0x7FC4F378, SeeArmorAlways.Checked);
        }
        #endregion

        #region Themes
        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeBx.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroThemeStyle.Dark;
                    Config.WriteKey("StyleTheme", themeBx.Text, "Theme");
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    Config.WriteKey("StyleTheme", themeBx.Text, "Theme");
                    break;

            }
        }

        private void colorBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorBx.Text);
            StyleManager.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), colorBx.Text);
            Config.WriteKey("ColorTheme", colorBx.Text, "Theme");

        }
        #endregion

        #region Language Debugging
        private void Sprache()
        {
            PH.Text = "Spieler Mods";
            MGS.Text = "Minispiel Mods";
            GRL.Text = "General Mods";
            World.Text = "Welt Mods";
            BlockCH.Text = "Block Wechsler";
            CDT.Text = "Eigene Mods";

            Flying.Text = "Immer Fliegen";
            FastAttack.Text = "Schnell Schlagen";
            LargeFOV.Text = "Große Sicht";
            SpamBow.Text = "Spam Bogen";
            XRay.Text = "X-Ray";
            BigHUD.Text = "Großes HUD";
            Creative.Text = "Kreativ Modus";
            SeeNNIDTags.Text = "Immer Spieler Namen Sehen";
            SeeDebugText.Text = "Item IDs sehen";
            SuperKnockback.Text = "Krasser Rückstoß";
            NoKnockback.Text = "Kein Rückstoß";
            InfiniteItems.Text = "Unendliche Items";
            PlaceBlocksHead.Text = "Blöcke auf den Kopf plazieren";
            CraftAll.Text = "Alles ist Herstellbar";
            JumpAir.Text = "In der Luft springen";
            WtaerFly.Text = "In der Luft Schwimmen";
            UnlimitedBlocksFoodArrows.Text = "Unendliche Blöcke, Essen, Pfeile";
            Burning.Text = "Immer am Brennen";

            AllPermissions.Text = "Alle Minigame Rechte";
            HostOption.Text = "Hostprivilegien Aktivieren";
            NoKillBarrier.Text = "Keine Schadens Barriere";
            NoTumbleHUD.Text = "Kein Sturz HUD";
            TNTBreaksBlocks.Text = "TNT zerstört Blöcke";
            NoEndGame.Text = "Das Spiel Ended Nie";
            HurtPlayers.Text = "Spieler Verletzen";
            DisableHUD.Text = "Kein HUD";
            BlockInventory.Text = "Inventar Blockieren";
            ReleaseMovement.Text = "Gehbeschrängung beim start des Minispiels Entfernen";
            PlayerLBN.Text = "Spieler:";
            ChestRefillLBN.Text = "Nachfüllzeit von Truhen:";
        }
        #endregion

        #region Navigation
        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = PH;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = MGS;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = GRL;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = World;
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = BlockCH;
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = WRLD;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = more;
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = home;
        }
        #endregion

        #region World Edit

        private void metroButton9_Click(object sender, EventArgs e)
        {
            string input = "9421ff687c0802a69001009c936100843f60109c637bd8e491e10054813b00009221005c8129003492e1007481e900548229005882e9005c392f0002912100443931ffff912100483937ffff91c100503dc0028a924100603e408000926100643e60109c928100683e80028a92a1006c3ea0028b934100803f40030493c100903fc059809201005863de000492c10070625200019301007861ced6c4938100883a31000293e100943af7000291210040635aa5d89321007c627346a493a1008c3b2fffff6294ec5c62b52b8c3fa0433081e100483ed9800083e100403f0f800093a100303d3f800092c1003438a0000093e1001038800000c82100307dc903a693c1003038600000932100083b800000c00100303bff000193a100289301002cfc21002891e1000cc841002893c10028c001002893a1002091210024fc420028c881002093c10020c001002093a100189241001cfc840028c861001893c10018c0010018fc6300284e800421813b0000388100387f4903a68129003481290878906100389381003c7d234b784e80042180d3000038e0000038a10008388000057e8903a6386000004e800421388000007c701b787ea903a6386000004e800421811b0000388100387f4903a68108003481080878906100389381003c7d0343784e800421811b0000388100387f4903a68108003480680878920100389381003c4e8004217c17f8404082fed839ef00017c1178404082fec4812100443b3900017c1948404082feac8001009c81c1005081e100547c0803a6820100588221005c82410060826100648281006882a1006c82c1007082e10074830100788321007c83410080836100848381008883a1008c83c1009083e10094382100984e800020";
            MainForm.GeckoU.makeAssembly(0x03917010, input);
            MainForm.GeckoU.CallFunction(0x03917010, new uint[1]);
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Copied Building!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            executeGetBuildWithDamage();
        }

        private void executeGetBuildWithDamage()
        {
            if (this.startY.Value > this.endY.Value)
            {
                decimal value = this.endY.Value;
                this.endY.Value = this.startY.Value;
                this.startY.Value = value;
            }
            uint value3;
            if (this.startX.Value < 0m)
            {
                decimal value2 = 4294967295m + this.startX.Value;
                value3 = (uint)value2;
            }
            else
            {
                value3 = (uint)this.startX.Value;
            }
            MainForm.GeckoU.WriteUInt(974127104u, value3);
            uint value5;
            if (this.startY.Value < 0m)
            {
                decimal value4 = 4294967295m + this.startY.Value;
                value5 = (uint)value4;
            }
            else
            {
                value5 = (uint)this.startY.Value;
            }
            MainForm.GeckoU.WriteUInt(974127108u, value5);
            uint value7;
            if (this.startZ.Value < 0m)
            {
                decimal value6 = 4294967295m + this.startZ.Value;
                value7 = (uint)value6;
            }
            else
            {
                value7 = (uint)this.startZ.Value;
            }
            MainForm.GeckoU.WriteUInt(974127112u, value7);
            uint value9;
            if (this.endX.Value < 0m)
            {
                decimal value8 = 4294967295m + this.endX.Value;
                value9 = (uint)value8;
            }
            else
            {
                value9 = (uint)this.endX.Value;
            }
            MainForm.GeckoU.WriteUInt(974127120u, value9);
            uint value11;
            if (this.endY.Value < 0m)
            {
                decimal value10 = 4294967295m + this.endY.Value;
                value11 = (uint)value10;
            }
            else
            {
                value11 = (uint)this.endY.Value;
            }
            MainForm.GeckoU.WriteUInt(974127124u, value11);
            uint value13;
            if (this.endZ.Value < 0m)
            {
                decimal value12 = 4294967295m + this.endZ.Value;
                value13 = (uint)value12;
            }
            else
            {
                value13 = (uint)this.endZ.Value;
            }
            MainForm.GeckoU.WriteUInt(974127128u, value13);
            MainForm.GeckoU.WriteUInt(52053236u, 2080899750u);
            string input = "9421ff987c0802a63d203a103d403a109001006c61290010924100307d800026824900003d2003186129c8789321004c7d2903a63d203a10832a000061290018614a00089221002c934100503cc0109c834a00003ce03a10822900003d003a107cb9905093e1006460c6d8e460e70004610800147ffa88509181001c38800000926100342d050000826700009281003893c10060828800008066000090a100107e93a05093e100082d9400004e8004217c7e1b784188017c418c01402e1f000092a1003c4190042c418a054091c1002091e100249201002892c1004092e1004493010048936100549381005893a1005c4091051039ffffff55ef2834394f00203d2002543ec002549141000c612fccac62d6d8007f32cb783ae000003ea03d003e001200418e00943b000000419200807dd89a14409103a4836100087ebfab783ba000007e3dd2147dc573787e268b787e4493787de903a67fc3f3783bff00204e8004217e268b787c7c1b787dc573787e4493787fc3f3787ec903a64e800421377bffff93bfffe83bbd0001939fffec907ffff092ffffe0931fffe493f000004082ffa48121000c7eb54a143b1800017c14c0004181ff78812100103af700013a5200017c09b8004181ff5c81c1002081e100248201002882c1004082e1004483010048836100548381005883a1005c4192030482a1003c8001006c8181001c8221002c7c0803a6824100307d83812082610034828100388321004c8341005083c1006083e10064382100684e80002041acffc88121000892a1003c3ea03d002e0900004091015841aeffac91c1002091e100249201002892c1004092e1004493010048936100549381005893a1005c409103a48121000839e9ffff55ef28343e4002543ec002543a2f00206252ccac62d6d8003ae000003e0012003b0000004192007c7dd89a1440910238836100087ebfab783ba000007dfdd2147dc573787de67b787f24cb787e4903a67fc3f3783bff00204e8004217de67b787c7c1b787dc573787f24cb787fc3f3787ec903a64e800421377bffff93bfffe83bbd0001939fffec907ffff092ffffe0931fffe493f000004082ffa47eb58a143b1800017c14c0004181ff7c812100103af7ffff3b39ffff7c09b8004082ff648001006c8181001c81c100207c0803a681e100247d8381208201002882a1003c82c1004082e1004483010048836100548381005883a1005c8221002c8241003082610034828100388321004c8341005083c1006083e10064382100684e80002091c1002091e100249201002892c1004092e1004493010048936100549381005893a1005c4190026c3a000000393000203e4002549121000c3ee00254812100086252ccac62f7d8007f3ccb787d2900d03b000000912100143ea03d003ec01200418e00943b600000419200807fbb9a14419000dc39e000017ebfab7839c000007e2ed2147fa5eb787e268b787f84e3787e4903a67fc3f3783bff00204e8004217e268b787c701b787fa5eb787f84e3787fc3f3787ee903a64e80042135efffff91dfffe839ceffff921fffec907ffff0931fffe0937fffe493f600004082ffa48121000c7eb54a143b7b00017c14d8004082ff78812100103b18ffff3b9cffff7c09c0004082ff5c81c1002081e100248201002882c1004082e1004483010048836100548381005883a1005c4190fd2c41a8fd7c82a1003c4bfffd243b6000014bfffc603b6000014bfffdcc81e100144bffff283ea03d00418a014441aefcfc91c1002091e100249201002892c1004092e1004493010048936100549381005893a1005c419000fc39e00000812100083e4002543ec0025439ef00207d2900d06252ccac9121000862d6d8003ae000003e0012003b0000004192007c7dd89a144190009c3b6000017ebfab783ba000007e3dd2147dc573787e268b787f24cb787e4903a67fc3f3783bff00204e8004217e268b787c7c1b787dc573787f24cb787fc3f3787ec903a64e800421377bffff93bfffe83bbdffff939fffec907ffff092ffffe0931fffe493f000004082ffa47eb57a143b1800017c14c0004181ff7c812100103af700013b3900017c09b80040a1fd503b0000004bffff60836100084bffff6839e000004bfffaf83ea03d004092fbe84bfffee439e000004bfffc68812100087d2f48f855ef28344bffff007d3048f8561028344bfffd9440b1fe9082a1003c4bfffbb860000000";
            MainForm.GeckoU.makeAssembly(59864492u, input);
            MainForm.GeckoU.CallFunction64(59864492u, new uint[1]);
            MainForm.GeckoU.WriteUInt(301989904u, MainForm.GeckoU.PeekUInt(301989888u));
            MainForm.GeckoU.WriteUInt(52053236u, 1223015176u);
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            uint value = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x54);
            uint value2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x58);
            uint value3 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x5C);
            MainForm.GeckoU.WriteUInt(0x3A100030, value);
            MainForm.GeckoU.WriteUInt(0x3A100034, value2);
            MainForm.GeckoU.WriteUInt(0x3A100038, value3);
            executeSetBuildWithDamage();
        }

        private void executeSetBuildWithDamage()
        {
            MainForm.GeckoU.WriteUInt(0x031A44F4, 0x7C0802A6);
            MainForm.GeckoU.WriteUInt(0x12000000, MainForm.GeckoU.PeekUInt(0x12000010));
            string input = "9421ff483d2012003cc03d003ce03a10920100783d403a108209000060e70030614a0034810700007c103040814a00003d203a1091e1007461290038910100609141006481e90000408102ac92a1008c3ea0800062a9000192e100943ee0109c912100687c0802a662e946a491c100703dc059809221007c3e200248924100803e400248926100843e600248928100883e80028b92c100903ec0028a930100983f00028b9321009c3f20109c934100a03f400304900100bc62316698936100a4625261bc938100a862738b2c93a100ac629409f893c100b06339d8e49121006c635aa5d893e100b461ce000462d6d6c4631825b83fe03d003ee04330807f000c2c0300004182019c812100607e2903a6839f00003b60000083bf00047f89e2148121006482bf00107fa9ea1483df00084e80042138a000407c641b787e4903a6386000007fcff2144e8004217ea4ab787e6903a67c751b784e80042138a10038388000247e8903a692a10038386000009361003c4e80042181590000388100407f4903a6814a0034814a087890610040936100447d4353784e8004213cdc800092e10030395dfffe90c100343d4a80003cde800081210068c821003038a0000091c10030388000007ec903a638600000c001003092e100289141002cfc210028c841002891c10028c001002892e1002090c10024fc420028c881002091c10020c001002092e100189121001cfc840028c861001891c10018c0010018fc6300284e80042181590000388100407f4903a6814a0034814a087890610040936100447d4353784e8004218121006c38c000003881005080a900007f0903a6938100083860000093a1000c93c100109381005093a1005493c100584e80042180d900007c6a1b783881004080c600347f4903a68066087893610044914100404e8004213bff00207c10f8404181fe54800100bc81c100708221007c7c0803a682410080826100848281008882a1008c82c1009082e10094830100988321009c834100a0836100a4838100a883a100ac83c100b083e100b481e1007482010078382100b84e80002060000000";
            MainForm.GeckoU.makeAssembly(0x03917BF4, input);
            MainForm.GeckoU.CallFunction64(0x03917BF4, new uint[1]);
            MainForm.GeckoU.WriteUInt(0x031A44F4, 0x48E5BB08);
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x54);
            uint num2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x58);
            uint num3 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x5C);


            if (num > 0xFFFF){
                num = uint.MaxValue + num;
                num = uint.MaxValue - num;
                this.startX.Value = (int)(0x0 - num);
            }
            else{
                this.startX.Value = num;
            }

            if (num2 > 0xFFFF){
                num2 = uint.MaxValue + num2;
                num2 = uint.MaxValue - num2;
                this.startY.Value = (int)(0x0 - (num2 - 0x1));
            }
            else{
                this.startY.Value = num2 - 0x1;
            }

            if (num3 > 0xFFFF){
                num3 = uint.MaxValue + num3;
                num3 = uint.MaxValue - num3;
                this.startZ.Value = (int)(0x0 - num3);
            }
            else{
                this.startZ.Value = num3;
            }

        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x54);
            uint num2 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x58);
            uint num3 = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x109CD8E4) + 0x34) + 0x5C);

            if (num > 0xFFFF){
                num = uint.MaxValue + num;
                num = uint.MaxValue - num;
                this.endX.Value = (int)(0x0 - num);
            }
            else{
                this.endX.Value = num;
            }
            if (num2 > 0xFFFF){
                num2 = uint.MaxValue + num2;
                num2 = uint.MaxValue - num2;
                this.endY.Value = (int)(0x0 - (num2 - 0x1));
            }
            else{
                this.endY.Value = num2 - 0x1;
            }
            if (num3 > 0xFFFF){
                num3 = uint.MaxValue + num3;
                num3 = uint.MaxValue - num3;
                this.endZ.Value = (int)(0x0 - num3);
            }
            else {
                this.endZ.Value = num3;
            }
        }

        private void endX_ValueChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}