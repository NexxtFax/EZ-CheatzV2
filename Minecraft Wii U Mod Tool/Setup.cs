using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using Minecraft_Wii_U_Mod_Tool.theme;

namespace Minecraft_Wii_U_Mod_Tool
{
    class Setup
    {
        public static MainForm Injector = new MainForm();

        public Setup(MainForm window)
        {
            Injector = window;
        }

        public static void SetupInjector()
        {
            try
            {
                // https://stackoverflow.com/a/2904963/3764804
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Failed to setup", Exceptions.ExceptionId.FailedtoSetup);
                Environment.Exit(0);
            }
        }

        public static void CheckLicenseActivation()
        {
        }

        public static void SetupUserPrefs()
        {
            Injector.Text = "EZ-Cheatz V2";
            try
            {
                try
                {
                    Injector.Theme = Injector.StyleManager.Theme = (MetroThemeStyle)Enum.Parse(typeof(MetroThemeStyle),
                        Config.ReadKey("StyleTheme", "Theme"));
                    Injector.Style = Injector.StyleManager.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle),
                        Config.ReadKey("ColorTheme", "Theme"));

                    Injector.colorBx.Text  = Config.ReadKey("ColorTheme", "Theme");
                    Injector.themeBx.Text = Config.ReadKey("StyleTheme", "Theme");
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            catch (Exception error)
            {
                Exceptions.LogError(error, "Exception in SetupUserPrefs() \n" + error,
                    Exceptions.ExceptionId.FailedtoSetup);
                Environment.Exit(0);
            }
        }
    }
}
