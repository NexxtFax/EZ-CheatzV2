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
    public partial class credits : MetroForm
    {
        public credits(MainForm INJ)
        {
            InitializeComponent();
            if (INJ != null)
            {
                StyleManager.Style = this.Style = INJ.StyleManager.Style;
                StyleManager.Theme = this.Theme = INJ.StyleManager.Theme;
            }
        }

        private void credits_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
