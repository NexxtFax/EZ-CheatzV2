using System.Collections.Generic;

namespace Minecraft_Wii_U_Mod_Tool.theme
{
    public class Config
    {
        private static INI INIConfig = new INI();

        public static void WriteKey(string key, string value, string section)
        {
            INIConfig.Write(key, value, section);
        }

        public static void DeleteKey(string key, string section)
        {
            INIConfig.DeleteKey(key, section);
        }

        public static string ReadKey(string key, string section)
        {
            return INIConfig.Read(key, section);
        }

        public static bool KeyEqualsTo(string key, string value, string section)
        {
            if (INIConfig.Read(key, section) == value)
                return true;
            else
                return false;
        }

        public static bool KeyExists(string key, string section)
        {
            return INIConfig.KeyExists(key, section);
        }

        public static List<string> Keys(string section)
        {
            return INIConfig.GetKeys(section);
        }
    }
}
