using System.IO;
using System.Windows.Forms;

namespace CQE.Classes
{
    class Configs
    {
        public static string ConfigFile = "config.ini";

        public static string LanguageTranslater = "Vanth";
        public static string CurrentLanguage = "EN";
        public static bool AutoCheckForUpdates;
        public static bool IsInvalid;

        public static void LoadConfigs()
        {
            if (File.Exists(ConfigFile))
            {
                string[] configs = File.ReadAllLines(ConfigFile);

                foreach (string config in configs)
                {
                    string[] splitted = config.Split("=".ToCharArray());

                    switch (splitted[0])
                    {
                        case "Lang":
                            CurrentLanguage = splitted[1];
                            break;
                        case "AutoUpdate":
                            AutoCheckForUpdates = splitted[1] == "1";
                            break;
                        default:
                            IsInvalid = true;
                            File.Delete(ConfigFile);
                            MessageBox.Show("Invalid Config File. Please restart this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            else
            {
                InitialSetup();
            }
        }

        public static void SaveConfigs()
        {
            if (File.Exists(ConfigFile))
                File.Delete(ConfigFile);

            File.WriteAllText(ConfigFile, "Lang=" + CurrentLanguage + "\r\n");
            File.AppendAllText(ConfigFile, AutoCheckForUpdates ? "AutoUpdate=1\r\n" : "AutoUpdate=0\r\n");
        }

        public static void InitialSetup()
        {
            if (File.Exists(ConfigFile))
                File.Delete(ConfigFile);

            ConfigWizard cw = new ConfigWizard();
            cw.ShowDialog();
            cw.Dispose();
            LoadConfigs();
        }
    }
}
