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
using MetroFramework.Properties;
using MetroFramework.Forms;
using wiiplaza.gecko;
using System.Threading;
using Minecraft_Wii_U_Mod_Tool.theme;

namespace Minecraft_Wii_U_Mod_Tool
{
    public partial class ban : MetroForm
    {
        public ban(MainForm Injector)
        {
            InitializeComponent();
            this.on = 0x38600001;
            this.off = 0x38600000;
            this.blr = 0x4E800020;
            if (Injector != null)
            {
                StyleManager.Style = this.Style = Injector.StyleManager.Style;
                StyleManager.Theme = this.Theme = Injector.StyleManager.Theme;
            }
        }
        public static GeckoUCore GeckoU;
        public static GeckoUConnect GeckoUConnection;
        private uint off;
        private uint on;
        private uint blr;
        private string appData;

        private void ban_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (ban.smethod_8(ban.controlText_method(ban_methode), "100"))
            {
                MainForm.GeckoU.WriteUInt(0x2D5731C, on);
                MainForm.GeckoU.WriteUInt(0x2D57320, blr);
                return;
            }
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x101D1D58) + 0x84);
            num += 0x2C;
            MainForm.GeckoU.WriteUInt(0x2D5731C, 0x7C0802A6);
            MainForm.GeckoU.WriteUInt(0x2D57320, 0x9421FFF0);
            MainForm.GeckoU.WriteUInt(num, MainForm.GeckoU.Mix(off, ban_methode.Value));
        }

        private void test()
        {
            if (ban.smethod_8(ban.controlText_method(ban_methode), "100"))
            {
                MainForm.GeckoU.WriteUInt(0x2D5731C, on);
                MainForm.GeckoU.WriteUInt(0x2D57320, blr);
                return;
            }
            uint num = MainForm.GeckoU.PeekUInt(MainForm.GeckoU.PeekUInt(0x101D1D58) + 0x84);
            num += 0x2C;
            MainForm.GeckoU.WriteUInt(0x2D5731C, 0x7C0802A6);
            MainForm.GeckoU.WriteUInt(0x2D57320, 0x9421FFF0);
            MainForm.GeckoU.WriteUInt(num, MainForm.GeckoU.Mix(off, ban_methode.Value));
        }

        private static bool smethod_8(string string_0, string string_1)
        {
            return string_0 == string_1;
        }

        private static string controlText_method(Control control_0)
        {
            return control_0.Text;
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            try
            {
                ban_methode.Value += 1;
                MessageBox.Show(this, "Changed User-ID!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(this, "Couldn't change ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            try
            {
                ban_methode.Value = 0;
                MessageBox.Show(this, "Reset User-ID!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(this, "Couldn't change ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void String_poke(uint address, string name)
        {
            uint[] array = new uint[1];
            uint num = 0x0;
            int num2 = smethod_5(name);
            checked
            {
                if (smethod_5(name) % 2 == 1)
                {
                    name = smethod_1(name, " ");
                    num2++;
                }
                for (int i = 0; i < num2; i++)
                {
                    num = (num << 16 | (uint)ban.smethod_2(name, i));
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
                    ban.smethod_3(2);
                }
            }
        }

        private void gck()
        {
            poke_fnc(0x10000000, 0x0);
            uint num = MainForm.GeckoU.PeekUInt(0x10000000);
            MainForm.GeckoU.WriteUInt(checked(num + 0x1000000), uint.MaxValue);
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num += 0x4C;
            MainForm.GeckoU.WriteUInt(num, 0x0);
            uint num2 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num2 += 0x50;
            MainForm.GeckoU.WriteUInt(num2, 0x0);
            uint num3 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num3 += 0x54;
            MainForm.GeckoU.WriteUInt(num3, 0x0);
            uint num4 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num4 += 0x58;
            MainForm.GeckoU.WriteUInt(num4, 0x0);
            uint num5 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num5 += 0x5C;
            MainForm.GeckoU.WriteUInt(num5, 0x0);
            uint num6 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num6 += 0x60;
            MainForm.GeckoU.WriteUInt(num6, 0x0);
            uint num7 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num7 += 0x64;
            MainForm.GeckoU.WriteUInt(num7, 0x0);
            uint num8 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num8 += 0x68;
            MainForm.GeckoU.WriteUInt(num8, 0x0);
            uint num9 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num9 += 0x6C;
            MainForm.GeckoU.WriteUInt(num9, 0x0);
            uint num10 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num10 += 0x70;
            MainForm.GeckoU.WriteUInt(num10, 0x0);
            uint num11 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num11 += 0x74;
            MainForm.GeckoU.WriteUInt(num11, 0x0);
            uint num12 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num12 += 0x78;
            MainForm.GeckoU.WriteUInt(num12, 0x0);
            uint num13 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num13 += 0x7C;
            MainForm.GeckoU.WriteUInt(num13, 0x0);
            uint num14 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num14 += 0x80;
            MainForm.GeckoU.WriteUInt(num14, 0x0);
            this.gck();
            uint num15 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            this.String_poke(checked(num15 + 0x4E), " " + ban.smethod_4(nnid_imput));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            uint num = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num += 0x4C;
            MainForm.GeckoU.WriteUInt(num, 0x0);
            uint num2 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num2 += 0x50;
            MainForm.GeckoU.WriteUInt(num2, 0x0);
            uint num3 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num3 += 0x54;
            MainForm.GeckoU.WriteUInt(num3, 0x0);
            uint num4 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num4 += 0x58;
            MainForm.GeckoU.WriteUInt(num4, 0x0);
            uint num5 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num5 += 0x5C;
            MainForm.GeckoU.WriteUInt(num5, 0x0);
            uint num6 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num6 += 0x60;
            MainForm.GeckoU.WriteUInt(num6, 0x0);
            uint num7 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num7 += 0x64;
            MainForm.GeckoU.WriteUInt(num7, 0x0);
            uint num8 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num8 += 0x68;
            MainForm.GeckoU.WriteUInt(num8, 0x0);
            uint num9 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num9 += 0x6C;
            MainForm.GeckoU.WriteUInt(num9, 0x0);
            uint num10 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num10 += 0x70;
            MainForm.GeckoU.WriteUInt(num10, 0x0);
            uint num11 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num11 += 0x74;
            MainForm.GeckoU.WriteUInt(num11, 0x0);
            uint num12 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num12 += 0x78;
            MainForm.GeckoU.WriteUInt(num12, 0x0);
            uint num13 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num13 += 0x7C;
            MainForm.GeckoU.WriteUInt(num13, 0x0);
            uint num14 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            num14 += 0x80;
            MainForm.GeckoU.WriteUInt(num14, 0x0);
            this.gck();
            uint num15 = MainForm.GeckoU.PeekUInt(0x10AD1C58);
            this.String_poke(checked(num15 + 0x4E), "");
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
