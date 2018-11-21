using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using CQE.Classes;
using CQE.Datas;
using CQE.Structures;

namespace CQE
{
    public partial class CQEForm : Form
    {
        private StcArms[,] ArmorData;
        private stcWeapon[,] WeaponData;
        private StcBeads[] Beads;
        private StcResources[,] ExerciseBag;
        private StcExerciseArmsSet[,] HuntersArmsSet;
        private StcMonster[] randomBoss; 
        private StcSkillStart[] SkillSysStart;
        private StcMonster[,] strBoss;
        private StcMonster[, ,] strDogfish;       
        private StcResources[,] strMaterialReward = new StcResources[6, 20];
        private StcResources[] strRation = new StcResources[40];
        private StcResources[, ,] strResources;
        private StcResourceGathering[,] strResrPoint;
        private StcSymbolSet[] SymbolSet;

        private string TaskFileName;
        private string EditToolState = "null";
        private string WeaponRange = "";

        private OpenFileDialog openFileDialog1;
        private static Form ShowMapForm;

        private TextBox[] TaskInfText;
        private TextBox[,] textBeadName;

        private int[] resourcesPoint;
        private string[] ResouresNames = new string[DataClass.ResouresNameSimple.Length];
        private string[] strMapPoint;
        private string[] strMonsterNames = new string[DataClass.strMonsterNamesSimple.Length];
        private int textBoxBeadIndex = 0xff;

        public CQEForm()
        {
            InitializeComponent();

            if (Configs.AutoCheckForUpdates)
                controllaAutomaticamenteUpdatesToolStripMenuItem.Image = Properties.Resources.Confirm;

            this.Text += Params.CurrentVersion;

            ApplyLanguage();

            RefreshLanguageList();

            TaskInfText = new TextBox[] { taskTitleText, taskWinCondText, taskLoseText, taskDescriptionText, taskMostriText, taskClientText };
            textBeadName = new TextBox[,] { { textBoxBead01, textBoxBead02, textBoxBead03 }, { textBoxBead11, textBoxBead12, textBoxBead13 }, { textBoxBead21, textBoxBead22, textBoxBead23 }, { textBoxBead31, textBoxBead32, textBoxBead33 }, { textBoxBead41, textBoxBead42, textBoxBead43 }, { textBoxBead51, textBoxBead52, textBoxBead53 }, { textBoxBead61, textBoxBead62, textBoxBead63 } };
            DataClass.ResouresNameSimple.CopyTo(ResouresNames, 0);
            DataClass.strMonsterNamesSimple.CopyTo(strMonsterNames, 0);
        }

        #region UI

        private void ApplyLanguageEx(Control mainControl)
        {
            foreach (Control cc in mainControl.Controls)
            {
                if (cc.AccessibleDescription != null)
                {
                    string[] locatestring = cc.AccessibleDescription.Split("|".ToCharArray());
                    cc.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
                    if (((string)cc.Tag) == "true")
                    {
                        cc.Text += ":";
                    }
                    if (Language.Dictionary[locatestring[0]].ContainsKey("faq-" + locatestring[1]))
                    {
                        ToolTip tt = new ToolTip();
                        tt.ReshowDelay = 0;
                        tt.SetToolTip(cc, Language.Dictionary[locatestring[0]]["faq-" + locatestring[1]]);
                    }
                }
                if (cc.Controls.Count > 0)
                    ApplyLanguageEx(cc);
            }
        }

        private void ApplyLanguage()
        {
            ApplyLanguageEx(this);

            #region UI

            foreach (ToolStripMenuItem mi in menuStrip1.Items)
            {
                string[] locatestring = mi.AccessibleDescription.Split("|".ToCharArray());
                mi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
            }


            foreach (object mi in opzioniToolStripMenuItem.DropDownItems)
            {
                if (mi.GetType().Name != "ToolStripSeparator")
                {
                    ToolStripMenuItem tmi = (ToolStripMenuItem)mi;
                    string[] locatestring = tmi.AccessibleDescription.Split("|".ToCharArray());
                    tmi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
                }
            }


            foreach (object mi in FileToolStripMenuItem.DropDownItems)
            {
                if (mi.GetType().Name != "ToolStripSeparator")
                {
                    ToolStripMenuItem tmi = (ToolStripMenuItem)mi;
                    string[] locatestring = tmi.AccessibleDescription.Split("|".ToCharArray());
                    tmi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
                }
            }

            foreach (ToolStripMenuItem mi in NewTaskToolStripMenuItem.DropDownItems)
            {
                string[] locatestring = mi.AccessibleDescription.Split("|".ToCharArray());
                mi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
            }

            foreach (ToolStripMenuItem mi in LowRankToolStripMenuItem.DropDownItems)
            {
                string[] locatestring = mi.AccessibleDescription.Split("|".ToCharArray());
                mi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
            }

            foreach (ToolStripMenuItem mi in HighRankToolStripMenuItem.DropDownItems)
            {
                string[] locatestring = mi.AccessibleDescription.Split("|".ToCharArray());
                mi.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
            }

            #endregion

            #region Info Page

            MapTimeCmbBox.Items[0] = Language.Dictionary["game"]["day"];
            MapTimeCmbBox.Items[1] = Language.Dictionary["game"]["night"];

            TaskTypeCmbBox.Items[0] = Language.Dictionary["game"]["minionkill"];
            TaskTypeCmbBox.Items[1] = Language.Dictionary["game"]["gathquest"];
            TaskTypeCmbBox.Items[2] = Language.Dictionary["game"]["huntquest"];
            TaskTypeCmbBox.Items[3] = Language.Dictionary["game"]["epicquest"];
            TaskTypeCmbBox.Items[4] = Language.Dictionary["game"]["specialquest"];
            TaskTypeCmbBox.Items[5] = Language.Dictionary["game"]["slayingquest"];
            TaskTypeCmbBox.Items[6] = Language.Dictionary["other"]["unknown"];

            StarGradeCmbBox.Items[0] = Language.Dictionary["game"]["lvl1"];
            StarGradeCmbBox.Items[1] = Language.Dictionary["game"]["lvl2"];
            StarGradeCmbBox.Items[2] = Language.Dictionary["game"]["lvl3"];
            StarGradeCmbBox.Items[3] = Language.Dictionary["game"]["lvl4"];
            StarGradeCmbBox.Items[4] = Language.Dictionary["game"]["lvl5"];
            StarGradeCmbBox.Items[5] = Language.Dictionary["game"]["lvl6"];
            StarGradeCmbBox.Items[6] = Language.Dictionary["game"]["lvl7"];
            StarGradeCmbBox.Items[7] = Language.Dictionary["game"]["lvl8"];

            OpenLimitCmbBox1.Items[0] = Language.Dictionary["game"]["hr1"];
            OpenLimitCmbBox1.Items[1] = Language.Dictionary["game"]["hr2"];
            OpenLimitCmbBox1.Items[2] = Language.Dictionary["game"]["hr3"];
            OpenLimitCmbBox1.Items[3] = Language.Dictionary["game"]["hr4"];
            OpenLimitCmbBox1.Items[4] = Language.Dictionary["game"]["hr5"];
            OpenLimitCmbBox1.Items[5] = Language.Dictionary["game"]["hr6"];
            OpenLimitCmbBox1.Items[6] = Language.Dictionary["game"]["greatsword"];
            OpenLimitCmbBox1.Items[7] = Language.Dictionary["game"]["lance"];
            OpenLimitCmbBox1.Items[8] = Language.Dictionary["game"]["hammer"];
            OpenLimitCmbBox1.Items[9] = Language.Dictionary["game"]["swordshield"];
            OpenLimitCmbBox1.Items[10] = Language.Dictionary["game"]["bowgun"];
            OpenLimitCmbBox1.Items[11] = Language.Dictionary["game"]["dualsword"];
            OpenLimitCmbBox1.Items[12] = Language.Dictionary["game"]["longsword"];
            OpenLimitCmbBox1.Items[13] = Language.Dictionary["game"]["gunlance"];
            OpenLimitCmbBox1.Items[14] = Language.Dictionary["game"]["horn"];
            OpenLimitCmbBox1.Items[15] = Language.Dictionary["game"]["bow"];
            OpenLimitCmbBox1.Items[16] = Language.Dictionary["game"]["axe"];
            OpenLimitCmbBox1.Items[17] = Language.Dictionary["game"]["noarmor"];
            OpenLimitCmbBox1.Items[18] = Language.Dictionary["game"]["max1pg"];
            OpenLimitCmbBox1.Items[19] = Language.Dictionary["game"]["max2pg"];
            OpenLimitCmbBox1.Items[20] = Language.Dictionary["game"]["max3pg"];

            OpenLimitCmbBox2.Items[0] = Language.Dictionary["other"]["null"];
            OpenLimitCmbBox2.Items[1] = Language.Dictionary["game"]["greatsword"];
            OpenLimitCmbBox2.Items[2] = Language.Dictionary["game"]["lance"];
            OpenLimitCmbBox2.Items[3] = Language.Dictionary["game"]["hammer"];
            OpenLimitCmbBox2.Items[4] = Language.Dictionary["game"]["swordshield"];
            OpenLimitCmbBox2.Items[5] = Language.Dictionary["game"]["bowgun"];
            OpenLimitCmbBox2.Items[6] = Language.Dictionary["game"]["dualsword"];
            OpenLimitCmbBox2.Items[7] = Language.Dictionary["game"]["longsword"];
            OpenLimitCmbBox2.Items[8] = Language.Dictionary["game"]["gunlance"];
            OpenLimitCmbBox2.Items[9] = Language.Dictionary["game"]["horn"];
            OpenLimitCmbBox2.Items[10] = Language.Dictionary["game"]["bow"];
            OpenLimitCmbBox2.Items[11] = Language.Dictionary["game"]["axe"];
            OpenLimitCmbBox2.Items[12] = Language.Dictionary["game"]["noarmor"];
            OpenLimitCmbBox2.Items[13] = Language.Dictionary["game"]["max1pg"];
            OpenLimitCmbBox2.Items[14] = Language.Dictionary["game"]["max2pg"];
            OpenLimitCmbBox2.Items[15] = Language.Dictionary["game"]["max3pg"];

            LandingCmbBox.Items[0] = Language.Dictionary["zones"]["base"];
            LandingCmbBox.Items[1] = Language.Dictionary["other"]["random"];
            LandingCmbBox.Items[2] = Language.Dictionary["other"]["special"];

            SndVicyTermCmbBox.Items[0] = Language.Dictionary["other"]["first"];
            SndVicyTermCmbBox.Items[1] = Language.Dictionary["other"]["both"];
            SndVicyTermCmbBox.Items[2] = Language.Dictionary["other"]["oneofthem"];

            EnvironmentCmbBox1.Items[0] = Language.Dictionary["game"]["general"];
            EnvironmentCmbBox1.Items[1] = Language.Dictionary["game"]["training"];
            EnvironmentCmbBox1.Items[4] = Language.Dictionary["game"]["strenghten"];

            EnvironmentCmbBox2.Items[0] = Language.Dictionary["game"]["general"];
            EnvironmentCmbBox2.Items[1] = Language.Dictionary["game"]["recalled"];
            EnvironmentCmbBox2.Items[2] = Language.Dictionary["game"]["randomenter"];
            EnvironmentCmbBox2.Items[3] = Language.Dictionary["game"]["repelled"];

            cmBoxStopTime.Items[0] = Language.Dictionary["game"]["minutedefault"];
            cmBoxStopTime.Items[1] = Language.Dictionary["game"]["minuteforced"];
            cmBoxStopTime.Items[2] = Language.Dictionary["game"]["twentysecond"];

            #endregion
            
            #region Minori Page

            groupBox9.Text = Language.Dictionary["edit"]["title"];

            DfRoundTypeCmbBox.Items[0] = Language.Dictionary["edit"]["fixed"];
            DfRoundTypeCmbBox.Items[1] = Language.Dictionary["edit"]["random"];
            DfRoundTypeCmbBox.Items[2] = Language.Dictionary["edit"]["hided"];

            #endregion

            #region Rifornimenti Page

            groupBox6.Text = Language.Dictionary["edit"]["title"];

            #endregion

            #region Raccolta Page

            groupBox12.Text = Language.Dictionary["edit"]["title"];

            #endregion

            #region Premio Page

            ExpMaterialChooseCmbBox.Items[0] = Language.Dictionary["questreward"]["bonus"] + " 1";
            ExpMaterialChooseCmbBox.Items[1] = Language.Dictionary["questreward"]["bonus"] + " 2";
            ExpMaterialChooseCmbBox.Items[2] = Language.Dictionary["questreward"]["bonus"] + " 3";
            ExpMaterialChooseCmbBox.Items[3] = Language.Dictionary["questreward"]["bonus"] + " 4";
            ExpMaterialChooseCmbBox.Items[4] = Language.Dictionary["questreward"]["bonus"] + " 5";

            #endregion

            #region Sfida Page

            DataClass.strSkillSystem[0] = Language.Dictionary["skillsys"]["S0"];
            DataClass.strSkillSystem[1] = Language.Dictionary["skillsys"]["ST"];
            for (int i = 1; i < Language.Dictionary["skillsys"].Count - 1; i++)
            {
                DataClass.strSkillSystem[i + 1] = Language.Dictionary["skillsys"]["S" + i.ToString()];
            }

            for (int i = 1; i < DataClass.BeadNameSimple.Length; i++)
                DataClass.BeadNameSimple[i] = Language.Dictionary["decorations"][i.ToString()];

            for (int i = 0; i < cmbBoxSymbolType.Items.Count; i++)
                cmbBoxSymbolType.Items[i] = Language.Dictionary["charms"][i.ToString()];

            cmbBoxWeaponType.Items[0] = Language.Dictionary["game"]["greatsword"];
            cmbBoxWeaponType.Items[1] = Language.Dictionary["game"]["swordshield"];
            cmbBoxWeaponType.Items[2] = Language.Dictionary["game"]["hammer"];
            cmbBoxWeaponType.Items[3] = Language.Dictionary["game"]["lance"];
            cmbBoxWeaponType.Items[4] = Language.Dictionary["game"]["heavybow"];
            cmbBoxWeaponType.Items[5] = Language.Dictionary["game"]["lightbow"];
            cmbBoxWeaponType.Items[6] = Language.Dictionary["game"]["longsword"];
            cmbBoxWeaponType.Items[7] = Language.Dictionary["game"]["axe"];
            cmbBoxWeaponType.Items[8] = Language.Dictionary["game"]["gunlance"];
            cmbBoxWeaponType.Items[9] = Language.Dictionary["game"]["bow"];
            cmbBoxWeaponType.Items[10] = Language.Dictionary["game"]["dualsword"];
            cmbBoxWeaponType.Items[11] = Language.Dictionary["game"]["horn"];

            #endregion

        }

        private void ClearControl()
        {
            if (this.EditToolState == "Open")
            {
                for (int i = 0; i < 6; i++)
                {
                    this.TaskInfText[i].Text = "";
                }
                this.BossRandomSysRadioBtn1.Checked = true;
                this.AppearanceProbabilityNumUpD1.Value = 0M;
                this.AppearanceProbabilityNumUpD2.Value = 0M;
                this.AppearanceProbabilityNumUpD3.Value = 0M;
                this.RadioBtnNothing.Checked = true;
                this.DogfRdButton1.Checked = true;
                this.BPointCmbBox.Items.Clear();
                this.DfPointCmbBox.Items.Clear();
                this.BossListView.Items.Clear();
                this.DogfishListView.Items.Clear();
                this.BaseContrLstView1.Items.Clear();
                this.BaseContrLstView2.Items.Clear();
                this.ResourcesListView.Items.Clear();
                this.MaterialListView1.Items.Clear();
                this.MaterialListView2.Items.Clear();
                this.BPointCmbBox.Items.Clear();
                this.DfPointCmbBox.Items.Clear();
                this.RsrLandmassCmbBox.Items.Clear();
                this.RsrPointCmbBox.Items.Clear();
                this.MapLabel.Text = "-";
                this.MapTimeCmbBox.Visible = false;
                this.RoundRdButton1.Checked = true;
                this.RoundRdButton2.Checked = false;
                this.RoundRdButton3.Checked = false;
                this.RoundRdButton2.Enabled = false;
                this.RoundRdButton3.Enabled = false;
                this.listViewBag.Items.Clear();
                this.rdBtnArmor1.Checked = false;
                this.rdBtnArmor2.Checked = false;
                this.rdBtnArmor3.Checked = false;
                this.rdBtnArmor4.Checked = false;
                this.rdBtnArmor5.Checked = false;
                this.chkBoxStartExercise.Checked = false;
                this.chkBoxStartExercise.Enabled = false;
                this.cmbBoxWeaponName.Items.Clear();
                this.cmbBoxHead.Items.Clear();
                this.cmbBoxBody.Items.Clear();
                this.cmbBoxArm.Items.Clear();
                this.cmbBoxWaist.Items.Clear();
                this.cmbBoxLeg.Items.Clear();
                this.SymbolSet = null;
                this.HuntersArmsSet = null;
                this.ExerciseBag = null;
            }
            this.EditToolState = "Close";
        }

        #endregion

        #region Menu

        #region Menu File

        private void NewTaskAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string templatepath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            switch (item.Name)
            {
                case "IsolaToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Deserted Island_L.dat";
                    break;

                case "PianureToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Sandy Plains_L.dat";
                    break;

                case "ForestaToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Flooded Forest_L.dat";
                    break;

                case "TundraToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Tundra_L.dat";
                    break;

                case "VulcanoToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Volcano_L.dat";
                    break;

                case "CascateToolStripMenuItem1":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Mountain Stream_L.dat";
                    break;

                case "IsolaToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Deserted Island_H.dat";
                    break;

                case "PianureToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Sandy Plains_H.dat";
                    break;

                case "ForestaToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Flooded Forest_H.dat";
                    break;

                case "TundraToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Tundra_H.dat";
                    break;

                case "VulcanoToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Volcano_H.dat";
                    break;

                case "CascateToolStripMenuItem2":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Mountain Stream_H.dat";
                    break;

                case "CanyonLavaToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Lava Canyon.dat";
                    break;

                case "ArenaToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Land Arena.dat";
                    break;

                case "ArenaPiccolaToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Small Land Arena.dat";
                    break;

                case "TerraSacraToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Sacred Land.dat";
                    break;

                case "ZonaPolareToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Polar Zone.dat";
                    break;

                case "CimaMontagnaToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Mountain Summit.dat";
                    break;

                case "grandeDesertoToolStripMenuItem":
                    templatepath += "Template" + Path.DirectorySeparatorChar + "Great Desert.dat";
                    break;

                default:
                    return;
            }
            if (File.Exists(templatepath))
            {
                FileStream stream = new FileStream(templatepath, FileMode.Open);
                byte[] buffer = new byte[Convert.ToInt32(stream.Length)];
                stream.Read(buffer, 0, Convert.ToInt32(stream.Length));
                string header = "9400000076303035";
                for (int i = 0; i < 8; i++)
                {
                    if (buffer[i] != Convert.ToByte(header.Substring(i * 2, 2), 0x10))
                    {
                        MessageBox.Show(Language.Dictionary["errors"]["corrupted"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        stream.Close();
                        return;
                    }
                }
                stream.Close();
                TaskFileName = "";
                ResourceControlInit();
                ResouresDataInit();
                if (EditToolState == "Open")
                    ClearControl();
                DataLoadToControl(buffer);
                EditToolState = "Open";
                if ((ShowMapForm != null) && !ShowMapForm.IsDisposed)
                    ShowMapForm.Close();
            }
            else
                MessageBox.Show(Language.Dictionary["errors"]["notfound"] + "\n" + templatepath, Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void ChiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = Params.CqwTitle;
            ClearControl();
        }

        private void EsciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearControl();
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditToolState == "Open")
            {
                string destinationFileType = "";
                if ((TaskFileName != "") || File.Exists(TaskFileName))
                {
                    destinationFileType = TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower();
                    if (destinationFileType != "mib" && destinationFileType != "mis" && destinationFileType != "mem" && destinationFileType != "cqs")
                        destinationFileType = "pat";

                    if (SaveTaskFile(destinationFileType, TaskFileName) <= 0)
                        MessageBox.Show(Language.Dictionary["errors"]["savefail"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    SaveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditToolState == "Open")
            {
                string destinationFileType = "";
                saveFileDialog1.Filter = Language.Dictionary["messages"]["fc"] + " (*.pat)|*.pat|" + Language.Dictionary["messages"]["cm"] + " (*.mem)|*.mem|" + Language.Dictionary["messages"]["dat"] + " (*.dat)|*.dat|" + Language.Dictionary["messages"]["mib"] + " (*.mib)|*.mib|" + Language.Dictionary["messages"]["mis"] + " (*.mis)|*.mis|" + Language.Dictionary["messages"]["cqs"] + " (*.cqs)|*.cqs";
                saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Patch" + Path.DirectorySeparatorChar;
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                TaskFileName = saveFileDialog1.FileName;
                if (TaskFileName != "")
                {
                    if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "pat")
                    {
                        destinationFileType = "pat";
                        Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    }
                    else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "mem")
                    {
                        destinationFileType = "mem";
                        if (((Path.GetFileName(TaskFileName).Length < 9) || (Path.GetFileName(TaskFileName).Substring(0, 9) != "0xE7B440_")) && (MessageBox.Show(Language.Dictionary["messages"]["memquestion"].Replace("\\\"", "\""), "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes))
                        {
                            string path = Path.GetDirectoryName(TaskFileName) + Path.DirectorySeparatorChar + "0xE7B440_" + Path.GetFileName(TaskFileName);
                            if (File.Exists(path))
                            {
                                if (MessageBox.Show(Language.Dictionary["messages"]["overwrite"] + "\nFILE: " + path, "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
                                    return;
                                TaskFileName = path;
                            }
                            else
                                TaskFileName = path;
                        }
                        Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    }
                    else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "dat")
                    {
                        destinationFileType = "dat";
                        Text = Params.CqwTitle;
                    }
                    else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "mib")
                    {
                        destinationFileType = "mib";
                        Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    }
                    else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "mis")
                    {
                        destinationFileType = "mis";
                        Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    }
                    else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "cqs")
                    {
                        destinationFileType = "cqs";
                        Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    }
                    else
                        MessageBox.Show(Language.Dictionary["errors"]["namefail"]);
                    if (!File.Exists(TaskFileName))
                        new FileStream(TaskFileName, FileMode.CreateNew).Close();
                    int num = 0;
                    num = SaveTaskFile(destinationFileType, TaskFileName);
                    if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "dat")
                        TaskFileName = "";
                    if (num <= 0)
                    {
                        MessageBox.Show(Language.Dictionary["errors"]["savefail"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                        try
                        {
                            if (File.Exists(TaskFileName))
                                File.Delete(TaskFileName);
                        }
                        catch { }
                    }
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Language.Dictionary["messages"]["supportedfile"] + " (*.pat,*.mem,*.mis,*.mib,*.dat,*.txt,*.cqs)|*.pat;*.mem;*.mis;*.mib;*.dat;*.txt;*.cqs";
            if (EditToolState == "null")
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"patch\";
            else
                openFileDialog1.InitialDirectory = "";

            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.ShowDialog();
            TaskFileName = openFileDialog1.FileName;
            if (TaskFileName != "")
            {
                byte[] buffer;
                FileStream stream = new FileStream(TaskFileName, FileMode.Open);
                if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "pat")
                {
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    buffer = new byte[Convert.ToInt32((long)(stream.Length - 4))];
                    stream.Seek(4, SeekOrigin.Begin);
                    stream.Read(buffer, 0, Convert.ToInt32((long)(stream.Length - 4)));
                }
                else if ((TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "mem"))
                {
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    buffer = new byte[Convert.ToInt32(stream.Length)];
                    stream.Read(buffer, 0, Convert.ToInt32(stream.Length));
                }

                else if (TaskFileName.Substring(TaskFileName.Length - 3, 3) == "cqs")
                {
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    byte[] cqslenght = new byte[4];
                    stream.Read(cqslenght, 0, 4);
                    int realenght = BitConverter.ToInt32(cqslenght, 0);
                    byte[] shabuffer = new byte[Convert.ToInt32(stream.Length) - realenght];
                    stream.Seek(realenght, SeekOrigin.Begin);
                    stream.Read(shabuffer, 0, Convert.ToInt32(stream.Length) - realenght);
                    shabuffer = SHA1Class.ProcessQuest(shabuffer);

                    buffer = new byte[Convert.ToInt32(shabuffer.Length - 0x20)];
                    for (int i = 0; i < buffer.Length; i++)
                        buffer[i] = shabuffer[0x20 + i];
                }
                else if (TaskFileName.Substring(TaskFileName.Length - 3, 3) == "mib")
                {
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    byte[] shabuffer = new byte[Convert.ToInt32(stream.Length)];
                    stream.Read(shabuffer, 0, Convert.ToInt32(stream.Length));
                    shabuffer = SHA1Class.ProcessQuest(shabuffer);

                    buffer = new byte[Convert.ToInt32(shabuffer.Length - 0x20)];
                    for (int i = 0; i < buffer.Length; i++)
                        buffer[i] = shabuffer[0x20 + i];
                }
                else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "dat")
                {
                    Text = "Template Editng - " + Params.CqwTitle;
                    TaskFileName = "";
                    buffer = new byte[Convert.ToInt32(stream.Length)];
                    stream.Read(buffer, 0, Convert.ToInt32(stream.Length));
                }
                else if ((TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "txt") || (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "cmf"))
                {
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    FileStream specialstream = new FileStream(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + Path.Combine("Template", "ConanEdogawa.dat"), FileMode.Open);
                    buffer = new byte[0x6010];
                    specialstream.Read(buffer, 0, Convert.ToInt32(specialstream.Length));
                    specialstream.Close();
                    StreamReader reader = new StreamReader(stream, Encoding.Default);
                    string str2 = "";
                    for (str2 = reader.ReadLine(); str2 != null; str2 = reader.ReadLine())
                    {
                        str2 = str2.Trim();
                        if (str2.Trim().Substring(0, 2).ToUpper() == "_L")
                        {
                            string[] strArray = str2.Split(new char[] { ' ' });
                            if (strArray[1].Length == 10)
                            {
                                long num = Convert.ToInt32(strArray[1].Substring(3, 7), 0x10);
                                if ((num >= 0xe7b440) && (num <= 0xe81440))
                                {
                                    num -= 0xe7b440;
                                    byte[] buffer2 = new byte[4];
                                    if (strArray[2].Length == 10)
                                    {
                                        for (int k = 0; k < 4; k++)
                                            buffer2[k] = Convert.ToByte(strArray[2].Substring(2 + (k * 2), 2), 0x10);
                                    }
                                    for (int j = 0; j < Convert.ToInt16(Math.Pow(2.0, (double)Convert.ToInt16(strArray[1].Substring(2, 1)))); j++)
                                        if (((num + j) != 0x1c) && ((num + j) != 0x1d))
                                            buffer[(int)((IntPtr)(num + j))] = buffer2[3 - j];
                                }
                            }
                        }
                    }
                    reader.Close();
                    TaskFileName = "";
                }
                else if (TaskFileName.Substring(TaskFileName.Length - 3, 3).ToLower() == "mis")
                {
                    string str3 = "7319";
                    Text = Path.GetFileName(TaskFileName) + " - " + Params.CqwTitle;
                    buffer = new byte[Convert.ToInt32(stream.Length) - 20];
                    byte[] buffer3 = new byte[Convert.ToInt32(stream.Length)];
                    byte[] buffer4 = new byte[] { 
                        1, 0xff, 0x3a, 0xb3, 0x61, 100, 0x65, 0x42, 0x79, 0x54, 0x69, 0xde, 0x41, 0xb9, 0x33, 0xbf, 
                        0xec, 0x6f, 0x5b, 0x52  };
                    string str4 = "6A25";
                    stream.Read(buffer3, 0, Convert.ToInt32(stream.Length));
                    long num4 = Convert.ToInt32(str4 + str3, 0x10);
                    byte[] buffer5 = new byte[20];
                    buffer3 = ByteYYYYtoXXXX(buffer3, num4);
                    for (int m = 0; m < buffer3.Length; m += 4)
                    {
                        bool[] flagArray = new bool[4];
                        for (int num6 = 0; num6 < 0x100; num6++)
                        {
                            if (!flagArray[0] && (buffer3[m] == DataClass.aaaatobbbb[num6]))
                            {
                                buffer3[m] = Convert.ToByte(num6);
                                flagArray[0] = true;
                            }
                            if (!flagArray[1] && (buffer3[m + 1] == DataClass.aaaatobbbb[num6]))
                            {
                                buffer3[m + 1] = Convert.ToByte(num6);
                                flagArray[1] = true;
                            }
                            if (!flagArray[2] && (buffer3[m + 2] == DataClass.aaaatobbbb[num6]))
                            {
                                buffer3[m + 2] = Convert.ToByte(num6);
                                flagArray[2] = true;
                            }
                            if (!flagArray[3] && (buffer3[m + 3] == DataClass.aaaatobbbb[num6]))
                            {
                                buffer3[m + 3] = Convert.ToByte(num6);
                                flagArray[3] = true;
                            }
                        }
                    }
                    for (int n = 0; n < 20; n++)
                    {
                        buffer5[n] = buffer3[n];
                        buffer3[n] = buffer4[n];
                    }
                    buffer4 = new SHA1CryptoServiceProvider().ComputeHash(buffer3);
                    for (int num8 = 0; num8 < 20; num8++)
                    {
                        if (buffer5[num8] != buffer4[num8])
                        {
                            MessageBox.Show(Language.Dictionary["errors"]["decrypt"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    for (int num9 = 0; num9 < (buffer.Length - 20); num9++)
                        buffer[num9] = buffer3[num9 + 20];
                }
                else
                {
                    MessageBox.Show(Language.Dictionary["errors"]["format"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    stream.Close();
                    return;
                }
                stream.Close();
                string str5 = "94000000763030";
                for (int i = 0; i < 7; i++)
                {
                    if (buffer[i] != Convert.ToByte(str5.Substring(i * 2, 2), 0x10))
                    {
                        MessageBox.Show(Language.Dictionary["errors"]["corrupted"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        stream.Close();
                        return;
                    }
                }
                ResourceControlInit();
                ResouresDataInit();
                if (EditToolState == "Open")
                    ClearControl();
                DataLoadToControl(buffer);
                EditToolState = "Open";
                if ((ShowMapForm != null) && !ShowMapForm.IsDisposed)
                {
                    ShowMapForm.Close();
                    int x = base.Location.X + base.Size.Width;
                    int y = base.Location.Y;
                    ShowMapForm = new MapForm(x, y, MapLabel.Text);
                    ShowMapForm.Owner = this;
                    ShowMapForm.Show();
                    base.Activate();
                }
            }
        }

        #endregion

        #region Menu Opzioni

        private void controllaAutomaticamenteUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Configs.AutoCheckForUpdates)
            {
                Configs.AutoCheckForUpdates = false;
                Configs.SaveConfigs();
                controllaAutomaticamenteUpdatesToolStripMenuItem.Image = null;
            }
            else
            {
                Configs.AutoCheckForUpdates = true;
                Configs.SaveConfigs();
                controllaAutomaticamenteUpdatesToolStripMenuItem.Image = Properties.Resources.Confirm;
            }
        }

        private void controllaAggiornamentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (Updater.CheckForUpdate())
            {
                case 1:
                    if (MessageBox.Show(Language.Dictionary["updater"]["wantupdate"], Language.Dictionary["updater"]["available"], MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Visible = false;
                        Updater updt = new Updater();
                        updt.ShowDialog();
                    }
                    break;
                case -1:
                    MessageBox.Show(Language.Dictionary["updater"]["commerror"], Language.Dictionary["errors"]["title"]);
                    break;
                case 0:
                    MessageBox.Show(Language.Dictionary["updater"]["lastversion"]);
                    break;
            }
        }

        private void scaricaLingueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageDownloadForm ldf = new LanguageDownloadForm();
            ldf.ShowDialog();
            RefreshLanguageList();
        }

        #endregion

        #region Menu Credits & Help & Map

        private void MapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((this.EditToolState.Substring(0, 4) == "Open") && ((ShowMapForm == null) || ShowMapForm.IsDisposed))
            {
                int x = base.Location.X + base.Size.Width;
                int y = base.Location.Y;
                ShowMapForm = new MapForm(x, y, MapLabel.Tag.ToString());
                ShowMapForm.Owner = this;
                ShowMapForm.Show();
                base.Activate();
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm cf = new CreditsForm();
            cf.ShowDialog();
            cf.Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBox hb = new HelpBox();
            hb.ShowDialog();
            hb.Close();
        }

        #endregion

        #region Menu Language

        private void ChangeLanguage(object sender, EventArgs e)
        {
            Language.InitDictionary(sender.ToString());

            MessageBox.Show(Language.Dictionary["messages"]["restart"], "CQE - Restart is needed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Configs.CurrentLanguage = sender.ToString();
            Configs.SaveConfigs();
        }

        private void RefreshLanguageList()
        {
            linguaToolStripMenuItem.DropDownItems.Clear();

            string[] languages = Directory.GetDirectories("Lang", "*", SearchOption.TopDirectoryOnly);
            int index = 0;
            foreach (string language in languages)
            {
                if (!language.Contains("#"))
                {
                    linguaToolStripMenuItem.DropDownItems.Add(language.Substring(5));
                    try
                    {
                        linguaToolStripMenuItem.DropDownItems[index].Image = Image.FromFile(language + Path.DirectorySeparatorChar + "flag.png");
                        linguaToolStripMenuItem.DropDownItems[index].ImageScaling = ToolStripItemImageScaling.None;
                    }
                    catch { }
                    linguaToolStripMenuItem.DropDownItems[index].Click += ChangeLanguage;
                    index++;
                }
            }
        }

        #endregion

        #endregion

        #region Data Handlers

        private byte[] ByteXXXXtoYYYY(byte[] byData, long Key16)
        {
            if ((byData.Length % 4) != 0)
            {
                MessageBox.Show("Error while processing data");
                return byData;
            }
            long num = 0;
            for (int i = 0; i < byData.Length; i += 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    byData[i + j] = DataClass.tableA[byData[i + j]];
                }
                for (int k = 0; k < 4; k++)
                {
                    byData[i + k] = DataClass.tableA[byData[i + k]];
                }
                num = Convert.ToInt32((int)(((byData[i] + (byData[i + 1] << 8)) + (byData[i + 2] << 0x10)) + (byData[i + 3] << 0x18)));
                long num5 = Key16 ^ num;
                Key16 = num5;
                byData[i] = Convert.ToByte((long)(num5 & 0xff));
                byData[i + 1] = Convert.ToByte((long)((num5 >> 8) & 0xff));
                byData[i + 2] = Convert.ToByte((long)((num5 >> 0x10) & 0xff));
                byData[i + 3] = Convert.ToByte((long)((num5 >> 0x18) & 0xff));
                for (int m = 0; m < 4; m++)
                {
                    byData[i + m] = DataClass.tableA[byData[i + m]];
                }
            }
            return byData;
        }

        private byte[] ByteYYYYtoXXXX(byte[] byData, long Key16)
        {
            if ((byData.Length % 4) != 0)
            {
                MessageBox.Show("Error while processing data");
                return byData;
            }
            long num = 0;
            for (int i = 0; i < byData.Length; i += 4)
            {
                bool[] flagArray = new bool[4];
                for (int j = 0; j < 0x100; j++)
                {
                    if (!flagArray[0] && (byData[i] == DataClass.tableA[j]))
                    {
                        byData[i] = Convert.ToByte(j);
                        flagArray[0] = true;
                    }
                    if (!flagArray[1] && (byData[i + 1] == DataClass.tableA[j]))
                    {
                        byData[i + 1] = Convert.ToByte(j);
                        flagArray[1] = true;
                    }
                    if (!flagArray[2] && (byData[i + 2] == DataClass.tableA[j]))
                    {
                        byData[i + 2] = Convert.ToByte(j);
                        flagArray[2] = true;
                    }
                    if (!flagArray[3] && (byData[i + 3] == DataClass.tableA[j]))
                    {
                        byData[i + 3] = Convert.ToByte(j);
                        flagArray[3] = true;
                    }
                }
                num = Convert.ToInt32((int)(((byData[i] + (byData[i + 1] << 8)) + (byData[i + 2] << 0x10)) + (byData[i + 3] << 0x18)));
                long num4 = Key16 ^ num;
                byData[i] = Convert.ToByte((long)(num4 & 0xff));
                byData[i + 1] = Convert.ToByte((long)((num4 >> 8) & 0xff));
                byData[i + 2] = Convert.ToByte((long)((num4 >> 0x10) & 0xff));
                byData[i + 3] = Convert.ToByte((long)((num4 >> 0x18) & 0xff));
                Key16 = num;
                bool[] flagArray2 = new bool[4];
                for (int k = 0; k < 0x100; k++)
                {
                    if (!flagArray2[0] && (byData[i] == DataClass.tableA[k]))
                    {
                        byData[i] = Convert.ToByte(k);
                        flagArray2[0] = true;
                    }
                    if (!flagArray2[1] && (byData[i + 1] == DataClass.tableA[k]))
                    {
                        byData[i + 1] = Convert.ToByte(k);
                        flagArray2[1] = true;
                    }
                    if (!flagArray2[2] && (byData[i + 2] == DataClass.tableA[k]))
                    {
                        byData[i + 2] = Convert.ToByte(k);
                        flagArray2[2] = true;
                    }
                    if (!flagArray2[3] && (byData[i + 3] == DataClass.tableA[k]))
                    {
                        byData[i + 3] = Convert.ToByte(k);
                        flagArray2[3] = true;
                    }
                }
                bool[] flagArray3 = new bool[4];
                for (int m = 0; m < 0x100; m++)
                {
                    if (!flagArray3[0] && (byData[i] == DataClass.tableA[m]))
                    {
                        byData[i] = Convert.ToByte(m);
                        flagArray3[0] = true;
                    }
                    if (!flagArray3[1] && (byData[i + 1] == DataClass.tableA[m]))
                    {
                        byData[i + 1] = Convert.ToByte(m);
                        flagArray3[1] = true;
                    }
                    if (!flagArray3[2] && (byData[i + 2] == DataClass.tableA[m]))
                    {
                        byData[i + 2] = Convert.ToByte(m);
                        flagArray3[2] = true;
                    }
                    if (!flagArray3[3] && (byData[i + 3] == DataClass.tableA[m]))
                    {
                        byData[i + 3] = Convert.ToByte(m);
                        flagArray3[3] = true;
                    }
                }
            }
            return byData;
        }


        public static string toHexString(byte data)
        {
            string str = "";
            if (data > 0)
            {
                str = Convert.ToString(data, 0x10).ToUpper();
            }
            if (str.Length < 2)
            {
                str = str.PadLeft(2, '0');
            }
            return str;
        }

        private void DataLoadToControl(byte[] byFileByte)
        {
            int[] numArray = new int[7];
            int index = (byFileByte[0xad] << 8) + byFileByte[0xac];
            if (index > 0)
            {
                int[] numArray2 = new int[6];
                numArray2[0] = (byFileByte[index + 1] << 8) + byFileByte[index];
                for (int m = 1; m < 6; m++)
                {
                    numArray2[m] = numArray2[m - 1] + 4;
                }
                numArray[0] = (byFileByte[numArray2[0] + 1] << 8) + byFileByte[numArray2[0]];
                numArray[1] = (byFileByte[numArray2[1] + 1] << 8) + byFileByte[numArray2[1]];
                numArray[2] = (byFileByte[numArray2[2] + 1] << 8) + byFileByte[numArray2[2]];
                numArray[3] = (byFileByte[numArray2[3] + 1] << 8) + byFileByte[numArray2[3]];
                numArray[4] = (byFileByte[numArray2[4] + 1] << 8) + byFileByte[numArray2[4]];
                numArray[5] = (byFileByte[numArray2[5] + 1] << 8) + byFileByte[numArray2[5]];
                numArray[6] = numArray2[0];
            }
            for (int i = 0; i < 6; i++)
            {
                byte[] bytes = new byte[numArray[i + 1] - numArray[i]];
                for (int n = 0; n < (numArray[i + 1] - numArray[i]); n++)
                {
                    bytes[n] = byFileByte[numArray[i] + n];
                }
                TaskInfText[i].Text = Encoding.UTF8.GetString(bytes);
                TaskInfText[i].Text = TaskInfText[i].Text.Replace("\n", "\r\n");
            }
            SN_NumUpDown.Value = (byFileByte[0xb1] << 8) + byFileByte[0xb0];
            if ((((byFileByte[0x9a] << 0x10) + (byFileByte[0x99] << 8)) + byFileByte[0x98]) < 0x1388)
            {
                ContractNumUpDown.Value = ((byFileByte[0x9a] << 0x10) + (byFileByte[0x99] << 8)) + byFileByte[0x98];
            }
            else
            {
                ContractNumUpDown.Value = 5000M;
            }
            if ((((byFileByte[0x9e] << 0x10) + (byFileByte[0x9d] << 8)) + byFileByte[0x9c]) < 0xea60)
            {
                RemuntNumUpDown.Value = ((byFileByte[0x9e] << 0x10) + (byFileByte[0x9d] << 8)) + byFileByte[0x9c];
            }
            else
            {
                RemuntNumUpDown.Value = 60000M;
            }
            if ((((byFileByte[0xa2] << 0x10) + (byFileByte[0xa1] << 8)) + byFileByte[160]) != 0)
            {
                if (Convert.ToInt16((decimal)(RemuntNumUpDown.Value / (((byFileByte[0xa2] << 0x10) + (byFileByte[0xa1] << 8)) + byFileByte[160]))) < 9)
                {
                    CatCarNumUpDown.Value = Convert.ToInt16((decimal)(RemuntNumUpDown.Value / (((byFileByte[0xa2] << 0x10) + (byFileByte[0xa1] << 8)) + byFileByte[160])));
                }
                else
                {
                    CatCarNumUpDown.Value = 9M;
                }
            }
            if (((byFileByte[0x7d] << 8) + byFileByte[0x7c]) < 0xbb8)
            {
                UnionNumUpDown.Value = (byFileByte[0x7d] << 8) + byFileByte[0x7c];
            }
            else
            {
                UnionNumUpDown.Value = 3000M;
            }
            TimeNumUpDown.Value = Convert.ToInt16((int)((((byFileByte[0xa6] << 0x10) + (byFileByte[0xa5] << 8)) + byFileByte[0xa4]) / 0x708));
            numUpDnDouNoTimeToDefer.Value = byFileByte[140];
            chkBoxDouNoTimeToDefer.Checked = byFileByte[140] > 0;
            if (byFileByte[0xbb] > 0)
            {
                SndVicyTermCmbBox.SelectedIndex = byFileByte[0xbb] - 1;
            }
            else
            {
                SndVicyTermCmbBox.SelectedIndex = 0;
            }
            if (byFileByte[0xbc] == 1)
            {
                int num5 = byFileByte[0xc0];
                if (num5 < 0x45)
                {
                    VicyTermCmbBox1.Text = strMonsterNames[num5];
                }
                else
                {
                    VicyTermCmbBox1.SelectedIndex = 0;
                }
                VicyTermNumUpDown1.Value = byFileByte[0xc2];
            }
            else if (byFileByte[0xbc] == 2)
            {
                int num6 = (byFileByte[0xc1] << 8) + byFileByte[0xc0];
                if (num6 <= 0x2dc)
                {
                    VicyTermCmbBox1.Text = ResouresNames[num6];
                }
                else
                {
                    VicyTermCmbBox1.SelectedIndex = 0;
                }
                VicyTermNumUpDown1.Value = byFileByte[0xc2];
            }
            else
            {
                VicyTermCmbBox1.SelectedIndex = 0;
                VicyTermNumUpDown1.Value = 0M;
            }
            if (byFileByte[0xc4] == 1)
            {
                int num7 = byFileByte[200];
                if (num7 < 0x45)
                {
                    VicyTermCmbBox2.Text = strMonsterNames[num7];
                }
                else
                {
                    VicyTermCmbBox2.SelectedIndex = 0;
                }
                VicyTermNumUpDown2.Value = byFileByte[0xca];
            }
            else if (byFileByte[0xc4] == 2)
            {
                int num8 = (byFileByte[0xc9] << 8) + byFileByte[200];
                if (num8 <= 0x2dc)
                {
                    VicyTermCmbBox2.Text = ResouresNames[num8];
                }
                else
                {
                    VicyTermCmbBox2.SelectedIndex = 0;
                }
                VicyTermNumUpDown2.Value = byFileByte[0xca];
            }
            else
            {
                VicyTermCmbBox2.SelectedIndex = 0;
                VicyTermNumUpDown2.Value = 0M;
            }
            OpenLimitCmbBox1.SelectedIndex = byFileByte[0xb5];
            if (byFileByte[0xb6] > 6)
            {
                OpenLimitCmbBox2.SelectedIndex = byFileByte[0xb6] - 5;
            }
            else
            {
                OpenLimitCmbBox2.SelectedIndex = 0;
            }
            StarGradeCmbBox.SelectedIndex = byFileByte[0xb2] - 1;
            if (byFileByte[0x94] == 0x84)
            {
                TaskTypeCmbBox.SelectedIndex = 5;
            }
            else
            {
                switch (Convert.ToByte((int)(byFileByte[0x94] & 0x1f)))
                {
                    case 1:
                        TaskTypeCmbBox.SelectedIndex = 0;
                        goto Label_06BD;

                    case 2:
                        TaskTypeCmbBox.SelectedIndex = 1;
                        goto Label_06BD;

                    case 4:
                        TaskTypeCmbBox.SelectedIndex = 2;
                        goto Label_06BD;

                    case 8:
                        TaskTypeCmbBox.SelectedIndex = 3;
                        goto Label_06BD;

                    case 0x10:
                        TaskTypeCmbBox.SelectedIndex = 4;
                        goto Label_06BD;
                }
                TaskTypeCmbBox.SelectedIndex = 6;
            }
        Label_06BD:
            EnvironmentCmbBox1.SelectedIndex = 0;
            EnvironmentCmbBox2.SelectedIndex = 0;
            if (byFileByte[0x95] > 0)
            {
                int num9 = (byFileByte[0x95] >> 4) & 15;
                if (num9 > 0)
                {
                    EnvironmentCmbBox1.SelectedIndex = Convert.ToInt16(Math.Log((double)num9, 2.0)) + 1;
                }
                num9 = byFileByte[0x95] & 15;
                if (num9 > 0)
                {
                    EnvironmentCmbBox2.SelectedIndex = Convert.ToInt16(Math.Log((double)num9, 2.0)) + 1;
                }
            }
            switch (byFileByte[150])
            {
                case 0:
                    CaiYeChkBox.Checked = false;
                    CatChkBox.Checked = true;
                    break;

                case 0x20:
                    CaiYeChkBox.Checked = false;
                    CatChkBox.Checked = false;
                    break;

                case 0x40:
                    CaiYeChkBox.Checked = true;
                    CatChkBox.Checked = true;
                    break;
            }
            cmBoxStopTime.SelectedIndex = (byFileByte[0x97] & 15) / 4;
            chkBoxBGM.Checked = (byFileByte[0x97] >> 4) == 2;
            if (byFileByte[0x93] < 2)
            {
                LandingCmbBox.SelectedIndex = byFileByte[0x93];
            }
            else
            {
                LandingCmbBox.SelectedIndex = 2;
            }
            switch (byFileByte[180])
            {
                case 1:
                    MapLabel.Text = Language.Dictionary["areas"]["island"];
                    MapLabel.Tag = "Isola";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a9"], "----", "----", Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a10"] };
                    break;
                case 14:
                    MapLabel.Text = Language.Dictionary["areas"]["island"];
                    MapLabel.Tag = "Isola";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a9"], "----", "----", Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a10"] };
                    break;
                case 2:
                    MapLabel.Text = Language.Dictionary["areas"]["plains"];
                    MapLabel.Tag = "Pianure";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"], Language.Dictionary["zones"]["a10"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a11"], Language.Dictionary["zones"]["a6"] };
                    break;
                case 15:
                    MapLabel.Text = Language.Dictionary["areas"]["plains"];
                    MapLabel.Tag = "Pianure";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"], Language.Dictionary["zones"]["a10"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a11"], Language.Dictionary["zones"]["a6"] };
                    break;
                case 3:
                    MapLabel.Text = Language.Dictionary["areas"]["forest"];
                    MapLabel.Tag = "Foresta";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a9"], Language.Dictionary["zones"]["a10"] };
                    break;
                case 16:
                    MapLabel.Text = Language.Dictionary["areas"]["forest"];
                    MapLabel.Tag = "Foresta";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a9"], Language.Dictionary["zones"]["a10"] };
                    break;
                case 4:
                    MapLabel.Text = Language.Dictionary["areas"]["tundra"];
                    MapLabel.Tag = "Tundra";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 17:
                    MapLabel.Text = Language.Dictionary["areas"]["tundra"];
                    MapLabel.Tag = "Tundra";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 5:
                    MapLabel.Text = Language.Dictionary["areas"]["volcano"];
                    MapLabel.Tag = "Vulcano";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a10"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 18:
                    MapLabel.Text = Language.Dictionary["areas"]["volcano"];
                    MapLabel.Tag = "Vulcano";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a10"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 6:
                    MapLabel.Text = Language.Dictionary["areas"]["greatdesert"];
                    MapLabel.Tag = "Grande Deserto";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["battlefield"] };
                    break;
                case 7:
                    MapLabel.Text = Language.Dictionary["areas"]["lavacanyon"];
                    MapLabel.Tag = "Canyon di Lava";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;
                case 8:
                    MapLabel.Text = Language.Dictionary["areas"]["landarena"];
                    MapLabel.Tag = "Arena";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;
                case 9:
                    MapLabel.Text = Language.Dictionary["areas"]["smallarena"];
                    MapLabel.Tag = "Arena Piccola";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;
                case 10:
                    MapLabel.Text = Language.Dictionary["areas"]["sacredland"];
                    MapLabel.Tag = "Terra Sacra";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;
                case 11:
                    MapLabel.Text = Language.Dictionary["areas"]["polarzone"];
                    MapLabel.Tag = "Zona Polare";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;
                case 12:
                    MapLabel.Text = Language.Dictionary["areas"]["streams"];
                    MapLabel.Tag = "Cascate";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 0;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 19:
                    MapLabel.Text = Language.Dictionary["areas"]["streams"];
                    MapLabel.Tag = "Cascate";
                    MapTimeCmbBox.Visible = true;
                    MapTimeCmbBox.SelectedIndex = 1;
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"], Language.Dictionary["zones"]["a2"], Language.Dictionary["zones"]["a3"], Language.Dictionary["zones"]["a4"], Language.Dictionary["zones"]["a5"], Language.Dictionary["zones"]["a6"], Language.Dictionary["zones"]["a7"], Language.Dictionary["zones"]["a8"], Language.Dictionary["zones"]["a9"] };
                    break;
                case 13:
                    MapLabel.Text = Language.Dictionary["areas"]["summit"];
                    MapLabel.Tag = "Cima Montagna";
                    strMapPoint = new string[] { Language.Dictionary["zones"]["base"], Language.Dictionary["zones"]["a1"] };
                    break;

                default:
                    return;
            }
            for (int j = 0; j < strMapPoint.Length; j++)
            {
                BPointCmbBox.Items.Add(strMapPoint[j]);
                DfPointCmbBox.Items.Add(strMapPoint[j]);
                RsrLandmassCmbBox.Items.Add(strMapPoint[j]);
            }
            MonsterIconCmbBox1.SelectedIndex = byFileByte[0xd0];
            MonsterIconCmbBox2.SelectedIndex = byFileByte[210];
            MonsterIconCmbBox3.SelectedIndex = byFileByte[0xd4];
            MonsterIconCmbBox4.SelectedIndex = byFileByte[0xd6];
            MonsterIconCmbBox5.SelectedIndex = byFileByte[0xd8];
            if ((byFileByte[12] > 0) || (byFileByte[13] > 0))
            {
                chkBoxBOSSJUMP.Checked = true;
            }
            randomBoss = new StcMonster[3];
            for (int k = 0; k < 3; k++)
            {
                randomBoss[k].nameValue = 0;
                randomBoss[k].number = 0;
                randomBoss[k].point = 0;
                randomBoss[k].monsterHP = 0;
                randomBoss[k].volume = 0;
                randomBoss[k].runningAppearance = 0;
                randomBoss[k].X = 0f;
                randomBoss[k].Z = 0f;
                randomBoss[k].Y = 0f;
                randomBoss[k].Endurance = 0;
                randomBoss[k].AttackPower = 0;
                randomBoss[k].DefensePower = 0;
                randomBoss[k].volumeChange = 0;
                randomBoss[k].toFace = 0;
            }
            index = (byFileByte[0x2d] << 8) + byFileByte[0x2c];
            if ((index > 0) && ((byFileByte[index] != 0xff) || (byFileByte[index + 1] != 0xff)))
            {
                if (((byFileByte[0xa8] != 0) || (byFileByte[0xa9] != 0)) || ((byFileByte[170] != 0) || (byFileByte[0xab] != 0)))
                {
                    BossRandomSysRadioBtn3.Checked = true;
                }
                else
                {
                    BossRandomSysRadioBtn2.Checked = true;
                }
                WarningUnionNumUpD.Value = (byFileByte[0x85] << 8) + byFileByte[0x84];
                WarningRemuntNumUpD.Value = (byFileByte[0x89] << 8) + byFileByte[0x88];
                for (int num12 = 0; num12 < 3; num12++)
                {
                    if ((byFileByte[index + (num12 * 0x34)] != 0xff) || (byFileByte[(index + 1) + (num12 * 0x34)] != 0xff))
                    {
                        switch (num12)
                        {
                            case 0:
                                AppearanceProbabilityNumUpD1.Value = byFileByte[index];
                                break;

                            case 1:
                                AppearanceProbabilityNumUpD2.Value = byFileByte[index + 0x34];
                                break;

                            case 2:
                                AppearanceProbabilityNumUpD3.Value = byFileByte[index + 0x68];
                                break;
                        }
                        randomBoss[num12].nameValue = byFileByte[(index + 4) + (num12 * 0x34)];
                        randomBoss[num12].runningAppearance = byFileByte[(index + 6) + (num12 * 0x34)];
                        randomBoss[num12].number = byFileByte[(index + 8) + (num12 * 0x34)];
                        randomBoss[num12].point = byFileByte[(index + 10) + (num12 * 0x34)];
                        randomBoss[num12].toFace = (byFileByte[(index + 0x11) + (num12 * 0x34)] << 8) + byFileByte[(index + 0x10) + (num12 * 0x34)];
                        randomBoss[num12].X = BitConverter.ToSingle(byFileByte, (index + 20) + (num12 * 0x34));
                        randomBoss[num12].Z = BitConverter.ToSingle(byFileByte, (index + 0x18) + (num12 * 0x34));
                        randomBoss[num12].Y = BitConverter.ToSingle(byFileByte, (index + 0x1c) + (num12 * 0x34));
                        randomBoss[num12].volume = byFileByte[0x40 + (num12 * 8)];
                        randomBoss[num12].volumeChange = byFileByte[0x42 + (num12 * 8)];
                        randomBoss[num12].monsterHP = byFileByte[0x43 + (num12 * 8)];
                        randomBoss[num12].AttackPower = byFileByte[0x44 + (num12 * 8)];
                        randomBoss[num12].DefensePower = byFileByte[0x45 + (num12 * 8)];
                        randomBoss[num12].Endurance = byFileByte[70 + (num12 * 8)];
                        continue;
                    }
                    if (((num12 == 0) && (byFileByte[index + (num12 * 0x34)] == 0xff)) && (byFileByte[(index + 1) + (num12 * 0x34)] == 0xff))
                    {
                        BossRandomSysRadioBtn1.Checked = true;
                    }
                    break;
                }
            }
            else
            {
                BossRandomSysRadioBtn1.Checked = true;
            }
            index = (byFileByte[0x21] << 8) + byFileByte[0x20];
            strBoss = new StcMonster[5, 2];
            if (index > byFileByte.Length)
            {
                MessageBox.Show("File Error!");
            }
            else
            {
                ListViewItem item;
                ListViewItem.ListViewSubItem item2;
                for (int num13 = 0; num13 < 5; num13++)
                {
                    for (int num14 = 0; num14 < 2; num14++)
                    {
                        strBoss[num13, num14].nameValue = 0;
                        strBoss[num13, num14].number = 0;
                        strBoss[num13, num14].point = 0;
                        strBoss[num13, num14].monsterHP = 0;
                        strBoss[num13, num14].volume = 0;
                        strBoss[num13, num14].runningAppearance = 0;
                        strBoss[num13, num14].X = 0f;
                        strBoss[num13, num14].Z = 0f;
                        strBoss[num13, num14].Y = 0f;
                        strBoss[num13, num14].Endurance = 0;
                        strBoss[num13, num14].AttackPower = 0;
                        strBoss[num13, num14].DefensePower = 0;
                        strBoss[num13, num14].volumeChange = 0;
                        strBoss[num13, num14].toFace = 0;
                    }
                }
                if (index != 0)
                {
                    int num16 = 0;
                    for (int num17 = 0; num17 < 5; num17++)
                    {
                        if (byFileByte[index + (num17 * 0x10)] > 0)
                        {
                            int num15 = (byFileByte[(index + 13) + (num17 * 0x10)] << 8) + byFileByte[(index + 12) + (num17 * 0x10)];
                            if (num15 == 0)
                            {
                                break;
                            }
                            for (int num18 = 0; num18 < 2; num18++)
                            {
                                if (byFileByte[num15 + (num18 * 0x30)] == 0xff)
                                {
                                    break;
                                }
                                strBoss[num17, num18].nameValue = byFileByte[num15 + (num18 * 0x30)];
                                strBoss[num17, num18].runningAppearance = byFileByte[(num15 + 2) + (num18 * 0x30)];
                                strBoss[num17, num18].number = byFileByte[(num15 + 4) + (num18 * 0x30)];
                                strBoss[num17, num18].point = byFileByte[(num15 + 6) + (num18 * 0x30)];
                                strBoss[num17, num18].toFace = (byFileByte[(num15 + 13) + (num18 * 0x30)] << 8) + byFileByte[(num15 + 12) + (num18 * 0x30)];
                                strBoss[num17, num18].X = BitConverter.ToSingle(byFileByte, (num15 + 0x10) + (num18 * 0x30));
                                strBoss[num17, num18].Z = BitConverter.ToSingle(byFileByte, (num15 + 20) + (num18 * 0x30));
                                strBoss[num17, num18].Y = BitConverter.ToSingle(byFileByte, (num15 + 0x18) + (num18 * 0x30));
                                if ((num16 < 5) && BossRandomSysRadioBtn1.Checked)
                                {
                                    strBoss[num17, num18].volume = byFileByte[0x30 + (num16 * 8)];
                                    strBoss[num17, num18].volumeChange = byFileByte[50 + (num16 * 8)];
                                    strBoss[num17, num18].monsterHP = byFileByte[0x33 + (num16 * 8)];
                                    strBoss[num17, num18].AttackPower = byFileByte[0x34 + (num16 * 8)];
                                    strBoss[num17, num18].DefensePower = byFileByte[0x35 + (num16 * 8)];
                                    strBoss[num17, num18].Endurance = byFileByte[0x36 + (num16 * 8)];
                                }
                                else if (!BossRandomSysRadioBtn1.Checked)
                                {
                                    strBoss[num17, num18].volume = byFileByte[0x30 + (num18 * 8)];
                                    strBoss[num17, num18].volumeChange = byFileByte[50 + (num18 * 8)];
                                    strBoss[num17, num18].monsterHP = byFileByte[0x33 + (num18 * 8)];
                                    strBoss[num17, num18].AttackPower = byFileByte[0x34 + (num18 * 8)];
                                    strBoss[num17, num18].DefensePower = byFileByte[0x35 + (num18 * 8)];
                                    strBoss[num17, num18].Endurance = byFileByte[0x36 + (num18 * 8)];
                                }
                                num16++;
                            }
                        }
                    }
                }
                BossListView.Items.Clear();
                BossListView.BeginUpdate();
                for (int num19 = 0; num19 < 5; num19++)
                {
                    for (int num20 = 0; num20 < 2; num20++)
                    {
                        item = new ListViewItem
                        {
                            Text = Convert.ToString((int)(((num19 * 2) + num20) + 1))
                        };
                        if (strBoss[num19, num20].nameValue > 0)
                        {
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = strMonsterNames[strBoss[num19, num20].nameValue]
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].number)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].monsterHP)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].AttackPower)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].DefensePower)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].Endurance)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].volume)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].volumeChange)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = strMapPoint[strBoss[num19, num20].point]
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].X)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].Z)
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strBoss[num19, num20].Y)
                            };
                            item.SubItems.Add(item2);
                            BossListView.Items.Add(item);
                        }
                        else
                        {
                            for (int num21 = 0; num21 < 13; num21++)
                            {
                                item2 = new ListViewItem.ListViewSubItem
                                {
                                    Text = ""
                                };
                                item.SubItems.Add(item2);
                            }
                            BossListView.Items.Add(item);
                        }
                    }
                }
                BossRandomUnknowValueTextBox.Text = toHexString(byFileByte[0xab]) + toHexString(byFileByte[170]) + toHexString(byFileByte[0xa9]) + toHexString(byFileByte[0xa8]);
                for (int num22 = 0; num22 < 3; num22++)
                {
                    item = new ListViewItem
                    {
                        Text = Convert.ToString((int)(11 + num22))
                    };
                    if (randomBoss[num22].nameValue > 0)
                    {
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = strMonsterNames[randomBoss[num22].nameValue]
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].number)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].monsterHP)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].AttackPower)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].DefensePower)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].Endurance)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].volume)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].volumeChange)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = strMapPoint[randomBoss[num22].point]
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].X)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].Z)
                        };
                        item.SubItems.Add(item2);
                        item2 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(randomBoss[num22].Y)
                        };
                        item.SubItems.Add(item2);
                        BossListView.Items.Add(item);
                    }
                    else
                    {
                        for (int num23 = 0; num23 < 13; num23++)
                        {
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item.SubItems.Add(item2);
                        }
                        BossListView.Items.Add(item);
                    }
                }
                BossListView.EndUpdate();
                for (int num24 = 1; num24 < 6; num24 += 2)
                {
                    BossListView.Items[num24 * 2].BackColor = Color.PowderBlue;
                    BossListView.Items[(num24 * 2) + 1].BackColor = Color.PowderBlue;
                }
                BossListView.Items[12].BackColor = Color.PowderBlue;
                DfVolumeNumUpD.Value = byFileByte[0x58];
                DfGradeNumUpDown.Value = byFileByte[0x5b];
                DfAttackNumUpDown.Value = byFileByte[0x5c];
                DfDefenseNumUpDown.Value = byFileByte[0x5d];
                NumUpDownDfEndurance.Value = byFileByte[0x5e];
                if (byFileByte[0x6c] > 0)
                {
                    DogfRdButton2.Checked = true;
                    RoundRdButton2.Enabled = true;
                    DfAddCmbBox1.Enabled = true;
                    DfAddNumNumUpDown1.Enabled = true;
                    int num25 = (byFileByte[0x71] << 8) + byFileByte[0x70];
                    if (num25 < 0x45)
                    {
                        DfAddCmbBox1.Text = strMonsterNames[num25];
                    }
                    else if (num25 >= 0x110)
                    {
                        DfAddCmbBox1.Text = ResouresNames[num25];
                    }
                    else
                    {
                        DfAddCmbBox1.SelectedIndex = 0;
                    }
                    DfAddNumNumUpDown1.Value = byFileByte[0x72];
                    DfAddCmbBox2.SelectedIndex = 0;
                    DfAddNumNumUpDown2.Value = 0M;
                }
                if (byFileByte[0x74] > 0)
                {
                    DogfRdButton3.Checked = true;
                    RoundRdButton2.Enabled = true;
                    RoundRdButton3.Enabled = true;
                    DfAddCmbBox1.Enabled = true;
                    DfAddCmbBox2.Enabled = true;
                    DfAddNumNumUpDown1.Enabled = true;
                    DfAddNumNumUpDown2.Enabled = true;
                    int num26 = (byFileByte[0x79] << 8) + byFileByte[120];
                    if (num26 < 0x45)
                    {
                        DfAddCmbBox2.Text = strMonsterNames[num26];
                    }
                    else if (num26 >= 0x110)
                    {
                        DfAddCmbBox2.Text = ResouresNames[num26];
                    }
                    else
                    {
                        DfAddCmbBox2.SelectedIndex = 0;
                    }
                    DfAddNumNumUpDown2.Value = byFileByte[0x7a];
                }
                index = (byFileByte[0x25] << 8) + byFileByte[0x24];
                strDogfish = new StcMonster[3, strMapPoint.Length, 10];
                for (int num27 = 0; num27 < 3; num27++)
                {
                    for (int num28 = 0; num28 < strMapPoint.Length; num28++)
                    {
                        for (int num29 = 0; num29 < 10; num29++)
                        {
                            strDogfish[num27, num28, num29].nameValue = 0;
                            strDogfish[num27, num28, num29].number = 0;
                            strDogfish[num27, num28, num29].point = 0;
                            strDogfish[num27, num28, num29].monsterHP = 0;
                            strDogfish[num27, num28, num29].volume = 0;
                            strDogfish[num27, num28, num29].runningAppearance = 0;
                            strDogfish[num27, num28, num29].X = 0f;
                            strDogfish[num27, num28, num29].Z = 0f;
                            strDogfish[num27, num28, num29].Y = 0f;
                            strDogfish[num27, num28, num29].toFace = 0;
                        }
                    }
                }
                if (index != 0)
                {
                    int[] numArray3 = new int[3];
                    for (int num30 = 0; num30 < 3; num30++)
                    {
                        numArray3[num30] = (byFileByte[(index + 1) + (num30 * 4)] << 8) + byFileByte[index + (num30 * 4)];
                    }
                    for (int num31 = 0; num31 < 3; num31++)
                    {
                        for (int num32 = 0; num32 < strMapPoint.Length; num32++)
                        {
                            int num33 = (byFileByte[(numArray3[num31] + 13) + (num32 * 0x10)] << 8) + byFileByte[(numArray3[num31] + 12) + (num32 * 0x10)];
                            if (num33 != 0)
                            {
                                for (int num34 = 0; num34 < 10; num34++)
                                {
                                    if (byFileByte[num33 + (num34 * 0x30)] == 0xff)
                                    {
                                        break;
                                    }
                                    strDogfish[num31, num32, num34].nameValue = byFileByte[num33 + (num34 * 0x30)];
                                    if ((strDogfish[num31, num32, num34].nameValue < 0) || (strDogfish[num31, num32, num34].nameValue > strMonsterNames.Length))
                                    {
                                        MessageBox.Show("Unknown Datas.\nPlease, contact the author of CQE.\n\n Undefined Data:" + Convert.ToString(strDogfish[num31, num32, num34].nameValue), "QS3 » Unknown Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        strDogfish[num31, num32, num34].nameValue = 0;
                                    }
                                    strDogfish[num31, num32, num34].number = byFileByte[(num33 + 4) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].point = byFileByte[(num33 + 6) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].monsterHP = byFileByte[(num33 + 5) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].volume = byFileByte[(num33 + 2) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].runningAppearance = byFileByte[(num33 + 8) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].toFace = (byFileByte[(num33 + 13) + (num34 * 0x30)] << 8) + byFileByte[(num33 + 12) + (num34 * 0x30)];
                                    strDogfish[num31, num32, num34].X = BitConverter.ToSingle(byFileByte, (num33 + 0x10) + (num34 * 0x30));
                                    strDogfish[num31, num32, num34].Z = BitConverter.ToSingle(byFileByte, (num33 + 20) + (num34 * 0x30));
                                    strDogfish[num31, num32, num34].Y = BitConverter.ToSingle(byFileByte, (num33 + 0x18) + (num34 * 0x30));
                                }
                            }
                        }
                    }
                }
                DfPointCmbBox.SelectedIndex = 1;
                RoundRdButton1.Checked = true;
                DogfishListView.Items.Clear();
                DogfishListView.BeginUpdate();
                for (int num35 = 0; num35 < 10; num35++)
                {
                    ListViewItem.ListViewSubItem item4;
                    ListViewItem item3 = new ListViewItem
                    {
                        Text = Convert.ToString((int)(num35 + 1))
                    };
                    if (strDogfish[0, 1, num35].nameValue > 0)
                    {
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = strMonsterNames[strDogfish[0, 1, num35].nameValue]
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].volume)
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem();
                        switch (strDogfish[0, 1, num35].runningAppearance)
                        {
                            case 0:
                                item4.Text = Language.Dictionary["edit"]["fixedshort"];
                                break;

                            case 1:
                                item4.Text = Language.Dictionary["edit"]["randomshort"];
                                break;

                            case 2:
                                item4.Text = Language.Dictionary["edit"]["hidedshort"];
                                break;
                        }
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].number)
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].X)
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].Z)
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].Y)
                        };
                        item3.SubItems.Add(item4);
                        item4 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strDogfish[0, 1, num35].toFace)
                        };
                        item3.SubItems.Add(item4);
                    }
                    else
                    {
                        for (int num36 = 0; num36 < 8; num36++)
                        {
                            item4 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item3.SubItems.Add(item4);
                        }
                    }
                    DogfishListView.Items.Add(item3);
                }
                DogfishListView.EndUpdate();
                for (int num37 = 1; num37 < 10; num37 += 2)
                {
                    DogfishListView.Items[num37].BackColor = Color.PowderBlue;
                }
                for (int num38 = 0; num38 < 40; num38++)
                {
                    strRation[num38].nameValue = 0;
                    strRation[num38].number = 0;
                }
                int num39 = 0;
                bool flag = true;
                index = (byFileByte[9] << 8) + byFileByte[8];
                int num40 = (byFileByte[index + 5] << 8) + byFileByte[index + 4];
                BaseRationNumUpD.Value = byFileByte[index + 1];
                for (int num41 = 0; num41 < 2; num41++)
                {
                    if ((byFileByte[index + (num41 * 8)] == 0xff) && (byFileByte[(index + (num41 * 8)) + 1] == 0))
                    {
                        flag = false;
                        RadioBtnNothing.Checked = true;
                        break;
                    }
                    if (byFileByte[(index + 1) + (num41 * 8)] <= 0)
                    {
                        break;
                    }
                    for (int num42 = 0; num42 < byFileByte[(index + 1) + (num41 * 8)]; num42++)
                    {
                        strRation[num39].nameValue = (byFileByte[(num40 + 1) + (num39 * 4)] << 8) + byFileByte[num40 + (num39 * 4)];
                        strRation[num39].number = byFileByte[(num40 + 2) + (num39 * 4)];
                        num39++;
                    }
                }
                if (flag)
                {
                    index += 0x10;
                    for (int num43 = 0; num43 < 3; num43++)
                    {
                        if ((byFileByte[index + (num43 * 8)] == 0xff) && (byFileByte[(index + (num43 * 8)) + 1] == 0))
                        {
                            break;
                        }
                        num40 = (byFileByte[(index + 5) + (num43 * 8)] << 8) + byFileByte[(index + 4) + (num43 * 8)];
                        if ((byFileByte[(index + 1) + (num43 * 8)] > 0) && (num40 > 0))
                        {
                            if (((num43 == 0) && (byFileByte[20] > 0)) && (byFileByte[0x15] > 0))
                            {
                                RadioBtnConditionsRation.Checked = true;
                                CmbBoxConditionsRation.Enabled = true;
                                ConditionsRationCmbBoxNumUpD.Enabled = true;
                                int num44 = (byFileByte[0x17] << 8) + byFileByte[0x16];
                                if (num44 < 0x45)
                                {
                                    CmbBoxConditionsRation.Text = strMonsterNames[num44];
                                }
                                else if (num44 >= 0x110)
                                {
                                    CmbBoxConditionsRation.Text = ResouresNames[num44];
                                }
                                ConditionsRationCmbBoxNumUpD.Value = byFileByte[0x18];
                            }
                            if ((num43 > 0) && BossRandomSysRadioBtn3.Checked)
                            {
                                RadioBtnRandomSysRation.Checked = true;
                            }
                            for (int num45 = 0; num45 < byFileByte[(index + 1) + (num43 * 8)]; num45++)
                            {
                                strRation[0x20 + num45].nameValue = (byFileByte[(num40 + 1) + (num45 * 4)] << 8) + byFileByte[num40 + (num45 * 4)];
                                strRation[0x20 + num45].number = byFileByte[(num40 + 2) + (num45 * 4)];
                            }
                            break;
                        }
                    }
                }
                BaseContrLstView1.Items.Clear();
                BaseContrLstView1.BeginUpdate();
                for (int num46 = 0; num46 < 20; num46++)
                {
                    ListViewItem.ListViewSubItem item6;
                    ListViewItem item5 = new ListViewItem
                    {
                        Text = Convert.ToString((int)(num46 + 1))
                    };
                    if (strRation[num46].nameValue > 0)
                    {
                        item6 = new ListViewItem.ListViewSubItem
                        {
                            Text = ResouresNames[strRation[num46].nameValue]
                        };
                        item5.SubItems.Add(item6);
                        item6 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strRation[num46].number)
                        };
                        item5.SubItems.Add(item6);
                    }
                    else
                    {
                        item6 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item5.SubItems.Add(item6);
                        item6 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item5.SubItems.Add(item6);
                    }
                    BaseContrLstView1.Items.Add(item5);
                }
                BaseContrLstView1.EndUpdate();
                BaseContrLstView2.Items.Clear();
                BaseContrLstView2.BeginUpdate();
                for (int num47 = 20; num47 < 40; num47++)
                {
                    ListViewItem.ListViewSubItem item8;
                    ListViewItem item7 = new ListViewItem
                    {
                        Text = Convert.ToString((int)(num47 + 1))
                    };
                    if (strRation[num47].nameValue > 0)
                    {
                        item8 = new ListViewItem.ListViewSubItem
                        {
                            Text = ResouresNames[strRation[num47].nameValue]
                        };
                        item7.SubItems.Add(item8);
                        item8 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strRation[num47].number)
                        };
                        item7.SubItems.Add(item8);
                    }
                    else
                    {
                        item8 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item7.SubItems.Add(item8);
                        item8 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item7.SubItems.Add(item8);
                    }
                    BaseContrLstView2.Items.Add(item7);
                }
                BaseContrLstView2.EndUpdate();
                if (BaseRationNumUpD.Value < 20M)
                {
                    for (int num48 = Convert.ToInt16(BaseRationNumUpD.Value); num48 < 20; num48++)
                    {
                        BaseContrLstView1.Items[num48].BackColor = Color.LightBlue;
                    }
                    int num49 = 0;
                    if (!RadioBtnNothing.Checked)
                    {
                        num49 = 12;
                        for (int num50 = 12; num50 < 20; num50++)
                        {
                            BaseContrLstView2.Items[num50].BackColor = Color.Thistle;
                        }
                    }
                    else
                    {
                        num49 = 20;
                    }
                    for (int num51 = 0; num51 < num49; num51++)
                    {
                        BaseContrLstView2.Items[num51].BackColor = Color.LightBlue;
                    }
                }
                else if (BaseRationNumUpD.Value >= 20M)
                {
                    int num52 = 0;
                    if (!RadioBtnNothing.Checked)
                    {
                        num52 = 12;
                        if (BaseRationNumUpD.Value > 32M)
                        {
                            BaseRationNumUpD.Value = 32M;
                        }
                        for (int num53 = 12; num53 < 20; num53++)
                        {
                            BaseContrLstView2.Items[num53].BackColor = Color.Thistle;
                        }
                    }
                    else
                    {
                        num52 = 20;
                    }
                    for (int num54 = Convert.ToInt16((decimal)(BaseRationNumUpD.Value - 20M)); num54 < num52; num54++)
                    {
                        BaseContrLstView2.Items[num54].BackColor = Color.LightBlue;
                    }
                }
                index = (byFileByte[0x61] << 8) + byFileByte[0x60];
                int[] numArray4 = new int[strMapPoint.Length + 1];
                resourcesPoint = new int[strMapPoint.Length];
                strResrPoint = new StcResourceGathering[strMapPoint.Length, 6];
                strResources = new StcResources[strMapPoint.Length, 6, 15];
                for (int num55 = 0; num55 < strMapPoint.Length; num55++)
                {
                    numArray4[num55] = (byFileByte[(index + 1) + (num55 * 4)] << 8) + byFileByte[index + (num55 * 4)];
                }
                numArray4[strMapPoint.Length] = index;
                for (int num56 = strMapPoint.Length - 1; num56 >= 0; num56--)
                {
                    if (numArray4[num56] != 0)
                    {
                        for (int num57 = num56 + 1; num57 <= strMapPoint.Length; num57++)
                        {
                            if (numArray4[num57] != 0)
                            {
                                resourcesPoint[num56] = (numArray4[num57] - numArray4[num56]) / 8;
                                if (resourcesPoint[num56] > 6)
                                {
                                    resourcesPoint[num56] = 6;
                                }
                                break;
                            }
                        }
                        for (int num58 = 0; num58 < resourcesPoint[num56]; num58++)
                        {
                            int num59 = (byFileByte[(numArray4[num56] + 1) + (num58 * 8)] << 8) + byFileByte[numArray4[num56] + (num58 * 8)];
                            strResrPoint[num56, num58].maxiNum = byFileByte[(numArray4[num56] + 4) + (num58 * 8)];
                            strResrPoint[num56, num58].miniNum = byFileByte[(numArray4[num56] + 6) + (num58 * 8)];
                            bool flag2 = true;
                            for (int num60 = 0; num60 < 15; num60++)
                            {
                                if (flag2)
                                {
                                    if ((num59 == 0) || (byFileByte[num59 + (num60 * 4)] == 0xff))
                                    {
                                        flag2 = false;
                                        strResources[num56, num58, num60].RateOrTeam = 0;
                                        strResources[num56, num58, num60].number = 0;
                                        strResources[num56, num58, num60].nameValue = 0;
                                    }
                                    else
                                    {
                                        strResources[num56, num58, num60].RateOrTeam = byFileByte[num59 + (num60 * 4)];
                                        strResources[num56, num58, num60].number = byFileByte[(num59 + 1) + (num60 * 4)];
                                        strResources[num56, num58, num60].nameValue = (byFileByte[(num59 + 3) + (num60 * 4)] << 8) + byFileByte[(num59 + 2) + (num60 * 4)];
                                    }
                                }
                                else
                                {
                                    strResources[num56, num58, num60].RateOrTeam = 0;
                                    strResources[num56, num58, num60].number = 0;
                                    strResources[num56, num58, num60].nameValue = 0;
                                }
                            }
                        }
                        for (int num61 = resourcesPoint[num56]; num61 < 6; num61++)
                        {
                            for (int num62 = 0; num62 < 15; num62++)
                            {
                                strResources[num56, num61, num62].RateOrTeam = 0;
                                strResources[num56, num61, num62].number = 0;
                                strResources[num56, num61, num62].nameValue = 0;
                            }
                        }
                        continue;
                    }
                    resourcesPoint[num56] = 0;
                    for (int num63 = 0; num63 < 6; num63++)
                    {
                        for (int num64 = 0; num64 < 15; num64++)
                        {
                            strResources[num56, num63, num64].RateOrTeam = 0;
                            strResources[num56, num63, num64].number = 0;
                            strResources[num56, num63, num64].nameValue = 0;
                        }
                    }
                }
                if (RsrLandmassCmbBox.Items.Count > 1)
                {
                    RsrLandmassCmbBox.SelectedIndex = 1;
                    RsrPointCmbBox.Items.Clear();
                    for (int num65 = 0; num65 < resourcesPoint[1]; num65++)
                    {
                        RsrPointCmbBox.Items.Add(Language.Dictionary["questgath"]["point"] + " " + Convert.ToString((int)(num65 + 1)));
                    }
                    if (RsrPointCmbBox.Items.Count > 0)
                    {
                        RsrPointCmbBox.SelectedIndex = 0;
                    }
                    RsMININumUpD.Value = strResrPoint[1, 0].miniNum;
                    RsMAXNumUpD.Value = strResrPoint[1, 0].maxiNum;
                    int num66 = 0;
                    ResourcesListView.Items.Clear();
                    ResourcesListView.BeginUpdate();
                    for (int num67 = 0; num67 < 15; num67++)
                    {
                        ListViewItem.ListViewSubItem item10;
                        ListViewItem item9 = new ListViewItem
                        {
                            Text = Convert.ToString((int)(num67 + 1))
                        };
                        if (strResources[1, 0, num67].nameValue > 0)
                        {
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = ResouresNames[strResources[1, 0, num67].nameValue]
                            };
                            item9.SubItems.Add(item10);
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strResources[1, 0, num67].number)
                            };
                            item9.SubItems.Add(item10);
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(strResources[1, 0, num67].RateOrTeam) + " %"
                            };
                            num66 += strResources[1, 0, num67].RateOrTeam;
                            item9.SubItems.Add(item10);
                        }
                        else
                        {
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item9.SubItems.Add(item10);
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item9.SubItems.Add(item10);
                            item10 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item9.SubItems.Add(item10);
                        }
                        ResourcesListView.Items.Add(item9);
                    }
                    ResourcesListView.EndUpdate();
                    RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num66) + "%)";
                }
                else
                {
                    RsrPointCmbBox.Items.Clear();
                    ResourcesListView.Clear();
                }
                index = (byFileByte[0x1d] << 8) + byFileByte[0x1c];
                int num68 = 0;
                MaterialNumNumUpD1.Value = byFileByte[index + 4];
                MaterialNumNumUpD2.Value = byFileByte[index + 3];
                while ((byFileByte[index + (num68 * 12)] != 0xff) || (byFileByte[index + (num68 * 12)] != 0xff))
                {
                    num68++;
                }
                for (int num69 = 0; num69 < num68; num69++)
                {
                    int num70 = (byFileByte[(index + 9) + (num69 * 12)] << 8) + byFileByte[(index + 8) + (num69 * 12)];
                    bool flag3 = true;
                    for (int num71 = 0; num71 < 20; num71++)
                    {
                        if (flag3)
                        {
                            if ((byFileByte[num70 + (num71 * 6)] == 0xff) && (byFileByte[(num70 + 1) + (num71 * 6)] == 0xff))
                            {
                                flag3 = false;
                                strMaterialReward[num69, num71].RateOrTeam = 0;
                                strMaterialReward[num69, num71].nameValue = 0;
                                strMaterialReward[num69, num71].number = 0;
                            }
                            else
                            {
                                strMaterialReward[num69, num71].RateOrTeam = byFileByte[num70 + (num71 * 6)];
                                strMaterialReward[num69, num71].nameValue = (byFileByte[(num70 + 3) + (num71 * 6)] << 8) + byFileByte[(num70 + 2) + (num71 * 6)];
                                strMaterialReward[num69, num71].number = byFileByte[(num70 + 4) + (num71 * 6)];
                                if (strMaterialReward[num69, num71].number > 20)
                                {
                                    strMaterialReward[num69, num71].number = 1;
                                }
                            }
                        }
                        else
                        {
                            strMaterialReward[num69, num71].RateOrTeam = 0;
                            strMaterialReward[num69, num71].nameValue = 0;
                            strMaterialReward[num69, num71].number = 0;
                        }
                    }
                }
                for (int num72 = num68; num72 < 6; num72++)
                {
                    for (int num73 = 0; num73 < 20; num73++)
                    {
                        strMaterialReward[num72, num73].RateOrTeam = 0;
                        strMaterialReward[num72, num73].nameValue = 0;
                        strMaterialReward[num72, num73].number = 0;
                    }
                }
                MaterialListView1.Items.Clear();
                int num74 = 0;
                MaterialListView1.Items.Clear();
                MaterialListView1.BeginUpdate();
                for (int num75 = 0; num75 < 20; num75++)
                {
                    ListViewItem.ListViewSubItem item12;
                    ListViewItem item11 = new ListViewItem
                    {
                        Text = Convert.ToString((int)(num75 + 1))
                    };
                    if (strMaterialReward[0, num75].nameValue > 0)
                    {
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = ResouresNames[strMaterialReward[0, num75].nameValue]
                        };
                        item11.SubItems.Add(item12);
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strMaterialReward[0, num75].number)
                        };
                        item11.SubItems.Add(item12);
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strMaterialReward[0, num75].RateOrTeam) + " %"
                        };
                        num74 += strMaterialReward[0, num75].RateOrTeam;
                        item11.SubItems.Add(item12);
                    }
                    else
                    {
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item11.SubItems.Add(item12);
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item11.SubItems.Add(item12);
                        item12 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item11.SubItems.Add(item12);
                    }
                    MaterialListView1.Items.Add(item11);
                }
                MaterialListView1.EndUpdate();
                MtlRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num74) + "%)";
                ExpMaterialChooseCmbBox.SelectedIndex = 0;
                MaterialListView2.Items.Clear();
                int num76 = 0;
                MaterialListView2.Items.Clear();
                MaterialListView2.BeginUpdate();
                for (int num77 = 0; num77 < 10; num77++)
                {
                    ListViewItem.ListViewSubItem item14;
                    ListViewItem item13 = new ListViewItem
                    {
                        Text = Convert.ToString((int)(num77 + 1))
                    };
                    if (strMaterialReward[1, num77].nameValue > 0)
                    {
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = ResouresNames[strMaterialReward[1, num77].nameValue]
                        };
                        item13.SubItems.Add(item14);
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strMaterialReward[1, num77].number)
                        };
                        item13.SubItems.Add(item14);
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = Convert.ToString(strMaterialReward[1, num77].RateOrTeam) + " %"
                        };
                        num76 += strMaterialReward[1, num77].RateOrTeam;
                        item13.SubItems.Add(item14);
                    }
                    else
                    {
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item13.SubItems.Add(item14);
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item13.SubItems.Add(item14);
                        item14 = new ListViewItem.ListViewSubItem
                        {
                            Text = ""
                        };
                        item13.SubItems.Add(item14);
                    }
                    MaterialListView2.Items.Add(item13);
                }
                MaterialListView2.EndUpdate();
                MtlExpRateLabe.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num76) + "%)";
                chkBoxStartExercise.Enabled = true;
                if ((byFileByte[0x91] == 3) && ((byFileByte[0xcc] > 0) || (byFileByte[0xcd] > 0)))
                {
                    SymbolSet = new StcSymbolSet[5];
                    HuntersArmsSet = new StcExerciseArmsSet[5, 6];
                    ExerciseBag = new StcResources[5, 0x18];
                    index = (byFileByte[0xcd] << 8) + byFileByte[0xcc];
                    for (int num78 = 0; num78 < 5; num78++)
                    {
                        for (int num79 = 0; num79 < 6; num79++)
                        {
                            HuntersArmsSet[num78, num79].ArmsType = byFileByte[((index + 0x1d) + (12 * num79)) + (0xd0 * num78)];
                            HuntersArmsSet[num78, num79].ArmsType = (HuntersArmsSet[num78, num79].ArmsType > 10) ? (HuntersArmsSet[num78, num79].ArmsType - 1) : HuntersArmsSet[num78, num79].ArmsType;
                            HuntersArmsSet[num78, num79].ArmsNameValue = (byFileByte[(index + 0x1f) + (0xd0 * num78)] << 8) + byFileByte[((index + 30) + (12 * num79)) + (0xd0 * num78)];
                            HuntersArmsSet[num78, num79].ArmsLV = byFileByte[((index + 0x20) + (12 * num79)) + (0xd0 * num78)];
                            HuntersArmsSet[num78, num79].Bead01Value = (byFileByte[((index + 0x23) + (12 * num79)) + (0xd0 * num78)] << 8) + byFileByte[((index + 0x22) + (12 * num79)) + (0xd0 * num78)];
                            if (HuntersArmsSet[num78, num79].Bead01Value > 0)
                            {
                                StcExerciseArmsSet set1 = HuntersArmsSet[num78, num79];
                                set1.Bead01Value -= 0x32e;
                            }
                            HuntersArmsSet[num78, num79].Bead02Value = (byFileByte[((index + 0x25) + (12 * num79)) + (0xd0 * num78)] << 8) + byFileByte[((index + 0x24) + (12 * num79)) + (0xd0 * num78)];
                            if (HuntersArmsSet[num78, num79].Bead02Value > 0)
                            {
                                StcExerciseArmsSet set2 = HuntersArmsSet[num78, num79];
                                set2.Bead02Value -= 0x32e;
                            }
                            HuntersArmsSet[num78, num79].Bead03Value = (byFileByte[((index + 0x27) + (12 * num79)) + (0xd0 * num78)] << 8) + byFileByte[((index + 0x26) + (12 * num79)) + (0xd0 * num78)];
                            if (HuntersArmsSet[num78, num79].Bead03Value > 0)
                            {
                                StcExerciseArmsSet set3 = HuntersArmsSet[num78, num79];
                                set3.Bead03Value -= 0x32e;
                            }
                        }
                        if (byFileByte[(index + 0x65) + (0xd0 * num78)] == 0x65)
                        {
                            SymbolSet[num78].Type = (byFileByte[(index + 0x66) + (0xd0 * num78)] & 15) + 1;
                            SymbolSet[num78].Skill01 = byFileByte[(index + 0x68) + (0xd0 * num78)] & 0x7f;
                            SymbolSet[num78].SkillPiont1 = ((byFileByte[(index + 0x66) + (0xd0 * num78)] >> 4) + ((byFileByte[(index + 0x67) + (0xd0 * num78)] & 3) << 4)) - 30;
                            SymbolSet[num78].Skill02 = ((byFileByte[(index + 0x69) + (0xd0 * num78)] & 0x3f) << 1) + (byFileByte[(index + 0x68) + (0xd0 * num78)] >> 7);
                            SymbolSet[num78].SkillPiont2 = (byFileByte[(index + 0x67) + (0xd0 * num78)] >> 2) - 30;
                            SymbolSet[num78].Hole = byFileByte[(index + 0x69) + (0xd0 * num78)] >> 6;
                            SymbolSet[num78].Bead01Value = (byFileByte[(index + 0x6b) + (0xd0 * num78)] << 8) + byFileByte[(index + 0x6a) + (0xd0 * num78)];
                            if (SymbolSet[num78].Bead01Value > 0)
                            {
                                SymbolSet[num78].Bead01Value -= 0x32e;
                            }
                            SymbolSet[num78].Bead02Value = (byFileByte[(index + 0x6d) + (0xd0 * num78)] << 8) + byFileByte[(index + 0x6c) + (0xd0 * num78)];
                            if (SymbolSet[num78].Bead02Value > 0)
                            {
                                SymbolSet[num78].Bead02Value -= 0x32e;
                            }
                            SymbolSet[num78].Bead03Value = (byFileByte[(index + 0x6f) + (0xd0 * num78)] << 8) + byFileByte[(index + 110) + (0xd0 * num78)];
                            if (SymbolSet[num78].Bead03Value > 0)
                            {
                                SymbolSet[num78].Bead03Value -= 0x32e;
                            }
                        }
                        else
                        {
                            SymbolSet[num78].Type = 0;
                            SymbolSet[num78].Skill01 = 0;
                            SymbolSet[num78].SkillPiont1 = 0;
                            SymbolSet[num78].Skill02 = 0;
                            SymbolSet[num78].SkillPiont2 = 0;
                            SymbolSet[num78].Hole = 0;
                            SymbolSet[num78].Bead01Value = 0;
                            SymbolSet[num78].Bead02Value = 0;
                            SymbolSet[num78].Bead03Value = 0;
                        }
                        for (int num80 = 0; num80 < 0x18; num80++)
                        {
                            ExerciseBag[num78, num80].nameValue = (byFileByte[((index + 0x71) + (4 * num80)) + (0xd0 * num78)] << 8) + byFileByte[((index + 0x70) + (4 * num80)) + (0xd0 * num78)];
                            ExerciseBag[num78, num80].number = byFileByte[((index + 0x72) + (4 * num80)) + (0xd0 * num78)];
                        }
                    }
                    chkBoxStartExercise.Checked = true;
                    cmbBoxHunterNumber.SelectedIndex = byFileByte[index] - 1;
                    int num81 = ((byFileByte[index + 5] << 8) + byFileByte[index + 4]) / 3;
                    numUpDnEstimateSS1.Value = num81 / 60;
                    numUpDnEstimateSS2.Value = num81 % 60;
                    num81 = ((byFileByte[index + 9] << 8) + byFileByte[index + 8]) / 3;
                    numUpDnEstimateS1.Value = num81 / 60;
                    numUpDnEstimateS2.Value = num81 % 60;
                    num81 = ((byFileByte[index + 13] << 8) + byFileByte[index + 12]) / 3;
                    numUpDnEstimateA1.Value = num81 / 60;
                    numUpDnEstimateA2.Value = num81 % 60;
                    numUpDnEstimatePtS.Value = (byFileByte[index + 0x11] << 8) + byFileByte[index + 0x10];
                    numUpDnEstimatePtA.Value = (byFileByte[index + 0x15] << 8) + byFileByte[index + 20];
                    numUpDnEstimatePtB.Value = (byFileByte[index + 0x19] << 8) + byFileByte[index + 0x18];
                    TrainingWeaponInit();
                    TrainingArmsInit();
                    rdBtnArmor1.Checked = true;
                }
                else
                {
                    chkBoxStartExercise.Checked = false;
                }
            }
        }

        private void UpdataArmor(int index)
        {
            if (chkBoxStartExercise.Checked && ((HuntersArmsSet != null) && (WeaponData != null)))
            {
                if (HuntersArmsSet[index, 0].ArmsType < 5)
                {
                    HuntersArmsSet[index, 0].ArmsType = 5;
                }
                cmbBoxWeaponType.SelectedIndex = HuntersArmsSet[index, 0].ArmsType - 5;
                if (((cmbBoxWeaponType.SelectedIndex == 4) || (cmbBoxWeaponType.SelectedIndex == 5)) || (cmbBoxWeaponType.SelectedIndex == 9))
                {
                    string str = "Long-range";
                    if (str != WeaponRange)
                    {
                        WeaponRange = "Long-range";
                        TrainingArmsInit();
                    }
                }
                else
                {
                    string str2 = "Short-range";
                    if (str2 != WeaponRange)
                    {
                        WeaponRange = "Short-range";
                        TrainingArmsInit();
                    }
                }
                cmbBoxWeaponName.Items.Clear();
                for (int i = 0; i < 0x100; i++)
                {
                    if ((WeaponData[cmbBoxWeaponType.SelectedIndex, i].Name == null) || (WeaponData[cmbBoxWeaponType.SelectedIndex, i].Name == ""))
                    {
                        break;
                    }
                    cmbBoxWeaponName.Items.Add(WeaponData[cmbBoxWeaponType.SelectedIndex, i].Name);
                }
                if (cmbBoxWeaponName.Items.Count > 0)
                {
                    if (HuntersArmsSet[index, 0].ArmsNameValue <= cmbBoxWeaponName.Items.Count)
                    {
                        cmbBoxWeaponName.SelectedIndex = HuntersArmsSet[index, 0].ArmsNameValue;
                    }
                    else
                    {
                        HuntersArmsSet[index, 0].ArmsNameValue = cmbBoxWeaponName.Items.Count - 1;
                        cmbBoxWeaponName.SelectedIndex = HuntersArmsSet[index, 0].ArmsNameValue;
                    }
                }
                else
                {
                    HuntersArmsSet[index, 0].ArmsNameValue = 1;
                    cmbBoxWeaponName.SelectedIndex = HuntersArmsSet[index, 0].ArmsNameValue;
                }
                if ((HuntersArmsSet[index, 0].ArmsLV & 1) == 1)
                {
                    chkBoxWeaponStrength.Checked = true;
                }
                else
                {
                    chkBoxWeaponStrength.Checked = false;
                }
                if (cmbBoxWeaponType.SelectedIndex == 4)
                {
                    rdBtnWeaponStrength1.Visible = true;
                    rdBtnWeaponStrength2.Visible = true;
                    rdBtnWeaponStrength3.Visible = true;
                    if ((HuntersArmsSet[index, 0].ArmsLV & 0x20) == 0x20)
                    {
                        rdBtnWeaponStrength2.Checked = true;
                    }
                    else if ((HuntersArmsSet[index, 0].ArmsLV & 0x80) == 0x80)
                    {
                        rdBtnWeaponStrength3.Checked = true;
                    }
                    else
                    {
                        rdBtnWeaponStrength1.Checked = true;
                    }
                }
                else if (cmbBoxWeaponType.SelectedIndex == 5)
                {
                    rdBtnWeaponStrength1.Visible = true;
                    rdBtnWeaponStrength2.Visible = true;
                    rdBtnWeaponStrength3.Visible = true;
                    if ((HuntersArmsSet[index, 0].ArmsLV & 0x20) == 0x20)
                    {
                        rdBtnWeaponStrength2.Checked = true;
                    }
                    else if ((HuntersArmsSet[index, 0].ArmsLV & 0x10) == 0x10)
                    {
                        rdBtnWeaponStrength3.Checked = true;
                    }
                    else
                    {
                        rdBtnWeaponStrength1.Checked = true;
                    }
                }
                else
                {
                    rdBtnWeaponStrength1.Visible = false;
                    rdBtnWeaponStrength2.Visible = false;
                    rdBtnWeaponStrength3.Visible = false;
                }
                cmbBoxBody.Text = ArmorData[0, HuntersArmsSet[index, 1].ArmsNameValue].Name;
                cmbBoxArm.Text = ArmorData[1, HuntersArmsSet[index, 2].ArmsNameValue].Name;
                cmbBoxWaist.Text = ArmorData[2, HuntersArmsSet[index, 3].ArmsNameValue].Name;
                cmbBoxLeg.Text = ArmorData[3, HuntersArmsSet[index, 4].ArmsNameValue].Name;
                cmbBoxHead.Text = ArmorData[4, HuntersArmsSet[index, 5].ArmsNameValue].Name;
                numUpDnBodyLV.Value = HuntersArmsSet[index, 1].ArmsLV + 1;
                numUpDnArmLV.Value = HuntersArmsSet[index, 2].ArmsLV + 1;
                numUpDnWaistLV.Value = HuntersArmsSet[index, 3].ArmsLV + 1;
                numUpDnLegLV.Value = HuntersArmsSet[index, 4].ArmsLV + 1;
                numUpDnHeadLV.Value = HuntersArmsSet[index, 5].ArmsLV + 1;
                for (int j = 0; j < 6; j++)
                {
                    byte hole;
                    switch (j)
                    {
                        case 0:
                            hole = WeaponData[HuntersArmsSet[index, 0].ArmsType - 5, HuntersArmsSet[index, 0].ArmsNameValue].Hole;
                            break;

                        case 1:
                            hole = ArmorData[0, HuntersArmsSet[index, 1].ArmsNameValue].Hole;
                            break;

                        case 2:
                            hole = ArmorData[1, HuntersArmsSet[index, 2].ArmsNameValue].Hole;
                            break;

                        case 3:
                            hole = ArmorData[2, HuntersArmsSet[index, 3].ArmsNameValue].Hole;
                            break;

                        case 4:
                            hole = ArmorData[3, HuntersArmsSet[index, 4].ArmsNameValue].Hole;
                            break;

                        case 5:
                            hole = ArmorData[4, HuntersArmsSet[index, 5].ArmsNameValue].Hole;
                            break;

                        default:
                            hole = 0xff;
                            break;
                    }
                    switch (hole)
                    {
                        case 0:
                            textBeadName[j, 0].Text = "-";
                            textBeadName[j, 1].Text = "-";
                            textBeadName[j, 2].Text = "-";
                            HuntersArmsSet[index, j].Bead01Value = 0;
                            HuntersArmsSet[index, j].Bead02Value = 0;
                            HuntersArmsSet[index, j].Bead03Value = 0;
                            break;

                        case 1:
                            textBeadName[j, 0].Text = Beads[HuntersArmsSet[index, j].Bead01Value].Name;
                            textBeadName[j, 1].Text = "-";
                            textBeadName[j, 2].Text = "-";
                            HuntersArmsSet[index, j].Bead02Value = 0;
                            HuntersArmsSet[index, j].Bead03Value = 0;
                            break;

                        case 2:
                            textBeadName[j, 0].Text = Beads[HuntersArmsSet[index, j].Bead01Value].Name;
                            textBeadName[j, 1].Text = Beads[HuntersArmsSet[index, j].Bead02Value].Name;
                            textBeadName[j, 2].Text = "-";
                            HuntersArmsSet[index, j].Bead03Value = 0;
                            break;

                        case 3:
                            textBeadName[j, 0].Text = Beads[HuntersArmsSet[index, j].Bead01Value].Name;
                            textBeadName[j, 1].Text = Beads[HuntersArmsSet[index, j].Bead02Value].Name;
                            textBeadName[j, 2].Text = Beads[HuntersArmsSet[index, j].Bead03Value].Name;
                            break;
                    }
                }
                cmbBoxSymbolType.SelectedIndex = SymbolSet[index].Type;
                cmbBoxSymbolHole.SelectedIndex = SymbolSet[index].Hole;
                cmbBoxSymbolList01.SelectedIndex = SymbolSet[index].Skill01;
                numUpDnSkillPiont01.Value = SymbolSet[index].SkillPiont1;
                cmbBoxSymbolList02.SelectedIndex = SymbolSet[index].Skill02;
                numUpDnSkillPiont02.Value = SymbolSet[index].SkillPiont2;
                switch (SymbolSet[index].Hole)
                {
                    case 0:
                        textBeadName[6, 0].Text = "-";
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[index].Bead01Value = 0;
                        SymbolSet[index].Bead02Value = 0;
                        SymbolSet[index].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[index].Bead02Value = 0;
                        SymbolSet[index].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[index].Bead02Value].Name;
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[index].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[index].Bead02Value].Name;
                        textBeadName[6, 2].Text = Beads[SymbolSet[index].Bead03Value].Name;
                        return;
                }
            }
        }

        private void UpdataBag(int index)
        {
            if (chkBoxStartExercise.Checked)
            {
                if (listViewBag.Items.Count < 0x18)
                {
                    listViewBag.Items.Clear();
                    listViewBag.BeginUpdate();
                    for (int i = 0; i < 0x18; i++)
                    {
                        ListViewItem.ListViewSubItem item2;
                        ListViewItem item = new ListViewItem
                        {
                            Text = Convert.ToString((int)(i + 1))
                        };
                        if (ExerciseBag[index, i].nameValue > 0)
                        {
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = ResouresNames[ExerciseBag[index, i].nameValue]
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = Convert.ToString(ExerciseBag[index, i].number)
                            };
                            item.SubItems.Add(item2);
                        }
                        else
                        {
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item.SubItems.Add(item2);
                            item2 = new ListViewItem.ListViewSubItem
                            {
                                Text = ""
                            };
                            item.SubItems.Add(item2);
                        }
                        listViewBag.Items.Add(item);
                    }
                    listViewBag.EndUpdate();
                }
                else
                {
                    for (int j = 0; j < 0x18; j++)
                    {
                        if (ExerciseBag[index, j].nameValue > 0)
                        {
                            listViewBag.Items[j].SubItems[1].Text = ResouresNames[ExerciseBag[index, j].nameValue];
                            listViewBag.Items[j].SubItems[2].Text = Convert.ToString(ExerciseBag[index, j].number);
                        }
                        else
                        {
                            listViewBag.Items[j].SubItems[1].Text = "";
                            listViewBag.Items[j].SubItems[2].Text = "";
                        }
                    }
                }
                EditToolState = "Wait...";
                numUpDnBagSN.Value = 1M;
                cmbBoxBagName.Text = ResouresNames[ExerciseBag[index, 0].nameValue];
                numUpDnBagNum.Value = ExerciseBag[index, 0].number;
                listViewBag.Items[0].EnsureVisible();
                EditToolState = "Open";
            }
        }

        private void UpdataSymbol(int index)
        {
            if (chkBoxStartExercise.Checked)
            {
                cmbBoxSymbolType.SelectedIndex = SymbolSet[index].Type;
                cmbBoxSymbolList01.SelectedIndex = SymbolSet[index].Skill01;
                numUpDnSkillPiont01.Value = SymbolSet[index].SkillPiont1;
                cmbBoxSymbolList02.SelectedIndex = SymbolSet[index].Skill02;
                numUpDnSkillPiont02.Value = SymbolSet[index].SkillPiont2;
                cmbBoxSymbolHole.SelectedIndex = SymbolSet[index].Hole;
                switch (SymbolSet[index].Hole)
                {
                    case 0:
                        textBeadName[6, 0].Text = "-";
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        return;

                    case 1:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        return;

                    case 2:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[index].Bead02Value].Name;
                        textBeadName[6, 2].Text = "-";
                        return;

                    case 3:
                        textBeadName[6, 0].Text = Beads[SymbolSet[index].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[index].Bead02Value].Name;
                        textBeadName[6, 2].Text = Beads[SymbolSet[index].Bead03Value].Name;
                        return;
                }
            }
        }

        #endregion

        #region Initializers
        
        private void ResourceControlInit()
        {
            VicyTermCmbBox1.Items.Clear();
            VicyTermCmbBox2.Items.Clear();
            BossNameCmbBox.Items.Clear();
            DfNameCmbBox.Items.Clear();
            DfAddCmbBox1.Items.Clear();
            DfAddCmbBox2.Items.Clear();
            MonsterIconCmbBox1.Items.Clear();
            MonsterIconCmbBox2.Items.Clear();
            MonsterIconCmbBox3.Items.Clear();
            MonsterIconCmbBox4.Items.Clear();
            MonsterIconCmbBox5.Items.Clear();
            CmbBoxConditionsRation.Items.Clear();
            cmbBoxBagName.Items.Clear();
            MapTimeCmbBox.Visible = false;
            for (int i = 0; i < strMonsterNames.Length; i++)
            {
                if ((i < 0x45) && (DataClass.strMonsterNamesType[i] != 2))
                {
                    VicyTermCmbBox1.Items.Add(strMonsterNames[i]);
                    VicyTermCmbBox2.Items.Add(strMonsterNames[i]);
                    CmbBoxConditionsRation.Items.Add(strMonsterNames[i]);
                    DfAddCmbBox1.Items.Add(strMonsterNames[i]);
                    DfAddCmbBox2.Items.Add(strMonsterNames[i]);
                    if (i < 0x42)
                    {
                        MonsterIconCmbBox1.Items.Add(strMonsterNames[i]);
                        MonsterIconCmbBox2.Items.Add(strMonsterNames[i]);
                        MonsterIconCmbBox3.Items.Add(strMonsterNames[i]);
                        MonsterIconCmbBox4.Items.Add(strMonsterNames[i]);
                        MonsterIconCmbBox5.Items.Add(strMonsterNames[i]);
                    }
                }
                if ((DataClass.strMonsterNamesType[i] == 0) || (DataClass.strMonsterNamesType[i] == 0xff))
                {
                    DfNameCmbBox.Items.Add(strMonsterNames[i]);
                }
                if ((DataClass.strMonsterNamesType[i] == 1) || (DataClass.strMonsterNamesType[i] == 0xff))
                {
                    BossNameCmbBox.Items.Add(strMonsterNames[i]);
                }
            }
            MonsterIconCmbBox1.Items.Add("------");
            MonsterIconCmbBox2.Items.Add("------");
            MonsterIconCmbBox3.Items.Add("------");
            MonsterIconCmbBox4.Items.Add("------");
            MonsterIconCmbBox5.Items.Add("------");
            MonsterIconCmbBox1.Items.Add(Language.Dictionary["game"]["instructors"]);
            MonsterIconCmbBox2.Items.Add(Language.Dictionary["game"]["instructors"]);
            MonsterIconCmbBox3.Items.Add(Language.Dictionary["game"]["instructors"]);
            MonsterIconCmbBox4.Items.Add(Language.Dictionary["game"]["instructors"]);
            MonsterIconCmbBox5.Items.Add(Language.Dictionary["game"]["instructors"]);
            MonsterIconCmbBox1.Items.Add(Language.Dictionary["game"]["flag"]);
            MonsterIconCmbBox2.Items.Add(Language.Dictionary["game"]["flag"]);
            MonsterIconCmbBox3.Items.Add(Language.Dictionary["game"]["flag"]);
            MonsterIconCmbBox4.Items.Add(Language.Dictionary["game"]["flag"]);
            MonsterIconCmbBox5.Items.Add(Language.Dictionary["game"]["flag"]);
            MonsterIconCmbBox1.Items.Add(Language.Dictionary["game"]["itembox"]);
            MonsterIconCmbBox2.Items.Add(Language.Dictionary["game"]["itembox"]);
            MonsterIconCmbBox3.Items.Add(Language.Dictionary["game"]["itembox"]);
            MonsterIconCmbBox4.Items.Add(Language.Dictionary["game"]["itembox"]);
            MonsterIconCmbBox5.Items.Add(Language.Dictionary["game"]["itembox"]);
            VicyTermCmbBox1.Items.Add(ResouresNames[0]);
            VicyTermCmbBox2.Items.Add(ResouresNames[0]);
            DfAddCmbBox1.Items.Add(ResouresNames[0]);
            DfAddCmbBox2.Items.Add(ResouresNames[0]);
            for (int j = 8; j < 0x253; j++)
            {
                VicyTermCmbBox1.Items.Add(ResouresNames[j]);
                VicyTermCmbBox2.Items.Add(ResouresNames[j]);
                DfAddCmbBox1.Items.Add(ResouresNames[j]);
                DfAddCmbBox2.Items.Add(ResouresNames[j]);
            }
            VicyTermCmbBox1.Items.Add(ResouresNames[0x29f]);
            VicyTermCmbBox2.Items.Add(ResouresNames[0x29f]);
            VicyTermCmbBox1.Items.Add(ResouresNames[0x2a3]);
            VicyTermCmbBox2.Items.Add(ResouresNames[0x2a3]);
            for (int k = 0x2ae; k < 0x2dd; k++)
            {
                VicyTermCmbBox1.Items.Add(ResouresNames[k]);
                VicyTermCmbBox2.Items.Add(ResouresNames[k]);
                DfAddCmbBox1.Items.Add(ResouresNames[k]);
                DfAddCmbBox2.Items.Add(ResouresNames[k]);
            }
            BaseCmbBox.Items.Clear();
            BaseCmbBox.Items.Add(ResouresNames[0]);
            for (int m = 1; m < ResouresNames.Length; m++)
            {
                if ((DataClass.ResouresType[m] & 2) == 2)
                {
                    BaseCmbBox.Items.Add(ResouresNames[m]);
                }
            }
            cmbBoxBagName.Items.Add(ResouresNames[0]);
            for (int n = 1; n < 0x2ad; n++)
            {
                if ((DataClass.ResouresType[n] & 8) == 8)
                {
                    cmbBoxBagName.Items.Add(ResouresNames[n]);
                }
            }
            if (cmbBoxSymbolList01.Items.Count < DataClass.strSkillSystem.Length)
            {
                cmbBoxSymbolList01.Items.Clear();
                for (int num6 = 0; num6 < DataClass.strSkillSystem.Length; num6++)
                {
                    cmbBoxSymbolList01.Items.Add(DataClass.strSkillSystem[num6]);
                }
            }
            if (cmbBoxSymbolList02.Items.Count < DataClass.strSkillSystem.Length)
            {
                cmbBoxSymbolList02.Items.Clear();
                for (int num7 = 0; num7 < DataClass.strSkillSystem.Length; num7++)
                {
                    cmbBoxSymbolList02.Items.Add(DataClass.strSkillSystem[num7]);
                }
            }
            if (SkillSysStart == null)
            {
                SkillSysStart = new StcSkillStart[210];
                MemoryStream rms = new MemoryStream(GameData.SkillList);
                StreamReader reader = new StreamReader(rms, Encoding.UTF8);
                string str = reader.ReadLine();
                SkillSysStart[0].SkillName = Language.Dictionary["skills"]["0"];
                SkillSysStart[0].SkillSystem = Language.Dictionary["skills"]["0"];
                for (int counter = 1; counter < SkillSysStart.Length; counter++)
                {
                    str = reader.ReadLine();
                    if ((str == null) || !(str.Trim() != ""))
                    {
                        break;
                    }
                    string[] strArray = str.Split(new char[] { ',' });
                    SkillSysStart[counter].SkillName = Language.Dictionary["skills"][counter.ToString()].Trim();
                    SkillSysStart[counter].SkillSystem = strArray[1].Trim();
                    SkillSysStart[counter].StartPoint = Convert.ToInt16(strArray[2].Trim());
                }
                reader.Close();
                rms.Close();
            }
            if (Beads == null)
            {
                Beads = new StcBeads[0xa5];
                MemoryStream rms = new MemoryStream(GameData.Decorations);
                StreamReader reader2 = new StreamReader(rms, Encoding.UTF8);
                string str3 = reader2.ReadLine();
                Beads[0].Name = "O";
                Beads[0].Hole = 0;
                for (int counter = 1; counter < 0xa5; counter++)
                {
                    str3 = reader2.ReadLine();
                    if ((str3 == null) || !(str3.Trim() != ""))
                    {
                        break;
                    }
                    string[] strArray2 = str3.Split(new char[] { ',' });
                    Beads[counter].Name = Language.Dictionary["decorations"][counter.ToString()].Trim();
                    Beads[counter].Hole = Convert.ToInt16(strArray2[1].Trim());
                    Beads[counter].SkillSys1 = strArray2[2].Trim();
                    Beads[counter].SkillPoint1 = Convert.ToInt16(strArray2[3].Trim());
                    Beads[counter].SkillSys2 = strArray2[4].Trim();
                    if (Beads[counter].SkillSys2 != "")
                    {
                        Beads[counter].SkillPoint2 = Convert.ToInt16(strArray2[5].Trim());
                    }
                    else
                    {
                        Beads[counter].SkillPoint2 = 0;
                    }
                    if (Beads[counter].SkillSys2 == "")
                        Beads[counter].SkillSys2 = " ";
                }
                reader2.Close();
                rms.Close();
                cmbBoxFloatBeadInput.Items.Clear();
                cmbBoxFloatBeadInputAmulet.Items.Clear();
                for (int num10 = 0; num10 < 0xa5; num10++)
                {
                    cmbBoxFloatBeadInput.Items.Add(Beads[num10].Name);
                    cmbBoxFloatBeadInputAmulet.Items.Add(Beads[num10].Name);
                }
            }
        }

        private void ResouresDataInit()
        {
            ResNameCmbBox.Items.Clear();
            MaterialNameCmbBox.Items.Clear();
            ResNameCmbBox.Items.Add(ResouresNames[0]);
            MaterialNameCmbBox.Items.Add(ResouresNames[0]);
            for (int i = 1; i < ResouresNames.Length; i++)
            {
                if ((DataClass.ResouresType[i] & 1) == 1)
                {
                    ResNameCmbBox.Items.Add(ResouresNames[i]);
                }
                if (((DataClass.ResouresType[i] & 4) == 4) || (((DataClass.ResouresType[i] >> 4) & 1) == 1))
                {
                    MaterialNameCmbBox.Items.Add(ResouresNames[i]);
                }
            }
        }

        private void TrainingWeaponInit()
        {
            if (WeaponData == null)
            {
                WeaponData = new stcWeapon[12, 0x100];
                for (int i = 0; i < 12; i++)
                {
                    string dict = "";
                    MemoryStream rms = null;
                    switch (i)
                    {
                        case 0:
                            rms = new MemoryStream(GameData.greatswords);
                            dict = "greatswords";
                            break;

                        case 1:
                            rms = new MemoryStream(GameData.shieldandswords);
                            dict = "shieldandswords";
                            break;

                        case 2:
                            rms = new MemoryStream(GameData.hammers);
                            dict = "hammers";
                            break;

                        case 3:
                            rms = new MemoryStream(GameData.lances);
                            dict = "lances";
                            break;

                        case 4:
                            rms = new MemoryStream(GameData.heavygun);
                            dict = "heavygun";
                            break;

                        case 5:
                            rms = new MemoryStream(GameData.lightgun);
                            dict = "lightgun";
                            break;

                        case 6:
                            rms = new MemoryStream(GameData.longswords);
                            dict = "longswords";
                            break;

                        case 7:
                            rms = new MemoryStream(GameData.axes);
                            dict = "axes";
                            break;

                        case 8:
                            rms = new MemoryStream(GameData.gunlances);
                            dict = "gunlances";
                            break;

                        case 9:
                            rms = new MemoryStream(GameData.bows);
                            dict = "bows";
                            break;

                        case 10:
                            rms = new MemoryStream(GameData.dualswords);
                            dict = "dualswords";
                            break;

                        case 11:
                            rms = new MemoryStream(GameData.horns);
                            dict = "horns";
                            break;

                        default:
                            break;
                    }

                    StreamReader reader = new StreamReader(rms, Encoding.Default);
                    string[] strArray = reader.ReadLine().Split(new char[] { ',' });
                    WeaponData[i, 0].Name = "-";
                    WeaponData[i, 0].StateAtt = "";
                    WeaponData[i, 0].Other = "";
                    for (int j = 1; j < 0x100; j++)
                    {
                        string currLine = reader.ReadLine();
                        if ((currLine == null) || !(currLine.Trim() != ""))
                            break;

                        strArray = currLine.Split(new char[] { ',' });
                        WeaponData[i, j].Name = Language.Dictionary[dict][j.ToString()];
                        if (strArray[1] != "")
                            WeaponData[i, j].Hole = Convert.ToByte(strArray[1]);
                        else
                            WeaponData[i, j].Hole = 0;

                        if (strArray[2] != "")
                            WeaponData[i, j].Attack = Convert.ToInt16(strArray[2]);
                        else
                            WeaponData[i, j].Attack = 0;

                        if (strArray[3] != "")
                            WeaponData[i, j].StateAtt = strArray[3];
                        else
                            WeaponData[i, j].StateAtt = " ";

                        if (strArray[4] != "")
                            WeaponData[i, j].BreakRate = Convert.ToInt16(strArray[4]);
                        else
                            WeaponData[i, j].BreakRate = 0;

                        if (strArray[5] != "")
                            WeaponData[i, j].Other = strArray[5];
                        else
                            WeaponData[i, j].Other = "?";
                    }
                    reader.Close();
                    rms.Close();
                }
            }
        }

        private void TrainingArmsInit()
        {
            if (ArmorData == null)
            {
                ArmorData = new StcArms[5, 0x100];
                for (int j = 0; j < 5; j++)
                {
                    string dict = "";
                    MemoryStream rms;
                    switch (j)
                    {
                        case 0:
                            rms = new MemoryStream(GameData.Plates);
                            dict = "plates";
                            break;

                        case 1:
                            rms = new MemoryStream(GameData.Arms);
                            dict = "arms";
                            break;

                        case 2:
                            rms = new MemoryStream(GameData.Waists);
                            dict = "waists";
                            break;

                        case 3:
                            rms = new MemoryStream(GameData.Legs);
                            dict = "legs";
                            break;

                        case 4:
                            rms = new MemoryStream(GameData.Helms);
                            dict = "helms";
                            break;

                        default:
                            return;
                    }
                    StreamReader reader = new StreamReader(rms, Encoding.Default);
                    string str2 = reader.ReadLine();
                    ArmorData[j, 0].Name = Language.Dictionary[dict]["0"];
                    for (int k = 1; k < 0x100; k++)
                    {
                        str2 = reader.ReadLine();
                        if ((str2 != null) && (str2.Trim() != ""))
                        {
                            string[] strArray = str2.Split(new char[] { ',' });
                            ArmorData[j, k].Name = Language.Dictionary[dict][k.ToString()];

                            ArmorData[j, k].Type = Convert.ToByte((int)(Convert.ToByte(strArray[1]) + (Convert.ToByte(strArray[2]) << 4)));
                            ArmorData[j, k].Hole = Convert.ToByte(strArray[3]);
                            ArmorData[j, k].Defense = Convert.ToInt16(strArray[4]);
                            ArmorData[j, k].SkillSys1 = strArray[5].Trim();
                            if (strArray[6] != "")
                                ArmorData[j, k].SkillPoint1 = Convert.ToInt16(strArray[6]);
                            else
                                ArmorData[j, k].SkillPoint1 = 0;

                            ArmorData[j, k].SkillSys2 = strArray[7].Trim();
                            if (strArray[8] != "")
                                ArmorData[j, k].SkillPoint2 = Convert.ToInt16(strArray[8]);
                            else
                                ArmorData[j, k].SkillPoint2 = 0;

                            ArmorData[j, k].SkillSys3 = strArray[9].Trim();
                            if (strArray[10] != "")
                                ArmorData[j, k].SkillPoint3 = Convert.ToInt16(strArray[10]);
                            else
                                ArmorData[j, k].SkillPoint3 = 0;

                            ArmorData[j, k].SkillSys4 = strArray[11].Trim();
                            if (strArray[12] != "")
                                ArmorData[j, k].SkillPoint4 = Convert.ToInt16(strArray[12]);
                            else
                                ArmorData[j, k].SkillPoint4 = 0;
                        }
                        else
                            ArmorData[j, k].Name = "";
                    }
                    reader.Close();
                    rms.Close();
                }
            }
            cmbBoxBody.Items.Clear();
            cmbBoxArm.Items.Clear();
            cmbBoxWaist.Items.Clear();
            cmbBoxLeg.Items.Clear();
            cmbBoxHead.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int m = 0; m < 0x100; m++)
                {
                    if (ArmorData[i, m].Name != "")
                    {
                        if (WeaponRange == "Short-range")
                        {
                            if (((ArmorData[i, m].Type & 3) == 0) && (((ArmorData[i, m].Type >> 4) & 2) != 2))
                            {
                                switch (i)
                                {
                                    case 0:
                                        cmbBoxBody.Items.Add(ArmorData[0, m].Name);
                                        break;

                                    case 1:
                                        cmbBoxArm.Items.Add(ArmorData[1, m].Name);
                                        break;

                                    case 2:
                                        cmbBoxWaist.Items.Add(ArmorData[2, m].Name);
                                        break;

                                    case 3:
                                        cmbBoxLeg.Items.Add(ArmorData[3, m].Name);
                                        break;

                                    case 4:
                                        cmbBoxHead.Items.Add(ArmorData[4, m].Name);
                                        break;
                                }
                            }
                        }
                        else if (((ArmorData[i, m].Type & 3) == 0) && (((ArmorData[i, m].Type >> 4) & 1) != 1))
                        {
                            switch (i)
                            {
                                case 0:
                                    cmbBoxBody.Items.Add(ArmorData[0, m].Name);
                                    break;

                                case 1:
                                    cmbBoxArm.Items.Add(ArmorData[1, m].Name);
                                    break;

                                case 2:
                                    cmbBoxWaist.Items.Add(ArmorData[2, m].Name);
                                    break;

                                case 3:
                                    cmbBoxLeg.Items.Add(ArmorData[3, m].Name);
                                    break;

                                case 4:
                                    cmbBoxHead.Items.Add(ArmorData[4, m].Name);
                                    break;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        private int SaveTaskFile(string DestinationFileType, string DestinationFilename)
        {
            int num6;
            int num7;
            bool flag2;
            bool flag4;

            if (DestinationFilename == "")
            {
                return 0;
            }
            if ((VicyTermCmbBox1.SelectedIndex <= 0) || (VicyTermCmbBox1.SelectedIndex == 0x42))
            {
                MessageBox.Show(Language.Dictionary["messages"]["insertgoal"], "QS3 » CQE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (chkBoxStartExercise.Checked && ((DestinationFileType.ToLower() != "mis") && (DestinationFileType.ToLower() != "mib") && (DestinationFileType.ToLower() != "cqs")))
            {
                MessageBox.Show(Language.Dictionary["messages"]["challengesupport"], "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                return 0;
            }

            byte[] array = new byte[0x5fd0];
            int index = 0;
            int num2 = 0;
            string str = "40B467099400000076303035";
            if (DestinationFileType.ToLower() == "pat")
            {
                for (int num3 = 0; num3 < 12; num3++)
                {
                    array[num3] = Convert.ToByte(str.Substring(num3 * 2, 2), 0x10);
                }
                num2 = 4;
            }
            else
            {
                for (int num4 = 0; num4 < 8; num4++)
                {
                    array[num4] = Convert.ToByte(str.Substring(8 + (num4 * 2), 2), 0x10);
                }
                num2 = 0;
            }
            if (RadioBtnConditionsRation.Checked)
            {
                array[num2 + 20] = 2;
                array[num2 + 0x15] = 2;
                for (int num5 = 0; num5 < strMonsterNames.Length; num5++)
                {
                    if (strMonsterNames[num5] == CmbBoxConditionsRation.Text)
                    {
                        array[num2 + 0x16] = Convert.ToByte(num5);
                        break;
                    }
                }
                array[num2 + 0x18] = Convert.ToByte(ConditionsRationCmbBoxNumUpD.Value);
            }
            array[num2 + 0x58] = Convert.ToByte(DfVolumeNumUpD.Value);
            array[num2 + 0x5b] = Convert.ToByte(DfGradeNumUpDown.Value);
            array[num2 + 0x5c] = Convert.ToByte(DfAttackNumUpDown.Value);
            array[num2 + 0x5d] = Convert.ToByte(DfDefenseNumUpDown.Value);
            array[num2 + 0x5e] = Convert.ToByte(NumUpDownDfEndurance.Value);
            array[num2 + 0x7c] = Convert.ToByte((int)(Convert.ToInt32(UnionNumUpDown.Value) & 0xff));
            array[num2 + 0x7d] = Convert.ToByte((int)(Convert.ToInt32(UnionNumUpDown.Value) >> 8));
            array[num2 + 0x80] = 15;
            if (chkBoxDouNoTimeToDefer.Checked)
            {
                array[num2 + 140] = Convert.ToByte(numUpDnDouNoTimeToDefer.Value);
            }
            if (!CaiYeChkBox.Checked && !CatChkBox.Checked)
            {
                array[num2 + 150] = 0x20;
            }
            else if (CaiYeChkBox.Checked && CatChkBox.Checked)
            {
                array[num2 + 150] = 0x40;
            }
            else if (!CaiYeChkBox.Checked && CatChkBox.Checked)
            {
                array[num2 + 150] = 0;
            }
            else
            {
                array[num2 + 150] = 0;
            }
            array[num2 + 0x98] = Convert.ToByte((int)(Convert.ToInt32(ContractNumUpDown.Value) & 0xff));
            array[num2 + 0x99] = Convert.ToByte((int)(Convert.ToInt32(ContractNumUpDown.Value) >> 8));
            if ((RemuntNumUpDown.Value % CatCarNumUpDown.Value) != 0M)
            {
                RemuntNumUpDown.Value -= RemuntNumUpDown.Value % CatCarNumUpDown.Value;
            }
            array[num2 + 0x9c] = Convert.ToByte((int)(Convert.ToInt32(RemuntNumUpDown.Value) & 0xff));
            array[num2 + 0x9d] = Convert.ToByte((int)(Convert.ToInt32(RemuntNumUpDown.Value) >> 8));
            array[num2 + 160] = Convert.ToByte((int)(Convert.ToInt32((decimal)(RemuntNumUpDown.Value / CatCarNumUpDown.Value)) & 0xff));
            array[num2 + 0xa1] = Convert.ToByte((int)(Convert.ToInt32((decimal)(RemuntNumUpDown.Value / CatCarNumUpDown.Value)) >> 8));
            array[num2 + 0xa4] = Convert.ToByte((int)(Convert.ToInt32((decimal)(TimeNumUpDown.Value * 1800M)) & 0xff));
            array[num2 + 0xa5] = Convert.ToByte((int)((Convert.ToInt32((decimal)(TimeNumUpDown.Value * 1800M)) & 0xff00) >> 8));
            array[num2 + 0xa6] = Convert.ToByte((int)(Convert.ToInt32((decimal)(TimeNumUpDown.Value * 1800M)) >> 0x10));
            array[num2 + 0xb0] = Convert.ToByte((int)(Convert.ToInt32(SN_NumUpDown.Value) & 0xff));
            array[num2 + 0xb1] = Convert.ToByte((int)(Convert.ToInt32(SN_NumUpDown.Value) >> 8));
            array[num2 + 0xb2] = Convert.ToByte((int)(StarGradeCmbBox.SelectedIndex + 1));
            if (chkBoxBOSSJUMP.Checked)
            {
                array[num2 + 12] = 1;
                array[num2 + 13] = 1;
            }
            if (chkBoxStartExercise.Checked)
            {
                array[num2 + 0x91] = 3;
                array[num2 + 0x92] = 1;
                array[num2 + 0x93] = 0;
            }
            else if (array[num2 + 0xb2] <= 5)
            {
                array[num2 + 0x91] = 1;
                array[num2 + 0x92] = 1;
                array[num2 + 0x93] = 0;
            }
            else
            {
                array[num2 + 0x91] = 2;
                array[num2 + 0x92] = 2;
                array[num2 + 0x93] = Convert.ToByte(LandingCmbBox.SelectedIndex);
            }
            if (array[num2 + 0xb2] <= 5)
            {
                array[num2 + 0xb5] = Convert.ToByte(OpenLimitCmbBox1.SelectedIndex);
                if (OpenLimitCmbBox2.SelectedIndex > 0)
                {
                    array[num2 + 0xb6] = Convert.ToByte((int)(OpenLimitCmbBox2.SelectedIndex + 5));
                }
            }
            else if (OpenLimitCmbBox1.SelectedIndex > 2)
            {
                array[num2 + 0xb5] = Convert.ToByte(OpenLimitCmbBox1.SelectedIndex);
                if (OpenLimitCmbBox2.SelectedIndex > 0)
                {
                    array[num2 + 0xb6] = Convert.ToByte((int)(OpenLimitCmbBox2.SelectedIndex + 5));
                }
            }
            else
            {
                array[num2 + 0xb5] = 3;
                if (OpenLimitCmbBox2.SelectedIndex > 0)
                {
                    array[num2 + 0xb6] = Convert.ToByte((int)(OpenLimitCmbBox2.SelectedIndex + 5));
                }
            }
            switch (EnvironmentCmbBox1.SelectedIndex)
            {
                case 0:
                    num6 = 0;
                    break;

                case 1:
                    num6 = 1;
                    break;

                case 2:
                    num6 = 2;
                    break;

                case 3:
                    num6 = 4;
                    break;

                case 4:
                    num6 = 8;
                    break;

                default:
                    num6 = 0;
                    break;
            }
            switch (EnvironmentCmbBox2.SelectedIndex)
            {
                case 0:
                    num7 = 0;
                    break;

                case 1:
                    num7 = 1;
                    break;

                case 2:
                    num7 = 2;
                    break;

                case 3:
                    num7 = 4;
                    break;

                case 4:
                    num7 = 8;
                    break;

                default:
                    num7 = 0;
                    break;
            }
            array[num2 + 0x95] = Convert.ToByte((int)((num6 << 4) + num7));
            switch (TaskTypeCmbBox.SelectedIndex)
            {
                case 0:
                    array[num2 + 0x94] = 1;
                    break;

                case 1:
                    array[num2 + 0x94] = 2;
                    break;

                case 2:
                    array[num2 + 0x94] = 4;
                    break;

                case 3:
                    array[num2 + 0x94] = 8;
                    break;

                case 4:
                    array[num2 + 0x94] = 0x10;
                    break;

                case 5:
                    array[num2 + 0x94] = 0x84;
                    break;

                default:
                    MessageBox.Show(Language.Dictionary["errors"]["unknowntype"], Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
            }
            string MapTag = (string)MapLabel.Tag;
            switch (MapTag)
            {
                case "Isola":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 14;
                        break;
                    }
                    array[num2 + 180] = 1;
                    break;

                case "Pianure":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 15;
                        break;
                    }
                    array[num2 + 180] = 2;
                    break;

                case "Foresta":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 0x10;
                        break;
                    }
                    array[num2 + 180] = 3;
                    break;

                case "Tundra":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 0x11;
                        break;
                    }
                    array[num2 + 180] = 4;
                    break;

                case "Vulcano":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 0x12;
                        break;
                    }
                    array[num2 + 180] = 5;
                    break;

                case "Cascate":
                    if (MapTimeCmbBox.SelectedIndex != 0)
                    {
                        array[num2 + 180] = 0x13;
                        break;
                    }
                    array[num2 + 180] = 12;
                    break;

                case "Grande Deserto":
                    array[num2 + 180] = 6;
                    break;

                case "Canyon di Lava":
                    array[num2 + 180] = 7;
                    break;

                case "Arena":
                    array[num2 + 180] = 8;
                    break;

                case "Arena Piccola":
                    array[num2 + 180] = 9;
                    break;

                case "Terra Sacra":
                    array[num2 + 180] = 10;
                    break;

                case "Zona Polare":
                    array[num2 + 180] = 11;
                    break;

                case "Cima Montagna":
                    array[num2 + 180] = 13;
                    break;
            }
            array[num2 + 0x97] = Convert.ToByte((int)(cmBoxStopTime.SelectedIndex * 4));
            if (chkBoxBGM.Checked)
            {
                array[num2 + 0x97] = (byte)(0x20 + (array[num2 + 0x97] & 15));
            }
            if (BossRandomSysRadioBtn3.Checked)
            {
                array[num2 + 0xb8] = 11;
            }
            else
            {
                array[num2 + 0xb8] = 0;
            }
            if (VicyTermCmbBox2.SelectedIndex == 0)
            {
                array[num2 + 0xbb] = 1;
            }
            else
            {
                array[num2 + 0xbb] = Convert.ToByte((int)(SndVicyTermCmbBox.SelectedIndex + 1));
            }
            if ((VicyTermCmbBox1.SelectedIndex <= 0) || (VicyTermCmbBox1.SelectedIndex >= 0x42))
            {
                if (VicyTermCmbBox1.SelectedIndex <= 0x42)
                {
                    goto Label_0C38;
                }
                array[num2 + 0xbc] = 2;
                flag2 = false;
                for (int num9 = 8; num9 < 0x2dd; num9++)
                {
                    if (ResouresNames[num9] == VicyTermCmbBox1.Text)
                    {
                        array[num2 + 0xc0] = Convert.ToByte((int)(num9 & 0xff));
                        array[num2 + 0xc1] = Convert.ToByte((int)(num9 >> 8));
                        flag2 = true;
                        break;
                    }
                }
            }
            else
            {
                array[num2 + 0xbc] = 1;
                bool flag = false;
                for (int num8 = 0; num8 < strMonsterNames.Length; num8++)
                {
                    if (strMonsterNames[num8] == VicyTermCmbBox1.Text)
                    {
                        array[num2 + 0xc0] = Convert.ToByte(num8);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show(Language.Dictionary["messages"]["victoryerror"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
                array[num2 + 0xc2] = Convert.ToByte(VicyTermNumUpDown1.Value);
                goto Label_0C38;
            }
            if (!flag2)
            {
                MessageBox.Show(Language.Dictionary["messages"]["victoryerror"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            array[num2 + 0xc2] = Convert.ToByte(VicyTermNumUpDown1.Value);
        Label_0C38:
            if (((SndVicyTermCmbBox.SelectedIndex <= 0) || (VicyTermCmbBox2.SelectedIndex <= 0)) || (VicyTermCmbBox2.SelectedIndex >= 0x41))
            {
                if ((SndVicyTermCmbBox.SelectedIndex <= 0) || (VicyTermCmbBox2.SelectedIndex <= 0x41))
                {
                    goto Label_0DB5;
                }
                array[num2 + 0xc4] = 2;
                flag4 = false;
                for (int num11 = 8; num11 < 0x2dd; num11++)
                {
                    if (ResouresNames[num11] == VicyTermCmbBox2.Text)
                    {
                        array[num2 + 200] = Convert.ToByte((int)(num11 & 0xff));
                        array[num2 + 0xc9] = Convert.ToByte((int)(num11 >> 8));
                        flag4 = true;
                        break;
                    }
                }
            }
            else
            {
                array[num2 + 0xc4] = 1;
                bool flag3 = false;
                for (int num10 = 0; num10 < strMonsterNames.Length; num10++)
                {
                    if (strMonsterNames[num10] == VicyTermCmbBox2.Text)
                    {
                        array[num2 + 200] = Convert.ToByte(num10);
                        flag3 = true;
                        break;
                    }
                }
                if (!flag3)
                {
                    MessageBox.Show(Language.Dictionary["messages"]["victoryerror"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
                array[num2 + 0xca] = Convert.ToByte(VicyTermNumUpDown2.Value);
                goto Label_0DB5;
            }
            if (!flag4)
            {
                MessageBox.Show(Language.Dictionary["messages"]["victoryerror"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            array[num2 + 0xca] = Convert.ToByte(VicyTermNumUpDown2.Value);
        Label_0DB5:
            if (BossRandomSysRadioBtn3.Checked)
            {
                if (WarningUnionNumUpD.Value == 0M)
                {
                    WarningUnionNumUpD.Value = 100M;
                }
                if (WarningRemuntNumUpD.Value == 0M)
                {
                    WarningRemuntNumUpD.Value = 300M;
                }
                array[num2 + 0x84] = Convert.ToByte((int)(Convert.ToInt32(WarningUnionNumUpD.Value) & 0xff));
                array[num2 + 0x85] = Convert.ToByte((int)(Convert.ToInt32(WarningUnionNumUpD.Value) >> 8));
                array[num2 + 0x88] = Convert.ToByte((int)(Convert.ToInt32(WarningRemuntNumUpD.Value) & 0xff));
                array[num2 + 0x89] = Convert.ToByte((int)(Convert.ToInt32(WarningRemuntNumUpD.Value) >> 8));
                if (BossRandomUnknowValueTextBox.Text.Trim().Length < 8)
                {
                    BossRandomUnknowValueTextBox.Text = BossRandomUnknowValueTextBox.Text.PadLeft(8, '0').ToUpper();
                }
                for (int num12 = 0; num12 < 4; num12++)
                {
                    array[(num2 + 0xab) - num12] = Convert.ToByte(BossRandomUnknowValueTextBox.Text.Substring(num12 * 2, 2), 0x10);
                }
            }
            array[num2 + 0xd0] = (byte)MonsterIconCmbBox1.SelectedIndex;
            array[num2 + 210] = (byte)MonsterIconCmbBox2.SelectedIndex;
            array[num2 + 0xd4] = (byte)MonsterIconCmbBox3.SelectedIndex;
            array[num2 + 0xd6] = (byte)MonsterIconCmbBox4.SelectedIndex;
            array[num2 + 0xd8] = (byte)MonsterIconCmbBox5.SelectedIndex;

            index = 220 + num2;
            if ((DestinationFileType.ToLower() == "pat") || (DestinationFileType.ToLower() == "mem"))
            {
                new byte[] { 0xe5, 0xa4, 0xa9, 0xe8, 170, 0x85, 0xe7, 0x86, 0x8a, 0xe8, 0xa3, 0xbd, 0xe4, 0xbd, 0x9c, 0 }.CopyTo(array, index);
                index = 0xec + num2;
            }
            int[] numArray = new int[6];
            if ((taskTitleText.Text != "") && (taskTitleText.Text.Length < 3))
            {
                taskTitleText.Text = taskTitleText.Text;
            }
            for (int i = 0; i < 6; i++)
            {
                numArray[i] = index - num2;
                if (TaskInfText[i].Text == "")
                {
                    MessageBox.Show(Language.Dictionary["messages"]["insertinfo"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
                string s = TaskInfText[i].Text.Replace("\r\n", "\n");
                byte[] buffer3 = Encoding.UTF8.GetBytes(s);
                for (int num14 = 0; num14 < buffer3.Length; num14++)
                {
                    array[index + num14] = buffer3[num14];
                }
                index += (buffer3.Length + 8) - (buffer3.Length % 8);
            }
            index += 4;
            array[index] = 220;
            index += 4;
            for (int j = 0; j < 6; j++)
            {
                array[index + (j * 4)] = Convert.ToByte((int)(numArray[j] & 0xff));
                array[(index + 1) + (j * 4)] = Convert.ToByte((int)(numArray[j] >> 8));
            }
            array[num2 + 0xac] = Convert.ToByte((int)(((index + 0x18) - num2) & 0xff));
            array[num2 + 0xad] = Convert.ToByte((int)(((index + 0x18) - num2) >> 8));
            for (int k = 0; k < 7; k++)
            {
                array[(index + 0x18) + (k * 4)] = Convert.ToByte((int)((index - num2) & 0xff));
                array[(index + 0x19) + (k * 4)] = Convert.ToByte((int)((index - num2) >> 8));
            }
            index += 0x34;

            if (chkBoxStartExercise.Checked)
            {
                array[num2 + 0xcc] = Convert.ToByte((int)((index - num2) & 0xff));
                array[num2 + 0xcd] = Convert.ToByte((int)((index - num2) >> 8));
                for (int num17 = 0; num17 < 5; num17++)
                {
                    if (cmbBoxHunterNumber.SelectedIndex >= 0)
                    {
                        array[index] = Convert.ToByte((int)(cmbBoxHunterNumber.SelectedIndex + 1));
                    }
                    else
                    {
                        array[index] = 4;
                    }
                    int num18 = 0;
                    num18 = Convert.ToInt16((decimal)((numUpDnEstimateSS1.Value * 60M) + numUpDnEstimateSS2.Value)) * 3;
                    array[index + 4] = Convert.ToByte((int)(num18 & 0xff));
                    array[index + 5] = Convert.ToByte((int)(num18 >> 8));
                    num18 = Convert.ToInt16((decimal)((numUpDnEstimateS1.Value * 60M) + numUpDnEstimateS2.Value)) * 3;
                    array[index + 8] = Convert.ToByte((int)(num18 & 0xff));
                    array[index + 9] = Convert.ToByte((int)(num18 >> 8));
                    num18 = Convert.ToInt16((decimal)((numUpDnEstimateA1.Value * 60M) + numUpDnEstimateA2.Value)) * 3;
                    array[index + 12] = Convert.ToByte((int)(num18 & 0xff));
                    array[index + 13] = Convert.ToByte((int)(num18 >> 8));
                    array[index + 0x10] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtS.Value) & 0xff));
                    array[index + 0x11] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtS.Value) >> 8));
                    array[index + 20] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtA.Value) & 0xff));
                    array[index + 0x15] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtA.Value) >> 8));
                    array[index + 0x18] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtB.Value) & 0xff));
                    array[index + 0x19] = Convert.ToByte((int)(Convert.ToInt16(numUpDnEstimatePtB.Value) >> 8));
                    for (int num19 = 0; num19 < 6; num19++)
                    {
                        if (num19 == 0)
                        {
                            if ((HuntersArmsSet[num17, 0].ArmsNameValue <= 0) || (HuntersArmsSet[num17, 0].ArmsType < 5))
                            {
                                MessageBox.Show(Language.Dictionary["messages"]["weaponchoice"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return 0;
                            }
                            array[(index + 0x1d) + (12 * num19)] = (HuntersArmsSet[num17, num19].ArmsType < 10) ? Convert.ToByte(HuntersArmsSet[num17, num19].ArmsType) : Convert.ToByte((int)(HuntersArmsSet[num17, num19].ArmsType + 1));
                        }
                        else
                        {
                            array[(index + 0x1d) + (12 * num19)] = Convert.ToByte((int)(num19 - 1));
                        }
                        array[(index + 30) + (12 * num19)] = Convert.ToByte((int)(HuntersArmsSet[num17, num19].ArmsNameValue & 0xff));
                        array[(index + 0x1f) + (12 * num19)] = Convert.ToByte((int)(HuntersArmsSet[num17, num19].ArmsNameValue >> 8));
                        if ((HuntersArmsSet[num17, num19].ArmsType != 9) && (HuntersArmsSet[num17, num19].ArmsType != 10))
                        {
                            array[(index + 0x20) + (12 * num19)] = Convert.ToByte((int)(HuntersArmsSet[num17, num19].ArmsLV & 15));
                        }
                        else
                        {
                            array[(index + 0x20) + (12 * num19)] = Convert.ToByte(HuntersArmsSet[num17, num19].ArmsLV);
                        }
                        if (HuntersArmsSet[num17, num19].Bead01Value > 0)
                        {
                            array[(index + 0x22) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead01Value + 0x32e) & 0xff));
                            array[(index + 0x23) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead01Value + 0x32e) >> 8));
                        }
                        if (HuntersArmsSet[num17, num19].Bead02Value > 0)
                        {
                            array[(index + 0x24) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead02Value + 0x32e) & 0xff));
                            array[(index + 0x25) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead02Value + 0x32e) >> 8));
                        }
                        if (HuntersArmsSet[num17, num19].Bead03Value > 0)
                        {
                            array[(index + 0x26) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead03Value + 0x32e) & 0xff));
                            array[(index + 0x27) + (12 * num19)] = Convert.ToByte((int)((HuntersArmsSet[num17, num19].Bead03Value + 0x32e) >> 8));
                        }
                    }
                    if (SymbolSet[num17].Type == 0)
                    {
                        array[index + 0x65] = 0xff;
                        array[index + 0x66] = 0xe0;
                        array[index + 0x67] = 0x79;
                        array[index + 0x68] = 0;
                        array[index + 0x69] = 0xc0;
                    }
                    else
                    {
                        array[index + 0x65] = 0x65;
                        int num20 = SymbolSet[num17].SkillPiont1 + 30;
                        int num21 = SymbolSet[num17].SkillPiont2 + 30;
                        array[index + 0x66] = Convert.ToByte((int)(((SymbolSet[num17].Type - 1) & 15) + ((num20 & 15) << 4)));
                        array[index + 0x67] = Convert.ToByte((int)((num21 << 2) + ((num20 >> 4) & 3)));
                        array[index + 0x68] = Convert.ToByte((int)((SymbolSet[num17].Skill01 & 0x7f) + ((SymbolSet[num17].Skill02 & 1) << 7)));
                        array[index + 0x69] = Convert.ToByte((int)((SymbolSet[num17].Skill02 >> 1) + (SymbolSet[num17].Hole << 6)));
                        if (SymbolSet[num17].Bead01Value > 0)
                        {
                            array[index + 0x6a] = Convert.ToByte((int)((SymbolSet[num17].Bead01Value + 0x32e) & 0xff));
                            array[index + 0x6b] = Convert.ToByte((int)((SymbolSet[num17].Bead01Value + 0x32e) >> 8));
                        }
                        if (SymbolSet[num17].Bead02Value > 0)
                        {
                            array[index + 0x6c] = Convert.ToByte((int)((SymbolSet[num17].Bead02Value + 0x32e) & 0xff));
                            array[index + 0x6d] = Convert.ToByte((int)((SymbolSet[num17].Bead02Value + 0x32e) >> 8));
                        }
                        if (SymbolSet[num17].Bead03Value > 0)
                        {
                            array[index + 110] = Convert.ToByte((int)((SymbolSet[num17].Bead03Value + 0x32e) & 0xff));
                            array[index + 0x6f] = Convert.ToByte((int)((SymbolSet[num17].Bead03Value + 0x32e) >> 8));
                        }
                    }
                    for (int num22 = 0; num22 < 0x18; num22++)
                    {
                        if (ExerciseBag[num17, num22].nameValue > 0)
                        {
                            array[(index + 0x70) + (4 * num22)] = Convert.ToByte((int)(ExerciseBag[num17, num22].nameValue & 0xff));
                            array[(index + 0x71) + (4 * num22)] = Convert.ToByte((int)(ExerciseBag[num17, num22].nameValue >> 8));
                            if (ExerciseBag[num17, num22].number > 0)
                            {
                                array[(index + 0x72) + (4 * num22)] = Convert.ToByte(ExerciseBag[num17, num22].number);
                            }
                            else
                            {
                                array[(index + 0x72) + (4 * num22)] = 1;
                            }
                        }
                    }
                    index += 0xd0;
                }
            }

            int[] numArray11 = new int[2];
            int[] numArray2 = numArray11;
            numArray11 = new int[4];
            int[] numArray3 = numArray11;
            numArray11 = new int[2];
            int[] numArray4 = numArray11;
            numArray3[0] = index - num2;
            int num23 = RadioBtnNothing.Checked ? 40 : 0x20;
            for (int m = 0; m < num23; m++)
            {
                if (strRation[m].nameValue <= 0)
                {
                    break;
                }
                array[index] = Convert.ToByte((int)(strRation[m].nameValue & 0xff));
                array[index + 1] = Convert.ToByte((int)(strRation[m].nameValue >> 8));
                array[index + 2] = Convert.ToByte(strRation[m].number);
                numArray4[0]++;
                index += 4;
            }
            if (!(DestinationFileType.ToLower() == "pat"))
            {
                bool flag1 = DestinationFileType.ToLower() == "mem";
            }
            if (RadioBtnRandomSysRation.Checked && (randomBoss[0].nameValue > 0))
            {
                for (int num25 = 0; num25 < 3; num25++)
                {
                    if (randomBoss[num25].nameValue > 0)
                    {
                        numArray3[1 + num25] = index - num2;
                        for (int num26 = 0x20; num26 < 40; num26++)
                        {
                            if (strRation[num26].nameValue <= 0)
                            {
                                break;
                            }
                            array[index] = Convert.ToByte((int)(strRation[num26].nameValue & 0xff));
                            array[index + 1] = Convert.ToByte((int)(strRation[num26].nameValue >> 8));
                            array[index + 2] = Convert.ToByte(strRation[num26].number);
                            if (num25 == 0)
                            {
                                numArray4[1]++;
                            }
                            index += 4;
                        }
                    }
                }
            }
            if (RadioBtnConditionsRation.Checked && (CmbBoxConditionsRation.SelectedIndex > 0))
            {
                if (strRation[0x20].nameValue > 0)
                {
                    numArray3[1] = index - num2;
                }
                for (int num27 = 0x20; num27 < 40; num27++)
                {
                    if (strRation[num27].nameValue <= 0)
                    {
                        break;
                    }
                    array[index] = Convert.ToByte((int)(strRation[num27].nameValue & 0xff));
                    array[index + 1] = Convert.ToByte((int)(strRation[num27].nameValue >> 8));
                    array[index + 2] = Convert.ToByte(strRation[num27].number);
                    numArray4[1]++;
                    index += 4;
                }
            }
            array[num2 + 8] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 9] = Convert.ToByte((int)((index - num2) >> 8));
            if (numArray4[0] > 0)
            {
                if ((StarGradeCmbBox.SelectedIndex < 5) || (BaseRationNumUpD.Value >= numArray4[0]))
                {
                    array[index + 1] = Convert.ToByte(numArray4[0]);
                }
                else
                {
                    array[index + 1] = Convert.ToByte(BaseRationNumUpD.Value);
                }
                array[index + 4] = Convert.ToByte((int)(numArray3[0] & 0xff));
                array[index + 5] = Convert.ToByte((int)(numArray3[0] >> 8));
                index += 8;
                if (((StarGradeCmbBox.SelectedIndex >= 5) && (BaseRationNumUpD.Value < numArray4[0])) || !RadioBtnNothing.Checked)
                {
                    array[index] = 1;
                    if ((StarGradeCmbBox.SelectedIndex >= 5) && (BaseRationNumUpD.Value < numArray4[0]))
                    {
                        array[index + 1] = Convert.ToByte((int)(numArray4[0] - Convert.ToInt16(BaseRationNumUpD.Value)));
                        array[index + 4] = Convert.ToByte((int)((numArray3[0] + (Convert.ToInt16(BaseRationNumUpD.Value) * 4)) & 0xff));
                        array[index + 5] = Convert.ToByte((int)((numArray3[0] + (Convert.ToInt16(BaseRationNumUpD.Value) * 4)) >> 8));
                    }
                    else
                    {
                        numArray2[0] = index + 4;
                    }
                    index += 8;
                }
                if (RadioBtnConditionsRation.Checked && (CmbBoxConditionsRation.SelectedIndex > 0))
                {
                    array[index] = 2;
                    if ((numArray3[1] > 0) && (numArray4[1] > 0))
                    {
                        array[index + 1] = Convert.ToByte(numArray4[1]);
                        array[index + 4] = Convert.ToByte((int)(numArray3[1] & 0xff));
                        array[index + 5] = Convert.ToByte((int)(numArray3[1] >> 8));
                    }
                    else
                    {
                        numArray2[1] = index + 4;
                    }
                    index += 8;
                }
                if (RadioBtnRandomSysRation.Checked && (randomBoss[0].nameValue > 0))
                {
                    array[index] = 2;
                    numArray2[1] = index + 4;
                    index += 8;
                    for (int num28 = 0; num28 < 3; num28++)
                    {
                        if (randomBoss[num28].nameValue > 0)
                        {
                            array[index] = Convert.ToByte((int)(num28 + 3));
                            array[index + 1] = Convert.ToByte(numArray4[1]);
                            array[index + 4] = Convert.ToByte((int)(numArray3[num28 + 1] & 0xff));
                            array[index + 5] = Convert.ToByte((int)(numArray3[num28 + 1] >> 8));
                            index += 8;
                        }
                    }
                }
            }
            array[index] = 0xff;
            index += 8;
            int[] numArray5 = new int[strMapPoint.Length];
            int[,] numArray6 = new int[strMapPoint.Length, 6];
            for (int n = 0; n < strMapPoint.Length; n++)
            {
                if (resourcesPoint[n] > 0)
                {
                    for (int num30 = 0; num30 < resourcesPoint[n]; num30++)
                    {
                        if (strResources[n, num30, 0].nameValue == 0)
                        {
                            numArray6[n, num30] = 0;
                            strResrPoint[n, num30].maxiNum = 0;
                            strResrPoint[n, num30].miniNum = 0;
                            break;
                        }
                        numArray6[n, num30] = index - num2;
                        for (int num31 = 0; num31 < 15; num31++)
                        {
                            if (strResources[n, num30, num31].nameValue <= 0)
                            {
                                break;
                            }
                            array[index] = Convert.ToByte(strResources[n, num30, num31].RateOrTeam);
                            array[index + 1] = Convert.ToByte(strResources[n, num30, num31].number);
                            array[index + 2] = Convert.ToByte((int)(strResources[n, num30, num31].nameValue & 0xff));
                            array[index + 3] = Convert.ToByte((int)(strResources[n, num30, num31].nameValue >> 8));
                            index += 4;
                        }
                        array[index] = 0xff;
                        array[index + 1] = 0xff;
                        array[index + 2] = 0xff;
                        array[index + 3] = 0xff;
                        index += 4;
                    }
                }
            }
            for (int num32 = 0; num32 < strMapPoint.Length; num32++)
            {
                if (resourcesPoint[num32] > 0)
                {
                    numArray5[num32] = index - num2;
                    for (int num33 = 0; num33 < resourcesPoint[num32]; num33++)
                    {
                        array[index] = Convert.ToByte((int)(numArray6[num32, num33] & 0xff));
                        array[index + 1] = Convert.ToByte((int)(numArray6[num32, num33] >> 8));
                        array[index + 4] = Convert.ToByte(strResrPoint[num32, num33].maxiNum);
                        array[index + 6] = Convert.ToByte(strResrPoint[num32, num33].miniNum);
                        index += 8;
                    }
                }
                else if (resourcesPoint[num32] == 0)
                {
                    numArray5[num32] = 0;
                }
            }
            array[num2 + 0x60] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 0x61] = Convert.ToByte((int)((index - num2) >> 8));
            for (int num34 = 0; num34 < strMapPoint.Length; num34++)
            {
                array[index] = Convert.ToByte((int)(numArray5[num34] & 0xff));
                array[index + 1] = Convert.ToByte((int)(numArray5[num34] >> 8));
                index += 4;
            }

            int[] numArray7 = new int[6];
            for (int num35 = 0; num35 < 6; num35++)
            {
                if ((strMaterialReward[num35, 0].nameValue > 0) || (num35 == 0))
                {
                    int num36 = 0;
                    numArray7[num35] = index - num2;
                    for (int num37 = 0; num37 < 20; num37++)
                    {
                        if (strMaterialReward[num35, num37].nameValue > 0)
                        {
                            array[index] = Convert.ToByte(strMaterialReward[num35, num37].RateOrTeam);
                            num36 += strMaterialReward[num35, num37].RateOrTeam;
                            array[index + 2] = Convert.ToByte((int)(strMaterialReward[num35, num37].nameValue & 0xff));
                            array[index + 3] = Convert.ToByte((int)(strMaterialReward[num35, num37].nameValue >> 8));
                            if ((strMaterialReward[num35, num37].nameValue <= 310) || (strMaterialReward[num35, num37].nameValue > 0x287))
                            {
                                array[index + 4] = Convert.ToByte(strMaterialReward[num35, num37].number);
                            }
                            else
                            {
                                array[index + 4] = (strMaterialReward[num35, num37].number <= 2) ? Convert.ToByte(strMaterialReward[num35, num37].number) : ((byte)2);
                            }
                            index += 6;
                        }
                        if (((strMaterialReward[num35, num37].nameValue <= 0) || ((num35 == 0) && (num37 == 0x13))) || ((num35 > 0) && (num37 == 9)))
                        {
                            array[index] = 0xff;
                            array[index + 1] = 0xff;
                            index += 2;
                            break;
                        }
                    }
                    if ((DestinationFileType.ToLower() == "mis") || (DestinationFileType.ToLower() == "mib") || (DestinationFileType.ToLower() == "cqs"))
                    {
                        if (num36 > 150)
                        {
                            MessageBox.Show(Language.Dictionary["messages"]["highprob"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return 0;
                        }
                        continue;
                    }
                    if (num36 <= 200)
                    {
                        continue;
                    }
                    MessageBox.Show(Language.Dictionary["messages"]["highprob"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
                numArray7[num35] = 0;
                break;
            }
            if ((index % 4) > 0)
            {
                index += 4 - (index % 4);
            }
            array[num2 + 0x1c] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 0x1d] = Convert.ToByte((int)((index - num2) >> 8));
            for (int num38 = 0; num38 < 6; num38++)
            {
                if ((numArray7[num38] <= 0) && (num38 != 0))
                {
                    break;
                }
                if (num38 == 0)
                {
                    array[index] = 0;
                    array[index + 3] = Convert.ToByte(MaterialNumNumUpD2.Value);
                    array[index + 4] = (MaterialNumNumUpD2.Value >= MaterialNumNumUpD1.Value) ? Convert.ToByte(MaterialNumNumUpD1.Value) : Convert.ToByte(MaterialNumNumUpD2.Value);
                }
                else
                {
                    array[index] = 1;
                }
                array[index + 1] = 0x80;
                array[index + 8] = Convert.ToByte((int)(numArray7[num38] & 0xff));
                array[index + 9] = Convert.ToByte((int)(numArray7[num38] >> 8));
                index += 12;
            }
            array[index] = 0xff;
            array[index + 1] = 0xff;
            index += 12;

            int[, ,] numArray8 = new int[3, strMapPoint.Length, 2];
            int num39 = 1;
            array[num2 + 0x73] = 1;
            array[num2 + 0x7b] = 2;
            if (DogfRdButton2.Checked || DogfRdButton3.Checked)
            {
                if ((DfAddCmbBox1.SelectedIndex <= 0) || (DfAddCmbBox1.SelectedIndex >= 0x42))
                {
                    if (DfAddCmbBox1.SelectedIndex > 0x42)
                    {
                        num39 = 2;
                        array[num2 + 0x6c] = 2;
                        for (int num41 = 0x110; num41 < 0x2dd; num41++)
                        {
                            if (ResouresNames[num41] == DfAddCmbBox1.Text)
                            {
                                array[num2 + 0x70] = Convert.ToByte((int)(num41 & 0xff));
                                array[num2 + 0x71] = Convert.ToByte((int)(num41 >> 8));
                                break;
                            }
                        }
                        array[num2 + 0x72] = Convert.ToByte(DfAddNumNumUpDown1.Value);
                    }
                }
                else
                {
                    num39 = 2;
                    array[num2 + 0x6c] = 1;
                    for (int num40 = 0; num40 < strMonsterNames.Length; num40++)
                    {
                        if (strMonsterNames[num40] == DfAddCmbBox1.Text)
                        {
                            array[num2 + 0x70] = Convert.ToByte(num40);
                            break;
                        }
                    }
                    array[num2 + 0x72] = Convert.ToByte(DfAddNumNumUpDown1.Value);
                }
            }
            if (DogfRdButton3.Checked)
            {
                if ((DfAddCmbBox2.SelectedIndex <= 0) || (DfAddCmbBox2.SelectedIndex >= 0x42))
                {
                    if (DfAddCmbBox2.SelectedIndex > 0x42)
                    {
                        num39 = 3;
                        if (array[num2 + 0x6c] == 2)
                        {
                            array[num2 + 0x6c] = 4;
                        }
                        array[num2 + 0x74] = 4;
                        for (int num43 = 0x110; num43 < 0x2dd; num43++)
                        {
                            if (ResouresNames[num43] == DfAddCmbBox2.Text)
                            {
                                array[num2 + 120] = Convert.ToByte((int)(num43 & 0xff));
                                array[num2 + 0x79] = Convert.ToByte((int)(num43 >> 8));
                                break;
                            }
                        }
                        array[num2 + 0x7a] = Convert.ToByte(DfAddNumNumUpDown2.Value);
                    }
                }
                else
                {
                    num39 = 3;
                    array[num2 + 0x74] = 1;
                    for (int num42 = 0; num42 < strMonsterNames.Length; num42++)
                    {
                        if (strMonsterNames[num42] == DfAddCmbBox2.Text)
                        {
                            array[num2 + 120] = Convert.ToByte(num42);
                            break;
                        }
                    }
                    array[num2 + 0x7a] = Convert.ToByte(DfAddNumNumUpDown2.Value);
                }
            }
            for (int num44 = 0; num44 < num39; num44++)
            {
                for (int num45 = 0; num45 < strMapPoint.Length; num45++)
                {
                    bool flag5 = false;
                    if (num44 > 0)
                    {
                        for (int num46 = 0; num46 < 10; num46++)
                        {
                            if (strDogfish[num44, num45, num46].nameValue != strDogfish[num44 - 1, num45, num46].nameValue)
                            {
                                flag5 = true;
                                break;
                            }
                            if (strDogfish[num44, num45, num46].number != strDogfish[num44 - 1, num45, num46].number)
                            {
                                flag5 = true;
                                break;
                            }
                            if (strDogfish[num44, num45, num46].runningAppearance != strDogfish[num44 - 1, num45, num46].runningAppearance)
                            {
                                flag5 = true;
                                break;
                            }
                            if (strDogfish[num44, num45, num46].volume != strDogfish[num44 - 1, num45, num46].volume)
                            {
                                flag5 = true;
                                break;
                            }
                            if ((strDogfish[num44, num45, num46].nameValue == 0) && (strDogfish[num44 - 1, num45, num46].nameValue == 0))
                            {
                                break;
                            }
                        }
                    }
                    if ((num44 > 0) && !flag5)
                    {
                        numArray8[num44, num45, 0] = numArray8[num44 - 1, num45, 0];
                        numArray8[num44, num45, 1] = numArray8[num44 - 1, num45, 1];
                        continue;
                    }
                    numArray8[num44, num45, 0] = index - num2;
                    int num47 = 0;
                    if (strDogfish[num44, num45, 0].nameValue > 0)
                    {
                        num47 = 1;
                    }
                    for (int num48 = 0; num48 < 10; num48++)
                    {
                        if (strDogfish[num44, num45, num48].nameValue <= 0)
                        {
                            break;
                        }
                        if (num48 > 0)
                        {
                            if (strDogfish[num44, num45, num48].nameValue != strDogfish[num44, num45, num48 - 1].nameValue)
                            {
                                num47++;
                            }
                            if (num47 >= 4)
                            {
                                break;
                            }
                        }
                        array[index] = Convert.ToByte(strDogfish[num44, num45, num48].nameValue);
                        array[index + 2] = Convert.ToByte(strDogfish[num44, num45, num48].volume);
                        array[index + 4] = Convert.ToByte(strDogfish[num44, num45, num48].number);
                        array[index + 5] = 1;
                        array[index + 6] = Convert.ToByte(num45);
                        array[index + 8] = Convert.ToByte(strDogfish[num44, num45, num48].runningAppearance);
                        if (strDogfish[num44, num45, num48].toFace != 0)
                        {
                            array[index + 12] = Convert.ToByte((int)(strDogfish[num44, num45, num48].toFace & 0xff));
                            array[index + 13] = Convert.ToByte((int)(strDogfish[num44, num45, num48].toFace >> 8));
                        }
                        else
                        {
                            Random random = new Random(DateTime.Now.Millisecond);
                            array[index + 12] = Convert.ToByte(random.Next(0x10, 0x80));
                            array[index + 13] = Convert.ToByte(random.Next(0x10, 0x80));
                        }
                        for (int num49 = 0; num49 < 3; num49++)
                        {
                            float x = 0f;
                            switch (num49)
                            {
                                case 0:
                                    x = strDogfish[num44, num45, num48].X;
                                    break;

                                case 1:
                                    x = strDogfish[num44, num45, num48].Z;
                                    break;

                                case 2:
                                    x = strDogfish[num44, num45, num48].Y;
                                    break;
                            }
                            byte[] buffer4 = BitConverter.GetBytes(x);
                            for (int num51 = 0; num51 < buffer4.Length; num51++)
                            {
                                if (num51 == 4)
                                {
                                    break;
                                }
                                array[((index + 0x10) + num51) + (num49 * 4)] = buffer4[num51];
                            }
                        }
                        index += 0x30;
                    }
                    array[index] = 0xff;
                    array[index + 1] = 0xff;
                    index += 0x30;
                    numArray8[num44, num45, 1] = index - num2;
                    num47 = 0;
                    for (int num52 = 0; num52 < 10; num52++)
                    {
                        if (strDogfish[num44, num45, num52].nameValue == 0)
                        {
                            break;
                        }
                        if (num52 == 0)
                        {
                            array[index] = Convert.ToByte(strDogfish[num44, num45, 0].nameValue);
                            index += 4;
                            num47 = 1;
                        }
                        else
                        {
                            if (strDogfish[num44, num45, num52].nameValue != strDogfish[num44, num45, num52 - 1].nameValue)
                            {
                                array[index] = Convert.ToByte(strDogfish[num44, num45, num52].nameValue);
                                index += 4;
                                num47++;
                            }
                            if (num47 == 3)
                            {
                                break;
                            }
                        }
                    }
                    for (int num53 = 0; num53 < ((4 - num47) * 4); num53++)
                    {
                        array[index] = 0xff;
                        index++;
                    }
                }
            }
            numArray11 = new int[3];
            int[] numArray9 = numArray11;
            for (int num54 = 0; num54 < num39; num54++)
            {
                numArray9[num54] = index - num2;
                for (int num55 = 0; num55 < strMapPoint.Length; num55++)
                {
                    array[index] = Convert.ToByte(num55);
                    array[index + 8] = Convert.ToByte((int)(numArray8[num54, num55, 1] & 0xff));
                    array[index + 9] = Convert.ToByte((int)(numArray8[num54, num55, 1] >> 8));
                    array[index + 12] = Convert.ToByte((int)(numArray8[num54, num55, 0] & 0xff));
                    array[index + 13] = Convert.ToByte((int)(numArray8[num54, num55, 0] >> 8));
                    index += 0x10;
                }
                index += 0x10;
            }
            array[num2 + 0x24] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 0x25] = Convert.ToByte((int)((index - num2) >> 8));
            array[num2 + 40] = Convert.ToByte((int)(((index - num2) + 0x10) & 0xff));
            array[num2 + 0x29] = Convert.ToByte((int)(((index - num2) + 0x10) >> 8));
            for (int num56 = 0; num56 < 3; num56++)
            {
                if (numArray9[num56] > 0)
                {
                    array[index] = Convert.ToByte((int)(numArray9[num56] & 0xff));
                    array[index + 1] = Convert.ToByte((int)(numArray9[num56] >> 8));
                    index += 4;
                }
                else
                {
                    array[index] = Convert.ToByte((int)(numArray9[0] & 0xff));
                    array[index + 1] = Convert.ToByte((int)(numArray9[0] >> 8));
                    index += 4;
                }
            }
            index += 4;
            array[index] = 0xff;
            array[index + 1] = 0xff;
            index += 0x30;

            int num57 = 0;
            int[,] numArray10 = new int[5, 2];
            if (BossRandomSysRadioBtn1.Checked)
            {
                for (int num58 = 0; num58 < 5; num58++)
                {
                    if ((num58 > 0) && (strBoss[num58, 0].nameValue == 0))
                    {
                        numArray10[num58, 0] = 0;
                        break;
                    }
                    numArray10[num58, 0] = index - num2;
                    for (int num59 = 0; num59 < 2; num59++)
                    {
                        if (strBoss[num58, num59].nameValue > 0)
                        {
                            if (num57 <= 4)
                            {
                                array[(num2 + 0x30) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].volume);
                                array[(num2 + 50) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].volumeChange);
                                array[(num2 + 0x33) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].monsterHP);
                                array[(num2 + 0x34) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].AttackPower);
                                array[(num2 + 0x35) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].DefensePower);
                                array[(num2 + 0x36) + (num57 * 8)] = Convert.ToByte(strBoss[num58, num59].Endurance);
                            }
                            num57++;
                            array[index] = Convert.ToByte(strBoss[num58, num59].nameValue);
                            array[index + 2] = Convert.ToByte(strBoss[num58, num59].runningAppearance);
                            array[index + 4] = Convert.ToByte(strBoss[num58, num59].number);
                            array[index + 6] = Convert.ToByte(strBoss[num58, num59].point);
                            if (strBoss[num58, num59].toFace == 0)
                            {
                                Random random2 = new Random(DateTime.Now.Millisecond);
                                array[index + 12] = Convert.ToByte(random2.Next(0x10, 0xee));
                                array[index + 13] = Convert.ToByte(random2.Next(0x10, 0xee));
                            }
                            else
                            {
                                array[index + 12] = Convert.ToByte((int)(strBoss[num58, num59].toFace & 0xff));
                                array[index + 13] = Convert.ToByte((int)(strBoss[num58, num59].toFace >> 8));
                            }
                            for (int num60 = 0; num60 < 3; num60++)
                            {
                                float z = 0f;
                                switch (num60)
                                {
                                    case 0:
                                        z = strBoss[num58, num59].X;
                                        break;

                                    case 1:
                                        z = strBoss[num58, num59].Z;
                                        break;

                                    case 2:
                                        z = strBoss[num58, num59].Y;
                                        break;
                                }
                                byte[] buffer5 = BitConverter.GetBytes(z);
                                for (int num62 = 0; num62 < buffer5.Length; num62++)
                                {
                                    if (num62 == 4)
                                    {
                                        break;
                                    }
                                    array[((index + 0x10) + num62) + (num60 * 4)] = buffer5[num62];
                                }
                            }
                            index += 0x30;
                        }
                    }
                    array[index] = 0xff;
                    array[index + 1] = 0xff;
                    index += 0x30;
                    numArray10[num58, 1] = index - num2;
                    for (int num63 = 0; num63 < 2; num63++)
                    {
                        if (strBoss[num58, num63].nameValue > 0)
                        {
                            array[index + (num63 * 4)] = Convert.ToByte(strBoss[num58, num63].nameValue);
                        }
                        else
                        {
                            for (int num64 = 0; num64 < 4; num64++)
                            {
                                array[(index + (num63 * 4)) + num64] = 0xff;
                            }
                        }
                    }
                    index += 8;
                    for (int num65 = 0; num65 < 8; num65++)
                    {
                        array[index + num65] = 0xff;
                    }
                    index += 8;
                }
            }
            else
            {
                for (int num66 = 0; num66 < 4; num66++)
                {
                    numArray10[num66, 0] = index - num2;
                    for (int num67 = 0; num67 < 2; num67++)
                    {
                        if ((strBoss[0, 0].nameValue == 0) || ((num67 == 1) && (strBoss[0, 1].nameValue <= 0)))
                        {
                            break;
                        }
                        if (num66 == 0)
                        {
                            array[(num2 + 0x30) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].volume);
                            array[(num2 + 50) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].volumeChange);
                            array[(num2 + 0x33) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].monsterHP);
                            array[(num2 + 0x34) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].AttackPower);
                            array[(num2 + 0x35) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].DefensePower);
                            array[(num2 + 0x36) + (num67 * 8)] = Convert.ToByte(strBoss[0, num67].Endurance);
                            if (BossRandomSysRadioBtn3.Checked)
                            {
                                array[(num2 + 0x37) + (num67 * 8)] = 1;
                            }
                        }
                        array[index] = Convert.ToByte(strBoss[0, num67].nameValue);
                        array[index + 2] = Convert.ToByte(strBoss[0, num67].runningAppearance);
                        array[index + 4] = Convert.ToByte(strBoss[0, num67].number);
                        array[index + 6] = Convert.ToByte(strBoss[0, num67].point);
                        if (strBoss[0, num67].toFace == 0)
                        {
                            Random random3 = new Random(DateTime.Now.Millisecond);
                            array[index + 12] = Convert.ToByte(random3.Next(0x10, 0xee));
                            array[index + 13] = Convert.ToByte(random3.Next(0x10, 0xee));
                            strBoss[0, num67].toFace = (array[index + 13] << 8) + array[index + 12];
                        }
                        else
                        {
                            array[index + 12] = Convert.ToByte((int)(strBoss[0, num67].toFace & 0xff));
                            array[index + 13] = Convert.ToByte((int)(strBoss[0, num67].toFace >> 8));
                        }
                        for (int num68 = 0; num68 < 3; num68++)
                        {
                            float y = 0f;
                            switch (num68)
                            {
                                case 0:
                                    y = strBoss[0, num67].X;
                                    break;

                                case 1:
                                    y = strBoss[0, num67].Z;
                                    break;

                                case 2:
                                    y = strBoss[0, num67].Y;
                                    break;
                            }
                            byte[] buffer6 = BitConverter.GetBytes(y);
                            for (int num70 = 0; num70 < buffer6.Length; num70++)
                            {
                                if (num70 == 4)
                                {
                                    break;
                                }
                                array[((index + 0x10) + num70) + (num68 * 4)] = buffer6[num70];
                            }
                        }
                        if (num66 == 0)
                        {
                            switch (num67)
                            {
                                case 0:
                                    array[index + 0x24] = 100;
                                    break;

                                case 1:
                                    array[index + 0x20] = 1;
                                    array[index + 0x24] = 100;
                                    array[index + 40] = 1;
                                    array[index + 0x2b] = 1;
                                    break;
                            }
                        }
                        index += 0x30;
                    }
                    array[index] = 0xff;
                    array[index + 1] = 0xff;
                    index += 0x30;
                    numArray10[num66, 1] = index - num2;
                    for (int num71 = 0; num71 < 2; num71++)
                    {
                        if (strBoss[0, num71].nameValue > 0)
                        {
                            array[index + (num71 * 4)] = Convert.ToByte(strBoss[0, num71].nameValue);
                        }
                        else
                        {
                            for (int num72 = 0; num72 < 4; num72++)
                            {
                                array[(index + (num71 * 4)) + num72] = 0xff;
                            }
                        }
                    }
                    index += 8;
                    for (int num73 = 0; num73 < 8; num73++)
                    {
                        array[index + num73] = 0xff;
                    }
                    index += 8;
                    if (strBoss[0, 1].nameValue <= 0)
                    {
                        break;
                    }
                }
            }
            array[num2 + 0x20] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 0x21] = Convert.ToByte((int)((index - num2) >> 8));
            for (int num74 = 0; num74 < 5; num74++)
            {
                if (numArray10[num74, 0] <= 0)
                {
                    break;
                }
                array[index] = 1;
                array[index + 8] = Convert.ToByte((int)(numArray10[num74, 1] & 0xff));
                array[index + 9] = Convert.ToByte((int)(numArray10[num74, 1] >> 8));
                array[index + 12] = Convert.ToByte((int)(numArray10[num74, 0] & 0xff));
                array[index + 13] = Convert.ToByte((int)(numArray10[num74, 0] >> 8));
                index += 0x10;
            }
            index += 0x10;

            array[num2 + 0x2c] = Convert.ToByte((int)((index - num2) & 0xff));
            array[num2 + 0x2d] = Convert.ToByte((int)((index - num2) >> 8));
            if (!BossRandomSysRadioBtn1.Checked)
            {
                for (int num75 = 0; num75 < 3; num75++)
                {
                    if (randomBoss[num75].nameValue <= 0)
                    {
                        break;
                    }
                    array[(num2 + 0x40) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].volume);
                    array[(num2 + 0x42) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].volumeChange);
                    array[(num2 + 0x43) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].monsterHP);
                    array[(num2 + 0x44) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].AttackPower);
                    array[(num2 + 0x45) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].DefensePower);
                    array[(num2 + 70) + (num75 * 8)] = Convert.ToByte(randomBoss[num75].Endurance);
                    array[(num2 + 0x47) + (num75 * 8)] = 1;
                    switch (num75)
                    {
                        case 0:
                            if (AppearanceProbabilityNumUpD1.Value <= 0M)
                            {
                                break;
                            }
                            array[index] = Convert.ToByte(AppearanceProbabilityNumUpD1.Value);
                            goto Label_3AF5;

                        case 1:
                            if (AppearanceProbabilityNumUpD2.Value <= 0M)
                            {
                                goto Label_3AB5;
                            }
                            array[index] = Convert.ToByte(AppearanceProbabilityNumUpD2.Value);
                            goto Label_3AF5;

                        case 2:
                            if (AppearanceProbabilityNumUpD3.Value <= 0M)
                            {
                                goto Label_3AE9;
                            }
                            array[index] = Convert.ToByte(AppearanceProbabilityNumUpD3.Value);
                            goto Label_3AF5;

                        default:
                            array[index] = 0x19;
                            goto Label_3AF5;
                    }
                    array[index] = 0x19;
                    goto Label_3AF5;
                Label_3AB5:
                    array[index] = 0x19;
                    goto Label_3AF5;
                Label_3AE9:
                    array[index] = 0x19;
                Label_3AF5:
                    if (BossRandomSysRadioBtn3.Checked)
                    {
                        array[index + 2] = Convert.ToByte((int)(11 + num75));
                        array[index + 3] = Convert.ToByte((int)(3 + num75));
                    }
                    array[index + 4] = Convert.ToByte(randomBoss[num75].nameValue);
                    array[index + 6] = Convert.ToByte(randomBoss[num75].runningAppearance);
                    array[index + 8] = Convert.ToByte(randomBoss[num75].number);
                    if (BossRandomSysRadioBtn2.Checked)
                    {
                        array[index + 9] = 3;
                    }
                    array[index + 10] = Convert.ToByte(randomBoss[num75].point);
                    if (randomBoss[num75].toFace == 0)
                    {
                        Random random4 = new Random(DateTime.Now.Millisecond);
                        array[index + 0x10] = Convert.ToByte(random4.Next(0x10, 0xee));
                        array[index + 0x11] = Convert.ToByte(random4.Next(0x10, 0xee));
                    }
                    else
                    {
                        array[index + 0x10] = Convert.ToByte((int)(randomBoss[num75].toFace & 0xff));
                        array[index + 0x11] = Convert.ToByte((int)(randomBoss[num75].toFace >> 8));
                    }
                    for (int num76 = 0; num76 < 3; num76++)
                    {
                        float num77 = 0f;
                        switch (num76)
                        {
                            case 0:
                                num77 = randomBoss[num75].X;
                                break;

                            case 1:
                                num77 = randomBoss[num75].Z;
                                break;

                            case 2:
                                num77 = randomBoss[num75].Y;
                                break;
                        }
                        byte[] buffer7 = BitConverter.GetBytes(num77);
                        for (int num78 = 0; num78 < buffer7.Length; num78++)
                        {
                            if (num78 == 4)
                            {
                                break;
                            }
                            array[((index + 20) + num78) + (num76 * 4)] = buffer7[num78];
                        }
                    }
                    array[index + 0x24] = Convert.ToByte((int)(2 + num75));
                    array[index + 40] = 100;
                    array[index + 0x2f] = Convert.ToByte((int)(2 + num75));
                    index += 0x34;
                }
            }
            array[index] = 0xff;
            array[index + 1] = 0xff;
            array[index + 3] = 0xff;
            array[index + 4] = 0xff;
            array[index + 5] = 0xff;
            index += 0x34;
            int num79 = index - num2;
            for (int num80 = 0; num80 < 2; num80++)
            {
                if (numArray2[num80] > 0)
                {
                    array[numArray2[num80]] = Convert.ToByte((int)(num79 & 0xff));
                    array[numArray2[num80] + 1] = Convert.ToByte((int)(num79 >> 8));
                }
            }
            byte[] bytes = Encoding.ASCII.GetBytes("[QS3]DarkVanthCopyrights");
            for (int num81 = 0; num81 < bytes.Length; num81++)
            {
                array[index + num81] = bytes[num81];
            }
            index += 0x20;

            if ((DestinationFileType.ToLower() == "mib") || (DestinationFileType.ToLower() == "cqs"))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(array, 0, index);
                ms.Seek(0, SeekOrigin.Begin);

                byte[] fullQuestBytes = new byte[index + 0x20];

                // Setting the Header
                Random random = new Random(DateTime.Now.Millisecond);
                for (int num10 = 0; num10 < 8; num10++)
                {
                    fullQuestBytes[num10] = Convert.ToByte(random.Next(2, 0xfe));
                }

                int questDimension = (int)(ms.Length);
                byte[] dimBytes = BitConverter.GetBytes(questDimension);

                int x = 0;
                for (x = 0; x < 4; x++)
                {
                    if (x < dimBytes.Length)
                        fullQuestBytes[8 + x] = dimBytes[x];
                    else
                        fullQuestBytes[8 + x] = 0x00;
                }

                // Adding the SHA1
                byte[] shaBuffer = new byte[index];
                ms.Read(shaBuffer, 0, shaBuffer.Length);
                byte[] hash = SHA1Class.ComputeHash(shaBuffer, "SHA1", Encoding.UTF8.GetBytes("sR2Tf4eLAj8b3TH7"));

                for (x = 0; x < hash.Length; x++)
                {
                    fullQuestBytes[0x0C + x] = hash[x];
                }

                // Adding the Quest File
                x = 0;
                foreach (byte b in shaBuffer)
                {
                    fullQuestBytes[0x20 + x] = b;
                    x++;
                }

                fullQuestBytes = SHA1Class.ProcessQuest(fullQuestBytes);

                if (DestinationFileType.ToLower() == "cqs")
                {
                    string infosplitter = "<!infov2!>";
                    string cqsheader = infosplitter + SN_NumUpDown.Value.ToString();
                    cqsheader += infosplitter + taskTitleText.Text;
                    cqsheader += infosplitter + RemuntNumUpDown.Value.ToString();
                    cqsheader += infosplitter + ContractNumUpDown.Value.ToString();

                    string MapId = "";
                    switch (MapTag)
                    {
                        case "Isola":
                            MapId = "1";
                            break;

                        case "Pianure":
                            MapId = "2";
                            break;

                        case "Foresta":
                            MapId = "3";
                            break;

                        case "Tundra":
                            MapId = "4";
                            break;

                        case "Vulcano":
                            MapId = "5";
                            break;

                        case "Cascate":
                            MapId = "6";
                            break;

                        case "Grande Deserto":
                            MapId = "7";
                            break;

                        case "Canyon di Lava":
                            MapId = "8";
                            break;

                        case "Arena":
                            MapId = "9";
                            break;

                        case "Arena Piccola":
                            MapId = "10";
                            break;

                        case "Terra Sacra":
                            MapId = "11";
                            break;

                        case "Zona Polare":
                            MapId = "12";
                            break;

                        case "Cima Montagna":
                            MapId = "13";
                            break;
                    }
                    cqsheader += infosplitter + MapId;
                    cqsheader += infosplitter + TaskTypeCmbBox.SelectedIndex.ToString();
                    cqsheader += infosplitter + VicyTermCmbBox1.SelectedIndex + "," + VicyTermCmbBox2.SelectedIndex;
                    cqsheader += infosplitter + taskDescriptionText.Text;
                    cqsheader += infosplitter + (StarGradeCmbBox.SelectedIndex + 1).ToString();
                    cqsheader += infosplitter + TimeNumUpDown.Value.ToString();
                    cqsheader += infosplitter + OpenLimitCmbBox1.SelectedIndex + "," + OpenLimitCmbBox2.SelectedIndex;
                    cqsheader += infosplitter + Configs.CurrentLanguage + infosplitter;

                    int bytexcount = Encoding.UTF8.GetByteCount(cqsheader);
                    FileStream cqsstream = new FileStream(DestinationFilename, FileMode.Truncate);
                    cqsstream.Write(BitConverter.GetBytes(bytexcount + sizeof(int)), 0, sizeof(int));
                    cqsstream.Flush();
                    cqsstream.Write(Encoding.UTF8.GetBytes(cqsheader), 0, bytexcount);
                    cqsstream.Flush();
                    cqsstream.Write(fullQuestBytes, 0, fullQuestBytes.Length);
                    cqsstream.Close();
                }
                else
                {
                    FileStream mibstream = new FileStream(DestinationFilename, FileMode.Truncate);
                    mibstream.Write(fullQuestBytes, 0, fullQuestBytes.Length);
                    mibstream.Close();
                }
            }
            else
            {
                if (DestinationFileType.ToLower() == "mis")
                {
                    if ((index % 4) != 0)
                    {
                        index = (index + 4) - (index % 4);
                    }
                    byte[] buffer = new byte[index + 20];
                    SHA1 sha = new SHA1CryptoServiceProvider();
                    byte[] buffer10 = new byte[] { 
                    1, 0xff, 0x3a, 0xb3, 0x61, 100, 0x65, 0x42, 0x79, 0x54, 0x69, 0xde, 0x41, 0xb9, 0x33, 0xbf, 
                    0xec, 0x6f, 0x5b, 0x52
                 };
                    for (int num82 = 0; num82 < 20; num82++)
                    {
                        buffer[num82] = buffer10[num82];
                    }
                    for (int num83 = 0; num83 < (buffer.Length - 20); num83++)
                    {
                        buffer[num83 + 20] = array[num83];
                    }
                    byte[] buffer11 = sha.ComputeHash(buffer);
                    sha.Clear();
                    //sha.Dispose();
                    for (int num84 = 0; num84 < 20; num84++)
                    {
                        buffer[num84] = buffer11[num84];
                    }
                    for (int num85 = 0; num85 < buffer.Length; num85 += 4)
                    {
                        for (int num86 = 0; num86 < 4; num86++)
                        {
                            buffer[num85 + num86] = DataClass.aaaatobbbb[buffer[num85 + num86]];
                        }
                    }
                    array = ByteXXXXtoYYYY(buffer, 0x6a257319);
                }
                FileStream stream = new FileStream(DestinationFilename, FileMode.Create);
                if (DestinationFileType.ToLower() == "mis")
                {
                    stream.Write(array, 0, index + 20);
                }
                else
                {
                    stream.Write(array, 0, index);
                }
                stream.Close();
            }
            return index;
        }

        #region TabPage Details

        private void BaseContrLstViewSubItemClear()
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = Convert.ToInt16(BaseSnNumUpD.Value) - 1;
                if ((index >= 0) && (index < 20))
                {
                    if (strRation[index].nameValue == 0)
                    {
                        BaseContrLstView1.Items[index].SubItems[1].Text = "";
                        BaseContrLstView1.Items[index].SubItems[2].Text = "";
                    }
                }
                else if (((index >= 20) && (index < 40)) && (strRation[index].nameValue == 0))
                {
                    BaseContrLstView2.Items[index - 20].SubItems[1].Text = "";
                    BaseContrLstView2.Items[index - 20].SubItems[2].Text = "";
                }
            }
        }

        #region Quest Info

        private void randomizeIDButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            SN_NumUpDown.Value = r.Next(59000, 61099);
        }

        private void MonsterIconCmbBox_Leave(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            bool flag = false;
            if ((EditToolState == "Open") && (box.Items.Count > 0))
            {
                for (int i = 0; i < box.Items.Count; i++)
                {
                    if ((box.Items[i].ToString().Length >= box.Text.Length) && (box.Text == box.Items[i].ToString().Substring(0, box.Text.Length)))
                    {
                        box.SelectedIndex = i;
                        flag = true;
                        return;
                    }
                }
                if (!flag)
                {
                    box.SelectedIndex = 0;
                }
            }
        }

        #endregion

        #region Quest Data

        private void StarGradeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResouresDataInit();
        }

        private void VicyTermCmbBox1_Leave(object sender, EventArgs e)
        {
            if ((EditToolState == "Open") && (VicyTermCmbBox1.Items.Count > 0))
            {
                bool flag = false;
                for (int i = 0; i < VicyTermCmbBox1.Items.Count; i++)
                {
                    if (VicyTermCmbBox1.Text == VicyTermCmbBox1.Items[i].ToString())
                    {
                        VicyTermCmbBox1.SelectedIndex = i;
                        flag = true;
                        return;
                    }
                }
                if (!flag)
                {
                    for (int j = 0; j < VicyTermCmbBox1.Items.Count; j++)
                    {
                        if ((VicyTermCmbBox1.Items[j].ToString().Length >= VicyTermCmbBox1.Text.Length) && (VicyTermCmbBox1.Text == VicyTermCmbBox1.Items[j].ToString().Substring(0, VicyTermCmbBox1.Text.Length)))
                        {
                            VicyTermCmbBox1.SelectedIndex = j;
                            flag = true;
                            return;
                        }
                    }
                }
                if (!flag)
                {
                    VicyTermCmbBox1.SelectedIndex = 0;
                }
            }
        }

        private void VicyTermCmbBox2_Leave(object sender, EventArgs e)
        {
            if ((EditToolState == "Open") && (VicyTermCmbBox2.Items.Count > 0))
            {
                bool flag = false;
                for (int i = 0; i < VicyTermCmbBox2.Items.Count; i++)
                {
                    if (VicyTermCmbBox2.Text == VicyTermCmbBox2.Items[i].ToString())
                    {
                        VicyTermCmbBox2.SelectedIndex = i;
                        flag = true;
                        return;
                    }
                }
                if (!flag)
                {
                    for (int j = 0; j < VicyTermCmbBox2.Items.Count; j++)
                    {
                        if ((VicyTermCmbBox2.Items[j].ToString().Length >= VicyTermCmbBox2.Text.Length) && (VicyTermCmbBox2.Text == VicyTermCmbBox2.Items[j].ToString().Substring(0, VicyTermCmbBox2.Text.Length)))
                        {
                            VicyTermCmbBox2.SelectedIndex = j;
                            flag = true;
                            return;
                        }
                    }
                }
                if (!flag)
                {
                    VicyTermCmbBox2.SelectedIndex = 0;
                }
            }
        }

        #endregion

        #endregion

        #region TabPage Monsters

        private void BossSubItemClear()
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    if (strBoss[num, num2].nameValue == 0)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            BossListView.Items[(num * 2) + num2].SubItems[i].Text = "";
                        }
                    }
                }
                else if (randomBoss[((num - 5) * 2) + num2].nameValue == 0)
                {
                    for (int j = 1; j < 13; j++)
                    {
                        BossListView.Items[(num * 2) + num2].SubItems[j].Text = "";
                    }
                }
            }
        }

        private void BossListView_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(BossListView.Items.IndexOf(BossListView.FocusedItem)) >> 1;
                int num2 = BossListView.Items.IndexOf(BossListView.FocusedItem) % 2;
                if (num < 5)
                {
                    BossSetGroupBox.Text = Language.Dictionary["edit"]["title"] + ": " + Language.Dictionary["edit"]["wave"] + " " + (num + 1);
                    if (strBoss[num, num2].nameValue == 0)
                    {
                        BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[strBoss[num, num2].nameValue];
                        BossListView.Items[(num * 2) + num2].SubItems[2].Text = Convert.ToString(strBoss[num, num2].number);
                        BossListView.Items[(num * 2) + num2].SubItems[3].Text = Convert.ToString(strBoss[num, num2].monsterHP);
                        BossListView.Items[(num * 2) + num2].SubItems[4].Text = Convert.ToString(strBoss[num, num2].AttackPower);
                        BossListView.Items[(num * 2) + num2].SubItems[5].Text = Convert.ToString(strBoss[num, num2].DefensePower);
                        BossListView.Items[(num * 2) + num2].SubItems[6].Text = Convert.ToString(strBoss[num, num2].Endurance);
                        BossListView.Items[(num * 2) + num2].SubItems[7].Text = Convert.ToString(strBoss[num, num2].volume);
                        BossListView.Items[(num * 2) + num2].SubItems[8].Text = Convert.ToString(strBoss[num, num2].volumeChange);
                        BossListView.Items[(num * 2) + num2].SubItems[9].Text = strMapPoint[strBoss[num, num2].point];
                        BossListView.Items[(num * 2) + num2].SubItems[10].Text = Convert.ToString(strBoss[num, num2].X);
                        BossListView.Items[(num * 2) + num2].SubItems[11].Text = Convert.ToString(strBoss[num, num2].Z);
                        BossListView.Items[(num * 2) + num2].SubItems[12].Text = Convert.ToString(strBoss[num, num2].Y);
                    }
                    BossSnNumUD.Value = ((num * 2) + num2) + 1;
                    BossNameCmbBox.Text = strMonsterNames[strBoss[num, num2].nameValue];
                    if (BossHPCmBox.Items.Count > 50)
                    {
                        BossHPCmBox.SelectedIndex = strBoss[num, num2].monsterHP;
                    }
                    BossJumpNumUDn.Value = strBoss[num, num2].volumeChange;
                    BossAttackNumUD.Value = strBoss[num, num2].AttackPower;
                    BossDefenseNumUD.Value = strBoss[num, num2].DefensePower;
                    BossEnduranceNumUpD.Value = strBoss[num, num2].Endurance;
                    BOSSstyleNumUpD.Value = strBoss[num, num2].runningAppearance;
                    BossNumNumUD.Value = strBoss[num, num2].number;
                    if (strBoss[num, num2].volume <= 0)
                    {
                        strBoss[num, num2].volume = 100;
                    }
                    BossVolumnNumUD.Value = strBoss[num, num2].volume;
                    BPointCmbBox.SelectedIndex = strBoss[num, num2].point;
                    BossXNumUD.Value = Convert.ToInt32(strBoss[num, num2].X);
                    BossZNumUD.Value = Convert.ToInt32(strBoss[num, num2].Z);
                    BossYNumUD.Value = Convert.ToInt32(strBoss[num, num2].Y);
                    BossToFaceNumUD.Value = strBoss[num, num2].toFace;
                }
                else
                {
                    BossSetGroupBox.Text = Language.Dictionary["edit"]["title"] + ": " + Language.Dictionary["edit"]["instablewave"];
                    if (randomBoss[((num - 5) * 2) + num2].nameValue == 0)
                    {
                        BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                        BossListView.Items[(num * 2) + num2].SubItems[2].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].number);
                        BossListView.Items[(num * 2) + num2].SubItems[3].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].monsterHP);
                        BossListView.Items[(num * 2) + num2].SubItems[4].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].AttackPower);
                        BossListView.Items[(num * 2) + num2].SubItems[5].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].DefensePower);
                        BossListView.Items[(num * 2) + num2].SubItems[6].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Endurance);
                        BossListView.Items[(num * 2) + num2].SubItems[7].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].volume);
                        BossListView.Items[(num * 2) + num2].SubItems[8].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].volumeChange);
                        BossListView.Items[(num * 2) + num2].SubItems[9].Text = strMapPoint[randomBoss[((num - 5) * 2) + num2].point];
                        BossListView.Items[(num * 2) + num2].SubItems[10].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].X);
                        BossListView.Items[(num * 2) + num2].SubItems[11].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Z);
                        BossListView.Items[(num * 2) + num2].SubItems[12].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Y);
                    }
                    BossSnNumUD.Value = ((num * 2) + num2) + 1;
                    BossNameCmbBox.Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                    if (BossHPCmBox.Items.Count > 50)
                    {
                        BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                    }
                    BossJumpNumUDn.Value = randomBoss[((num - 5) * 2) + num2].volumeChange;
                    BossAttackNumUD.Value = randomBoss[((num - 5) * 2) + num2].AttackPower;
                    BossDefenseNumUD.Value = randomBoss[((num - 5) * 2) + num2].DefensePower;
                    BossEnduranceNumUpD.Value = randomBoss[((num - 5) * 2) + num2].Endurance;
                    BOSSstyleNumUpD.Value = randomBoss[((num - 5) * 2) + num2].runningAppearance;
                    BossNumNumUD.Value = randomBoss[((num - 5) * 2) + num2].number;
                    if (randomBoss[((num - 5) * 2) + num2].volume <= 0)
                    {
                        randomBoss[((num - 5) * 2) + num2].volume = 100;
                    }
                    BossVolumnNumUD.Value = randomBoss[((num - 5) * 2) + num2].volume;
                    BPointCmbBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].point;
                    BossXNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].X);
                    BossZNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].Z);
                    BossYNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].Y);
                    BossToFaceNumUD.Value = randomBoss[((num - 5) * 2) + num2].toFace;
                }
                if (((num * 2) + num2) < 10)
                {
                    BossPanel.Location = new Point(0x5e, 0x41 + (((num * 2) + num2) * 13));
                }
                else
                {
                    BossPanel.Location = new Point(0x5e, 0x37 + ((((num * 2) - 10) + num2) * 13));
                }
                BossPanel.Visible = true;
                BossNameCmbBox.Focus();
            }
        }

        private void BossTabPage_Click(object sender, EventArgs e)
        {
            BossPanel.Visible = false;
            BossSubItemClear();
        }

        #region Special Options

        private void numUpDnDouNoTimeToDefer_ValueChanged(object sender, EventArgs e)
        {
            chkBoxDouNoTimeToDefer.Checked = numUpDnDouNoTimeToDefer.Value > 0M;
        }

        private void BossRandomSysRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BossRandomSysRadioBtn1.Checked)
            {
                EnvironmentCmbBox2.SelectedIndex = 0;
                WarningUnionNumUpD.Enabled = false;
                WarningRemuntNumUpD.Enabled = false;
                AppearanceProbabilityNumUpD1.Enabled = false;
                AppearanceProbabilityNumUpD2.Enabled = false;
                AppearanceProbabilityNumUpD3.Enabled = false;
                BossRandomUnknowValueTextBox.Enabled = false;
                BossRandomButton.Enabled = false;
            }
            if (BossRandomSysRadioBtn2.Checked)
            {
                EnvironmentCmbBox2.SelectedIndex = 1;
                WarningUnionNumUpD.Enabled = false;
                WarningRemuntNumUpD.Enabled = false;
                AppearanceProbabilityNumUpD1.Enabled = true;
                AppearanceProbabilityNumUpD2.Enabled = true;
                AppearanceProbabilityNumUpD3.Enabled = true;
                BossRandomUnknowValueTextBox.Enabled = false;
                BossRandomButton.Enabled = false;
            }
            if (BossRandomSysRadioBtn3.Checked)
            {
                EnvironmentCmbBox2.SelectedIndex = 2;
                WarningUnionNumUpD.Enabled = true;
                WarningRemuntNumUpD.Enabled = true;
                AppearanceProbabilityNumUpD1.Enabled = true;
                AppearanceProbabilityNumUpD2.Enabled = true;
                AppearanceProbabilityNumUpD3.Enabled = true;
                BossRandomUnknowValueTextBox.Enabled = true;
                BossRandomButton.Enabled = true;
            }
        }

        private void BossRandomUnknowValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar >= 'a') && (e.KeyChar <= 'f')) || ((e.KeyChar >= 'A') && (e.KeyChar <= 'F'))) || (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == Convert.ToChar(8))))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BossRandomButton_Click(object sender, EventArgs e)
        {
            //BossRandomUnknowValueTextBox.Text = "FFFFFFFF";
            
            Random random = new Random(DateTime.Now.Millisecond);
            BossRandomUnknowValueTextBox.Text = "";
            for (int i = 0; i < 4; i++)
            {
                BossRandomUnknowValueTextBox.Text = BossRandomUnknowValueTextBox.Text + toHexString(Convert.ToByte(random.Next(7, 0xcf)));
            }
            
        }

        #endregion

        #region Edit Panel

        private void BossSnNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    BossSetGroupBox.Text = Language.Dictionary["edit"]["title"] + ": " + Language.Dictionary["edit"]["wave"] + " " + (num + 1);
                    if (strBoss[num, num2].nameValue == 0)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            BossListView.Items[(num * 2) + num2].SubItems[i].Text = "";
                        }
                    }
                    BossNameCmbBox.Text = strMonsterNames[strBoss[num, num2].nameValue];
                    if (BossHPCmBox.Items.Count > 50)
                    {
                        BossHPCmBox.SelectedIndex = strBoss[num, num2].monsterHP;
                    }
                    BossJumpNumUDn.Value = strBoss[num, num2].volumeChange;
                    BossAttackNumUD.Value = strBoss[num, num2].AttackPower;
                    BossDefenseNumUD.Value = strBoss[num, num2].DefensePower;
                    BossEnduranceNumUpD.Value = strBoss[num, num2].Endurance;
                    BOSSstyleNumUpD.Value = strBoss[num, num2].runningAppearance;
                    BossNumNumUD.Value = strBoss[num, num2].number;
                    if (strBoss[num, num2].volume <= 0)
                    {
                        strBoss[num, num2].volume = 100;
                    }
                    BossVolumnNumUD.Value = strBoss[num, num2].volume;
                    BPointCmbBox.SelectedIndex = strBoss[num, num2].point;
                    BossXNumUD.Value = Convert.ToInt32(strBoss[num, num2].X);
                    BossZNumUD.Value = Convert.ToInt32(strBoss[num, num2].Z);
                    BossYNumUD.Value = Convert.ToInt32(strBoss[num, num2].Y);
                    BossToFaceNumUD.Value = strBoss[num, num2].toFace;
                }
                else
                {
                    BossSetGroupBox.Text = Language.Dictionary["edit"]["title"] + ": " + Language.Dictionary["edit"]["instablewave"];
                    if (randomBoss[((num - 5) * 2) + num2].nameValue == 0)
                    {
                        for (int j = 1; j < 13; j++)
                        {
                            BossListView.Items[(num * 2) + num2].SubItems[j].Text = "";
                        }
                    }
                    BossNameCmbBox.Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                    if (BossHPCmBox.Items.Count > 50)
                    {
                        BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                    }
                    BossJumpNumUDn.Value = randomBoss[((num - 5) * 2) + num2].volumeChange;
                    BossAttackNumUD.Value = randomBoss[((num - 5) * 2) + num2].AttackPower;
                    BossDefenseNumUD.Value = randomBoss[((num - 5) * 2) + num2].DefensePower;
                    BossEnduranceNumUpD.Value = randomBoss[((num - 5) * 2) + num2].Endurance;
                    BOSSstyleNumUpD.Value = randomBoss[((num - 5) * 2) + num2].runningAppearance;
                    BossNumNumUD.Value = randomBoss[((num - 5) * 2) + num2].number;
                    if (randomBoss[((num - 5) * 2) + num2].volume <= 0)
                    {
                        randomBoss[((num - 5) * 2) + num2].volume = 100;
                    }
                    BossVolumnNumUD.Value = randomBoss[((num - 5) * 2) + num2].volume;
                    BPointCmbBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].point;
                    BossXNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].X);
                    BossZNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].Z);
                    BossYNumUD.Value = Convert.ToInt32(randomBoss[((num - 5) * 2) + num2].Y);
                    BossToFaceNumUD.Value = randomBoss[((num - 5) * 2) + num2].toFace;
                }
            }
        }

        private void BossNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                BossHPCmBox.Items.Clear();
                if (BossNameCmbBox.SelectedIndex > 0)
                {
                    for (int i = 0; i < DataClass.strMonsterHPTimes.Length; i++)
                    {
                        long num3;
                        num3 = num3 = DataClass.strMonsterHPbase[BossNameCmbBox.SelectedIndex - 1] * DataClass.strMonsterHPTimes[i];
                        BossHPCmBox.Items.Add(Convert.ToString(num3));
                    }
                }
                if (num < 5)
                {
                    for (int j = 0; j < strMonsterNames.Length; j++)
                    {
                        if (BossNameCmbBox.Text == strMonsterNames[j])
                        {
                            strBoss[num, num2].nameValue = j;
                            BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[strBoss[num, num2].nameValue];
                            if (BossHPCmBox.Items.Count > 50)
                            {
                                BossHPCmBox.SelectedIndex = strBoss[num, num2].monsterHP;
                            }
                            return;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < strMonsterNames.Length; k++)
                    {
                        if (BossNameCmbBox.Text == strMonsterNames[k])
                        {
                            randomBoss[((num - 5) * 2) + num2].nameValue = k;
                            BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                            if (BossHPCmBox.Items.Count > 50)
                            {
                                BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                            }
                            return;
                        }
                    }
                }
            }
        }

        private void BossNameCmbBox_Leave(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (((num < 5) && (strMonsterNames[strBoss[num, num2].nameValue] != BossNameCmbBox.Text)) || ((num >= 5) && (strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue] != BossNameCmbBox.Text)))
                {
                    BossHPCmBox.Items.Clear();
                    if (BossNameCmbBox.SelectedIndex > 0)
                    {
                        for (int i = 0; i < DataClass.strMonsterHPTimes.Length; i++)
                        {
                            long num3 = DataClass.strMonsterHPbase[BossNameCmbBox.SelectedIndex - 1] * DataClass.strMonsterHPTimes[i];
                            BossHPCmBox.Items.Add(Convert.ToString(num3));
                        }
                    }
                    if (num >= 5)
                    {
                        bool flag2 = false;
                        for (int j = 0; j < strMonsterNames.Length; j++)
                        {
                            if (BossNameCmbBox.Text == strMonsterNames[j])
                            {
                                randomBoss[((num - 5) * 2) + num2].nameValue = j;
                                BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                                flag2 = true;
                                if (BossHPCmBox.Items.Count > 50)
                                {
                                    BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                                }
                                return;
                            }
                        }
                        if (!flag2)
                        {
                            for (int k = 0; k < strMonsterNames.Length; k++)
                            {
                                if (((DataClass.strMonsterNamesType[k] == 1) && (BossNameCmbBox.Text.Length < strMonsterNames[k].Length)) && (BossNameCmbBox.Text == strMonsterNames[k].Substring(0, BossNameCmbBox.Text.Length)))
                                {
                                    BossNameCmbBox.Text = strMonsterNames[k];
                                    randomBoss[((num - 5) * 2) + num2].nameValue = k;
                                    BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[randomBoss[((num - 5) * 2) + num2].nameValue];
                                    if (BossHPCmBox.Items.Count > 50)
                                    {
                                        BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                                    }
                                    flag2 = true;
                                    if (BossHPCmBox.Items.Count > 50)
                                    {
                                        BossHPCmBox.SelectedIndex = randomBoss[((num - 5) * 2) + num2].monsterHP;
                                    }
                                    break;
                                }
                            }
                            if (!flag2)
                            {
                                BossNameCmbBox.SelectedIndex = 0;
                            }
                        }
                    }
                    else
                    {
                        bool flag = false;
                        for (int m = 0; m < strMonsterNames.Length; m++)
                        {
                            if (BossNameCmbBox.Text == strMonsterNames[m])
                            {
                                strBoss[num, num2].nameValue = m;
                                BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[strBoss[num, num2].nameValue];
                                flag = true;
                                if (BossHPCmBox.Items.Count > 50)
                                {
                                    BossHPCmBox.SelectedIndex = strBoss[num, num2].monsterHP;
                                }
                                return;
                            }
                        }
                        if (!flag)
                        {
                            for (int n = 0; n < strMonsterNames.Length; n++)
                            {
                                if (((DataClass.strMonsterNamesType[n] == 1) && (BossNameCmbBox.Text.Length < strMonsterNames[n].Length)) && (BossNameCmbBox.Text == strMonsterNames[n].Substring(0, BossNameCmbBox.Text.Length)))
                                {
                                    BossNameCmbBox.Text = strMonsterNames[n];
                                    strBoss[num, num2].nameValue = n;
                                    BossListView.Items[(num * 2) + num2].SubItems[1].Text = strMonsterNames[strBoss[num, num2].nameValue];
                                    flag = true;
                                    if (BossHPCmBox.Items.Count > 50)
                                    {
                                        BossHPCmBox.SelectedIndex = strBoss[num, num2].monsterHP;
                                    }
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                BossNameCmbBox.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
        }

        private void BossNumNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].number = Convert.ToInt16(BossNumNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[2].Text = Convert.ToString(strBoss[num, num2].number);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].number = Convert.ToInt16(BossNumNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[2].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].number);
                }
            }
        }

        private void BossHPCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((BossHPCmBox.Items.Count > 0) && (EditToolState.Substring(0, 4) == "Open"))
            {
                int num = Convert.ToInt16(BossSnNumUD.Value - 1) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].monsterHP = BossHPCmBox.SelectedIndex;
                    BossListView.Items[(num * 2) + num2].SubItems[3].Text = Convert.ToString(strBoss[num, num2].monsterHP);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].monsterHP = BossHPCmBox.SelectedIndex;
                    BossListView.Items[(num * 2) + num2].SubItems[3].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].monsterHP);
                }
            }
        }

        private void BossAttackNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(BossSnNumUD.Value - 1) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].AttackPower = Convert.ToInt16(BossAttackNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[4].Text = Convert.ToString(strBoss[num, num2].AttackPower);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].AttackPower = Convert.ToInt16(BossAttackNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[4].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].AttackPower);
                }
            }
        }

        private void BossDefenseNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(BossSnNumUD.Value - 1) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].DefensePower = Convert.ToInt16(BossDefenseNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[5].Text = Convert.ToString(strBoss[num, num2].DefensePower);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].DefensePower = Convert.ToInt16(BossDefenseNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[5].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].DefensePower);
                }
            }
        }

        private void BossEnduranceNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(BossSnNumUD.Value - 1) >> 1;
                int num2 = Convert.ToInt16((decimal)(BossSnNumUD.Value - 1) % 2M);
                if (num < 5)
                {
                    strBoss[num, num2].Endurance = Convert.ToInt16(BossEnduranceNumUpD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[6].Text = Convert.ToString(strBoss[num, num2].Endurance);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].Endurance = Convert.ToInt16(BossEnduranceNumUpD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[6].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Endurance);
                }
            }
        }

        private void BOSSstyleNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].runningAppearance = Convert.ToInt16(BOSSstyleNumUpD.Value);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].runningAppearance = Convert.ToInt16(BOSSstyleNumUpD.Value);
                }
            }
        }

        private void BossVolumnNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].volume = Convert.ToInt16(BossVolumnNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[7].Text = Convert.ToString(strBoss[num, num2].volume);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].volume = Convert.ToInt16(BossVolumnNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[7].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].volume);
                }
            }
        }

        private void BossJumpNumUDn_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].volumeChange = Convert.ToInt16(BossJumpNumUDn.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[8].Text = Convert.ToString(strBoss[num, num2].volumeChange);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].volumeChange = Convert.ToInt16(BossJumpNumUDn.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[8].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].volumeChange);
                }
            }
        }

        private void BPointCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].point = BPointCmbBox.SelectedIndex;
                    BossListView.Items[(num * 2) + num2].SubItems[9].Text = BPointCmbBox.Text;
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].point = BPointCmbBox.SelectedIndex;
                    BossListView.Items[(num * 2) + num2].SubItems[9].Text = BPointCmbBox.Text;
                }
            }
        }

        private void BossXNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].X = Convert.ToInt32(BossXNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[10].Text = Convert.ToString(strBoss[num, num2].X);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].X = Convert.ToInt32(BossXNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[10].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].X);
                }
            }
        }

        private void BossZNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].Z = Convert.ToInt32(BossZNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[11].Text = Convert.ToString(strBoss[num, num2].Z);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].Z = Convert.ToInt32(BossZNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[11].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Z);
                }
            }
        }

        private void BossYNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].Y = Convert.ToInt32(BossYNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[12].Text = Convert.ToString(strBoss[num, num2].Y);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].Y = Convert.ToInt32(BossYNumUD.Value);
                    BossListView.Items[(num * 2) + num2].SubItems[12].Text = Convert.ToString(randomBoss[((num - 5) * 2) + num2].Y);
                }
            }
        }

        private void BossToFaceNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16((BossSnNumUD.Value - 1)) >> 1;
                int num2 = Convert.ToInt16((decimal)((BossSnNumUD.Value - 1) % 2M));
                if (num < 5)
                {
                    strBoss[num, num2].toFace = Convert.ToInt32(BossToFaceNumUD.Value);
                }
                else
                {
                    randomBoss[((num - 5) * 2) + num2].toFace = Convert.ToInt32(BossToFaceNumUD.Value);
                }
            }
        }

        private void BossPanelCloseBtn_Click(object sender, EventArgs e)
        {
            BossPanel.Visible = false;
            BossSubItemClear();
        }

        private void BossPanel_Leave(object sender, EventArgs e)
        {
            BossPanel.Visible = false;
            BossSubItemClear();
        }

        #endregion

        #endregion

        #region TabPage Minions

        private void DogfishTabPage_Click(object sender, EventArgs e)
        {
            DogfishPanel.Visible = false;
            DogfishSubItemClear();
        }

        private void DogfishSubItemClear()
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                if (strDogfish[num, selectedIndex, num3].nameValue == 0)
                {
                    DogfishListView.Items[num3].SubItems[1].Text = "";
                    DogfishListView.Items[num3].SubItems[2].Text = "";
                    DogfishListView.Items[num3].SubItems[3].Text = "";
                    DogfishListView.Items[num3].SubItems[4].Text = "";
                    DogfishListView.Items[num3].SubItems[5].Text = "";
                    DogfishListView.Items[num3].SubItems[6].Text = "";
                    DogfishListView.Items[num3].SubItems[7].Text = "";
                    DogfishListView.Items[num3].SubItems[8].Text = "";
                }
            }
        }

        #region Minions Options

        private void DogfRdButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DogfRdButton1.Checked)
            {
                RoundRdButton1.Checked = true;
                RoundRdButton2.Enabled = false;
                RoundRdButton3.Enabled = false;
                DfAddCmbBox1.Enabled = false;
                DfAddCmbBox2.Enabled = false;
                DfAddNumNumUpDown1.Enabled = false;
                DfAddNumNumUpDown2.Enabled = false;
            }
            if (DogfRdButton2.Checked)
            {
                RoundRdButton1.Checked = true;
                RoundRdButton2.Enabled = true;
                RoundRdButton3.Enabled = false;
                DfAddCmbBox1.Enabled = true;
                DfAddCmbBox2.Enabled = false;
                DfAddNumNumUpDown1.Enabled = true;
                DfAddNumNumUpDown2.Enabled = false;
            }
            if (DogfRdButton3.Checked)
            {
                RoundRdButton2.Enabled = true;
                RoundRdButton3.Enabled = true;
                DfAddCmbBox1.Enabled = true;
                DfAddCmbBox2.Enabled = true;
                DfAddNumNumUpDown1.Enabled = true;
                DfAddNumNumUpDown2.Enabled = true;
            }
        }

        #endregion

        #region Big Monsters Options

        private void DogfishToBossChkBox_CheckedChanged(object sender, EventArgs e)
        {
            DfNameCmbBox.Items.Clear();
            if (DogfishToBossChkBox.Checked)
            {
                for (int i = 0; i < strMonsterNames.Length; i++)
                {
                    DfNameCmbBox.Items.Add(strMonsterNames[i]);
                }
            }
            else
            {
                for (int j = 0; j < strMonsterNames.Length; j++)
                {
                    if ((DataClass.strMonsterNamesType[j] == 0) || (DataClass.strMonsterNamesType[j] == 0xff))
                    {
                        DfNameCmbBox.Items.Add(strMonsterNames[j]);
                    }
                }
            }
        }

        #endregion

        #region General Options

        private void DfPointCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                DogfishListView.BeginUpdate();
                for (int i = 0; i < 10; i++)
                {
                    if (strDogfish[num, selectedIndex, i].nameValue != 0)
                    {
                        DogfishListView.Items[i].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, i].nameValue];
                        DogfishListView.Items[i].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, i].volume);
                        switch (strDogfish[num, selectedIndex, i].runningAppearance)
                        {
                            case 0:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["fixedshort"]; ;
                                break;

                            case 1:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["randomshort"];
                                break;

                            case 2:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["hidedshort"];
                                break;
                        }
                        DogfishListView.Items[i].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, i].number);
                        DogfishListView.Items[i].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, i].X);
                        DogfishListView.Items[i].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Z);
                        DogfishListView.Items[i].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Y);
                        DogfishListView.Items[i].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, i].toFace);
                    }
                    else
                    {
                        DogfishListView.Items[i].SubItems[1].Text = "";
                        DogfishListView.Items[i].SubItems[2].Text = "";
                        DogfishListView.Items[i].SubItems[3].Text = "";
                        DogfishListView.Items[i].SubItems[4].Text = "";
                        DogfishListView.Items[i].SubItems[5].Text = "";
                        DogfishListView.Items[i].SubItems[6].Text = "";
                        DogfishListView.Items[i].SubItems[7].Text = "";
                        DogfishListView.Items[i].SubItems[8].Text = "";
                    }
                    DogfishListView.EndUpdate();
                }
            }
        }

        private void RoundRdButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                DogfishListView.BeginUpdate();
                for (int i = 0; i < 10; i++)
                {
                    if (strDogfish[num, selectedIndex, i].nameValue != 0)
                    {
                        DogfishListView.Items[i].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, i].nameValue];
                        DogfishListView.Items[i].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, i].volume);
                        switch (strDogfish[num, selectedIndex, i].runningAppearance)
                        {
                            case 0:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["fixedshort"];
                                break;

                            case 1:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["randomshort"];
                                break;

                            case 2:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["hidedshort"];
                                break;
                        }
                        DogfishListView.Items[i].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, i].number);
                        DogfishListView.Items[i].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, i].X);
                        DogfishListView.Items[i].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Z);
                        DogfishListView.Items[i].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Y);
                        DogfishListView.Items[i].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, i].toFace);
                    }
                    else
                    {
                        DogfishListView.Items[i].SubItems[1].Text = "";
                        DogfishListView.Items[i].SubItems[2].Text = "";
                        DogfishListView.Items[i].SubItems[3].Text = "";
                        DogfishListView.Items[i].SubItems[4].Text = "";
                        DogfishListView.Items[i].SubItems[5].Text = "";
                        DogfishListView.Items[i].SubItems[6].Text = "";
                        DogfishListView.Items[i].SubItems[7].Text = "";
                        DogfishListView.Items[i].SubItems[8].Text = "";
                    }
                    DogfishListView.EndUpdate();
                }
            }
        }

        private void RoundRdButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 1;
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                DogfishListView.BeginUpdate();
                for (int i = 0; i < 10; i++)
                {
                    if (strDogfish[num, selectedIndex, i].nameValue != 0)
                    {
                        DogfishListView.Items[i].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, i].nameValue];
                        DogfishListView.Items[i].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, i].volume);
                        switch (strDogfish[num, selectedIndex, i].runningAppearance)
                        {
                            case 0:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["fixedshort"];
                                break;

                            case 1:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["randomshort"];
                                break;

                            case 2:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["hidedshort"];
                                break;
                        }
                        DogfishListView.Items[i].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, i].number);
                        DogfishListView.Items[i].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, i].X);
                        DogfishListView.Items[i].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Z);
                        DogfishListView.Items[i].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Y);
                        DogfishListView.Items[i].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, i].toFace);
                    }
                    else
                    {
                        DogfishListView.Items[i].SubItems[1].Text = "";
                        DogfishListView.Items[i].SubItems[2].Text = "";
                        DogfishListView.Items[i].SubItems[3].Text = "";
                        DogfishListView.Items[i].SubItems[4].Text = "";
                        DogfishListView.Items[i].SubItems[5].Text = "";
                        DogfishListView.Items[i].SubItems[6].Text = "";
                        DogfishListView.Items[i].SubItems[7].Text = "";
                        DogfishListView.Items[i].SubItems[8].Text = "";
                    }
                    DogfishListView.EndUpdate();
                }
            }
        }

        private void RoundRdButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 2;
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                DogfishListView.BeginUpdate();
                for (int i = 0; i < 10; i++)
                {
                    if (strDogfish[num, selectedIndex, i].nameValue != 0)
                    {
                        DogfishListView.Items[i].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, i].nameValue];
                        DogfishListView.Items[i].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, i].volume);
                        switch (strDogfish[num, selectedIndex, i].runningAppearance)
                        {
                            case 0:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["fixedshort"];
                                break;

                            case 1:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["randomshort"];
                                break;

                            case 2:
                                DogfishListView.Items[i].SubItems[3].Text = Language.Dictionary["edit"]["hidedshort"];
                                break;
                        }
                        DogfishListView.Items[i].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, i].number);
                        DogfishListView.Items[i].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, i].X);
                        DogfishListView.Items[i].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Z);
                        DogfishListView.Items[i].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, i].Y);
                        DogfishListView.Items[i].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, i].toFace);
                    }
                    else
                    {
                        DogfishListView.Items[i].SubItems[1].Text = "";
                        DogfishListView.Items[i].SubItems[2].Text = "";
                        DogfishListView.Items[i].SubItems[3].Text = "";
                        DogfishListView.Items[i].SubItems[4].Text = "";
                        DogfishListView.Items[i].SubItems[5].Text = "";
                        DogfishListView.Items[i].SubItems[6].Text = "";
                        DogfishListView.Items[i].SubItems[7].Text = "";
                        DogfishListView.Items[i].SubItems[8].Text = "";
                    }
                    DogfishListView.EndUpdate();
                }
            }
        }

        private void DogfishListView_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (RoundRdButton2.Checked)
            {
                num = 1;
            }
            else if (RoundRdButton3.Checked)
            {
                num = 2;
            }
            int selectedIndex = DfPointCmbBox.SelectedIndex;
            int index = DogfishListView.Items.IndexOf(DogfishListView.FocusedItem);
            DfSnNumUpD.Value = index + 1;
            DfNameCmbBox.Text = strMonsterNames[strDogfish[num, selectedIndex, index].nameValue];
            DfTypeNumUpD.Value = strDogfish[num, selectedIndex, index].volume;
            DfRoundTypeCmbBox.SelectedIndex = strDogfish[num, selectedIndex, index].runningAppearance;
            DfNumNumUpD.Value = strDogfish[num, selectedIndex, index].number;
            Df_XNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, index].X);
            Df_ZNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, index].Z);
            Df_YNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, index].Y);
            DftoFaceNumUpD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, index].toFace);
            if (strDogfish[num, selectedIndex, index].nameValue == 0)
            {
                DogfishListView.Items[index].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, index].nameValue];
                DogfishListView.Items[index].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, index].volume);
                switch (strDogfish[num, selectedIndex, index].runningAppearance)
                {
                    case 0:
                        DogfishListView.Items[index].SubItems[3].Text = Language.Dictionary["edit"]["fixedshort"];
                        break;

                    case 1:
                        DogfishListView.Items[index].SubItems[3].Text = Language.Dictionary["edit"]["randomshort"];
                        break;

                    case 2:
                        DogfishListView.Items[index].SubItems[3].Text = Language.Dictionary["edit"]["hidedshort"];
                        break;
                }
                DogfishListView.Items[index].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, index].number);
                DogfishListView.Items[index].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, index].X);
                DogfishListView.Items[index].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, index].Z);
                DogfishListView.Items[index].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, index].Y);
                DogfishListView.Items[index].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, index].toFace);
            }
            if (index < 4)
            {
                DogfishPanel.Location = new Point(0x86, 0xdf + (index * 13));
            }
            else
            {
                DogfishPanel.Location = new Point(0x86, 0x8f + ((index - 4) * 13));
            }
            DogfishPanel.Visible = true;
            DfNameCmbBox.Focus();
        }

        #endregion

        #region Edit Panel

        private void DogfishPanel_Leave(object sender, EventArgs e)
        {
            DogfishPanel.Visible = false;
            DogfishSubItemClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DogfishPanel.Visible = false;
            DogfishSubItemClear();
        }

        private void DfSnNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                DfNameCmbBox.Text = strMonsterNames[strDogfish[num, selectedIndex, num3].nameValue];
                DfTypeNumUpD.Value = strDogfish[num, selectedIndex, num3].volume;
                DfRoundTypeCmbBox.SelectedIndex = strDogfish[num, selectedIndex, num3].runningAppearance;
                DfNumNumUpD.Value = strDogfish[num, selectedIndex, num3].number;
                Df_XNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, num3].X);
                Df_ZNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, num3].Z);
                Df_YNumUD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, num3].Y);
                DftoFaceNumUpD.Value = Convert.ToInt32(strDogfish[num, selectedIndex, num3].toFace);
            }
        }

        private void DfNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    for (int i = 0; i < strMonsterNames.Length; i++)
                    {
                        if (DfNameCmbBox.Text == strMonsterNames[i])
                        {
                            strDogfish[num, selectedIndex, num3].nameValue = i;
                            break;
                        }
                    }
                    DogfishListView.Items[num3].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, num3].nameValue];
                }
            }
        }

        private void DfNameCmbBox_Leave(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    for (int i = 0; i < strMonsterNames.Length; i++)
                    {
                        if (DfNameCmbBox.Text == strMonsterNames[i])
                        {
                            strDogfish[num, selectedIndex, num3].nameValue = i;
                            break;
                        }
                    }
                    DogfishListView.Items[num3].SubItems[1].Text = strMonsterNames[strDogfish[num, selectedIndex, num3].nameValue];
                }
            }
        }

        private void DfRoundTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].runningAppearance = DfRoundTypeCmbBox.SelectedIndex;
                    switch (strDogfish[num, selectedIndex, num3].runningAppearance)
                    {
                        case 0:
                            DogfishListView.Items[num3].SubItems[3].Text = "" + Language.Dictionary["edit"]["fixedshort"];
                            return;

                        case 1:
                            DogfishListView.Items[num3].SubItems[3].Text = "" + Language.Dictionary["edit"]["randomshort"];
                            return;

                        case 2:
                            DogfishListView.Items[num3].SubItems[3].Text = "" + Language.Dictionary["edit"]["hidedshort"];
                            return;
                    }
                }
            }
        }

        private void DfNumNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].number = Convert.ToInt16(DfNumNumUpD.Value);
                    DogfishListView.Items[num3].SubItems[4].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].number);
                }
            }
        }

        private void DfTypeNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].volume = Convert.ToInt16(DfTypeNumUpD.Value);
                    DogfishListView.Items[num3].SubItems[2].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].volume);
                }
            }
        }

        private void Df_XNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].X = Convert.ToInt32(Df_XNumUD.Value);
                    DogfishListView.Items[num3].SubItems[5].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].X);
                }
            }
        }

        private void Df_YNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].Y = Convert.ToInt32(Df_YNumUD.Value);
                    DogfishListView.Items[num3].SubItems[7].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].Y);
                }
            }
        }

        private void Df_ZNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].Z = Convert.ToInt32(Df_ZNumUD.Value);
                    DogfishListView.Items[num3].SubItems[6].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].Z);
                }
            }
        }

        private void DftoFaceNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (RoundRdButton2.Checked)
                {
                    num = 1;
                }
                else if (RoundRdButton3.Checked)
                {
                    num = 2;
                }
                int selectedIndex = DfPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16((DfSnNumUpD.Value - 1));
                if ((num3 < 10) && (num3 >= 0))
                {
                    strDogfish[num, selectedIndex, num3].toFace = Convert.ToInt32(DftoFaceNumUpD.Value);
                    DogfishListView.Items[num3].SubItems[8].Text = Convert.ToString(strDogfish[num, selectedIndex, num3].toFace);
                }
            }
        }

        #endregion

        #endregion

        #region TabPage Supply

        private void FieldTabPage_Click(object sender, EventArgs e)
        {
            BasePanel.Visible = false;
            BaseContrLstViewSubItemClear();
        }

        private void SaveBaseSetButton_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                saveFileDialog1.Filter = Language.Dictionary["messages"]["itemlist"] + "(*.rat)|*.rat";
                saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data" + +Path.DirectorySeparatorChar;
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                string fileName = saveFileDialog1.FileName;
                if (fileName != "")
                {
                    byte[] byData = new byte[160];
                    for (int i = 0; i < 40; i++)
                    {
                        byData[i * 4] = Convert.ToByte((int)(strRation[i].nameValue & 0xff));
                        byData[(i * 4) + 1] = Convert.ToByte((int)(strRation[i].nameValue >> 8));
                        byData[(i * 4) + 2] = Convert.ToByte(strRation[i].number);
                        byData[(i * 4) + 3] = 0x1a;
                    }
                    byData = ByteXXXXtoYYYY(byData, 0xa1930f48L);
                    if (!File.Exists(fileName))
                    {
                        FileStream stream = new FileStream(fileName, FileMode.CreateNew);
                        stream.Write(byData, 0, byData.Length);
                        stream.Close();
                    }
                    else
                    {
                        FileStream stream2 = new FileStream(fileName, FileMode.Truncate);
                        stream2.Write(byData, 0, byData.Length);
                        stream2.Close();
                    }
                }
            }
        }

        private void LoadBaseSetButton_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                openFileDialog1.Filter = Language.Dictionary["messages"]["itemlist"] + "(*.rat)|*.rat";
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Data\";
                openFileDialog1.FileName = "";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.ShowDialog();
                byte[] buffer = new byte[160];
                string fileName = openFileDialog1.FileName;
                if (fileName != "")
                {
                    FileStream stream = new FileStream(fileName, FileMode.Open);
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.Read(buffer, 0, 160);
                    stream.Close();
                    buffer = ByteYYYYtoXXXX(buffer, 0xa1930f48L);
                    for (int i = 0; i < 20; i++)
                    {
                        strRation[i].nameValue = buffer[i * 4] + (buffer[(i * 4) + 1] << 8);
                        strRation[i].number = buffer[(i * 4) + 2];
                        if (strRation[i].nameValue > 0)
                        {
                            BaseContrLstView1.Items[i].SubItems[1].Text = ResouresNames[strRation[i].nameValue];
                            BaseContrLstView1.Items[i].SubItems[2].Text = Convert.ToString(strRation[i].number);
                        }
                        else
                        {
                            BaseContrLstView1.Items[i].SubItems[1].Text = "";
                            BaseContrLstView1.Items[i].SubItems[2].Text = "";
                        }
                    }
                    for (int j = 20; j < 40; j++)
                    {
                        strRation[j].nameValue = buffer[j * 4] + (buffer[(j * 4) + 1] << 8);
                        strRation[j].number = buffer[(j * 4) + 2];
                        if (strRation[j].nameValue > 0)
                        {
                            BaseContrLstView2.Items[j - 20].SubItems[1].Text = ResouresNames[strRation[j].nameValue];
                            BaseContrLstView2.Items[j - 20].SubItems[2].Text = Convert.ToString(strRation[j].number);
                        }
                        else
                        {
                            BaseContrLstView2.Items[j - 20].SubItems[1].Text = "";
                            BaseContrLstView2.Items[j - 20].SubItems[2].Text = "";
                        }
                    }
                }
            }
        }

        #region Object Options

        private void BaseContrLstView1_Click(object sender, EventArgs e)
        {
            int index = BaseContrLstView1.Items.IndexOf(BaseContrLstView1.FocusedItem);
            if (strRation[index].nameValue == 0)
            {
                BaseContrLstView1.Items[index].SubItems[1].Text = ResouresNames[strRation[index].nameValue];
                BaseContrLstView1.Items[index].SubItems[2].Text = Convert.ToString(strRation[index].number);
            }
            BaseSnNumUpD.Value = index + 1;
            BaseCmbBox.Text = ResouresNames[strRation[index].nameValue];
            BaseNumNumUpD.Value = strRation[index].number;
            BasePanel.Location = new Point(0x89, 0x41 + (index * 13));
            BasePanel.Visible = true;
            BaseCmbBox.Focus();
        }

        private void BaseContrLstView2_Click(object sender, EventArgs e)
        {
            int index = BaseContrLstView2.Items.IndexOf(BaseContrLstView2.FocusedItem);
            BaseSnNumUpD.Value = index + 0x15;
            BaseCmbBox.Text = ResouresNames[strRation[index + 20].nameValue];
            BaseNumNumUpD.Value = strRation[index + 20].number;
            BasePanel.Location = new Point(0x11e, 0x41 + (index * 13));
            BasePanel.Visible = true;
            BaseCmbBox.Focus();
        }

        #endregion

        #region Supply Options

        private void BaseContrNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = 0;
                if (!RadioBtnNothing.Checked)
                {
                    num = 12;
                    if (BaseRationNumUpD.Value > 32M)
                    {
                        BaseRationNumUpD.Value = 32M;
                    }
                }
                else
                {
                    num = 20;
                }
                if (BaseRationNumUpD.Value < 20M)
                {
                    for (int i = 0; i < Convert.ToInt16(BaseRationNumUpD.Value); i++)
                    {
                        BaseContrLstView1.Items[i].BackColor = Color.White;
                    }
                    for (int j = Convert.ToInt16(BaseRationNumUpD.Value); j < 20; j++)
                    {
                        BaseContrLstView1.Items[j].BackColor = Color.LightBlue;
                    }
                    for (int k = 0; k < num; k++)
                    {
                        BaseContrLstView2.Items[k].BackColor = Color.LightBlue;
                    }
                }
                else if (BaseRationNumUpD.Value >= 20M)
                {
                    for (int m = 0; m < 20; m++)
                    {
                        BaseContrLstView1.Items[m].BackColor = Color.White;
                    }
                    for (int n = 0; n < Convert.ToInt16((decimal)(BaseRationNumUpD.Value - 20M)); n++)
                    {
                        BaseContrLstView2.Items[n].BackColor = Color.White;
                    }
                    for (int num7 = Convert.ToInt16((decimal)(BaseRationNumUpD.Value - 20M)); num7 < num; num7++)
                    {
                        BaseContrLstView2.Items[num7].BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void RadioBtnRation_CheckedChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                if (RadioBtnNothing.Checked)
                {
                    CmbBoxConditionsRation.Enabled = false;
                    ConditionsRationCmbBoxNumUpD.Enabled = false;
                    for (int i = 12; i < 20; i++)
                    {
                        BaseContrLstView2.Items[i].BackColor = Color.LightBlue;
                    }
                }
                if (RadioBtnConditionsRation.Checked)
                {
                    CmbBoxConditionsRation.Enabled = true;
                    ConditionsRationCmbBoxNumUpD.Enabled = true;
                    for (int j = 12; j < 20; j++)
                    {
                        BaseContrLstView2.Items[j].BackColor = Color.Thistle;
                    }
                    if (BaseRationNumUpD.Value > 32M)
                    {
                        BaseRationNumUpD.Value = 32M;
                    }
                }
                if (RadioBtnRandomSysRation.Checked)
                {
                    CmbBoxConditionsRation.Enabled = false;
                    ConditionsRationCmbBoxNumUpD.Enabled = false;
                    for (int k = 12; k < 20; k++)
                    {
                        BaseContrLstView2.Items[k].BackColor = Color.Thistle;
                    }
                    if (BaseRationNumUpD.Value > 32M)
                    {
                        BaseRationNumUpD.Value = 32M;
                    }
                }
            }
        }

        #endregion

        #region Edit Panel

        private void BasePanel_Leave(object sender, EventArgs e)
        {
            BasePanel.Visible = false;
            BaseContrLstViewSubItemClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BasePanel.Visible = false;
            BaseContrLstViewSubItemClear();
        }

        private void BaseSnNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = Convert.ToInt16(BaseSnNumUpD.Value) - 1;
                BaseCmbBox.Text = ResouresNames[strRation[index].nameValue];
                BaseNumNumUpD.Value = strRation[index].number;
            }
        }

        private void BaseCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = Convert.ToInt16(BaseSnNumUpD.Value) - 1;
                for (int i = 0; i < 0x2ae; i++)
                {
                    if ((((DataClass.ResouresType[i] & 2) == 2) || (i == 0)) && (ResouresNames[i] == BaseCmbBox.Text))
                    {
                        strRation[index].nameValue = i;
                        break;
                    }
                }
                if ((index >= 0) && (index < 20))
                {
                    BaseContrLstView1.Items[index].SubItems[1].Text = ResouresNames[strRation[index].nameValue];
                }
                else if ((index >= 20) && (index < 40))
                {
                    BaseContrLstView2.Items[index - 20].SubItems[1].Text = ResouresNames[strRation[index].nameValue];
                }
            }
        }

        private void BaseCmbBox_Leave(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = Convert.ToInt16(BaseSnNumUpD.Value) - 1;
                for (int i = 0; i < ResouresNames.Length; i++)
                {
                    if ((((DataClass.ResouresType[i] & 2) == 2) || (i == 0)) && (ResouresNames[i] == BaseCmbBox.Text))
                    {
                        strRation[index].nameValue = i;
                        break;
                    }
                }
                if ((index >= 0) && (index < 20))
                {
                    BaseContrLstView1.Items[index].SubItems[1].Text = ResouresNames[strRation[index].nameValue];
                }
                else if ((index >= 20) && (index < 40))
                {
                    BaseContrLstView2.Items[index - 20].SubItems[1].Text = ResouresNames[strRation[index].nameValue];
                }
            }
        }

        private void BaseNumNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = Convert.ToInt16(BaseSnNumUpD.Value) - 1;
                strRation[index].number = Convert.ToInt16(BaseNumNumUpD.Value);
                if ((index >= 0) && (index < 20))
                {
                    BaseContrLstView1.Items[index].SubItems[2].Text = Convert.ToString(strRation[index].number);
                }
                else if ((index >= 20) && (index < 40))
                {
                    BaseContrLstView2.Items[index - 20].SubItems[2].Text = Convert.ToString(strRation[index].number);
                }
            }
        }

        #endregion

        #endregion

        #region TabPage Gathering

        private void ResourseTabPage_Click(object sender, EventArgs e)
        {
            ResourcesPanel.Visible = false;
            ResourseLstViewSubItemClear();
        }

        private void ResourseLstViewSubItemClear()
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                if (strResources[selectedIndex, num2, num3].nameValue == 0)
                {
                    ResourcesListView.Items[num3].SubItems[1].Text = "";
                    ResourcesListView.Items[num3].SubItems[2].Text = "";
                    ResourcesListView.Items[num3].SubItems[3].Text = "";
                }
            }
        }

        #region Gath Options

        private void RsrLandmassCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = 0;
                int num3 = 0;
                if (resourcesPoint[selectedIndex] > 0)
                {
                    RsrPointCmbBox.Items.Clear();
                    for (int i = 0; i < resourcesPoint[selectedIndex]; i++)
                    {
                        RsrPointCmbBox.Items.Add(Language.Dictionary["questgath"]["point"] + Convert.ToString((int)(i + 1)));
                    }
                    RsrPointCmbBox.SelectedIndex = 0;
                    num2 = RsrPointCmbBox.SelectedIndex;
                    for (int j = 0; j < 15; j++)
                    {
                        if (strResources[selectedIndex, num2, j].nameValue != 0)
                        {
                            ResourcesListView.Items[j].SubItems[1].Text = ResouresNames[strResources[selectedIndex, num2, j].nameValue];
                            ResourcesListView.Items[j].SubItems[2].Text = Convert.ToString(strResources[selectedIndex, num2, j].number);
                            ResourcesListView.Items[j].SubItems[3].Text = Convert.ToString(strResources[selectedIndex, num2, j].RateOrTeam) + " %";
                            num3 += strResources[selectedIndex, num2, j].RateOrTeam;
                        }
                        else
                        {
                            ResourcesListView.Items[j].SubItems[1].Text = "";
                            ResourcesListView.Items[j].SubItems[2].Text = "";
                            ResourcesListView.Items[j].SubItems[3].Text = "";
                        }
                    }
                }
                else
                {
                    RsrPointCmbBox.Items.Clear();
                    for (int k = 0; k < 15; k++)
                    {
                        ResourcesListView.Items[k].SubItems[1].Text = "";
                        ResourcesListView.Items[k].SubItems[2].Text = "";
                        ResourcesListView.Items[k].SubItems[3].Text = "";
                    }
                }
                RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num3) + "%)";
                if (num3 > 100)
                {
                    RsrRateLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    RsrRateLabel.ForeColor = Color.Black;
                }
                RsMININumUpD.Value = strResrPoint[selectedIndex, num2].miniNum;
                RsMAXNumUpD.Value = strResrPoint[selectedIndex, num2].maxiNum;
            }
        }

        private void RsrPointCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = 0;
                for (int i = 0; i < 15; i++)
                {
                    if (strResources[selectedIndex, num2, i].nameValue != 0)
                    {
                        ResourcesListView.Items[i].SubItems[1].Text = ResouresNames[strResources[selectedIndex, num2, i].nameValue];
                        ResourcesListView.Items[i].SubItems[2].Text = Convert.ToString(strResources[selectedIndex, num2, i].number);
                        ResourcesListView.Items[i].SubItems[3].Text = Convert.ToString(strResources[selectedIndex, num2, i].RateOrTeam) + " %";
                        num3 += strResources[selectedIndex, num2, i].RateOrTeam;
                    }
                    else
                    {
                        ResourcesListView.Items[i].SubItems[1].Text = "";
                        ResourcesListView.Items[i].SubItems[2].Text = "";
                        ResourcesListView.Items[i].SubItems[3].Text = "";
                    }
                }
                RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num3) + "%)";
                if (num3 > 100)
                {
                    RsrRateLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    RsrRateLabel.ForeColor = Color.Black;
                }
                RsMININumUpD.Value = strResrPoint[selectedIndex, num2].miniNum;
                RsMAXNumUpD.Value = strResrPoint[selectedIndex, num2].maxiNum;
            }
        }

        private void RsMININumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                strResrPoint[selectedIndex, num2].miniNum = Convert.ToInt16(RsMININumUpD.Value);
            }
        }

        private void RsMAXNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                strResrPoint[selectedIndex, num2].maxiNum = Convert.ToInt16(RsMAXNumUpD.Value);
            }
        }

        #endregion

        #region Gath List

        private void ResourcesListView_Click(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int index = ResourcesListView.Items.IndexOf(ResourcesListView.FocusedItem);
                if (strResources[selectedIndex, num2, index].nameValue == 0)
                {
                    ResourcesListView.Items[index].SubItems[1].Text = ResouresNames[strResources[selectedIndex, num2, index].nameValue];
                    ResourcesListView.Items[index].SubItems[2].Text = Convert.ToString(strResources[selectedIndex, num2, index].number);
                    ResourcesListView.Items[index].SubItems[3].Text = Convert.ToString(strResources[selectedIndex, num2, index].RateOrTeam) + " %";
                }
                ResSnNumUpD.Value = index + 1;
                ResNameCmbBox.Text = ResouresNames[strResources[selectedIndex, num2, index].nameValue];
                ResNumNumUpD.Value = strResources[selectedIndex, num2, index].number;
                ResRareNumUpD.Value = strResources[selectedIndex, num2, index].RateOrTeam;
                if (index < 9)
                {
                    ResourcesPanel.Location = new Point(0xab, 0xb1 + (index * 13));
                }
                else
                {
                    ResourcesPanel.Location = new Point(0xab, 0x52 + (index * 13));
                }
                ResourcesPanel.Visible = true;
                ResNameCmbBox.Focus();
            }
        }

        #endregion

        #region Edit Panel

        private void ResourcesPanel_Leave(object sender, EventArgs e)
        {
            ResourcesPanel.Visible = false;
            ResourseLstViewSubItemClear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ResourcesPanel.Visible = false;
            ResourseLstViewSubItemClear();
        }

        private void ResSnNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                ResNameCmbBox.Text = ResouresNames[strResources[selectedIndex, num2, num3].nameValue];
                ResNumNumUpD.Value = strResources[selectedIndex, num2, num3].number;
                ResRareNumUpD.Value = strResources[selectedIndex, num2, num3].RateOrTeam;
            }
        }

        private void ResNameCmbBox_Leave(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                if (ResNameCmbBox.SelectedIndex == 0)
                {
                    strResources[selectedIndex, num2, num3].nameValue = 0;
                }
                else
                {
                    for (int j = 1; j < ResouresNames.Length; j++)
                    {
                        if (((DataClass.ResouresType[j] & 1) == 1) && (ResNameCmbBox.Text == ResouresNames[j]))
                        {
                            strResources[selectedIndex, num2, num3].nameValue = j;
                            break;
                        }
                    }
                }
                ResourcesListView.Items[num3].SubItems[1].Text = ResouresNames[strResources[selectedIndex, num2, num3].nameValue];
                int num5 = 0;
                for (int i = 0; i < 15; i++)
                {
                    if (strResources[selectedIndex, num2, i].nameValue != 0)
                    {
                        num5 += strResources[selectedIndex, num2, i].RateOrTeam;
                    }
                }
                RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num5) + "%)";
                if (num5 > 100)
                {
                    RsrRateLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    RsrRateLabel.ForeColor = Color.Black;
                }
            }
        }

        private void ResNumNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                strResources[selectedIndex, num2, num3].number = Convert.ToInt16(ResNumNumUpD.Value);
                ResourcesListView.Items[num3].SubItems[2].Text = Convert.ToString(strResources[selectedIndex, num2, num3].number);
            }
        }

        private void ResNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                if (ResNameCmbBox.SelectedIndex == 0)
                {
                    strResources[selectedIndex, num2, num3].nameValue = 0;
                }
                else
                {
                    for (int j = 1; j < ResouresNames.Length; j++)
                    {
                        if (((DataClass.ResouresType[j] & 1) == 1) && (ResNameCmbBox.Text == ResouresNames[j]))
                        {
                            strResources[selectedIndex, num2, num3].nameValue = j;
                            break;
                        }
                    }
                }
                ResourcesListView.Items[num3].SubItems[1].Text = ResouresNames[strResources[selectedIndex, num2, num3].nameValue];
                int num5 = 0;
                for (int i = 0; i < 15; i++)
                {
                    if (strResources[selectedIndex, num2, i].nameValue != 0)
                    {
                        num5 += strResources[selectedIndex, num2, i].RateOrTeam;
                    }
                }
                RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num5) + "%)";
                if (num5 > 100)
                {
                    RsrRateLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    RsrRateLabel.ForeColor = Color.Black;
                }
            }
        }

        private void ResRareNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (((EditToolState == "Open") && (RsrPointCmbBox.Items.Count >= 1)) && (RsrLandmassCmbBox.Items.Count >= 1))
            {
                int selectedIndex = RsrLandmassCmbBox.SelectedIndex;
                int num2 = RsrPointCmbBox.SelectedIndex;
                int num3 = Convert.ToInt16(ResSnNumUpD.Value) - 1;
                int num4 = 0;
                strResources[selectedIndex, num2, num3].RateOrTeam = Convert.ToInt16(ResRareNumUpD.Value);
                ResourcesListView.Items[num3].SubItems[3].Text = Convert.ToString(strResources[selectedIndex, num2, num3].RateOrTeam) + " %";
                for (int i = 0; i < 15; i++)
                {
                    if (strResources[selectedIndex, num2, i].nameValue != 0)
                    {
                        num4 += strResources[selectedIndex, num2, i].RateOrTeam;
                    }
                }
                RsrRateLabel.Text = Language.Dictionary["edit"]["probability"] + "(" + Convert.ToString(num4) + "%)";
                if (num4 > 100)
                {
                    RsrRateLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    RsrRateLabel.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        #endregion

        #region TabPage Reward

        private void MaterialTabPage_Click(object sender, EventArgs e)
        {
            MaterialPanel.Visible = false;
            MaterialSubItemClear();
        }

        private void SaveMaterialBtn_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                saveFileDialog1.Filter = Language.Dictionary["messages"]["rewardlist"] + "(*.rew)|*.rew";
                saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data" + Path.DirectorySeparatorChar;
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                string fileName = saveFileDialog1.FileName;
                if (fileName != "")
                {
                    byte[] byData = new byte[80];
                    for (int i = 0; i < 20; i++)
                    {
                        byData[i * 4] = Convert.ToByte((int)(strMaterialReward[0, i].nameValue & 0xff));
                        byData[(i * 4) + 1] = Convert.ToByte((int)(strMaterialReward[0, i].nameValue >> 8));
                        byData[(i * 4) + 2] = Convert.ToByte(strMaterialReward[0, i].number);
                        byData[(i * 4) + 3] = Convert.ToByte(strMaterialReward[0, i].RateOrTeam);
                    }
                    byData = ByteXXXXtoYYYY(byData, 0xa1930f48L);
                    if (!File.Exists(fileName))
                    {
                        FileStream stream = new FileStream(fileName, FileMode.CreateNew);
                        stream.Write(byData, 0, byData.Length);
                        stream.Close();
                    }
                    else
                    {
                        FileStream stream2 = new FileStream(fileName, FileMode.Truncate);
                        stream2.Write(byData, 0, byData.Length);
                        stream2.Close();
                    }
                }
            }
        }

        private void LoadMaterialBtn_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                openFileDialog1.Filter = Language.Dictionary["messages"]["rewardlist"] + "(*.rew)|*.rew";
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data" + Path.DirectorySeparatorChar;
                openFileDialog1.FileName = "";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.ShowDialog();
                byte[] buffer = new byte[80];
                string fileName = openFileDialog1.FileName;
                if (fileName != "")
                {
                    FileStream stream = new FileStream(fileName, FileMode.Open);
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.Read(buffer, 0, 80);
                    stream.Close();
                    buffer = ByteYYYYtoXXXX(buffer, 0xa1930f48L);
                    for (int i = 0; i < 20; i++)
                    {
                        strMaterialReward[0, i].nameValue = buffer[i * 4] + (buffer[(i * 4) + 1] << 8);
                        strMaterialReward[0, i].number = buffer[(i * 4) + 2];
                        strMaterialReward[0, i].RateOrTeam = buffer[(i * 4) + 3];
                        if (strMaterialReward[0, i].nameValue > 0)
                        {
                            MaterialListView1.Items[i].SubItems[1].Text = ResouresNames[strMaterialReward[0, i].nameValue];
                            MaterialListView1.Items[i].SubItems[2].Text = Convert.ToString(strMaterialReward[0, i].number);
                            MaterialListView1.Items[i].SubItems[3].Text = Convert.ToString(strMaterialReward[0, i].RateOrTeam) + " %";
                        }
                        else
                        {
                            MaterialListView1.Items[i].SubItems[1].Text = "";
                            MaterialListView1.Items[i].SubItems[2].Text = "";
                            MaterialListView1.Items[i].SubItems[3].Text = "";
                        }
                    }
                }
            }
        }

        private void MaterialSubItemClear()
        {
            int num = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
            if (MaterialGroupBox.Text.Substring(1, 1) == "0")
            {
                if (strMaterialReward[0, num].nameValue == 0)
                {
                    MaterialListView1.Items[num].SubItems[1].Text = "";
                    MaterialListView1.Items[num].SubItems[2].Text = "";
                    MaterialListView1.Items[num].SubItems[3].Text = "";
                }
            }
            else
            {
                int num2 = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                if ((strMaterialReward[num2, num].nameValue == 0) && (num <= 10))
                {
                    MaterialListView2.Items[num].SubItems[1].Text = "";
                    MaterialListView2.Items[num].SubItems[2].Text = "";
                    MaterialListView2.Items[num].SubItems[3].Text = "";
                }
            }
        }

        #region Base Reward

        private void MaterialListView1_Click(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int index = MaterialListView1.Items.IndexOf(MaterialListView1.FocusedItem);
                if (strMaterialReward[0, index].nameValue == 0)
                {
                    MaterialListView1.Items[index].SubItems[1].Text = ResouresNames[strMaterialReward[0, index].nameValue];
                    MaterialListView1.Items[index].SubItems[2].Text = Convert.ToString(strMaterialReward[0, index].number);
                    MaterialListView1.Items[index].SubItems[3].Text = Convert.ToString(strMaterialReward[0, index].RateOrTeam) + " %";
                }
                MaterialGroupBox.Text = "(0)" + Language.Dictionary["edit"]["title"];
                MaterialSnNumUpD.Maximum = 20M;
                MaterialSnNumUpD.Value = index + 1;
                MaterialNameCmbBox.Text = ResouresNames[strMaterialReward[0, index].nameValue];
                MaterialNumNumUpD.Value = strMaterialReward[0, index].number;
                MaterialnRareNmericUpDown.Value = strMaterialReward[0, index].RateOrTeam;
                if (index < 12)
                {
                    MaterialPanel.Location = new Point(0x8b, 0x88 + (index * 13));
                }
                else
                {
                    MaterialPanel.Location = new Point(0x8b, 0x29 + (index * 13));
                }
                MaterialPanel.Visible = true;
                MaterialNameCmbBox.Focus();
            }
        }

        #endregion

        #region Bonus Reward

        private void ExpMaterialChooseCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.EditToolState.Substring(0, 4) == "Open")
            {
                int num = this.ExpMaterialChooseCmbBox.SelectedIndex + 1;
                int num2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (this.strMaterialReward[num, i].nameValue == 0)
                    {
                        this.MaterialListView2.Items[i].SubItems[1].Text = "";
                        this.MaterialListView2.Items[i].SubItems[2].Text = "";
                        this.MaterialListView2.Items[i].SubItems[3].Text = "";
                    }
                    else
                    {
                        this.MaterialListView2.Items[i].SubItems[1].Text = this.ResouresNames[this.strMaterialReward[num, i].nameValue];
                        this.MaterialListView2.Items[i].SubItems[2].Text = Convert.ToString(this.strMaterialReward[num, i].number);
                        this.MaterialListView2.Items[i].SubItems[3].Text = Convert.ToString(this.strMaterialReward[num, i].RateOrTeam) + " %";
                        num2 += this.strMaterialReward[num, i].RateOrTeam;
                    }
                }
                this.MtlExpRateLabe.Text = Language.Dictionary["edit"]["probability"] + "(" + Convert.ToString(num2) + "%)";
            }
        }

        private void MaterialListView2_Click(object sender, EventArgs e)
        {
            if (this.EditToolState.Substring(0, 4) == "Open")
            {
                int index = this.MaterialListView2.Items.IndexOf(this.MaterialListView2.FocusedItem);
                if (index < 10)
                {
                    int num2 = this.ExpMaterialChooseCmbBox.SelectedIndex + 1;
                    if (this.strMaterialReward[num2, index].nameValue == 0)
                    {
                        this.MaterialListView2.Items[index].SubItems[1].Text = this.ResouresNames[this.strMaterialReward[num2, index].nameValue];
                        this.MaterialListView2.Items[index].SubItems[2].Text = Convert.ToString(this.strMaterialReward[num2, index].number);
                        this.MaterialListView2.Items[index].SubItems[3].Text = Convert.ToString(this.strMaterialReward[num2, index].RateOrTeam) + " %";
                    }
                    this.MaterialGroupBox.Text = "(" + Convert.ToString(num2).Trim() + ")" + Language.Dictionary["edit"]["title"];
                    this.MaterialSnNumUpD.Maximum = 10M;
                    this.MaterialSnNumUpD.Value = index + 1;
                    this.MaterialNameCmbBox.Text = this.ResouresNames[this.strMaterialReward[num2, index].nameValue];
                    this.MaterialNumNumUpD.Value = this.strMaterialReward[num2, index].number;
                    this.MaterialnRareNmericUpDown.Value = this.strMaterialReward[num2, index].RateOrTeam;
                    this.MaterialPanel.Location = new Point(0x4e, 0xd3 + (index * 13));
                    this.MaterialPanel.Visible = true;
                    this.MaterialNameCmbBox.Focus();
                }
            }
        }

        #endregion

        #region Edit Panel

        private void MaterialPanel_Leave(object sender, EventArgs e)
        {
            MaterialPanel.Visible = false;
            MaterialSubItemClear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MaterialPanel.Visible = false;
            MaterialSubItemClear();
        }

        private void MaterialSnNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                if (MaterialGroupBox.Text.Substring(1, 1) == "0")
                {
                    int num = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                    MaterialSnNumUpD.Value = num + 1;
                    MaterialNameCmbBox.Text = ResouresNames[strMaterialReward[0, num].nameValue];
                    MaterialNumNumUpD.Value = strMaterialReward[0, num].number;
                    MaterialnRareNmericUpDown.Value = strMaterialReward[0, num].RateOrTeam;
                }
                else
                {
                    int num2 = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                    int num3 = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                    if (num3 < 10)
                    {
                        MaterialNameCmbBox.Text = ResouresNames[strMaterialReward[num2, num3].nameValue];
                        MaterialNumNumUpD.Value = strMaterialReward[num2, num3].number;
                        MaterialnRareNmericUpDown.Value = strMaterialReward[num2, num3].RateOrTeam;
                    }
                }
            }
        }

        private void MaterialNameCmbBox_Leave(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                int num2 = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                if ((num <= 0) || (num2 <= 10))
                {
                    if ((!(ResouresNames[strMaterialReward[num, num2].nameValue] != MaterialNameCmbBox.Text) || !(MaterialNameCmbBox.Text != "")) || !(MaterialNameCmbBox.Text.Substring(0, 1) != "-"))
                    {
                        if ((MaterialNameCmbBox.Text == "") || (MaterialNameCmbBox.Text.Substring(0, 1) == "-"))
                        {
                            strMaterialReward[num, num2].nameValue = 0;
                            MaterialNameCmbBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        bool flag = false;
                        for (int i = 1; i < ResouresNames.Length; i++)
                        {
                            if ((((DataClass.ResouresType[i] & 4) == 4) || (((DataClass.ResouresType[i] >> 4) & 1) == 1)) && (MaterialNameCmbBox.Text == ResouresNames[i]))
                            {
                                strMaterialReward[num, num2].nameValue = i;
                                MaterialNameCmbBox.Text = ResouresNames[strMaterialReward[num, num2].nameValue];
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            for (int j = 1; j < ResouresNames.Length; j++)
                            {
                                if ((((DataClass.ResouresType[j] & 4) == 4) || (((DataClass.ResouresType[j] >> 4) & 1) == 1)) && ((MaterialNameCmbBox.Text.Length < ResouresNames[j].Length) && (MaterialNameCmbBox.Text == ResouresNames[j].Substring(0, MaterialNameCmbBox.Text.Length))))
                                {
                                    strMaterialReward[num, num2].nameValue = j;
                                    MaterialNameCmbBox.Text = ResouresNames[strMaterialReward[num, num2].nameValue];
                                    flag = true;
                                    break;
                                }
                            }
                        }
                        if (flag)
                        {
                            int num5 = 0;
                            if (num == 0)
                            {
                                MaterialListView1.Items[num2].SubItems[1].Text = ResouresNames[strMaterialReward[0, num2].nameValue];
                                if (strMaterialReward[0, num2].nameValue > 0)
                                {
                                    if (strMaterialReward[0, num2].number == 0)
                                    {
                                        strMaterialReward[0, num2].number = 1;
                                    }
                                    MaterialListView1.Items[num2].SubItems[2].Text = (strMaterialReward[0, num2].number > 0) ? Convert.ToString(strMaterialReward[0, num2].number) : "";
                                    if (strMaterialReward[0, num2].RateOrTeam == 0)
                                    {
                                        strMaterialReward[0, num2].RateOrTeam = 1;
                                    }
                                    MaterialListView1.Items[num2].SubItems[3].Text = (strMaterialReward[0, num2].RateOrTeam > 0) ? (Convert.ToString(strMaterialReward[0, num2].RateOrTeam) + " %") : "";
                                }
                                else
                                {
                                    MaterialListView1.Items[num2].SubItems[2].Text = "";
                                    MaterialListView1.Items[num2].SubItems[3].Text = "";
                                }
                                for (int k = 0; k < 20; k++)
                                {
                                    num5 += strMaterialReward[0, k].RateOrTeam;
                                }
                                MtlRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num5) + "%)";
                            }
                            else
                            {
                                MaterialListView2.Items[num2].SubItems[1].Text = ResouresNames[strMaterialReward[num, num2].nameValue];
                                if (strMaterialReward[num, num2].nameValue > 0)
                                {
                                    if (strMaterialReward[num, num2].number == 0)
                                    {
                                        strMaterialReward[num, num2].number = 1;
                                    }
                                    MaterialListView2.Items[num2].SubItems[2].Text = (strMaterialReward[num, num2].number > 0) ? Convert.ToString(strMaterialReward[num, num2].number) : "";
                                    if (strMaterialReward[num, num2].RateOrTeam == 0)
                                    {
                                        strMaterialReward[num, num2].RateOrTeam = 1;
                                    }
                                    MaterialListView2.Items[num2].SubItems[3].Text = (strMaterialReward[num, num2].RateOrTeam > 0) ? (Convert.ToString(strMaterialReward[num, num2].RateOrTeam) + " %") : "";
                                }
                                else
                                {
                                    MaterialListView2.Items[num2].SubItems[2].Text = "";
                                    MaterialListView2.Items[num2].SubItems[3].Text = "";
                                }
                                for (int m = 0; m < 20; m++)
                                {
                                    num5 += strMaterialReward[num, m].RateOrTeam;
                                }
                                MtlExpRateLabe.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num5) + "%)";
                            }
                        }
                        else if (!flag)
                        {
                            strMaterialReward[num, num2].nameValue = 0;
                            MaterialNameCmbBox.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void MaterialNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                int num2 = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                if ((num <= 0) || (num2 <= 10))
                {
                    if (MaterialNameCmbBox.SelectedIndex <= 0)
                    {
                        strMaterialReward[num, num2].nameValue = 0;
                        strMaterialReward[num, num2].number = 0;
                        strMaterialReward[num, num2].RateOrTeam = 0;
                    }
                    else
                    {
                        bool flag = false;
                        for (int i = 1; i < ResouresNames.Length; i++)
                        {
                            if ((((DataClass.ResouresType[i] & 4) == 4) || (((DataClass.ResouresType[i] >> 4) & 1) == 1)) && (MaterialNameCmbBox.Text == ResouresNames[i]))
                            {
                                strMaterialReward[num, num2].nameValue = i;
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            strMaterialReward[num, num2].nameValue = 0;
                        }
                    }
                    int num4 = 0;
                    if (num == 0)
                    {
                        MaterialListView1.Items[num2].SubItems[1].Text = ResouresNames[strMaterialReward[0, num2].nameValue];
                        if (strMaterialReward[0, num2].nameValue > 0)
                        {
                            if (strMaterialReward[0, num2].number == 0)
                            {
                                strMaterialReward[0, num2].number = 1;
                            }
                            MaterialListView1.Items[num2].SubItems[2].Text = (strMaterialReward[0, num2].number > 0) ? Convert.ToString(strMaterialReward[0, num2].number) : "";
                            if (strMaterialReward[0, num2].RateOrTeam == 0)
                            {
                                strMaterialReward[0, num2].RateOrTeam = 1;
                            }
                            MaterialListView1.Items[num2].SubItems[3].Text = (strMaterialReward[0, num2].RateOrTeam > 0) ? (Convert.ToString(strMaterialReward[0, num2].RateOrTeam) + " %") : "";
                        }
                        else
                        {
                            MaterialListView1.Items[num2].SubItems[2].Text = "";
                            MaterialListView1.Items[num2].SubItems[3].Text = "";
                        }
                        for (int j = 0; j < 20; j++)
                        {
                            num4 += strMaterialReward[0, j].RateOrTeam;
                        }
                        MtlRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num4) + "%)";
                    }
                    else
                    {
                        MaterialListView2.Items[num2].SubItems[1].Text = ResouresNames[strMaterialReward[num, num2].nameValue];
                        if (strMaterialReward[num, num2].nameValue > 0)
                        {
                            if (strMaterialReward[num, num2].number == 0)
                            {
                                strMaterialReward[num, num2].number = 1;
                            }
                            MaterialListView2.Items[num2].SubItems[2].Text = (strMaterialReward[num, num2].number > 0) ? Convert.ToString(strMaterialReward[num, num2].number) : "";
                            if (strMaterialReward[num, num2].RateOrTeam == 0)
                            {
                                strMaterialReward[num, num2].RateOrTeam = 1;
                            }
                            MaterialListView2.Items[num2].SubItems[3].Text = (strMaterialReward[num, num2].RateOrTeam > 0) ? (Convert.ToString(strMaterialReward[num, num2].RateOrTeam) + " %") : "";
                        }
                        else
                        {
                            MaterialListView2.Items[num2].SubItems[2].Text = "";
                            MaterialListView2.Items[num2].SubItems[3].Text = "";
                        }
                        for (int k = 0; k < 20; k++)
                        {
                            num4 += strMaterialReward[num, k].RateOrTeam;
                        }
                        MtlExpRateLabe.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num4) + "%)";
                    }
                }
            }
        }

        private void MaterialNumNumUpD_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                int num2 = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                strMaterialReward[num, num2].number = Convert.ToInt16(MaterialNumNumUpD.Value);
                if (num == 0)
                {
                    MaterialListView1.Items[num2].SubItems[2].Text = Convert.ToString(strMaterialReward[0, num2].number);
                }
                else if (num2 < 10)
                {
                    MaterialListView2.Items[num2].SubItems[2].Text = Convert.ToString(strMaterialReward[num, num2].number);
                }
            }
        }

        private void MaterialnRareNmericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                int num = Convert.ToInt16(MaterialGroupBox.Text.Substring(1, 1));
                int num2 = Convert.ToInt16(MaterialSnNumUpD.Value) - 1;
                int num3 = 0;
                strMaterialReward[num, num2].RateOrTeam = Convert.ToInt16(MaterialnRareNmericUpDown.Value);
                if (num == 0)
                {
                    MaterialListView1.Items[num2].SubItems[3].Text = Convert.ToString(strMaterialReward[0, num2].RateOrTeam) + " %";
                    for (int i = 0; i < 20; i++)
                    {
                        num3 += strMaterialReward[0, i].RateOrTeam;
                    }
                    MtlRateLabel.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num3) + "%)";
                }
                else if (num2 < 10)
                {
                    MaterialListView2.Items[num2].SubItems[3].Text = Convert.ToString(strMaterialReward[num, num2].RateOrTeam) + " %";
                    for (int j = 0; j < 20; j++)
                    {
                        num3 += strMaterialReward[num, j].RateOrTeam;
                    }
                    MtlExpRateLabe.Text = Language.Dictionary["edit"]["probability"] + " (" + Convert.ToString(num3) + "%)";
                }
            }
        }

        #endregion

        #endregion

        #region TabPage Challenge

        private void chkBoxStartExercise_CheckedChanged(object sender, EventArgs e)
        {
            if (EditToolState.Substring(0, 4) == "Open")
            {
                if (chkBoxStartExercise.Checked)
                {
                    EnvironmentCmbBox1.SelectedIndex = 1;
                    if (SymbolSet == null)
                    {
                        SymbolSet = new StcSymbolSet[5];
                    }
                    if (HuntersArmsSet == null)
                    {
                        HuntersArmsSet = new StcExerciseArmsSet[5, 6];
                    }
                    if (ExerciseBag == null)
                    {
                        ExerciseBag = new StcResources[5, 0x18];
                    }
                    if (cmbBoxHunterNumber.SelectedIndex < 0)
                    {
                        cmbBoxHunterNumber.SelectedIndex = 0;
                    }
                    if (!rdBtnArmor1.Checked)
                    {
                        rdBtnArmor1.Checked = true;
                    }
                    rdBtnArmor1.Checked = true;
                    TrainingWeaponInit();
                    TrainingArmsInit();
                    if (cmbBoxHunterNumber.SelectedIndex < 0)
                    {
                        cmbBoxHunterNumber.SelectedIndex = 3;
                    }
                }
                else if (!chkBoxStartExercise.Checked)
                {
                    EnvironmentCmbBox1.SelectedIndex = 0;
                }
            }
        }

        private void challengeDetailsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (challengeDetailsTabControl.SelectedIndex == 1)
                ShowEquipSetDetails();
        }
        
        private void cmbBoxWeaponType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxWeaponType.SelectedIndex)
            {
                case 0:
                    weaponPictureBox.Image = Challenge.GS;
                    break;
                case 1:
                    weaponPictureBox.Image = Challenge.SnS;
                    break;
                case 2:
                    weaponPictureBox.Image = Challenge.Hammer;
                    break;
                case 3:
                    weaponPictureBox.Image = Challenge.Lance;
                    break;
                case 4:
                    weaponPictureBox.Image = Challenge.HBG;
                    break;
                case 5:
                    weaponPictureBox.Image = Challenge.LBG;
                    break;
                case 6:
                    weaponPictureBox.Image = Challenge.LS;
                    break;
                case 7:
                    weaponPictureBox.Image = Challenge.Axe;
                    break;
                case 8:
                    weaponPictureBox.Image = Challenge.GL;
                    break;
                case 9:
                    weaponPictureBox.Image = Challenge.Bow;
                    break;
                case 10:
                    weaponPictureBox.Image = Challenge.DS;
                    break;
                case 11:
                    weaponPictureBox.Image = Challenge.HH;
                    break;
            }

            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                string str;
                if (rdBtnArmor1.Checked)
                    num = 0;
                else if (rdBtnArmor2.Checked)
                    num = 1;
                else if (rdBtnArmor3.Checked)
                    num = 2;
                else if (rdBtnArmor4.Checked)
                    num = 3;
                else if (rdBtnArmor5.Checked)
                    num = 4;
                else
                    return;

                if (((cmbBoxWeaponType.SelectedIndex == 4) || (cmbBoxWeaponType.SelectedIndex == 5)) || (cmbBoxWeaponType.SelectedIndex == 9))
                    str = "Long-range";
                else
                    str = "Short-range";
                if (WeaponRange != str)
                    MessageBox.Show(Language.Dictionary["messages"]["armorchange"], "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                HuntersArmsSet[num, 0].ArmsType = cmbBoxWeaponType.SelectedIndex + 5;
                UpdataArmor(num);
            }
        }

        #region Decorations Selection

        private void textBoxBead_MouseHover(object sender, EventArgs e)
        {
            TextBox box;
            int num;
            if (chkBoxStartExercise.Checked && (EditToolState == "Open") && (cmbBoxWeaponType.SelectedIndex >= 0))
            {
                box = (TextBox)sender;
                if (box.Text != "-")
                {
                    switch (box.Name)
                    {
                        case "textBoxBead01":
                            textBoxBeadIndex = 0;
                            goto Label_02D1;

                        case "textBoxBead02":
                            textBoxBeadIndex = 1;
                            goto Label_02D1;

                        case "textBoxBead03":
                            textBoxBeadIndex = 2;
                            goto Label_02D1;

                        case "textBoxBead11":
                            textBoxBeadIndex = 4;
                            goto Label_02D1;

                        case "textBoxBead12":
                            textBoxBeadIndex = 5;
                            goto Label_02D1;

                        case "textBoxBead13":
                            textBoxBeadIndex = 6;
                            goto Label_02D1;

                        case "textBoxBead21":
                            textBoxBeadIndex = 8;
                            goto Label_02D1;

                        case "textBoxBead22":
                            textBoxBeadIndex = 9;
                            goto Label_02D1;

                        case "textBoxBead23":
                            textBoxBeadIndex = 10;
                            goto Label_02D1;

                        case "textBoxBead31":
                            textBoxBeadIndex = 12;
                            goto Label_02D1;

                        case "textBoxBead32":
                            textBoxBeadIndex = 13;
                            goto Label_02D1;

                        case "textBoxBead33":
                            textBoxBeadIndex = 14;
                            goto Label_02D1;

                        case "textBoxBead41":
                            textBoxBeadIndex = 0x10;
                            goto Label_02D1;

                        case "textBoxBead42":
                            textBoxBeadIndex = 0x11;
                            goto Label_02D1;

                        case "textBoxBead43":
                            textBoxBeadIndex = 0x12;
                            goto Label_02D1;

                        case "textBoxBead51":
                            textBoxBeadIndex = 20;
                            goto Label_02D1;

                        case "textBoxBead52":
                            textBoxBeadIndex = 0x15;
                            goto Label_02D1;

                        case "textBoxBead53":
                            textBoxBeadIndex = 0x16;
                            goto Label_02D1;

                        case "textBoxBead61":
                            textBoxBeadIndex = 0x18;
                            goto Label_02D1;

                        case "textBoxBead62":
                            textBoxBeadIndex = 0x19;
                            goto Label_02D1;

                        case "textBoxBead63":
                            textBoxBeadIndex = 0x1a;
                            goto Label_02D1;
                    }
                    textBoxBeadIndex = 0xff;
                }
            }
            return;
        Label_02D1:
            num = textBoxBeadIndex >> 2;
            int num2 = textBoxBeadIndex & 3;
            if (num2 > 0)
            {
                for (int i = 0; i < num2; i++)
                {
                    if (textBeadName[num, num2 - 1].Text == "O")
                    {
                        return;
                    }
                }
            }
            cmbBoxFloatBeadInput.Location = new Point(box.Location.X, box.Location.Y);
            cmbBoxFloatBeadInput.Visible = true;
            cmbBoxFloatBeadInput.Text = box.Text;
        }

        private void textBoxBead_Amulet_MouseHover(object sender, EventArgs e)
        {
            TextBox box;
            int num;
            if (chkBoxStartExercise.Checked && (EditToolState == "Open") && (cmbBoxWeaponType.SelectedIndex >= 0))
            {
                box = (TextBox)sender;
                if (box.Text != "-")
                {
                    switch (box.Name)
                    {
                        case "textBoxBead01":
                            textBoxBeadIndex = 0;
                            goto Label_02D1;

                        case "textBoxBead02":
                            textBoxBeadIndex = 1;
                            goto Label_02D1;

                        case "textBoxBead03":
                            textBoxBeadIndex = 2;
                            goto Label_02D1;

                        case "textBoxBead11":
                            textBoxBeadIndex = 4;
                            goto Label_02D1;

                        case "textBoxBead12":
                            textBoxBeadIndex = 5;
                            goto Label_02D1;

                        case "textBoxBead13":
                            textBoxBeadIndex = 6;
                            goto Label_02D1;

                        case "textBoxBead21":
                            textBoxBeadIndex = 8;
                            goto Label_02D1;

                        case "textBoxBead22":
                            textBoxBeadIndex = 9;
                            goto Label_02D1;

                        case "textBoxBead23":
                            textBoxBeadIndex = 10;
                            goto Label_02D1;

                        case "textBoxBead31":
                            textBoxBeadIndex = 12;
                            goto Label_02D1;

                        case "textBoxBead32":
                            textBoxBeadIndex = 13;
                            goto Label_02D1;

                        case "textBoxBead33":
                            textBoxBeadIndex = 14;
                            goto Label_02D1;

                        case "textBoxBead41":
                            textBoxBeadIndex = 0x10;
                            goto Label_02D1;

                        case "textBoxBead42":
                            textBoxBeadIndex = 0x11;
                            goto Label_02D1;

                        case "textBoxBead43":
                            textBoxBeadIndex = 0x12;
                            goto Label_02D1;

                        case "textBoxBead51":
                            textBoxBeadIndex = 20;
                            goto Label_02D1;

                        case "textBoxBead52":
                            textBoxBeadIndex = 0x15;
                            goto Label_02D1;

                        case "textBoxBead53":
                            textBoxBeadIndex = 0x16;
                            goto Label_02D1;

                        case "textBoxBead61":
                            textBoxBeadIndex = 0x18;
                            goto Label_02D1;

                        case "textBoxBead62":
                            textBoxBeadIndex = 0x19;
                            goto Label_02D1;

                        case "textBoxBead63":
                            textBoxBeadIndex = 0x1a;
                            goto Label_02D1;
                    }
                    textBoxBeadIndex = 0xff;
                }
            }
            return;
        Label_02D1:
            num = textBoxBeadIndex >> 2;
            int num2 = textBoxBeadIndex & 3;
            if (num2 > 0)
            {
                for (int i = 0; i < num2; i++)
                {
                    if (textBeadName[num, num2 - 1].Text == "O")
                    {
                        return;
                    }
                }
            }
            cmbBoxFloatBeadInputAmulet.Location = new Point(box.Location.X, box.Location.Y);
            cmbBoxFloatBeadInputAmulet.Visible = true;
            cmbBoxFloatBeadInputAmulet.Text = box.Text;
        }

        private void cmbBoxFloatBeadInput_MouseLeave(object sender, EventArgs e)
        {
            int num;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (textBoxBeadIndex == 0xff))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            int num2 = textBoxBeadIndex >> 2;
            int num3 = textBoxBeadIndex & 3;
            int index = 0;
            bool flag = true;
            for (int i = 0; i < 0xa5; i++)
            {
                if (cmbBoxFloatBeadInput.Text == Beads[i].Name)
                {
                    index = i;
                    flag = false;
                    break;
                }
                if ((cmbBoxFloatBeadInput.Text.Length <= Beads[i].Name.Length) && (cmbBoxFloatBeadInput.Text == Beads[i].Name.Substring(0, cmbBoxFloatBeadInput.Text.Length)))
                {
                    index = i;
                    flag = false;
                }
            }
            if (flag)
            {
                cmbBoxFloatBeadInput.Visible = false;
                return;
            }
            if (index > 0)
            {
                int num6 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if ((j != num3) && (textBeadName[num2, j].Text.Length > 3))
                    {
                        num6 += Convert.ToInt16(textBeadName[num2, j].Text.Substring(textBeadName[num2, j].Text.Length - 2, 1));
                    }
                    else if ((j != num3) && (textBeadName[num2, j].Text == "-"))
                    {
                        num6++;
                    }
                }
                if ((num6 + Convert.ToInt16(Beads[index].Name.Substring(Beads[index].Name.Length - 2, 1))) > 3)
                {
                    textBeadName[num2, num3].Focus();
                    cmbBoxFloatBeadInput.Visible = false;
                    return;
                }
            }
            if (num2 < 6)
            {
                switch (num3)
                {
                    case 0:
                        HuntersArmsSet[num, num2].Bead01Value = index;
                        goto Label_030D;

                    case 1:
                        HuntersArmsSet[num, num2].Bead02Value = index;
                        goto Label_030D;

                    case 2:
                        HuntersArmsSet[num, num2].Bead03Value = index;
                        goto Label_030D;
                }
            }
            else
            {
                switch (num3)
                {
                    case 0:
                        SymbolSet[num].Bead01Value = index;
                        goto Label_030D;

                    case 1:
                        SymbolSet[num].Bead02Value = index;
                        goto Label_030D;

                    case 2:
                        SymbolSet[num].Bead03Value = index;
                        goto Label_030D;
                }
            }
        Label_030D:
            textBeadName[num2, num3].Text = Beads[index].Name;
            textBeadName[num2, num3].Focus();
            cmbBoxFloatBeadInput.Visible = false;
        }

        private void cmbBoxFloatBeadInputAmulet_MouseLeave(object sender, EventArgs e)
        {
            int num;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (textBoxBeadIndex == 0xff))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            int num2 = textBoxBeadIndex >> 2;
            int num3 = textBoxBeadIndex & 3;
            int index = 0;
            bool flag = true;
            for (int i = 0; i < 0xa5; i++)
            {
                if (cmbBoxFloatBeadInputAmulet.Text == Beads[i].Name)
                {
                    index = i;
                    flag = false;
                    break;
                }
                if ((cmbBoxFloatBeadInputAmulet.Text.Length <= Beads[i].Name.Length) && (cmbBoxFloatBeadInputAmulet.Text == Beads[i].Name.Substring(0, cmbBoxFloatBeadInputAmulet.Text.Length)))
                {
                    index = i;
                    flag = false;
                }
            }
            if (flag)
            {
                cmbBoxFloatBeadInputAmulet.Visible = false;
                return;
            }
            if (index > 0)
            {
                int num6 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if ((j != num3) && (textBeadName[num2, j].Text.Length > 3))
                    {
                        num6 += Convert.ToInt16(textBeadName[num2, j].Text.Substring(textBeadName[num2, j].Text.Length - 2, 1));
                    }
                    else if ((j != num3) && (textBeadName[num2, j].Text == "-"))
                    {
                        num6++;
                    }
                }
                if ((num6 + Convert.ToInt16(Beads[index].Name.Substring(Beads[index].Name.Length - 2, 1))) > 3)
                {
                    textBeadName[num2, num3].Focus();
                    cmbBoxFloatBeadInputAmulet.Visible = false;
                    return;
                }
            }
            if (num2 < 6)
            {
                switch (num3)
                {
                    case 0:
                        HuntersArmsSet[num, num2].Bead01Value = index;
                        goto Label_030D;

                    case 1:
                        HuntersArmsSet[num, num2].Bead02Value = index;
                        goto Label_030D;

                    case 2:
                        HuntersArmsSet[num, num2].Bead03Value = index;
                        goto Label_030D;
                }
            }
            else
            {
                switch (num3)
                {
                    case 0:
                        SymbolSet[num].Bead01Value = index;
                        goto Label_030D;

                    case 1:
                        SymbolSet[num].Bead02Value = index;
                        goto Label_030D;

                    case 2:
                        SymbolSet[num].Bead03Value = index;
                        goto Label_030D;
                }
            }
        Label_030D:
            textBeadName[num2, num3].Text = Beads[index].Name;
            textBeadName[num2, num3].Focus();
            cmbBoxFloatBeadInputAmulet.Visible = false;
        }

        private void cmbBoxFloatBeadInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (textBoxBeadIndex == 0xff))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            int num2 = textBoxBeadIndex >> 2;
            int num3 = textBoxBeadIndex & 3;
            if (cmbBoxFloatBeadInput.SelectedIndex > 0)
            {
                int num4 = 0;
                for (int i = 0; i < 3; i++)
                {
                    if ((i != num3) && (textBeadName[num2, i].Text.Length > 3))
                    {
                        num4 += Convert.ToInt16(textBeadName[num2, i].Text.Substring(textBeadName[num2, i].Text.Length - 2, 1));
                    }
                    else if ((i != num3) && (textBeadName[num2, i].Text == "-"))
                    {
                        num4++;
                    }
                }
                if ((num4 + Convert.ToInt16(cmbBoxFloatBeadInput.Text.Substring(cmbBoxFloatBeadInput.Text.Length - 2, 1))) > 3)
                {
                    textBeadName[num2, num3].Focus();
                    return;
                }
            }
            if (num2 < 6)
            {
                switch (num3)
                {
                    case 0:
                        HuntersArmsSet[num, num2].Bead01Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;

                    case 1:
                        HuntersArmsSet[num, num2].Bead02Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;

                    case 2:
                        HuntersArmsSet[num, num2].Bead03Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;
                }
            }
            else
            {
                switch (num3)
                {
                    case 0:
                        SymbolSet[num].Bead01Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;

                    case 1:
                        SymbolSet[num].Bead02Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;

                    case 2:
                        SymbolSet[num].Bead03Value = cmbBoxFloatBeadInput.SelectedIndex;
                        goto Label_0276;
                }
            }
        Label_0276:
            textBeadName[num2, num3].Text = cmbBoxFloatBeadInput.Text;
            textBeadName[num2, num3].Focus();
        }

        private void cmbBoxFloatBeadInputAmulet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (textBoxBeadIndex == 0xff))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            int num2 = textBoxBeadIndex >> 2;
            int num3 = textBoxBeadIndex & 3;
            if (cmbBoxFloatBeadInputAmulet.SelectedIndex > 0)
            {
                int num4 = 0;
                for (int i = 0; i < 3; i++)
                {
                    if ((i != num3) && (textBeadName[num2, i].Text.Length > 3))
                    {
                        num4 += Convert.ToInt16(textBeadName[num2, i].Text.Substring(textBeadName[num2, i].Text.Length - 2, 1));
                    }
                    else if ((i != num3) && (textBeadName[num2, i].Text == "-"))
                    {
                        num4++;
                    }
                }
                if ((num4 + Convert.ToInt16(cmbBoxFloatBeadInputAmulet.Text.Substring(cmbBoxFloatBeadInputAmulet.Text.Length - 2, 1))) > 3)
                {
                    textBeadName[num2, num3].Focus();
                    return;
                }
            }
            if (num2 < 6)
            {
                switch (num3)
                {
                    case 0:
                        HuntersArmsSet[num, num2].Bead01Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;

                    case 1:
                        HuntersArmsSet[num, num2].Bead02Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;

                    case 2:
                        HuntersArmsSet[num, num2].Bead03Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;
                }
            }
            else
            {
                switch (num3)
                {
                    case 0:
                        SymbolSet[num].Bead01Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;

                    case 1:
                        SymbolSet[num].Bead02Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;

                    case 2:
                        SymbolSet[num].Bead03Value = cmbBoxFloatBeadInputAmulet.SelectedIndex;
                        goto Label_0276;
                }
            }
        Label_0276:
            textBeadName[num2, num3].Text = cmbBoxFloatBeadInputAmulet.Text;
            textBeadName[num2, num3].Focus();
        }

        #endregion

        #region Items Page

        private void btnBagThingsInput_Click(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                openFileDialog1.Filter = Language.Dictionary["messages"]["bag"] + " (*.bag)|*.bag";
                openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data" + Path.DirectorySeparatorChar;
                openFileDialog1.FileName = "";
                openFileDialog1.CheckFileExists = true;
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string fileName = openFileDialog1.FileName;
                    byte[] buffer = new byte[0x60];
                    if (File.Exists(fileName))
                    {
                        FileStream stream = new FileStream(fileName, FileMode.Open);
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.Read(buffer, 0, 0x60);
                        stream.Close();
                    }
                    for (int i = 0; i < 0x18; i++)
                    {
                        ExerciseBag[num, i].nameValue = buffer[i * 4] + (buffer[(i * 4) + 1] << 8);
                        ExerciseBag[num, i].number = buffer[(i * 4) + 2];
                        if (ExerciseBag[num, i].nameValue > 0)
                        {
                            listViewBag.Items[i].SubItems[1].Text = ResouresNames[ExerciseBag[num, i].nameValue];
                            listViewBag.Items[i].SubItems[2].Text = Convert.ToString(ExerciseBag[num, i].number);
                        }
                        else
                        {
                            listViewBag.Items[i].SubItems[1].Text = "";
                            listViewBag.Items[i].SubItems[2].Text = "";
                        }
                    }
                    numUpDnBagSN.Value = 1M;
                    cmbBoxBagName.Text = ResouresNames[ExerciseBag[num, 0].nameValue];
                    numUpDnBagNum.Value = ExerciseBag[num, 0].number;
                }
            }
        }

        private void btnBagThingsOutput_Click(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                saveFileDialog1.Filter = Language.Dictionary["messages"]["bag"] + " (*.bag)|*.bag";
                saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Data" + Path.DirectorySeparatorChar;
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                string fileName = saveFileDialog1.FileName;
                if (fileName != "")
                {
                    byte[] buffer = new byte[0x60];
                    for (int i = 0; i < 0x18; i++)
                    {
                        buffer[i * 4] = Convert.ToByte((int)(ExerciseBag[num, i].nameValue & 0xff));
                        buffer[(i * 4) + 1] = Convert.ToByte((int)(ExerciseBag[num, i].nameValue >> 8));
                        buffer[(i * 4) + 2] = Convert.ToByte(ExerciseBag[num, i].number);
                        buffer[(i * 4) + 3] = 0;
                    }
                    FileStream stream = new FileStream(fileName, FileMode.Create);
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                }
            }
        }

        private void listViewBag_Click(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                EditToolState = "Wait...";
                numUpDnBagSN.Value = listViewBag.Items.IndexOf(listViewBag.FocusedItem) + 1;
                cmbBoxBagName.Text = ResouresNames[ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue];
                numUpDnBagNum.Value = ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].number;
                EditToolState = "Open";
                cmbBoxBagName.Focus();
            }
        }

        private void cmbBoxBagName_Leave(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                for (int i = 0; i < 0x2ae; i++)
                {
                    if (((i == 0) || ((DataClass.ResouresType[i] & 8) == 8)) && (ResouresNames[i] == cmbBoxBagName.Text))
                    {
                        ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue = i;
                        if (i == 0)
                        {
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = "";
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[2].Text = "";
                        }
                        else
                        {
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = ResouresNames[i];
                        }
                        break;
                    }
                    if (((i == 0) || ((DataClass.ResouresType[i] & 8) == 8)) && ((ResouresNames[i].Length >= cmbBoxBagName.Text.Length) && (ResouresNames[i].Substring(0, cmbBoxBagName.Text.Length) == cmbBoxBagName.Text)))
                    {
                        ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue = i;
                        if (i == 0)
                        {
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = "";
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[2].Text = "";
                        }
                        else
                        {
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = ResouresNames[i];
                        }
                    }
                }
                cmbBoxBagName.Text = ResouresNames[ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue];
            }
        }

        private void cmbBoxBagName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                for (int i = 0; i < 0x2ae; i++)
                {
                    if (((i == 0) || ((DataClass.ResouresType[i] & 8) == 8)) && (ResouresNames[i] == cmbBoxBagName.Text))
                    {
                        ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue = i;
                        if (i == 0)
                        {
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = "";
                            listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[2].Text = "";
                            return;
                        }
                        listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[1].Text = ResouresNames[i];
                        return;
                    }
                }
            }
        }

        private void numUpDnBagNum_ValueChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].number = Convert.ToInt16(numUpDnBagNum.Value);
                listViewBag.Items[Convert.ToInt16((numUpDnBagSN.Value - 1))].SubItems[2].Text = Convert.ToString(numUpDnBagNum.Value);
            }
        }

        private void numUpDnBagSN_ValueChanged(object sender, EventArgs e)
        {
            if ((chkBoxStartExercise.Checked && (cmbBoxBagName.Items.Count > 0)) && (ExerciseBag != null))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                EditToolState = "Wait...";
                cmbBoxBagName.Text = ResouresNames[ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].nameValue];
                numUpDnBagNum.Value = ExerciseBag[num, Convert.ToInt16((numUpDnBagSN.Value - 1))].number;
                EditToolState = "Open";
            }
        }

        #endregion

        #region Details Page

        private void ShowEquipSetDetails()
        {
            int setnum = 0;
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                if (rdBtnArmor1.Checked)
                    setnum = 0;
                if (rdBtnArmor2.Checked)
                    setnum = 1;
                if (rdBtnArmor3.Checked)
                    setnum = 2;
                if (rdBtnArmor4.Checked)
                    setnum = 3;
                if (rdBtnArmor5.Checked)
                    setnum = 4;

                if (HuntersArmsSet[setnum, 0].ArmsNameValue > 0)
                {
                    int index = 0;
                    string[] strArray = new string[100];
                    int[] numArray = new int[100];

                    #region Weapon Skill Calculation
                    if (HuntersArmsSet[setnum, 0].Bead01Value > 0)
                    {
                        #region Decoration 1
                        bool[] flags = new bool[] { true, true };
                        for (int n = 0; n < index; n++)
                        {
                            if ((flags[0] && (strArray[n] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys1 != "") && (strArray[n] == Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys1.Trim())))
                            {
                                numArray[n] += Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillPoint1;
                                flags[0] = false;
                            }
                            if ((flags[1] && (strArray[n] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys2 != "") && (strArray[n] == Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys2.Trim())))
                            {
                                numArray[n] += Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillPoint2;
                                flags[1] = false;
                            }
                            if (!flags[0] && !flags[1])
                            {
                                break;
                            }
                        }
                        if (flags[0] && (Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys1 != ""))
                        {
                            strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys1.Trim();
                            numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillPoint1;
                            index++;
                        }
                        if (flags[1] && (Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys2 != ""))
                        {
                            strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillSys2.Trim();
                            numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead01Value].SkillPoint2;
                            index++;
                        }
                    #endregion
                        if (HuntersArmsSet[setnum, 0].Bead02Value > 0)
                        {
                            #region Decoration 2
                            flags[0] = true;
                            flags[1] = true;
                            for (int i = 0; i < index; i++)
                            {
                                if ((flags[0] && (strArray[i] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys1 != "") && (strArray[i] == Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys1.Trim())))
                                {
                                    numArray[i] += Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillPoint1;
                                    flags[0] = false;
                                }
                                if ((flags[1] && (strArray[i] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys2 != "") && (strArray[i] == Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys2.Trim())))
                                {
                                    numArray[i] += Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillPoint2;
                                    flags[1] = false;
                                }
                                if (!flags[0] && !flags[1])
                                    break;
                            }
                            if (flags[0] && (Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys1 != ""))
                            {
                                strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys1.Trim();
                                numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillPoint1;
                                index++;
                            }
                            if (flags[1] && (Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys2 != ""))
                            {
                                strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillSys2.Trim();
                                numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead02Value].SkillPoint2;
                                index++;
                            }
                            #endregion
                            if (HuntersArmsSet[setnum, 0].Bead03Value > 0)
                            {
                                #region Decoration 3
                                flags[0] = true;
                                flags[1] = true;
                                for (int i = 0; i < index; i++)
                                {
                                    if ((flags[0] && (strArray[i] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys1 != "") && (strArray[i] == Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys1.Trim())))
                                    {
                                        numArray[i] += Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillPoint1;
                                        flags[0] = false;
                                    }
                                    if ((flags[1] && (strArray[i] != "")) && ((Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys2 != "") && (strArray[i] == Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys2.Trim())))
                                    {
                                        numArray[i] += Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillPoint2;
                                        flags[1] = false;
                                    }
                                    if (!flags[0] && !flags[1])
                                        break;
                                }
                                if (flags[0] && (Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys1 != ""))
                                {
                                    strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys1.Trim();
                                    numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillPoint1;
                                    index++;
                                }
                                if (flags[1] && (Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys2 != ""))
                                {
                                    strArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillSys2.Trim();
                                    numArray[index] = Beads[HuntersArmsSet[setnum, 0].Bead03Value].SkillPoint2;
                                    index++;
                                }
                                #endregion
                            }
                        }
                    }
                    #endregion

                    #region Armor Calculation
                    for (int i = 0; i < 5; i++)
                    {
                        bool[] flagArray = new bool[] { true, true, true, true };
                        if (HuntersArmsSet[setnum, i + 1].ArmsNameValue > 0)
                        {
                            #region Armor Calculation - Base
                            for (int j = 0; j < index; j++)
                            {
                                if ((flagArray[0] && (strArray[j] != "")) && ((ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys1 != "") && (strArray[j] == ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys1.Trim())))
                                {
                                    numArray[j] += ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint1;
                                    flagArray[0] = false;
                                }
                                if ((flagArray[1] && (strArray[j] != "")) && ((ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys2 != "") && (strArray[j] == ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys2.Trim())))
                                {
                                    numArray[j] += ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint2;
                                    flagArray[1] = false;
                                }
                                if ((flagArray[2] && (strArray[j] != "")) && ((ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys3 != "") && (strArray[j] == ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys3.Trim())))
                                {
                                    numArray[j] += ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint3;
                                    flagArray[2] = false;
                                }
                                if ((flagArray[3] && (strArray[j] != "")) && ((ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys4 != "") && (strArray[j] == ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys4.Trim())))
                                {
                                    numArray[j] += ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint4;
                                    flagArray[3] = false;
                                }
                                if ((!flagArray[0] && !flagArray[1]) && (!flagArray[2] && !flagArray[3]))
                                    break;
                            }
                            if (flagArray[0] && (ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys1 != ""))
                            {
                                strArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys1.Trim();
                                numArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint1;
                                index++;
                            }
                            if (flagArray[1] && (ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys2 != ""))
                            {
                                strArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys2.Trim();
                                numArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint2;
                                index++;
                            }
                            if (flagArray[2] && (ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys3 != ""))
                            {
                                strArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys3.Trim();
                                numArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint3;
                                index++;
                            }
                            if (flagArray[3] && (ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys4 != ""))
                            {
                                strArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillSys4.Trim();
                                numArray[index] = ArmorData[i, HuntersArmsSet[setnum, i + 1].ArmsNameValue].SkillPoint4;
                                index++;
                            }
                            #endregion

                            #region Armor Calculation - Decorations
                            if (HuntersArmsSet[setnum, i + 1].Bead01Value > 0)
                            {
                                #region Decoration 1
                                flagArray[0] = true;
                                flagArray[1] = true;
                                for (int num8 = 0; num8 < index; num8++)
                                {
                                    if ((flagArray[0] && (strArray[num8] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys1 != "") && (strArray[num8] == Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys1.Trim())))
                                    {
                                        numArray[num8] += Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillPoint1;
                                        flagArray[0] = false;
                                    }
                                    if ((flagArray[1] && (strArray[num8] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys2 != "") && (strArray[num8] == Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys2.Trim())))
                                    {
                                        numArray[num8] += Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillPoint2;
                                        flagArray[1] = false;
                                    }
                                    if (!flagArray[0] && !flagArray[1])
                                    {
                                        break;
                                    }
                                }
                                if (flagArray[0] && (Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys1 != ""))
                                {
                                    strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys1.Trim();
                                    numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillPoint1;
                                    index++;
                                }
                                if (flagArray[1] && (Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys2 != ""))
                                {
                                    strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillSys2.Trim();
                                    numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead01Value].SkillPoint2;
                                    index++;
                                }
                                #endregion
                                if (HuntersArmsSet[setnum, i + 1].Bead02Value > 0)
                                {
                                    #region Decoration 2
                                    flagArray[0] = true;
                                    flagArray[1] = true;
                                    for (int num9 = 0; num9 < index; num9++)
                                    {
                                        if ((flagArray[0] && (strArray[num9] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys1 != "") && (strArray[num9] == Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys1.Trim())))
                                        {
                                            numArray[num9] += Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillPoint1;
                                            flagArray[0] = false;
                                        }
                                        if ((flagArray[1] && (strArray[num9] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys2 != "") && (strArray[num9] == Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys2.Trim())))
                                        {
                                            numArray[num9] += Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillPoint2;
                                            flagArray[1] = false;
                                        }
                                        if (!flagArray[0] && !flagArray[1])
                                        {
                                            break;
                                        }
                                    }
                                    if (flagArray[0] && (Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys1 != ""))
                                    {
                                        strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys1.Trim();
                                        numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillPoint1;
                                        index++;
                                    }
                                    if (flagArray[1] && (Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys2 != ""))
                                    {
                                        strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillSys2.Trim();
                                        numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead02Value].SkillPoint2;
                                        index++;
                                    }
                                    #endregion
                                    if (HuntersArmsSet[setnum, i + 1].Bead03Value > 0)
                                    {
                                        #region Decoration 3
                                        flagArray[0] = true;
                                        flagArray[1] = true;
                                        for (int num10 = 0; num10 < index; num10++)
                                        {
                                            if ((flagArray[0] && (strArray[num10] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys1 != "") && (strArray[num10] == Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys1.Trim())))
                                            {
                                                numArray[num10] += Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillPoint1;
                                                flagArray[0] = false;
                                            }
                                            if ((flagArray[1] && (strArray[num10] != "")) && ((Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys2 != "") && (strArray[num10] == Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys2.Trim())))
                                            {
                                                numArray[num10] += Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillPoint2;
                                                flagArray[1] = false;
                                            }
                                            if (!flagArray[0] && !flagArray[1])
                                            {
                                                break;
                                            }
                                        }
                                        if (flagArray[0] && (Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys1 != ""))
                                        {
                                            strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys1.Trim();
                                            numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillPoint1;
                                            index++;
                                        }
                                        if (flagArray[1] && (Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys2 != ""))
                                        {
                                            strArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillSys2.Trim();
                                            numArray[index] = Beads[HuntersArmsSet[setnum, i + 1].Bead03Value].SkillPoint2;
                                            index++;
                                        }
                                        #endregion
                                    }
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion

                    #region Charm Calculation
                    if (SymbolSet[setnum].Type > 0)
                    {
                        bool[] flagscharm = new bool[] { true, true };
                        for (int j = 0; j < index; j++)
                        {
                            if (flagscharm[0] && (strArray[j] != ""))
                            {
                                int currSkillId = SymbolSet[setnum].Skill01;
                                string currSkillSys = (currSkillId == 1) ? currSkillSys = "ST" : currSkillSys = "S" + (currSkillId - 1).ToString();
                                if ((currSkillId > 0) && (strArray[j] == currSkillSys))
                                {
                                    numArray[j] += SymbolSet[setnum].SkillPiont1;
                                    flagscharm[0] = false;
                                }
                            }
                            if (!flagscharm[0])
                            {
                                break;
                            }
                        }

                        if (flagscharm[0] && (SymbolSet[setnum].Skill01 > 0))
                        {
                            int currSkillId = SymbolSet[setnum].Skill01;
                            string currSkillSys = (currSkillId == 1) ? currSkillSys = "ST" : currSkillSys = "S" + (currSkillId - 1).ToString();
                            strArray[index] = currSkillSys;
                            numArray[index] = SymbolSet[setnum].SkillPiont1;
                            index++;
                        }

                        for (int num12 = 0; num12 < index; num12++)
                        {
                            if (flagscharm[1] && (strArray[num12] != ""))
                            {
                                int currSkillId = SymbolSet[setnum].Skill02;
                                string currSkillSys = (currSkillId == 1) ? currSkillSys = "ST" : currSkillSys = "S" + (currSkillId - 1).ToString();
                                if ((currSkillId > 0) && (strArray[num12] == currSkillSys))
                                {
                                    numArray[num12] += SymbolSet[setnum].SkillPiont2;
                                    flagscharm[1] = false;
                                }
                            }
                            if (!flagscharm[1])
                            {
                                break;
                            }
                        }

                        if (flagscharm[1] && (SymbolSet[setnum].Skill02 > 0))
                        {
                            int currSkillId = SymbolSet[setnum].Skill02;
                            string currSkillSys = (currSkillId == 1) ? currSkillSys = "ST" : currSkillSys = "S" + (currSkillId - 1).ToString();
                            strArray[index] = DataClass.strSkillSystem[SymbolSet[setnum].Skill02].Trim();
                            numArray[index] = SymbolSet[setnum].SkillPiont2;
                            index++;
                        }

                        if (SymbolSet[setnum].Bead01Value > 0)
                        {
                            flagscharm[0] = true;
                            flagscharm[1] = true;
                            for (int num13 = 0; num13 < index; num13++)
                            {
                                if ((flagscharm[0] && (strArray[num13] != "")) && ((Beads[SymbolSet[setnum].Bead01Value].SkillSys1 != "") && (strArray[num13] == Beads[SymbolSet[setnum].Bead01Value].SkillSys1.Trim())))
                                {
                                    numArray[num13] += Beads[SymbolSet[setnum].Bead01Value].SkillPoint1;
                                    flagscharm[0] = false;
                                }
                                if ((flagscharm[1] && (strArray[num13] != "")) && ((Beads[SymbolSet[setnum].Bead01Value].SkillSys2 != "") && (strArray[num13] == Beads[SymbolSet[setnum].Bead01Value].SkillSys2.Trim())))
                                {
                                    numArray[num13] += Beads[SymbolSet[setnum].Bead01Value].SkillPoint2;
                                    flagscharm[1] = false;
                                }
                                if (!flagscharm[0] && !flagscharm[1])
                                {
                                    break;
                                }
                            }
                            if (flagscharm[0] && (Beads[SymbolSet[setnum].Bead01Value].SkillSys1 != ""))
                            {
                                strArray[index] = Beads[SymbolSet[setnum].Bead01Value].SkillSys1.Trim();
                                numArray[index] = Beads[SymbolSet[setnum].Bead01Value].SkillPoint1;
                                index++;
                            }
                            if (flagscharm[1] && (Beads[SymbolSet[setnum].Bead01Value].SkillSys2 != ""))
                            {
                                strArray[index] = Beads[SymbolSet[setnum].Bead01Value].SkillSys2.Trim();
                                numArray[index] = Beads[SymbolSet[setnum].Bead01Value].SkillPoint2;
                                index++;
                            }
                            if (SymbolSet[setnum].Bead02Value > 0)
                            {
                                flagscharm[0] = true;
                                flagscharm[1] = true;
                                for (int num14 = 0; num14 < index; num14++)
                                {
                                    if ((flagscharm[0] && (strArray[num14] != "")) && ((Beads[SymbolSet[setnum].Bead02Value].SkillSys1 != "") && (strArray[num14] == Beads[SymbolSet[setnum].Bead02Value].SkillSys1.Trim())))
                                    {
                                        numArray[num14] += Beads[SymbolSet[setnum].Bead02Value].SkillPoint1;
                                        flagscharm[0] = false;
                                    }
                                    if ((flagscharm[1] && (strArray[num14] != "")) && ((Beads[SymbolSet[setnum].Bead02Value].SkillSys2 != "") && (strArray[num14] == Beads[SymbolSet[setnum].Bead02Value].SkillSys2.Trim())))
                                    {
                                        numArray[num14] += Beads[SymbolSet[setnum].Bead02Value].SkillPoint2;
                                        flagscharm[1] = false;
                                    }
                                    if (!flagscharm[0] && !flagscharm[1])
                                    {
                                        break;
                                    }
                                }
                                if (flagscharm[0] && (Beads[SymbolSet[setnum].Bead02Value].SkillSys1 != ""))
                                {
                                    strArray[index] = Beads[SymbolSet[setnum].Bead02Value].SkillSys1.Trim();
                                    numArray[index] = Beads[SymbolSet[setnum].Bead02Value].SkillPoint1;
                                    index++;
                                }
                                if (flagscharm[1] && (Beads[SymbolSet[setnum].Bead02Value].SkillSys2 != ""))
                                {
                                    strArray[index] = Beads[SymbolSet[setnum].Bead02Value].SkillSys2.Trim();
                                    numArray[index] = Beads[SymbolSet[setnum].Bead02Value].SkillPoint2;
                                    index++;
                                }
                                if (SymbolSet[setnum].Bead03Value > 0)
                                {
                                    flagscharm[0] = true;
                                    flagscharm[1] = true;
                                    for (int num15 = 0; num15 < index; num15++)
                                    {
                                        if ((flagscharm[0] && (strArray[num15] != "")) && ((Beads[SymbolSet[setnum].Bead03Value].SkillSys1 != "") && (strArray[num15] == Beads[SymbolSet[setnum].Bead03Value].SkillSys1.Trim())))
                                        {
                                            numArray[num15] += Beads[SymbolSet[setnum].Bead03Value].SkillPoint1;
                                            flagscharm[0] = false;
                                        }
                                        if ((flagscharm[1] && (strArray[num15] != "")) && ((Beads[SymbolSet[setnum].Bead03Value].SkillSys2 != "") && (strArray[num15] == Beads[SymbolSet[setnum].Bead03Value].SkillSys2.Trim())))
                                        {
                                            numArray[num15] += Beads[SymbolSet[setnum].Bead03Value].SkillPoint2;
                                            flagscharm[1] = false;
                                        }
                                        if (!flagscharm[0] && !flagscharm[1])
                                        {
                                            break;
                                        }
                                    }
                                    if (flagscharm[0] && (Beads[SymbolSet[setnum].Bead03Value].SkillSys1 != ""))
                                    {
                                        strArray[index] = Beads[SymbolSet[setnum].Bead03Value].SkillSys1.Trim();
                                        numArray[index] = Beads[SymbolSet[setnum].Bead03Value].SkillPoint1;
                                        index++;
                                    }
                                    if (flagscharm[1] && (Beads[SymbolSet[setnum].Bead03Value].SkillSys2 != ""))
                                    {
                                        strArray[index] = Beads[SymbolSet[setnum].Bead03Value].SkillSys2.Trim();
                                        numArray[index] = Beads[SymbolSet[setnum].Bead03Value].SkillPoint2;
                                        index++;
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region Skills Sums
                    for (int j = 0; j < index; j++)
                    {
                        if (strArray[j] == "ST")
                        {
                            for (int num17 = 0; num17 < numArray[j]; num17++)
                            {
                                bool[] flagArray4 = new bool[] { true, true, true, true };
                                if (HuntersArmsSet[setnum, 1].ArmsNameValue > 0)
                                {
                                    for (int num18 = 0; num18 < index; num18++)
                                    {
                                        if ((flagArray4[0] && (strArray[num18] != "")) && ((ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys1 != "") && (strArray[num18] == ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys1.Trim())))
                                        {
                                            numArray[num18] += ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillPoint1;
                                            flagArray4[0] = false;
                                        }
                                        if ((flagArray4[1] && (strArray[num18] != "")) && ((ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys2 != "") && (strArray[num18] == ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys2.Trim())))
                                        {
                                            numArray[num18] += ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillPoint2;
                                            flagArray4[1] = false;
                                        }
                                        if ((flagArray4[2] && (strArray[num18] != "")) && ((ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys3 != "") && (strArray[num18] == ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys3.Trim())))
                                        {
                                            numArray[num18] += ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillPoint3;
                                            flagArray4[2] = false;
                                        }
                                        if ((flagArray4[3] && (strArray[num18] != "")) && ((ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys4 != "") && (strArray[num18] == ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillSys4.Trim())))
                                        {
                                            numArray[num18] += ArmorData[0, HuntersArmsSet[setnum, 1].ArmsNameValue].SkillPoint4;
                                            flagArray4[3] = false;
                                        }
                                        if ((!flagArray4[0] && !flagArray4[1]) && (!flagArray4[2] && !flagArray4[3]))
                                        {
                                            break;
                                        }
                                    }
                                    if (HuntersArmsSet[setnum, 1].Bead01Value > 0)
                                    {
                                        flagArray4[0] = true;
                                        flagArray4[1] = true;
                                        for (int num19 = 0; num19 < index; num19++)
                                        {
                                            if ((flagArray4[0] && (strArray[num19] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillSys1 != "") && (strArray[num19] == Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillSys1.Trim())))
                                            {
                                                numArray[num19] += Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillPoint1;
                                                flagArray4[0] = false;
                                            }
                                            if ((flagArray4[1] && (strArray[num19] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillSys2 != "") && (strArray[num19] == Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillSys2.Trim())))
                                            {
                                                numArray[num19] += Beads[HuntersArmsSet[setnum, 1].Bead01Value].SkillPoint2;
                                                flagArray4[1] = false;
                                            }
                                            if (!flagArray4[0] && !flagArray4[1])
                                            {
                                                break;
                                            }
                                        }
                                        if (HuntersArmsSet[setnum, 1].Bead02Value > 0)
                                        {
                                            flagArray4[0] = true;
                                            flagArray4[1] = true;
                                            for (int num20 = 0; num20 < index; num20++)
                                            {
                                                if ((flagArray4[0] && (strArray[num20] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillSys1 != "") && (strArray[num20] == Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillSys1.Trim())))
                                                {
                                                    numArray[num20] += Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillPoint1;
                                                    flagArray4[0] = false;
                                                }
                                                if ((flagArray4[1] && (strArray[num20] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillSys2 != "") && (strArray[num20] == Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillSys2.Trim())))
                                                {
                                                    numArray[num20] += Beads[HuntersArmsSet[setnum, 1].Bead02Value].SkillPoint2;
                                                    flagArray4[1] = false;
                                                }
                                                if (!flagArray4[0] && !flagArray4[1])
                                                {
                                                    break;
                                                }
                                            }
                                            if (HuntersArmsSet[setnum, 1].Bead03Value > 0)
                                            {
                                                flagArray4[0] = true;
                                                flagArray4[1] = true;
                                                for (int num21 = 0; num21 < index; num21++)
                                                {
                                                    if ((flagArray4[0] && (strArray[num21] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillSys1 != "") && (strArray[num21] == Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillSys1.Trim())))
                                                    {
                                                        numArray[num21] += Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillPoint1;
                                                        flagArray4[0] = false;
                                                    }
                                                    if ((flagArray4[1] && (strArray[num21] != "")) && ((Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillSys2 != "") && (strArray[num21] == Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillSys2.Trim())))
                                                    {
                                                        numArray[num21] += Beads[HuntersArmsSet[setnum, 1].Bead03Value].SkillPoint2;
                                                        flagArray4[1] = false;
                                                    }
                                                    if (!flagArray4[0] && !flagArray4[1])
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                    #endregion

                    #region Writing

                    textBoxSkillList.Text = " # " + Language.Dictionary["questchallenge"]["attack"] + " ";
                    textBoxSkillList.Text = textBoxSkillList.Text + (chkBoxWeaponStrength.Checked ? Convert.ToString((int)(WeaponData[HuntersArmsSet[setnum, 0].ArmsType - 5, HuntersArmsSet[setnum, 0].ArmsNameValue].Attack + 15)) : Convert.ToString(WeaponData[HuntersArmsSet[setnum, 0].ArmsType - 5, HuntersArmsSet[setnum, 0].ArmsNameValue].Attack));

                    #region Info 1 Write

                    string[] states = WeaponData[HuntersArmsSet[setnum, 0].ArmsType - 5, HuntersArmsSet[setnum, 0].ArmsNameValue].StateAtt.Split(" ".ToCharArray());
                    foreach (string state in states)
                    {
                        if (HuntersArmsSet[setnum, 0].ArmsType == 16)
                        {
                            if (state.Contains("|"))
                            {
                                string[] notes = state.Split("|".ToCharArray());
                                textBoxSkillList.Text += "\r\n      |__ " + Language.Dictionary["game"][notes[0]] + "-" + Language.Dictionary["game"][notes[1]] + "-" + Language.Dictionary["game"][notes[2]];
                            }
                            else
                            {
                                if (Language.Dictionary["game"].ContainsKey(state))
                                    textBoxSkillList.Text += "\r\n      |__ " + Language.Dictionary["game"][state];
                                else
                                    textBoxSkillList.Text += " " + state;
                            }
                        }
                        else
                        {
                            if (Language.Dictionary["game"].ContainsKey(state))
                            {
                                textBoxSkillList.Text += "\r\n      |__ " + Language.Dictionary["game"][state];
                                if (HuntersArmsSet[setnum, 0].ArmsType == 14)
                                    if ((state == "poison") || (state == "paralysis") || (state == "sleep"))
                                        textBoxSkillList.Text += "+";
                            }
                            else
                                textBoxSkillList.Text += " " + state;
                        }
                    }

                    #endregion

                    #region Info 2 Write

                    string[] others = WeaponData[HuntersArmsSet[setnum, 0].ArmsType - 5, HuntersArmsSet[setnum, 0].ArmsNameValue].Other.Split(" ".ToCharArray());
                    foreach (string other in others)
                    {
                        if (Language.Dictionary["game"].ContainsKey(other))
                            textBoxSkillList.Text += "\r\n      |__ " + Language.Dictionary["game"][other];
                        else
                            textBoxSkillList.Text += " " + other;
                    }
                    textBoxSkillList.Text = textBoxSkillList.Text + "\r\n # " + Language.Dictionary["questchallenge"]["defense"] + " ";
                    int num22 = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        if (HuntersArmsSet[setnum, k + 1].ArmsNameValue > 0)
                        {
                            num22 += ArmorData[k, HuntersArmsSet[setnum, k + 1].ArmsNameValue].Defense;
                        }
                    }
                    textBoxSkillList.Text = textBoxSkillList.Text + Convert.ToString(num22);

                    #endregion

                    #region Skill Print

                    textBoxSkillList.Text = textBoxSkillList.Text + "\r\n # " + Language.Dictionary["questchallenge"]["skills"];
                    for (int m = 0; m < index; m++)
                    {
                        int num24 = 0;
                        if (numArray[m] >= 10)
                        {
                            bool flag = true;
                            for (int i = 0; i < SkillSysStart.Length; i++)
                            {
                                if ((((SkillSysStart[i].SkillSystem == strArray[m]) && (SkillSysStart[i].StartPoint >= 10)) && (SkillSysStart[i].StartPoint <= numArray[m])) && ((num24 == 0) || (SkillSysStart[num24].StartPoint < SkillSysStart[i].StartPoint)))
                                {
                                    num24 = i;
                                    flag = false;
                                }
                            }
                            if (!flag)
                            {
                                textBoxSkillList.Text += "\r\n　" + SkillSysStart[num24].SkillName + "\r\n             |__ " + Language.Dictionary["skillsys"][SkillSysStart[num24].SkillSystem] + "+" + Convert.ToString(numArray[m]);
                            }
                        }
                        else if (numArray[m] <= -10)
                        {
                            bool flag = true;
                            for (int i = 0; i < SkillSysStart.Length; i++)
                            {
                                if ((((SkillSysStart[i].SkillSystem == strArray[m]) && (SkillSysStart[i].StartPoint <= -10)) && (SkillSysStart[i].StartPoint >= numArray[m])) && ((num24 == 0) || (SkillSysStart[num24].StartPoint > SkillSysStart[i].StartPoint)))
                                {
                                    num24 = i;
                                    flag = false;
                                }
                            }
                            if (!flag)
                            {
                                textBoxSkillList.Text += "\r\n　" + SkillSysStart[num24].SkillName + "\r\n             |__ " + Language.Dictionary["skillsys"][SkillSysStart[num24].SkillSystem] + Convert.ToString(numArray[m]);
                            }
                        }
                    }

                    #endregion

                    #region Non Skill Print

                    textBoxSkillList.Text = textBoxSkillList.Text + "\r\n -----";
                    for (int m = 0; m < index; m++)
                    {
                        int num24 = 0;
                        if ((numArray[m] > -10) && (numArray[m] < 10))
                        {
                            bool flag = true;
                            for (int i = 0; i < SkillSysStart.Length; i++)
                            {
                                if (SkillSysStart[i].SkillSystem == strArray[m])
                                {
                                    num24 = i;
                                    flag = false;
                                }
                            }
                            if (!flag)
                            {
                                textBoxSkillList.Text += "\r\n　" + Language.Dictionary["skillsys"][SkillSysStart[num24].SkillSystem] + ((numArray[m] > 0) ? "+" : "") + Convert.ToString(numArray[m]);
                            }
                        }
                    }

                    #endregion

                    #endregion
                }
            }
        }

        #endregion

        #region Charm

        private void cmbBoxSymbolHole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                SymbolSet[num].Hole = cmbBoxSymbolHole.SelectedIndex;
                switch (SymbolSet[num].Hole)
                {
                    case 0:
                        textBeadName[6, 0].Text = "-";
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[num].Bead01Value = 0;
                        SymbolSet[num].Bead02Value = 0;
                        SymbolSet[num].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[6, 0].Text = Beads[SymbolSet[num].Bead01Value].Name;
                        textBeadName[6, 1].Text = "-";
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[num].Bead02Value = 0;
                        SymbolSet[num].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[6, 0].Text = Beads[SymbolSet[num].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[num].Bead02Value].Name;
                        textBeadName[6, 2].Text = "-";
                        SymbolSet[num].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[6, 0].Text = Beads[SymbolSet[num].Bead01Value].Name;
                        textBeadName[6, 1].Text = Beads[SymbolSet[num].Bead02Value].Name;
                        textBeadName[6, 2].Text = Beads[SymbolSet[num].Bead03Value].Name;
                        return;
                }
            }
        }

        private void cmbBoxSymbolList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                ComboBox box = (ComboBox)sender;
                string name = box.Name;
                if (name != null)
                {
                    if (!(name == "cmbBoxSymbolList01"))
                    {
                        if (!(name == "cmbBoxSymbolList02"))
                        {
                            return;
                        }
                    }
                    else
                    {
                        SymbolSet[num].Skill01 = cmbBoxSymbolList01.SelectedIndex;
                        return;
                    }
                    SymbolSet[num].Skill02 = cmbBoxSymbolList02.SelectedIndex;
                }
            }
        }

        private void cmbBoxSymbolList01_Leave(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                ComboBox box = (ComboBox)sender;
                int num2 = 0;
                bool flag = true;
                for (int i = 0; i < box.Items.Count; i++)
                {
                    if (box.Text == box.Items[i].ToString())
                    {
                        num2 = i;
                        flag = false;
                        break;
                    }
                    if ((flag && (box.Text.Length <= box.Items[i].ToString().Length)) && (box.Text == box.Items[i].ToString().Substring(0, box.Text.Length)))
                    {
                        num2 = i;
                        flag = false;
                    }
                }
                if (!flag)
                {
                    string name = box.Name;
                    if (name != null)
                    {
                        if (!(name == "cmbBoxSymbolList01"))
                        {
                            if (!(name == "cmbBoxSymbolList02"))
                            {
                                return;
                            }
                        }
                        else
                        {
                            SymbolSet[num].Skill01 = num2;
                            cmbBoxSymbolList01.SelectedIndex = num2;
                            return;
                        }
                        SymbolSet[num].Skill02 = num2;
                        cmbBoxSymbolList02.SelectedIndex = num2;
                    }
                }
                else
                {
                    string str2 = box.Name;
                    if (str2 != null)
                    {
                        if (!(str2 == "cmbBoxSymbolList01"))
                        {
                            if (!(str2 == "cmbBoxSymbolList02"))
                            {
                                return;
                            }
                        }
                        else
                        {
                            SymbolSet[num].Skill01 = 0;
                            cmbBoxSymbolList01.SelectedIndex = 0;
                            return;
                        }
                        SymbolSet[num].Skill02 = 0;
                        cmbBoxSymbolList02.SelectedIndex = 0;
                    }
                }
            }
        }

        private void cmbBoxSymbolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                SymbolSet[num].Type = cmbBoxSymbolType.SelectedIndex;
            }
        }

        private void numUpDnSkillPiont_ValueChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                NumericUpDown down = (NumericUpDown)sender;
                string name = down.Name;
                if (name != null)
                {
                    if (!(name == "numUpDnSkillPiont01"))
                    {
                        if (!(name == "numUpDnSkillPiont02"))
                        {
                            return;
                        }
                    }
                    else
                    {
                        SymbolSet[num].SkillPiont1 = Convert.ToInt16(numUpDnSkillPiont01.Value);
                        return;
                    }
                    SymbolSet[num].SkillPiont2 = Convert.ToInt16(numUpDnSkillPiont02.Value);
                }
            }
        }

        #endregion

        #region Armor

        private void numUpDnArmorLV_ValueChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                NumericUpDown down = (NumericUpDown)sender;
                string name = down.Name;
                if (name != null)
                {
                    if (!(name == "numUpDnHeadLV"))
                    {
                        if (!(name == "numUpDnBodyLV"))
                        {
                            if (!(name == "numUpDnArmLV"))
                            {
                                if (!(name == "numUpDnWaistLV"))
                                {
                                    if (name == "numUpDnLegLV")
                                    {
                                        HuntersArmsSet[num, 4].ArmsLV = Convert.ToInt16(numUpDnLegLV.Value) - 1;
                                    }
                                    return;
                                }
                                HuntersArmsSet[num, 3].ArmsLV = Convert.ToInt16(numUpDnWaistLV.Value) - 1;
                                return;
                            }
                            HuntersArmsSet[num, 2].ArmsLV = Convert.ToInt16(numUpDnArmLV.Value) - 1;
                            return;
                        }
                    }
                    else
                    {
                        HuntersArmsSet[num, 5].ArmsLV = Convert.ToInt16(numUpDnHeadLV.Value) - 1;
                        return;
                    }
                    HuntersArmsSet[num, 1].ArmsLV = Convert.ToInt16(numUpDnBodyLV.Value) - 1;
                }
            }
        }

        private void rdBtnArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxStartExercise.Checked)
            {
                rdBtnArmor1.Checked = false;
                rdBtnArmor2.Checked = false;
                rdBtnArmor3.Checked = false;
                rdBtnArmor4.Checked = false;
                rdBtnArmor5.Checked = false;
            }
            else
            {
                int num;
                RadioButton button = (RadioButton)sender;
                switch (button.Name)
                {
                    case "rdBtnArmor1":
                        if (!rdBtnArmor1.Checked)
                        {
                            return;
                        }
                        num = 0;
                        break;

                    case "rdBtnArmor2":
                        if (!rdBtnArmor2.Checked)
                        {
                            return;
                        }
                        num = 1;
                        break;

                    case "rdBtnArmor3":
                        if (!rdBtnArmor3.Checked)
                        {
                            return;
                        }
                        num = 2;
                        break;

                    case "rdBtnArmor4":
                        if (!rdBtnArmor4.Checked)
                        {
                            return;
                        }
                        num = 3;
                        break;

                    case "rdBtnArmor5":
                        if (!rdBtnArmor5.Checked)
                        {
                            return;
                        }
                        num = 4;
                        break;

                    default:
                        num = 0;
                        return;
                }
                EditToolState = "Wait...";
                UpdataArmor(num);
                UpdataBag(num);
                UpdataSymbol(num);
                textBoxSkillList.Text = "";
                EditToolState = "Open";
            }
        }

        private void cmbBoxArmor_Leave(object sender, EventArgs e)
        {
            int num;
            int num2;
            bool flag;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (ArmorData == null))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            ComboBox box = (ComboBox)sender;
            string name = box.Name;
            if (name == null)
            {
                return;
            }
            if (!(name == "cmbBoxBody"))
            {
                if (!(name == "cmbBoxArm"))
                {
                    if (!(name == "cmbBoxWaist"))
                    {
                        if (!(name == "cmbBoxLeg"))
                        {
                            if (!(name == "cmbBoxHead"))
                            {
                                return;
                            }
                            num2 = 4;
                        }
                        else
                        {
                            num2 = 3;
                        }
                    }
                    else
                    {
                        num2 = 2;
                    }
                    goto Label_00EC;
                }
            }
            else
            {
                num2 = 0;
                goto Label_00EC;
            }
            num2 = 1;
        Label_00EC:
            flag = true;
            for (int i = 0; i < 0x100; i++)
            {
                if (((ArmorData[num2, i].Name != "") && (ArmorData[num2, i].Name.Length >= box.Text.Trim().Length)) && (ArmorData[num2, i].Name.Substring(0, box.Text.Trim().Length) == box.Text.Trim()))
                {
                    HuntersArmsSet[num, num2 + 1].ArmsNameValue = i;
                    box.Text = ArmorData[num2, HuntersArmsSet[num, num2 + 1].ArmsNameValue].Name;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                box.Text = ArmorData[num2, HuntersArmsSet[num, num2 + 1].ArmsNameValue].Name;
            }
            else
            {
                switch (ArmorData[num2, HuntersArmsSet[num, num2 + 1].ArmsNameValue].Hole)
                {
                    case 0:
                        textBeadName[num2 + 1, 0].Text = "-";
                        textBeadName[num2 + 1, 1].Text = "-";
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead01Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead02Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = "-";
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead02Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead02Value].Name;
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead02Value].Name;
                        textBeadName[num2 + 1, 2].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead03Value].Name;
                        return;
                }
            }
        }

        private void cmbBoxArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            int num2;
            bool flag;
            if ((!chkBoxStartExercise.Checked || (EditToolState != "Open")) || (ArmorData == null))
            {
                return;
            }
            if (rdBtnArmor1.Checked)
            {
                num = 0;
            }
            else if (rdBtnArmor2.Checked)
            {
                num = 1;
            }
            else if (rdBtnArmor3.Checked)
            {
                num = 2;
            }
            else if (rdBtnArmor4.Checked)
            {
                num = 3;
            }
            else if (rdBtnArmor5.Checked)
            {
                num = 4;
            }
            else
            {
                return;
            }
            ComboBox box = (ComboBox)sender;
            string name = box.Name;
            if (name == null)
            {
                return;
            }
            if (!(name == "cmbBoxBody"))
            {
                if (!(name == "cmbBoxArm"))
                {
                    if (!(name == "cmbBoxWaist"))
                    {
                        if (!(name == "cmbBoxLeg"))
                        {
                            if (!(name == "cmbBoxHead"))
                            {
                                return;
                            }
                            num2 = 4;
                        }
                        else
                        {
                            num2 = 3;
                        }
                    }
                    else
                    {
                        num2 = 2;
                    }
                    goto Label_00EC;
                }
            }
            else
            {
                num2 = 0;
                goto Label_00EC;
            }
            num2 = 1;
        Label_00EC:
            flag = true;
            for (int i = 0; i < 0x100; i++)
            {
                if ((ArmorData[num2, i].Name != "") && (ArmorData[num2, i].Name == box.Text))
                {
                    HuntersArmsSet[num, num2 + 1].ArmsNameValue = i;
                    flag = false;
                    break;
                }
                if (ArmorData[num2, i].Name != "")
                {
                    break;
                }
            }
            if (!flag)
            {
                switch (ArmorData[num2, HuntersArmsSet[num, num2 + 1].ArmsNameValue].Hole)
                {
                    case 0:
                        textBeadName[num2 + 1, 0].Text = "-";
                        textBeadName[num2 + 1, 1].Text = "-";
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead01Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead02Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = "-";
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead02Value = 0;
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead02Value].Name;
                        textBeadName[num2 + 1, 2].Text = "-";
                        HuntersArmsSet[num, num2 + 1].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[num2 + 1, 0].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead01Value].Name;
                        textBeadName[num2 + 1, 1].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead02Value].Name;
                        textBeadName[num2 + 1, 2].Text = Beads[HuntersArmsSet[num, num2 + 1].Bead03Value].Name;
                        return;
                }
            }
        }

        #endregion

        #region Weapon

        private void chkBoxWeaponStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                if (chkBoxWeaponStrength.Checked)
                {
                    HuntersArmsSet[num, 0].ArmsLV |= 1;
                }
                else
                {
                    HuntersArmsSet[num, 0].ArmsLV &= 0xfe;
                }
            }
        }

        private void cmbBoxWeaponName_Leave(object sender, EventArgs e)
        {
            if ((chkBoxStartExercise.Checked && (EditToolState == "Open")) && (cmbBoxWeaponName.Items.Count > 0))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                bool flag = true;
                for (int i = 1; i < cmbBoxWeaponName.Items.Count; i++)
                {
                    if (cmbBoxWeaponName.Text == cmbBoxWeaponName.Items[i].ToString())
                    {
                        HuntersArmsSet[num, 0].ArmsNameValue = i;
                        flag = false;
                        break;
                    }
                    if ((cmbBoxWeaponName.Text.Length <= cmbBoxWeaponName.Items[i].ToString().Length) && (cmbBoxWeaponName.Text == cmbBoxWeaponName.Items[i].ToString().Substring(0, cmbBoxWeaponName.Text.Length)))
                    {
                        HuntersArmsSet[num, 0].ArmsNameValue = i;
                        flag = false;
                    }
                }
                if (flag)
                {
                    HuntersArmsSet[num, 0].ArmsNameValue = 1;
                    cmbBoxWeaponName.SelectedIndex = 1;
                }
                else
                {
                    cmbBoxWeaponName.SelectedIndex = HuntersArmsSet[num, 0].ArmsNameValue;
                }
                switch (WeaponData[HuntersArmsSet[num, 0].ArmsType - 5, HuntersArmsSet[num, 0].ArmsNameValue].Hole)
                {
                    case 0:
                        textBeadName[0, 0].Text = "-";
                        textBeadName[0, 1].Text = "-";
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead01Value = 0;
                        HuntersArmsSet[num, 0].Bead02Value = 0;
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = "-";
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead02Value = 0;
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = Beads[HuntersArmsSet[num, 0].Bead02Value].Name;
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = Beads[HuntersArmsSet[num, 0].Bead02Value].Name;
                        textBeadName[0, 2].Text = Beads[HuntersArmsSet[num, 0].Bead03Value].Name;
                        return;
                }
            }
        }

        private void cmbBoxWeaponName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                if (cmbBoxWeaponName.SelectedIndex > 0)
                {
                    HuntersArmsSet[num, 0].ArmsNameValue = cmbBoxWeaponName.SelectedIndex;
                }
                else
                {
                    HuntersArmsSet[num, 0].ArmsNameValue = 1;
                    cmbBoxWeaponName.SelectedIndex = 1;
                }
                switch (WeaponData[HuntersArmsSet[num, 0].ArmsType - 5, HuntersArmsSet[num, 0].ArmsNameValue].Hole)
                {
                    case 0:
                        textBeadName[0, 0].Text = "-";
                        textBeadName[0, 1].Text = "-";
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead01Value = 0;
                        HuntersArmsSet[num, 0].Bead02Value = 0;
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 1:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = "-";
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead02Value = 0;
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 2:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = Beads[HuntersArmsSet[num, 0].Bead02Value].Name;
                        textBeadName[0, 2].Text = "-";
                        HuntersArmsSet[num, 0].Bead03Value = 0;
                        return;

                    case 3:
                        textBeadName[0, 0].Text = Beads[HuntersArmsSet[num, 0].Bead01Value].Name;
                        textBeadName[0, 1].Text = Beads[HuntersArmsSet[num, 0].Bead02Value].Name;
                        textBeadName[0, 2].Text = Beads[HuntersArmsSet[num, 0].Bead03Value].Name;
                        return;
                }
            }
        }

        private void rdBtnWeaponStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxStartExercise.Checked && (EditToolState == "Open"))
            {
                int num;
                if (rdBtnArmor1.Checked)
                {
                    num = 0;
                }
                else if (rdBtnArmor2.Checked)
                {
                    num = 1;
                }
                else if (rdBtnArmor3.Checked)
                {
                    num = 2;
                }
                else if (rdBtnArmor4.Checked)
                {
                    num = 3;
                }
                else if (rdBtnArmor5.Checked)
                {
                    num = 4;
                }
                else
                {
                    return;
                }
                RadioButton button = (RadioButton)sender;
                string name = button.Name;
                if (name != null)
                {
                    if (!(name == "rdBtnWeaponStrength1"))
                    {
                        if (!(name == "rdBtnWeaponStrength2"))
                        {
                            if ((name == "rdBtnWeaponStrength3") && rdBtnWeaponStrength3.Checked)
                            {
                                if (cmbBoxWeaponType.SelectedIndex == 4)
                                {
                                    HuntersArmsSet[num, 0].ArmsLV |= 0x80;
                                    HuntersArmsSet[num, 0].ArmsLV &= 0x81;
                                    return;
                                }
                                if (cmbBoxWeaponType.SelectedIndex == 5)
                                {
                                    HuntersArmsSet[num, 0].ArmsLV |= 0x10;
                                    HuntersArmsSet[num, 0].ArmsLV &= 0x11;
                                }
                            }
                            return;
                        }
                    }
                    else
                    {
                        if (rdBtnWeaponStrength1.Checked)
                        {
                            HuntersArmsSet[num, 0].ArmsLV &= 1;
                        }
                        return;
                    }
                    if (rdBtnWeaponStrength2.Checked)
                    {
                        HuntersArmsSet[num, 0].ArmsLV |= 0x20;
                        HuntersArmsSet[num, 0].ArmsLV &= 0x21;
                    }
                }
            }
        }

        #endregion

        #endregion

    }
}
