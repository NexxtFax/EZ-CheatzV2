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
using MetroFramework.Properties;
using Minecraft_Wii_U_Mod_Tool.theme;

namespace Minecraft_Wii_U_Mod_Tool.forms
{
    public partial class Messaging : MetroForm
    {
        public Messaging(MainForm INJP)
        {
            InitializeComponent();
            if (INJP != null)
            {
                StyleManager.Style = this.Style = INJP.StyleManager.Style;
                StyleManager.Theme = this.Theme = INJP.StyleManager.Theme;
            }
        }

        private void Messaging_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainForm.GeckoU.WriteUInt(0x31000214, 0x1);
            MainForm.GeckoU.WriteUInt(0x31000218, 0x0);
            MainForm.GeckoU.WriteUInt(0x3100021C, 0x0);
            MainForm.GeckoU.clearString2(0x1061F270, 0x1061F68C);
            MainForm.GeckoU.WriteStringUTF16(0x1061F270, EnterMessage.Text);
            this.executeGiveItem();
        }

        private void executeGiveItem()
        {
            string input = "9421ff887c0802a63ce031003d0031009001007c3d4031003d20310093c10070610802143bc00000614a02186129021c60e70210934100609381006893a1006c93e100743fe0109c80e7000063ffd8e48349000083a80000838a000093c1005493610064813f000093c1005081290034812900f8812900c87f69382e480000110067006900760065000000007c8802a63d20020b38610008612908d47d2903a64e8004213d20024661290e54814100107d2903a681210014800100187f47d378808100087f86e3788061000c7fa5eb788161001c3901002891410030912100348141002081210024900100389361004893c1004c90810028388100489061002c386100509161003c91410040912100444e800421811f0000814100503d200304810800346129a5d88161005438810058806808787d2903a6914100589161005c4e8004218001007c83410060836100647c0803a68381006883a1006c83c1007083e10074382100784e80002060000000";
            MainForm.GeckoU.makeAssembly(0x039156C0, input);
            MainForm.GeckoU.CallFunction(0x039156C0, new uint[1]);
        }
    }
}
