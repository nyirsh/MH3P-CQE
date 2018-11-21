using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CQE.Classes;

namespace CQE
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            this.Region = BitmapToRegion.GetRegionFast(Properties.Resources.LogoMap, Color.FromArgb(0, 255, 6), 254);
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 2500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Configs.LoadConfigs();

            if (!Configs.IsInvalid)
            {
                try
                {
                    Language.InitDictionary(Configs.CurrentLanguage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Language Pack. Please Restart this application.\nERROR:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(Configs.ConfigFile);
                }
            }
            else
            {
                File.Delete(Configs.ConfigFile);
            }


            
            if (Configs.AutoCheckForUpdates)
            {
                switch (Updater.CheckForUpdate())
                {
                    case 1:
                        WantToUpdate();
                        break;
                    case -1:
                        MessageBox.Show(Language.Dictionary["updater"]["commerror"], Language.Dictionary["errors"]["title"]);
                        break;
                    case 0:
                        break;
                }
            }
            

            this.Close();
        }

        private void WantToUpdate()
        {
            
            if (MessageBox.Show(Language.Dictionary["updater"]["wantupdate"], Language.Dictionary["updater"]["available"], MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Visible = false;
                Updater updt = new Updater();
                updt.ShowDialog();
            }
            
        }
    }
}
