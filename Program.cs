using System;
using System.Windows.Forms;
using System.IO;
using CQE.Classes;

namespace CQE
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);




            // Carica il form iniziale
            IntroForm introForm = new IntroForm();
            introForm.TopMost = true;
            introForm.ShowDialog();

            //Configs.LoadConfigs();
            if (!Configs.IsInvalid)
            {
                try
                {
                    //Language.InitDictionary(Configs.CurrentLanguage);
                    Application.Run(new CQEForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Application Error.\nERROR:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(Configs.ConfigFile);
                }
            }
            Environment.Exit(0);
        }
    }
}

