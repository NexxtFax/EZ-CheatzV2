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
using MetroFramework.Fonts;
using System.Globalization;
using Minecraft_Wii_U_Mod_Tool.forms;
using Minecraft_Wii_U_Mod_Tool.theme;
using System.Text.RegularExpressions;

namespace Minecraft_Wii_U_Mod_Tool.forms
{
    public partial class Aperance : MetroForm
    {

        private readonly uint[] _capes =
        {
            0x80001518, 0x80001519, 0x8000151A, 0x8000151B,
            0x8000151C, 0x80000BB8, 0x80000C81, 0x80000C82,
            0x80000C83, 0x80000C84, 0x80000C85, 0x80000C92,
            0x80000519, 0x8000051C, 0x8000051D, 0x8000051E,
            0x80000B1A, 0x80000B1B, 0x80000B17, 0x80000B1E,
            0x80000B1F, 0x80000B07, 0x80000B0B, 0x80000B0D,
            0x80000B0E, 0x80000B10, 0x80000B18, 0x80000B13,
            0x80000B14, 0x80000B0B, 0x80000B1C, 0x80000B1D,
            0x8000065A
        };

        public Aperance(MainForm MainFormForSkin)
        {
            InitializeComponent();
            if (MainFormForSkin != null)
            {
                StyleManager.Style = this.Style = MainFormForSkin.StyleManager.Style;
                StyleManager.Theme = this.Theme = MainFormForSkin.StyleManager.Theme;
            }
        }

        private void Aperance_Load(object sender, EventArgs e)
        {
            foreach (string skin in Config.Keys("Skins"))
            {
                SkinList.Items.Add(Config.ReadKey(skin, "Skins") + " | " + skin);
            }
        }

        private void capeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var capeId = _capes[capeBox.SelectedIndex];
            MainForm.GeckoU.CallFunction(0x02F6FC2C, 0, capeId, 0);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var skinId = Convert.ToString(SkinIdBox.Value, CultureInfo.InvariantCulture);

            Config.WriteKey(skinId, SkinNameBox.Text, "Skins");

            SkinList.Items.Add(SkinNameBox.Text + " | " + skinId);
        }

        private void GetSkinIDBtn_Click(object sender, EventArgs e)
        {
            SkinIdBox.Value = MainForm.GeckoU.CallFunction(0x02F70178, 0);
        }

        private void SkinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var skinIdString = SkinList.Text;
            skinIdString = skinIdString.Substring(skinIdString.IndexOf('|') + 1);
            skinIdString = Regex.Replace(skinIdString, @"\s+", "");

            MainForm.GeckoU.CallFunction(0x02F70028, 0, Convert.ToUInt32(skinIdString), 0);
        }
    }
}
