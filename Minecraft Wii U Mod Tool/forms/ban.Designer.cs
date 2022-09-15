
namespace Minecraft_Wii_U_Mod_Tool
{
    partial class ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ban));
            this.ban_methode = new System.Windows.Forms.NumericUpDown();
            this.metroButton23 = new MetroFramework.Controls.MetroButton();
            this.nnid_imput = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ban_methode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ban_methode
            // 
            this.ban_methode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ban_methode.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ban_methode.ForeColor = System.Drawing.Color.Black;
            this.ban_methode.Location = new System.Drawing.Point(6, 19);
            this.ban_methode.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ban_methode.Name = "ban_methode";
            this.ban_methode.Size = new System.Drawing.Size(272, 22);
            this.ban_methode.TabIndex = 2;
            this.ban_methode.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // metroButton23
            // 
            this.metroButton23.Location = new System.Drawing.Point(6, 50);
            this.metroButton23.Name = "metroButton23";
            this.metroButton23.Size = new System.Drawing.Size(272, 23);
            this.metroButton23.TabIndex = 148;
            this.metroButton23.Text = "Reset ID";
            this.metroButton23.UseSelectable = true;
            this.metroButton23.UseStyleColors = true;
            this.metroButton23.Click += new System.EventHandler(this.metroButton23_Click);
            // 
            // nnid_imput
            // 
            // 
            // 
            // 
            this.nnid_imput.CustomButton.Image = null;
            this.nnid_imput.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.nnid_imput.CustomButton.Name = "";
            this.nnid_imput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nnid_imput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nnid_imput.CustomButton.TabIndex = 1;
            this.nnid_imput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nnid_imput.CustomButton.UseSelectable = true;
            this.nnid_imput.CustomButton.Visible = false;
            this.nnid_imput.Lines = new string[0];
            this.nnid_imput.Location = new System.Drawing.Point(6, 19);
            this.nnid_imput.MaxLength = 5334;
            this.nnid_imput.Name = "nnid_imput";
            this.nnid_imput.PasswordChar = '\0';
            this.nnid_imput.PromptText = "Enter a Nintendo Network ID";
            this.nnid_imput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nnid_imput.SelectedText = "";
            this.nnid_imput.SelectionLength = 0;
            this.nnid_imput.SelectionStart = 0;
            this.nnid_imput.ShortcutsEnabled = true;
            this.nnid_imput.Size = new System.Drawing.Size(272, 23);
            this.nnid_imput.TabIndex = 155;
            this.nnid_imput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nnid_imput.UseSelectable = true;
            this.nnid_imput.WaterMark = "Enter a Nintendo Network ID";
            this.nnid_imput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nnid_imput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(6, 50);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(133, 24);
            this.metroButton2.TabIndex = 154;
            this.metroButton2.Text = "Change Name";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(5, -2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 15);
            this.metroLabel1.TabIndex = 160;
            this.metroLabel1.Text = "User-ID Changer";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(6, -2);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 15);
            this.metroLabel2.TabIndex = 161;
            this.metroLabel2.Text = "Nintendo Network ID";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(145, 50);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(133, 24);
            this.metroButton4.TabIndex = 157;
            this.metroButton4.Text = "Set Blank Name";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nnid_imput);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 93);
            this.groupBox1.TabIndex = 162;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nintendo Network ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton23);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.ban_methode);
            this.groupBox2.Location = new System.Drawing.Point(315, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 93);
            this.groupBox2.TabIndex = 163;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User ID Changer";
            // 
            // ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ban";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Account Spoofer";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ban_methode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown ban_methode;
        private MetroFramework.Controls.MetroButton metroButton23;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox nnid_imput;
        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}