using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Properties;
using System.Net;
using Minecraft_Wii_U_Mod_Tool.theme;

namespace Minecraft_Wii_U_Mod_Tool
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.users = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Temp/";
            this.appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Temp/";
        }
        public static int x;
        public static int y;
        public static Point newpoint = new Point();
        private string users;
        private string appData;

        private void Login_Load(object sender, EventArgs e)
        {
            conn();
        }

        private void conn()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://pastebin.com/raw/H9QnknvK", appData + "667382_Temp");
                }
                this.richTextBox1.Text = File.ReadAllText(appData + "667382_Temp");
            }
            catch
            {
                MetroMessageBox.Show(this, "Unable to load Changelog,\nplease try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "Unable to load changelog";
            }
        }

        private void check()
        {
            if (File.Exists(users + "data"))
            {
                this.Hide();
                MainForm _mm = new MainForm();
                _mm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Login first to use the feature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - base.Location.X;
            y = Control.MousePosition.Y - base.Location.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = Control.MousePosition;
                newpoint.X -= x;
                newpoint.Y -= y;
                base.Location = newpoint;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mm = new MainForm();
            mm.Show();
        }

        private void access_allow()
        {
            MetroMessageBox.Show(this, "Successfuly logged in!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            MainForm mm = new MainForm();
            mm.Show();
        }

        private void access_denied()
        {
            MetroMessageBox.Show(this, "Your account has been blocked.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            string lo = metroTextBox1.Text;
            switch (lo)
            {
                case "":
                    MessageBox.Show("An error has occurred, Enter a User Key", "EZ Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case "cBVPyAj0Z9":
                    StreamWriter streamWriter = new StreamWriter(users + "user.txt");
                    streamWriter.Write("TestUser123");
                    streamWriter.Close();
                    access_denied();
                    return;

                case "w1T80Zxvor":
                    StreamWriter _streamWriter = new StreamWriter(users + "user.txt");
                    _streamWriter.Write("Joe");
                    _streamWriter.Close();
                    access_allow();
                    File.Create(users + "data");
                    return;

                case "Pgp1huzNsE":
                    StreamWriter ___streamWriter = new StreamWriter(users + "user.txt");
                    ___streamWriter.Write("Darkgespielt");
                    ___streamWriter.Close();
                    access_allow();
                    File.Create(users + "data");
                    return;
            }
            MessageBox.Show("Wrong License!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            check();
        }
    }
}
