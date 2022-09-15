
namespace Minecraft_Wii_U_Mod_Tool.forms
{
    partial class Messaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messaging));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.EnterMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // EnterMessage
            // 
            // 
            // 
            // 
            this.EnterMessage.CustomButton.Image = null;
            this.EnterMessage.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.EnterMessage.CustomButton.Name = "";
            this.EnterMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EnterMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnterMessage.CustomButton.TabIndex = 1;
            this.EnterMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EnterMessage.CustomButton.UseSelectable = true;
            this.EnterMessage.CustomButton.Visible = false;
            this.EnterMessage.Lines = new string[0];
            this.EnterMessage.Location = new System.Drawing.Point(23, 63);
            this.EnterMessage.MaxLength = 32767;
            this.EnterMessage.Name = "EnterMessage";
            this.EnterMessage.PasswordChar = '\0';
            this.EnterMessage.PromptText = "Enter Message";
            this.EnterMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterMessage.SelectedText = "";
            this.EnterMessage.SelectionLength = 0;
            this.EnterMessage.SelectionStart = 0;
            this.EnterMessage.ShortcutsEnabled = true;
            this.EnterMessage.Size = new System.Drawing.Size(372, 23);
            this.EnterMessage.TabIndex = 0;
            this.EnterMessage.UseSelectable = true;
            this.EnterMessage.WaterMark = "Enter Message";
            this.EnterMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EnterMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 92);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 25);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Send Message";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(146, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(223, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "(This message will show to everyone)";
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 135);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.EnterMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Messaging";
            this.Resizable = false;
            this.Text = "Messaging";
            this.Load += new System.EventHandler(this.Messaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroTextBox EnterMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}