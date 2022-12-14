using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Tool.theme
{

    //By SlothWiiPlaza / Kashiiera
    class Exceptions
        {
            public static INI INI = new INI(Application.StartupPath + "/logs/");

            public enum ExceptionId
            {
                FailedUpdate = 1,
                ConnectionProblem = 2,
                FailedtoLog = 3,
                FailedtoSetup = 4,
                FailedtoClose = 5,
                FailedtoGetGameLanguage = 6,
                FailedtoReadINI = 7,
                FailedtoWriteINI = 8,
                UnknownFail = 9,
                NullReference = 10,
                TimedOut = 11,
                DatabaseError = 12,
            }

            public static void LogError(Exception ErrorLog, string Information, ExceptionId ErrorCode)
            {
                try
                {
                    string CleanDate = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");

                    if (!Directory.Exists(Application.StartupPath + "/logs/"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + "/logs/");
                    }

                    INI = new INI(Application.StartupPath + "/logs/" + CleanDate + "-" + ErrorLog.Source + ".ini");
                    INI.Write("ExceptionMessage", ErrorLog.Message);
                    INI.Write("ExceptionInformation", Information);
                    INI.Write("ExceptionID", ErrorCode.ToString());
                    INI.Write("ExceptionString", ErrorLog.ToString());
                    INI.Write("Timestamp", CleanDate);

                    Process.Start(Application.StartupPath + "/logs/" + CleanDate + "-" + ErrorLog.Source + ".ini");
                    MessageBox.Show("An error has occured, a log file has been written to /logs/" + CleanDate + "-" + ErrorLog.Source + ".ini, the file has been opened.\nPlease send the log file to [DE]Leo for help.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
