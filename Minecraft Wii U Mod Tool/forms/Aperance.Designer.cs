
namespace Minecraft_Wii_U_Mod_Tool.forms
{
    partial class Aperance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.capeBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SkinList = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GetSkinIDBtn = new MetroFramework.Controls.MetroButton();
            this.SaveSkin = new MetroFramework.Controls.MetroButton();
            this.SkinNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SkinIdBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinIdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // capeBox
            // 
            this.capeBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.capeBox.FormattingEnabled = true;
            this.capeBox.ItemHeight = 19;
            this.capeBox.Items.AddRange(new object[] {
            "Minecon 2011",
            "Minecon 2012",
            "Minecon 2013",
            "Minecon 2015",
            "Minecon 2016",
            "Jeb Ponytail",
            "The Grim Reaper",
            "Devil",
            "Dracula",
            "Evil Wizard",
            "Bride of Frankenstein",
            "Wicked Witch",
            "Senator Padmé Amidala",
            "Senator Palpatine",
            "Count Dooku",
            "General Grievous",
            "Erinyes",
            "Dryad",
            "Spartoi",
            "Hephaestus",
            "Prometheus",
            "Heracles",
            "Perseus",
            "Zeus",
            "Hades",
            "Poseidon",
            "Apollo",
            "Artemis",
            "Athena",
            "Trojan Warrior",
            "Atlanta",
            "Cadmus",
            "Drone"});
            this.capeBox.Location = new System.Drawing.Point(72, 68);
            this.capeBox.Name = "capeBox";
            this.capeBox.Size = new System.Drawing.Size(410, 25);
            this.capeBox.TabIndex = 0;
            this.capeBox.UseSelectable = true;
            this.capeBox.SelectedIndexChanged += new System.EventHandler(this.capeBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Cape:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select Saved Skin:";
            // 
            // SkinList
            // 
            this.SkinList.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.SkinList.FormattingEnabled = true;
            this.SkinList.ItemHeight = 19;
            this.SkinList.Location = new System.Drawing.Point(138, 105);
            this.SkinList.Name = "SkinList";
            this.SkinList.Size = new System.Drawing.Size(410, 25);
            this.SkinList.TabIndex = 2;
            this.SkinList.UseSelectable = true;
            this.SkinList.SelectedIndexChanged += new System.EventHandler(this.SkinList_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Your current skin ID:";
            // 
            // GetSkinIDBtn
            // 
            this.GetSkinIDBtn.Location = new System.Drawing.Point(436, 135);
            this.GetSkinIDBtn.Name = "GetSkinIDBtn";
            this.GetSkinIDBtn.Size = new System.Drawing.Size(112, 23);
            this.GetSkinIDBtn.TabIndex = 6;
            this.GetSkinIDBtn.Text = "Get Skin ID";
            this.GetSkinIDBtn.UseSelectable = true;
            this.GetSkinIDBtn.UseStyleColors = true;
            this.GetSkinIDBtn.Click += new System.EventHandler(this.GetSkinIDBtn_Click);
            // 
            // SaveSkin
            // 
            this.SaveSkin.Location = new System.Drawing.Point(436, 166);
            this.SaveSkin.Name = "SaveSkin";
            this.SaveSkin.Size = new System.Drawing.Size(112, 23);
            this.SaveSkin.TabIndex = 8;
            this.SaveSkin.Text = "Save Skin";
            this.SaveSkin.UseSelectable = true;
            this.SaveSkin.UseStyleColors = true;
            this.SaveSkin.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SkinNameBox
            // 
            // 
            // 
            // 
            this.SkinNameBox.CustomButton.Image = null;
            this.SkinNameBox.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.SkinNameBox.CustomButton.Name = "";
            this.SkinNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SkinNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SkinNameBox.CustomButton.TabIndex = 1;
            this.SkinNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SkinNameBox.CustomButton.UseSelectable = true;
            this.SkinNameBox.CustomButton.Visible = false;
            this.SkinNameBox.Lines = new string[0];
            this.SkinNameBox.Location = new System.Drawing.Point(150, 166);
            this.SkinNameBox.MaxLength = 32767;
            this.SkinNameBox.Name = "SkinNameBox";
            this.SkinNameBox.PasswordChar = '\0';
            this.SkinNameBox.PromptText = "Enter any Name for the Skin you want";
            this.SkinNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SkinNameBox.SelectedText = "";
            this.SkinNameBox.SelectionLength = 0;
            this.SkinNameBox.SelectionStart = 0;
            this.SkinNameBox.ShortcutsEnabled = true;
            this.SkinNameBox.Size = new System.Drawing.Size(280, 23);
            this.SkinNameBox.TabIndex = 7;
            this.SkinNameBox.UseSelectable = true;
            this.SkinNameBox.WaterMark = "Enter any Name for the Skin you want";
            this.SkinNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SkinNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Enter a Skin name:";
            // 
            // SkinIdBox
            // 
            this.SkinIdBox.Location = new System.Drawing.Point(154, 137);
            this.SkinIdBox.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.SkinIdBox.Name = "SkinIdBox";
            this.SkinIdBox.Size = new System.Drawing.Size(276, 20);
            this.SkinIdBox.TabIndex = 10;
            // 
            // Aperance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 204);
            this.Controls.Add(this.SkinIdBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.SaveSkin);
            this.Controls.Add(this.SkinNameBox);
            this.Controls.Add(this.GetSkinIDBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SkinList);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.capeBox);
            this.MaximizeBox = false;
            this.Name = "Aperance";
            this.Resizable = false;
            this.Text = "Appearance Changer";
            this.Load += new System.EventHandler(this.Aperance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinIdBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton SaveSkin;
        private MetroFramework.Controls.MetroTextBox SkinNameBox;
        private MetroFramework.Controls.MetroButton GetSkinIDBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox SkinList;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox capeBox;
        private System.Windows.Forms.NumericUpDown SkinIdBox;
    }
}