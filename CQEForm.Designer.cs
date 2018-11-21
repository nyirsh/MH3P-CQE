using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System;

namespace CQE
{
	partial class CQEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CQEForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LowRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsolaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PianureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ForestaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TundraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VulcanoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CascateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HighRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsolaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PianureToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ForestaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TundraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.VulcanoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CascateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CanyonLavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArenaPiccolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TerraSacraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZonaPolareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CimaMontagnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandeDesertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllaAutomaticamenteUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.controllaAggiornamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaricaLingueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BaseTabPage = new System.Windows.Forms.TabPage();
            this.groupQuestReward = new System.Windows.Forms.GroupBox();
            this.UnionNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.CatCarNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.RemuntNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContractNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupQuestData = new System.Windows.Forms.GroupBox();
            this.label149 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.cmBoxStopTime = new System.Windows.Forms.ComboBox();
            this.SndVicyTermCmbBox = new System.Windows.Forms.ComboBox();
            this.OpenLimitCmbBox2 = new System.Windows.Forms.ComboBox();
            this.CaiYeChkBox = new System.Windows.Forms.CheckBox();
            this.CatChkBox = new System.Windows.Forms.CheckBox();
            this.MapLabel = new System.Windows.Forms.Label();
            this.MapTimeCmbBox = new System.Windows.Forms.ComboBox();
            this.EnvironmentCmbBox2 = new System.Windows.Forms.ComboBox();
            this.EnvironmentCmbBox1 = new System.Windows.Forms.ComboBox();
            this.label81 = new System.Windows.Forms.Label();
            this.TimeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.VicyTermNumUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.VicyTermNumUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.VicyTermCmbBox2 = new System.Windows.Forms.ComboBox();
            this.VicyTermCmbBox1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.OpenLimitCmbBox1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TaskTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StarGradeCmbBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LandingCmbBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupQuestInfo = new System.Windows.Forms.GroupBox();
            this.randomizeIDButton = new System.Windows.Forms.Button();
            this.MonsterIconCmbBox5 = new System.Windows.Forms.ComboBox();
            this.MonsterIconCmbBox4 = new System.Windows.Forms.ComboBox();
            this.chkBoxBGM = new System.Windows.Forms.CheckBox();
            this.MonsterIconCmbBox3 = new System.Windows.Forms.ComboBox();
            this.MonsterIconCmbBox2 = new System.Windows.Forms.ComboBox();
            this.MonsterIconCmbBox1 = new System.Windows.Forms.ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.taskTitleText = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.SN_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.taskLoseText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskWinCondText = new System.Windows.Forms.TextBox();
            this.taskMostriText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskDescriptionText = new System.Windows.Forms.TextBox();
            this.taskClientText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BossTabPage = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.BossPanel = new System.Windows.Forms.Panel();
            this.BossPanelCloseBtn = new System.Windows.Forms.Button();
            this.BossSetGroupBox = new System.Windows.Forms.GroupBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.BossHPCmBox = new System.Windows.Forms.ComboBox();
            this.BOSSstyleNumUpD = new System.Windows.Forms.NumericUpDown();
            this.BossEnduranceNumUpD = new System.Windows.Forms.NumericUpDown();
            this.BossToFaceNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossDefenseNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossAttackNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossJumpNumUDn = new System.Windows.Forms.NumericUpDown();
            this.BossVolumnNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossSnNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossZNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossYNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossXNumUD = new System.Windows.Forms.NumericUpDown();
            this.BPointCmbBox = new System.Windows.Forms.ComboBox();
            this.BossNumNumUD = new System.Windows.Forms.NumericUpDown();
            this.BossNameCmbBox = new System.Windows.Forms.ComboBox();
            this.groupMonsterOptions = new System.Windows.Forms.GroupBox();
            this.label150 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.numUpDnDouNoTimeToDefer = new System.Windows.Forms.NumericUpDown();
            this.label146 = new System.Windows.Forms.Label();
            this.chkBoxDouNoTimeToDefer = new System.Windows.Forms.CheckBox();
            this.chkBoxBOSSJUMP = new System.Windows.Forms.CheckBox();
            this.label116 = new System.Windows.Forms.Label();
            this.BossRandomSysRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.BossRandomSysRadioBtn3 = new System.Windows.Forms.RadioButton();
            this.BossRandomSysRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.AppearanceProbabilityNumUpD3 = new System.Windows.Forms.NumericUpDown();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.BossRandomButton = new System.Windows.Forms.Button();
            this.BossRandomUnknowValueTextBox = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.AppearanceProbabilityNumUpD2 = new System.Windows.Forms.NumericUpDown();
            this.label87 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.AppearanceProbabilityNumUpD1 = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.WarningRemuntNumUpD = new System.Windows.Forms.NumericUpDown();
            this.WarningUnionNumUpD = new System.Windows.Forms.NumericUpDown();
            this.BossListView = new System.Windows.Forms.ListView();
            this.BossClmnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.BossClmnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.DogfishTabPage = new System.Windows.Forms.TabPage();
            this.groupMinionsBig = new System.Windows.Forms.GroupBox();
            this.label152 = new System.Windows.Forms.Label();
            this.NumUpDownDfEndurance = new System.Windows.Forms.NumericUpDown();
            this.label145 = new System.Windows.Forms.Label();
            this.DogfishToBossChkBox = new System.Windows.Forms.CheckBox();
            this.DfVolumeNumUpD = new System.Windows.Forms.NumericUpDown();
            this.label106 = new System.Windows.Forms.Label();
            this.DfDefenseNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label88 = new System.Windows.Forms.Label();
            this.DfAttackNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.DfGradeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.DogfishPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.DftoFaceNumUpD = new System.Windows.Forms.NumericUpDown();
            this.Df_YNumUD = new System.Windows.Forms.NumericUpDown();
            this.Df_ZNumUD = new System.Windows.Forms.NumericUpDown();
            this.Df_XNumUD = new System.Windows.Forms.NumericUpDown();
            this.DfNumNumUpD = new System.Windows.Forms.NumericUpDown();
            this.DfRoundTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.DfTypeNumUpD = new System.Windows.Forms.NumericUpDown();
            this.DfNameCmbBox = new System.Windows.Forms.ComboBox();
            this.DfSnNumUpD = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.RoundRdButton3 = new System.Windows.Forms.RadioButton();
            this.RoundRdButton2 = new System.Windows.Forms.RadioButton();
            this.RoundRdButton1 = new System.Windows.Forms.RadioButton();
            this.label55 = new System.Windows.Forms.Label();
            this.DfPointCmbBox = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.DogfishListView = new System.Windows.Forms.ListView();
            this.DfClmnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.DfClmnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DfAddCmbBox2 = new System.Windows.Forms.ComboBox();
            this.DogfRdButton3 = new System.Windows.Forms.RadioButton();
            this.DfAddNumNumUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DfAddNumNumUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DfAddCmbBox1 = new System.Windows.Forms.ComboBox();
            this.DogfRdButton2 = new System.Windows.Forms.RadioButton();
            this.DogfRdButton1 = new System.Windows.Forms.RadioButton();
            this.FieldTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.BasePlCloseBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.BaseNumNumUpD = new System.Windows.Forms.NumericUpDown();
            this.BaseCmbBox = new System.Windows.Forms.ComboBox();
            this.BaseSnNumUpD = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RadioBtnRandomSysRation = new System.Windows.Forms.RadioButton();
            this.CmbBoxConditionsRation = new System.Windows.Forms.ComboBox();
            this.RadioBtnConditionsRation = new System.Windows.Forms.RadioButton();
            this.RadioBtnNothing = new System.Windows.Forms.RadioButton();
            this.ConditionsRationCmbBoxNumUpD = new System.Windows.Forms.NumericUpDown();
            this.label121 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.BaseRationNumUpD = new System.Windows.Forms.NumericUpDown();
            this.LoadBaseSetButton = new System.Windows.Forms.Button();
            this.SaveBaseSetButton = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.BaseContrLstView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.BaseContrLstView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ResourseTabPage = new System.Windows.Forms.TabPage();
            this.ResourcesPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.ResRareNumUpD = new System.Windows.Forms.NumericUpDown();
            this.ResNumNumUpD = new System.Windows.Forms.NumericUpDown();
            this.ResNameCmbBox = new System.Windows.Forms.ComboBox();
            this.ResSnNumUpD = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.RsrPointCmbBox = new System.Windows.Forms.ComboBox();
            this.RsMAXNumUpD = new System.Windows.Forms.NumericUpDown();
            this.RsMININumUpD = new System.Windows.Forms.NumericUpDown();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.RsrLandmassCmbBox = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.RsrRateLabel = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.ResourcesListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MaterialTabPage = new System.Windows.Forms.TabPage();
            this.label153 = new System.Windows.Forms.Label();
            this.MaterialPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.MaterialGroupBox = new System.Windows.Forms.GroupBox();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.MaterialnRareNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaterialNumNumUpD = new System.Windows.Forms.NumericUpDown();
            this.MaterialNameCmbBox = new System.Windows.Forms.ComboBox();
            this.MaterialSnNumUpD = new System.Windows.Forms.NumericUpDown();
            this.LoadMaterialBtn = new System.Windows.Forms.Button();
            this.SaveMaterialBtn = new System.Windows.Forms.Button();
            this.groupBoxBonus = new System.Windows.Forms.GroupBox();
            this.MtlExpRateLabe = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.ExpMaterialChooseCmbBox = new System.Windows.Forms.ComboBox();
            this.MaterialListView2 = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.MtlRateLabel = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.MaterialListView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.MaterialNumNumUpD2 = new System.Windows.Forms.NumericUpDown();
            this.MaterialNumNumUpD1 = new System.Windows.Forms.NumericUpDown();
            this.label105 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.ChallengeTabPage = new System.Windows.Forms.TabPage();
            this.challengeEquipmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.rdBtnArmor1 = new System.Windows.Forms.RadioButton();
            this.rdBtnArmor2 = new System.Windows.Forms.RadioButton();
            this.rdBtnArmor3 = new System.Windows.Forms.RadioButton();
            this.rdBtnArmor4 = new System.Windows.Forms.RadioButton();
            this.rdBtnArmor5 = new System.Windows.Forms.RadioButton();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.challengeDetailsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label130 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.weaponPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.cmbBoxFloatBeadInput = new System.Windows.Forms.ComboBox();
            this.cmbBoxWeaponType = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmbBoxWeaponName = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cmbBoxHead = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmbBoxBody = new System.Windows.Forms.ComboBox();
            this.textBoxBead43 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxBead42 = new System.Windows.Forms.TextBox();
            this.cmbBoxArm = new System.Windows.Forms.ComboBox();
            this.textBoxBead41 = new System.Windows.Forms.TextBox();
            this.cmbBoxWaist = new System.Windows.Forms.ComboBox();
            this.textBoxBead33 = new System.Windows.Forms.TextBox();
            this.cmbBoxLeg = new System.Windows.Forms.ComboBox();
            this.textBoxBead32 = new System.Windows.Forms.TextBox();
            this.numUpDnHeadLV = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead31 = new System.Windows.Forms.TextBox();
            this.numUpDnBodyLV = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead23 = new System.Windows.Forms.TextBox();
            this.numUpDnArmLV = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead22 = new System.Windows.Forms.TextBox();
            this.numUpDnWaistLV = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead21 = new System.Windows.Forms.TextBox();
            this.numUpDnLegLV = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead13 = new System.Windows.Forms.TextBox();
            this.challengeEditPanel = new System.Windows.Forms.Panel();
            this.rdBtnWeaponStrength2 = new System.Windows.Forms.RadioButton();
            this.rdBtnWeaponStrength3 = new System.Windows.Forms.RadioButton();
            this.rdBtnWeaponStrength1 = new System.Windows.Forms.RadioButton();
            this.chkBoxWeaponStrength = new System.Windows.Forms.CheckBox();
            this.textBoxBead12 = new System.Windows.Forms.TextBox();
            this.textBoxBead01 = new System.Windows.Forms.TextBox();
            this.textBoxBead11 = new System.Windows.Forms.TextBox();
            this.textBoxBead02 = new System.Windows.Forms.TextBox();
            this.textBoxBead53 = new System.Windows.Forms.TextBox();
            this.textBoxBead03 = new System.Windows.Forms.TextBox();
            this.textBoxBead52 = new System.Windows.Forms.TextBox();
            this.textBoxBead51 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label122 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.numUpDnEstimatePtB = new System.Windows.Forms.NumericUpDown();
            this.label123 = new System.Windows.Forms.Label();
            this.numUpDnEstimateSS2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDnEstimateS1 = new System.Windows.Forms.NumericUpDown();
            this.label144 = new System.Windows.Forms.Label();
            this.numUpDnEstimateSS1 = new System.Windows.Forms.NumericUpDown();
            this.label141 = new System.Windows.Forms.Label();
            this.numUpDnEstimateA2 = new System.Windows.Forms.NumericUpDown();
            this.label138 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.numUpDnEstimatePtA = new System.Windows.Forms.NumericUpDown();
            this.numUpDnEstimateS2 = new System.Windows.Forms.NumericUpDown();
            this.label124 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.numUpDnEstimatePtS = new System.Windows.Forms.NumericUpDown();
            this.numUpDnEstimateA1 = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxFloatBeadInputAmulet = new System.Windows.Forms.ComboBox();
            this.cmbBoxSymbolType = new System.Windows.Forms.ComboBox();
            this.cmbBoxSymbolList02 = new System.Windows.Forms.ComboBox();
            this.textBoxSkillList = new System.Windows.Forms.TextBox();
            this.textBoxBead63 = new System.Windows.Forms.TextBox();
            this.textBoxBead62 = new System.Windows.Forms.TextBox();
            this.numUpDnSkillPiont01 = new System.Windows.Forms.NumericUpDown();
            this.textBoxBead61 = new System.Windows.Forms.TextBox();
            this.numUpDnSkillPiont02 = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxSymbolList01 = new System.Windows.Forms.ComboBox();
            this.cmbBoxSymbolHole = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnBagThingsInput = new System.Windows.Forms.Button();
            this.label133 = new System.Windows.Forms.Label();
            this.btnBagThingsOutput = new System.Windows.Forms.Button();
            this.listViewBag = new System.Windows.Forms.ListView();
            this.bagColumnOrd = new System.Windows.Forms.ColumnHeader();
            this.bagColumnName = new System.Windows.Forms.ColumnHeader();
            this.bagColumnQty = new System.Windows.Forms.ColumnHeader();
            this.numUpDnBagSN = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxBagName = new System.Windows.Forms.ComboBox();
            this.label135 = new System.Windows.Forms.Label();
            this.numUpDnBagNum = new System.Windows.Forms.NumericUpDown();
            this.label134 = new System.Windows.Forms.Label();
            this.challengeOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.cmbBoxHunterNumber = new System.Windows.Forms.ComboBox();
            this.label120 = new System.Windows.Forms.Label();
            this.chkBoxStartExercise = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BaseTabPage.SuspendLayout();
            this.groupQuestReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnionNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatCarNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemuntNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractNumUpDown)).BeginInit();
            this.groupQuestData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VicyTermNumUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VicyTermNumUpDown1)).BeginInit();
            this.groupQuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SN_NumUpDown)).BeginInit();
            this.BossTabPage.SuspendLayout();
            this.BossPanel.SuspendLayout();
            this.BossSetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOSSstyleNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossEnduranceNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossToFaceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossDefenseNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossAttackNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossJumpNumUDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossVolumnNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSnNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossZNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossYNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossXNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossNumNumUD)).BeginInit();
            this.groupMonsterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnDouNoTimeToDefer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningRemuntNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningUnionNumUpD)).BeginInit();
            this.DogfishTabPage.SuspendLayout();
            this.groupMinionsBig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDfEndurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfVolumeNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfDefenseNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfAttackNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfGradeNumUpDown)).BeginInit();
            this.DogfishPanel.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DftoFaceNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_YNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_ZNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_XNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfNumNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfTypeNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfSnNumUpD)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DfAddNumNumUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfAddNumNumUpDown1)).BeginInit();
            this.FieldTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BasePanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseNumNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseSnNumUpD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionsRationCmbBoxNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseRationNumUpD)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.ResourseTabPage.SuspendLayout();
            this.ResourcesPanel.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResRareNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResNumNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResSnNumUpD)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RsMAXNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RsMININumUpD)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MaterialTabPage.SuspendLayout();
            this.MaterialPanel.SuspendLayout();
            this.MaterialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialnRareNmericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialSnNumUpD)).BeginInit();
            this.groupBoxBonus.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD1)).BeginInit();
            this.ChallengeTabPage.SuspendLayout();
            this.challengeEquipmentsGroupBox.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.challengeDetailsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnHeadLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBodyLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnArmLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnWaistLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLegLV)).BeginInit();
            this.challengeEditPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateSS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateSS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSkillPiont01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSkillPiont02)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBagSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBagNum)).BeginInit();
            this.challengeOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.MapToolStripMenuItem,
            this.opzioniToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.linguaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.AccessibleDescription = "menu|file";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTaskToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.QuitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // NewTaskToolStripMenuItem
            // 
            this.NewTaskToolStripMenuItem.AccessibleDescription = "menu|new";
            this.NewTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LowRankToolStripMenuItem,
            this.HighRankToolStripMenuItem,
            this.CanyonLavaToolStripMenuItem,
            this.ArenaToolStripMenuItem,
            this.ArenaPiccolaToolStripMenuItem,
            this.TerraSacraToolStripMenuItem,
            this.ZonaPolareToolStripMenuItem,
            this.CimaMontagnaToolStripMenuItem,
            this.grandeDesertoToolStripMenuItem});
            this.NewTaskToolStripMenuItem.Name = "NewTaskToolStripMenuItem";
            this.NewTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.NewTaskToolStripMenuItem.Text = "&Nuovo";
            // 
            // LowRankToolStripMenuItem
            // 
            this.LowRankToolStripMenuItem.AccessibleDescription = "menu|lowrank";
            this.LowRankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsolaToolStripMenuItem1,
            this.PianureToolStripMenuItem1,
            this.ForestaToolStripMenuItem1,
            this.TundraToolStripMenuItem1,
            this.VulcanoToolStripMenuItem1,
            this.CascateToolStripMenuItem1});
            this.LowRankToolStripMenuItem.Name = "LowRankToolStripMenuItem";
            this.LowRankToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.LowRankToolStripMenuItem.Text = "Low Rank";
            // 
            // IsolaToolStripMenuItem1
            // 
            this.IsolaToolStripMenuItem1.AccessibleDescription = "areas|island";
            this.IsolaToolStripMenuItem1.Name = "IsolaToolStripMenuItem1";
            this.IsolaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.IsolaToolStripMenuItem1.Text = "Isola";
            this.IsolaToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // PianureToolStripMenuItem1
            // 
            this.PianureToolStripMenuItem1.AccessibleDescription = "areas|plains";
            this.PianureToolStripMenuItem1.Name = "PianureToolStripMenuItem1";
            this.PianureToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.PianureToolStripMenuItem1.Text = "Pianure";
            this.PianureToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // ForestaToolStripMenuItem1
            // 
            this.ForestaToolStripMenuItem1.AccessibleDescription = "areas|forest";
            this.ForestaToolStripMenuItem1.Name = "ForestaToolStripMenuItem1";
            this.ForestaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.ForestaToolStripMenuItem1.Text = "Foresta";
            this.ForestaToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // TundraToolStripMenuItem1
            // 
            this.TundraToolStripMenuItem1.AccessibleDescription = "areas|tundra";
            this.TundraToolStripMenuItem1.Name = "TundraToolStripMenuItem1";
            this.TundraToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.TundraToolStripMenuItem1.Text = "Tundra";
            this.TundraToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // VulcanoToolStripMenuItem1
            // 
            this.VulcanoToolStripMenuItem1.AccessibleDescription = "areas|volcano";
            this.VulcanoToolStripMenuItem1.Name = "VulcanoToolStripMenuItem1";
            this.VulcanoToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.VulcanoToolStripMenuItem1.Text = "Vulcano";
            this.VulcanoToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // CascateToolStripMenuItem1
            // 
            this.CascateToolStripMenuItem1.AccessibleDescription = "areas|streams";
            this.CascateToolStripMenuItem1.Name = "CascateToolStripMenuItem1";
            this.CascateToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.CascateToolStripMenuItem1.Text = "Cascate";
            this.CascateToolStripMenuItem1.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // HighRankToolStripMenuItem
            // 
            this.HighRankToolStripMenuItem.AccessibleDescription = "menu|highrank";
            this.HighRankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsolaToolStripMenuItem2,
            this.PianureToolStripMenuItem2,
            this.ForestaToolStripMenuItem2,
            this.TundraToolStripMenuItem2,
            this.VulcanoToolStripMenuItem2,
            this.CascateToolStripMenuItem2});
            this.HighRankToolStripMenuItem.Name = "HighRankToolStripMenuItem";
            this.HighRankToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.HighRankToolStripMenuItem.Text = "High Rank";
            // 
            // IsolaToolStripMenuItem2
            // 
            this.IsolaToolStripMenuItem2.AccessibleDescription = "areas|island";
            this.IsolaToolStripMenuItem2.Name = "IsolaToolStripMenuItem2";
            this.IsolaToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.IsolaToolStripMenuItem2.Text = "Isola";
            this.IsolaToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // PianureToolStripMenuItem2
            // 
            this.PianureToolStripMenuItem2.AccessibleDescription = "areas|plains";
            this.PianureToolStripMenuItem2.Name = "PianureToolStripMenuItem2";
            this.PianureToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.PianureToolStripMenuItem2.Text = "Pianure";
            this.PianureToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // ForestaToolStripMenuItem2
            // 
            this.ForestaToolStripMenuItem2.AccessibleDescription = "areas|forest";
            this.ForestaToolStripMenuItem2.Name = "ForestaToolStripMenuItem2";
            this.ForestaToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.ForestaToolStripMenuItem2.Text = "Foresta";
            this.ForestaToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // TundraToolStripMenuItem2
            // 
            this.TundraToolStripMenuItem2.AccessibleDescription = "areas|tundra";
            this.TundraToolStripMenuItem2.Name = "TundraToolStripMenuItem2";
            this.TundraToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.TundraToolStripMenuItem2.Text = "Tundra";
            this.TundraToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // VulcanoToolStripMenuItem2
            // 
            this.VulcanoToolStripMenuItem2.AccessibleDescription = "areas|volcano";
            this.VulcanoToolStripMenuItem2.Name = "VulcanoToolStripMenuItem2";
            this.VulcanoToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.VulcanoToolStripMenuItem2.Text = "Vulcano";
            this.VulcanoToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // CascateToolStripMenuItem2
            // 
            this.CascateToolStripMenuItem2.AccessibleDescription = "areas|streams";
            this.CascateToolStripMenuItem2.Name = "CascateToolStripMenuItem2";
            this.CascateToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.CascateToolStripMenuItem2.Text = "Cascate";
            this.CascateToolStripMenuItem2.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // CanyonLavaToolStripMenuItem
            // 
            this.CanyonLavaToolStripMenuItem.AccessibleDescription = "areas|lavacanyon";
            this.CanyonLavaToolStripMenuItem.Name = "CanyonLavaToolStripMenuItem";
            this.CanyonLavaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CanyonLavaToolStripMenuItem.Text = "Canyon di Lava";
            this.CanyonLavaToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // ArenaToolStripMenuItem
            // 
            this.ArenaToolStripMenuItem.AccessibleDescription = "areas|landarena";
            this.ArenaToolStripMenuItem.Name = "ArenaToolStripMenuItem";
            this.ArenaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ArenaToolStripMenuItem.Text = "Arena";
            this.ArenaToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // ArenaPiccolaToolStripMenuItem
            // 
            this.ArenaPiccolaToolStripMenuItem.AccessibleDescription = "areas|smallarena";
            this.ArenaPiccolaToolStripMenuItem.Name = "ArenaPiccolaToolStripMenuItem";
            this.ArenaPiccolaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ArenaPiccolaToolStripMenuItem.Text = "Arena Piccola";
            this.ArenaPiccolaToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // TerraSacraToolStripMenuItem
            // 
            this.TerraSacraToolStripMenuItem.AccessibleDescription = "areas|sacredland";
            this.TerraSacraToolStripMenuItem.Name = "TerraSacraToolStripMenuItem";
            this.TerraSacraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.TerraSacraToolStripMenuItem.Text = "Terra Sacra";
            this.TerraSacraToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // ZonaPolareToolStripMenuItem
            // 
            this.ZonaPolareToolStripMenuItem.AccessibleDescription = "areas|polarzone";
            this.ZonaPolareToolStripMenuItem.Name = "ZonaPolareToolStripMenuItem";
            this.ZonaPolareToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ZonaPolareToolStripMenuItem.Text = "Zona Polare";
            this.ZonaPolareToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // CimaMontagnaToolStripMenuItem
            // 
            this.CimaMontagnaToolStripMenuItem.AccessibleDescription = "areas|summit";
            this.CimaMontagnaToolStripMenuItem.Name = "CimaMontagnaToolStripMenuItem";
            this.CimaMontagnaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CimaMontagnaToolStripMenuItem.Text = "Cima Montagna";
            this.CimaMontagnaToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // grandeDesertoToolStripMenuItem
            // 
            this.grandeDesertoToolStripMenuItem.AccessibleDescription = "areas|greatdesert";
            this.grandeDesertoToolStripMenuItem.Name = "grandeDesertoToolStripMenuItem";
            this.grandeDesertoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.grandeDesertoToolStripMenuItem.Text = "Grande Deserto";
            this.grandeDesertoToolStripMenuItem.Click += new System.EventHandler(this.NewTaskAreaToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.AccessibleDescription = "menu|open";
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.ShowShortcutKeys = false;
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpenToolStripMenuItem.Text = "Apri";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.AccessibleDescription = "menu|save";
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.ShowShortcutKeys = false;
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveToolStripMenuItem.Text = "&Salva";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.AccessibleDescription = "menu|saveas";
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.ShowShortcutKeys = false;
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveAsToolStripMenuItem.Text = "Salva con Nome";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.AccessibleDescription = "menu|close";
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.CloseToolStripMenuItem.Text = "&Chiudi Quest";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.ChiudiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.AccessibleDescription = "menu|exit";
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.QuitToolStripMenuItem.ShowShortcutKeys = false;
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.QuitToolStripMenuItem.Text = "Esci";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.EsciToolStripMenuItem_Click);
            // 
            // MapToolStripMenuItem
            // 
            this.MapToolStripMenuItem.AccessibleDescription = "menu|map";
            this.MapToolStripMenuItem.Name = "MapToolStripMenuItem";
            this.MapToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.MapToolStripMenuItem.Text = "&Mappa";
            this.MapToolStripMenuItem.Click += new System.EventHandler(this.MapToolStripMenuItem_Click);
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.AccessibleDescription = "menu|options";
            this.opzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controllaAutomaticamenteUpdatesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.controllaAggiornamentiToolStripMenuItem,
            this.scaricaLingueToolStripMenuItem});
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // controllaAutomaticamenteUpdatesToolStripMenuItem
            // 
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.AccessibleDescription = "menu|autoupdate";
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.Name = "controllaAutomaticamenteUpdatesToolStripMenuItem";
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.Text = "Autocontrolla Aggiornamenti";
            this.controllaAutomaticamenteUpdatesToolStripMenuItem.Click += new System.EventHandler(this.controllaAutomaticamenteUpdatesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // controllaAggiornamentiToolStripMenuItem
            // 
            this.controllaAggiornamentiToolStripMenuItem.AccessibleDescription = "menu|checkupdate";
            this.controllaAggiornamentiToolStripMenuItem.Name = "controllaAggiornamentiToolStripMenuItem";
            this.controllaAggiornamentiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.controllaAggiornamentiToolStripMenuItem.Text = "Controlla Aggiornamenti";
            this.controllaAggiornamentiToolStripMenuItem.Click += new System.EventHandler(this.controllaAggiornamentiToolStripMenuItem_Click);
            // 
            // scaricaLingueToolStripMenuItem
            // 
            this.scaricaLingueToolStripMenuItem.AccessibleDescription = "menu|dwnlangs";
            this.scaricaLingueToolStripMenuItem.Name = "scaricaLingueToolStripMenuItem";
            this.scaricaLingueToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.scaricaLingueToolStripMenuItem.Text = "Scarica Lingue";
            this.scaricaLingueToolStripMenuItem.Click += new System.EventHandler(this.scaricaLingueToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.AccessibleDescription = "menu|credits";
            this.creditsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AccessibleDescription = "menu|help";
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.helpToolStripMenuItem.Text = "?";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // linguaToolStripMenuItem
            // 
            this.linguaToolStripMenuItem.AccessibleDescription = "menu|language";
            this.linguaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.linguaToolStripMenuItem.Name = "linguaToolStripMenuItem";
            this.linguaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.linguaToolStripMenuItem.Text = "Lingua";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BaseTabPage);
            this.tabControl1.Controls.Add(this.BossTabPage);
            this.tabControl1.Controls.Add(this.DogfishTabPage);
            this.tabControl1.Controls.Add(this.FieldTabPage);
            this.tabControl1.Controls.Add(this.ResourseTabPage);
            this.tabControl1.Controls.Add(this.MaterialTabPage);
            this.tabControl1.Controls.Add(this.ChallengeTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // BaseTabPage
            // 
            this.BaseTabPage.AccessibleDescription = "pages|info";
            this.BaseTabPage.Controls.Add(this.groupQuestReward);
            this.BaseTabPage.Controls.Add(this.groupQuestData);
            this.BaseTabPage.Controls.Add(this.groupQuestInfo);
            this.BaseTabPage.Location = new System.Drawing.Point(4, 22);
            this.BaseTabPage.Name = "BaseTabPage";
            this.BaseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BaseTabPage.Size = new System.Drawing.Size(566, 460);
            this.BaseTabPage.TabIndex = 0;
            this.BaseTabPage.Text = "Dettagli Quest";
            this.BaseTabPage.UseVisualStyleBackColor = true;
            // 
            // groupQuestReward
            // 
            this.groupQuestReward.AccessibleDescription = "questinfo|reward";
            this.groupQuestReward.Controls.Add(this.UnionNumUpDown);
            this.groupQuestReward.Controls.Add(this.CatCarNumUpDown);
            this.groupQuestReward.Controls.Add(this.RemuntNumUpDown);
            this.groupQuestReward.Controls.Add(this.ContractNumUpDown);
            this.groupQuestReward.Controls.Add(this.label19);
            this.groupQuestReward.Controls.Add(this.label18);
            this.groupQuestReward.Controls.Add(this.label17);
            this.groupQuestReward.Controls.Add(this.label13);
            this.groupQuestReward.Controls.Add(this.label11);
            this.groupQuestReward.Controls.Add(this.label10);
            this.groupQuestReward.Controls.Add(this.label9);
            this.groupQuestReward.Controls.Add(this.label7);
            this.groupQuestReward.Location = new System.Drawing.Point(295, 6);
            this.groupQuestReward.Name = "groupQuestReward";
            this.groupQuestReward.Size = new System.Drawing.Size(265, 104);
            this.groupQuestReward.TabIndex = 2;
            this.groupQuestReward.TabStop = false;
            this.groupQuestReward.Text = "Premio Quest";
            // 
            // UnionNumUpDown
            // 
            this.UnionNumUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UnionNumUpDown.Location = new System.Drawing.Point(83, 74);
            this.UnionNumUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.UnionNumUpDown.Name = "UnionNumUpDown";
            this.UnionNumUpDown.Size = new System.Drawing.Size(56, 20);
            this.UnionNumUpDown.TabIndex = 3;
            this.UnionNumUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CatCarNumUpDown
            // 
            this.CatCarNumUpDown.Location = new System.Drawing.Point(177, 48);
            this.CatCarNumUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.CatCarNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CatCarNumUpDown.Name = "CatCarNumUpDown";
            this.CatCarNumUpDown.Size = new System.Drawing.Size(35, 20);
            this.CatCarNumUpDown.TabIndex = 2;
            this.CatCarNumUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // RemuntNumUpDown
            // 
            this.RemuntNumUpDown.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.RemuntNumUpDown.Location = new System.Drawing.Point(83, 47);
            this.RemuntNumUpDown.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.RemuntNumUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.RemuntNumUpDown.Name = "RemuntNumUpDown";
            this.RemuntNumUpDown.Size = new System.Drawing.Size(56, 20);
            this.RemuntNumUpDown.TabIndex = 1;
            this.RemuntNumUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // ContractNumUpDown
            // 
            this.ContractNumUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ContractNumUpDown.Location = new System.Drawing.Point(83, 20);
            this.ContractNumUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ContractNumUpDown.Name = "ContractNumUpDown";
            this.ContractNumUpDown.Size = new System.Drawing.Size(56, 20);
            this.ContractNumUpDown.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AccessibleDescription = "game|points";
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Pti";
            // 
            // label18
            // 
            this.label18.AccessibleDescription = "game|z";
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(140, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "z";
            // 
            // label17
            // 
            this.label17.AccessibleDescription = "game|z";
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(140, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "z";
            // 
            // label13
            // 
            this.label13.AccessibleDescription = "game|times";
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Volte";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "questinfo|guildpoints";
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Punti Gilda:";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "questinfo|faint";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Sconfitte:";
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "questinfo|money";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Soldi:";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "questinfo|fee";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tassa:";
            // 
            // groupQuestData
            // 
            this.groupQuestData.AccessibleDescription = "questinfo|data";
            this.groupQuestData.Controls.Add(this.label149);
            this.groupQuestData.Controls.Add(this.label148);
            this.groupQuestData.Controls.Add(this.label117);
            this.groupQuestData.Controls.Add(this.cmBoxStopTime);
            this.groupQuestData.Controls.Add(this.SndVicyTermCmbBox);
            this.groupQuestData.Controls.Add(this.OpenLimitCmbBox2);
            this.groupQuestData.Controls.Add(this.CaiYeChkBox);
            this.groupQuestData.Controls.Add(this.CatChkBox);
            this.groupQuestData.Controls.Add(this.MapLabel);
            this.groupQuestData.Controls.Add(this.MapTimeCmbBox);
            this.groupQuestData.Controls.Add(this.EnvironmentCmbBox2);
            this.groupQuestData.Controls.Add(this.EnvironmentCmbBox1);
            this.groupQuestData.Controls.Add(this.label81);
            this.groupQuestData.Controls.Add(this.TimeNumUpDown);
            this.groupQuestData.Controls.Add(this.label20);
            this.groupQuestData.Controls.Add(this.label12);
            this.groupQuestData.Controls.Add(this.VicyTermNumUpDown2);
            this.groupQuestData.Controls.Add(this.VicyTermNumUpDown1);
            this.groupQuestData.Controls.Add(this.VicyTermCmbBox2);
            this.groupQuestData.Controls.Add(this.VicyTermCmbBox1);
            this.groupQuestData.Controls.Add(this.label22);
            this.groupQuestData.Controls.Add(this.OpenLimitCmbBox1);
            this.groupQuestData.Controls.Add(this.label21);
            this.groupQuestData.Controls.Add(this.TaskTypeCmbBox);
            this.groupQuestData.Controls.Add(this.label16);
            this.groupQuestData.Controls.Add(this.StarGradeCmbBox);
            this.groupQuestData.Controls.Add(this.label15);
            this.groupQuestData.Controls.Add(this.LandingCmbBox);
            this.groupQuestData.Controls.Add(this.label14);
            this.groupQuestData.Controls.Add(this.label8);
            this.groupQuestData.Location = new System.Drawing.Point(295, 111);
            this.groupQuestData.Name = "groupQuestData";
            this.groupQuestData.Size = new System.Drawing.Size(265, 343);
            this.groupQuestData.TabIndex = 1;
            this.groupQuestData.TabStop = false;
            this.groupQuestData.Text = "Dati Quest";
            // 
            // label149
            // 
            this.label149.AccessibleDescription = "questinfo|waittime";
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(11, 293);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(40, 13);
            this.label149.TabIndex = 76;
            this.label149.Text = "Attesa:";
            // 
            // label148
            // 
            this.label148.AccessibleDescription = "questinfo|iaminions";
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(189, 131);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(41, 13);
            this.label148.TabIndex = 75;
            this.label148.Text = "- Minori";
            // 
            // label117
            // 
            this.label117.AccessibleDescription = "questinfo|iamonsters";
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(188, 108);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(41, 13);
            this.label117.TabIndex = 74;
            this.label117.Text = "- Mostri";
            // 
            // cmBoxStopTime
            // 
            this.cmBoxStopTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxStopTime.FormattingEnabled = true;
            this.cmBoxStopTime.Items.AddRange(new object[] {
            "1分钟（通常）",
            "1分钟（据守）",
            "20秒（交纳）"});
            this.cmBoxStopTime.Location = new System.Drawing.Point(83, 290);
            this.cmBoxStopTime.Name = "cmBoxStopTime";
            this.cmBoxStopTime.Size = new System.Drawing.Size(134, 21);
            this.cmBoxStopTime.TabIndex = 71;
            // 
            // SndVicyTermCmbBox
            // 
            this.SndVicyTermCmbBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SndVicyTermCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SndVicyTermCmbBox.FormattingEnabled = true;
            this.SndVicyTermCmbBox.Items.AddRange(new object[] {
            "-",
            "E",
            "Oppure"});
            this.SndVicyTermCmbBox.Location = new System.Drawing.Point(13, 264);
            this.SndVicyTermCmbBox.Name = "SndVicyTermCmbBox";
            this.SndVicyTermCmbBox.Size = new System.Drawing.Size(64, 21);
            this.SndVicyTermCmbBox.TabIndex = 12;
            // 
            // OpenLimitCmbBox2
            // 
            this.OpenLimitCmbBox2.DisplayMember = "0";
            this.OpenLimitCmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpenLimitCmbBox2.FormattingEnabled = true;
            this.OpenLimitCmbBox2.Items.AddRange(new object[] {
            "------",
            "Spadone",
            "Lancia",
            "Martello",
            "Scudo&Spada",
            "Balestra",
            "Doppie Lame",
            "Spada Lunga",
            "Lanciafucile",
            "Corno",
            "Arco",
            "Ascia",
            "No Armatura",
            "Max 1 Gioc.",
            "Max 2 Gioc.",
            "Max 3 Gioc."});
            this.OpenLimitCmbBox2.Location = new System.Drawing.Point(174, 186);
            this.OpenLimitCmbBox2.Name = "OpenLimitCmbBox2";
            this.OpenLimitCmbBox2.Size = new System.Drawing.Size(85, 21);
            this.OpenLimitCmbBox2.TabIndex = 8;
            // 
            // CaiYeChkBox
            // 
            this.CaiYeChkBox.AccessibleDescription = "questinfo|elder";
            this.CaiYeChkBox.AutoSize = true;
            this.CaiYeChkBox.Location = new System.Drawing.Point(142, 320);
            this.CaiYeChkBox.Name = "CaiYeChkBox";
            this.CaiYeChkBox.Size = new System.Drawing.Size(105, 17);
            this.CaiYeChkBox.TabIndex = 16;
            this.CaiYeChkBox.Text = "Anziano Vegetali";
            this.CaiYeChkBox.UseVisualStyleBackColor = true;
            // 
            // CatChkBox
            // 
            this.CatChkBox.AccessibleDescription = "questinfo|transporter";
            this.CatChkBox.AutoSize = true;
            this.CatChkBox.Location = new System.Drawing.Point(28, 320);
            this.CatChkBox.Name = "CatChkBox";
            this.CatChkBox.Size = new System.Drawing.Size(96, 17);
            this.CatChkBox.TabIndex = 15;
            this.CatChkBox.Text = "Gatto Trasporti";
            this.CatChkBox.UseVisualStyleBackColor = true;
            // 
            // MapLabel
            // 
            this.MapLabel.AccessibleDescription = "other|mapnull";
            this.MapLabel.AutoSize = true;
            this.MapLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.MapLabel.Location = new System.Drawing.Point(80, 26);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(10, 13);
            this.MapLabel.TabIndex = 66;
            this.MapLabel.Text = "-";
            // 
            // MapTimeCmbBox
            // 
            this.MapTimeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapTimeCmbBox.FormattingEnabled = true;
            this.MapTimeCmbBox.Items.AddRange(new object[] {
            "Giorno",
            "Notte"});
            this.MapTimeCmbBox.Location = new System.Drawing.Point(174, 23);
            this.MapTimeCmbBox.Name = "MapTimeCmbBox";
            this.MapTimeCmbBox.Size = new System.Drawing.Size(55, 21);
            this.MapTimeCmbBox.TabIndex = 0;
            this.MapTimeCmbBox.Visible = false;
            // 
            // EnvironmentCmbBox2
            // 
            this.EnvironmentCmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentCmbBox2.FormattingEnabled = true;
            this.EnvironmentCmbBox2.Items.AddRange(new object[] {
            "Base",
            "Richiamati",
            "Casuali",
            "Repulsi",
            "8"});
            this.EnvironmentCmbBox2.Location = new System.Drawing.Point(83, 128);
            this.EnvironmentCmbBox2.Name = "EnvironmentCmbBox2";
            this.EnvironmentCmbBox2.Size = new System.Drawing.Size(99, 21);
            this.EnvironmentCmbBox2.TabIndex = 4;
            // 
            // EnvironmentCmbBox1
            // 
            this.EnvironmentCmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentCmbBox1.FormattingEnabled = true;
            this.EnvironmentCmbBox1.Items.AddRange(new object[] {
            "Base",
            "Allenamento",
            "2",
            "4",
            "Forti"});
            this.EnvironmentCmbBox1.Location = new System.Drawing.Point(83, 105);
            this.EnvironmentCmbBox1.Name = "EnvironmentCmbBox1";
            this.EnvironmentCmbBox1.Size = new System.Drawing.Size(99, 21);
            this.EnvironmentCmbBox1.TabIndex = 3;
            // 
            // label81
            // 
            this.label81.AccessibleDescription = "questinfo|ia";
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(12, 119);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(64, 13);
            this.label81.TabIndex = 60;
            this.label81.Text = "Difficoltà IA:";
            // 
            // TimeNumUpDown
            // 
            this.TimeNumUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TimeNumUpDown.Location = new System.Drawing.Point(83, 48);
            this.TimeNumUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TimeNumUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TimeNumUpDown.Name = "TimeNumUpDown";
            this.TimeNumUpDown.Size = new System.Drawing.Size(46, 20);
            this.TimeNumUpDown.TabIndex = 1;
            this.TimeNumUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AccessibleDescription = "game|minutes";
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(135, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Min";
            // 
            // label12
            // 
            this.label12.AccessibleDescription = "questinfo|time";
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Tempo:";
            // 
            // VicyTermNumUpDown2
            // 
            this.VicyTermNumUpDown2.Location = new System.Drawing.Point(223, 264);
            this.VicyTermNumUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.VicyTermNumUpDown2.Name = "VicyTermNumUpDown2";
            this.VicyTermNumUpDown2.Size = new System.Drawing.Size(36, 20);
            this.VicyTermNumUpDown2.TabIndex = 14;
            // 
            // VicyTermNumUpDown1
            // 
            this.VicyTermNumUpDown1.Location = new System.Drawing.Point(223, 240);
            this.VicyTermNumUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.VicyTermNumUpDown1.Name = "VicyTermNumUpDown1";
            this.VicyTermNumUpDown1.Size = new System.Drawing.Size(36, 20);
            this.VicyTermNumUpDown1.TabIndex = 11;
            // 
            // VicyTermCmbBox2
            // 
            this.VicyTermCmbBox2.FormattingEnabled = true;
            this.VicyTermCmbBox2.Location = new System.Drawing.Point(83, 264);
            this.VicyTermCmbBox2.Name = "VicyTermCmbBox2";
            this.VicyTermCmbBox2.Size = new System.Drawing.Size(134, 21);
            this.VicyTermCmbBox2.TabIndex = 13;
            this.VicyTermCmbBox2.Leave += new System.EventHandler(this.VicyTermCmbBox2_Leave);
            // 
            // VicyTermCmbBox1
            // 
            this.VicyTermCmbBox1.FormattingEnabled = true;
            this.VicyTermCmbBox1.Location = new System.Drawing.Point(83, 239);
            this.VicyTermCmbBox1.Name = "VicyTermCmbBox1";
            this.VicyTermCmbBox1.Size = new System.Drawing.Size(134, 21);
            this.VicyTermCmbBox1.TabIndex = 10;
            this.VicyTermCmbBox1.Leave += new System.EventHandler(this.VicyTermCmbBox1_Leave);
            // 
            // label22
            // 
            this.label22.AccessibleDescription = "questinfo|goal";
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Cond. Vittoria:";
            // 
            // OpenLimitCmbBox1
            // 
            this.OpenLimitCmbBox1.DisplayMember = "0";
            this.OpenLimitCmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpenLimitCmbBox1.FormattingEnabled = true;
            this.OpenLimitCmbBox1.Items.AddRange(new object[] {
            "Nessuna",
            "GC2",
            "GC3",
            "GC4",
            "GC5",
            "GC6",
            "Spadone",
            "Lancia",
            "Martello",
            "Scudo&Spada",
            "Balestra",
            "Doppie Lame",
            "Spada Lunga",
            "Lanciafucile",
            "Corno",
            "Arco",
            "Ascia",
            "No Armatura",
            "Max 1 Gioc.",
            "Max 2 Gioc.",
            "Max 3 Gioc."});
            this.OpenLimitCmbBox1.Location = new System.Drawing.Point(83, 186);
            this.OpenLimitCmbBox1.Name = "OpenLimitCmbBox1";
            this.OpenLimitCmbBox1.Size = new System.Drawing.Size(85, 21);
            this.OpenLimitCmbBox1.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AccessibleDescription = "questinfo|specialcond";
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Cond. Spec.:";
            // 
            // TaskTypeCmbBox
            // 
            this.TaskTypeCmbBox.DisplayMember = "0";
            this.TaskTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskTypeCmbBox.FormattingEnabled = true;
            this.TaskTypeCmbBox.Items.AddRange(new object[] {
            "Uccisione Minori",
            "Missione di Raccolta",
            "Caccia",
            "Caccia Epica",
            "Uccisione",
            "Speciale",
            "(Sconosciuto)"});
            this.TaskTypeCmbBox.Location = new System.Drawing.Point(83, 75);
            this.TaskTypeCmbBox.Name = "TaskTypeCmbBox";
            this.TaskTypeCmbBox.Size = new System.Drawing.Size(164, 21);
            this.TaskTypeCmbBox.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AccessibleDescription = "questinfo|type";
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tipo Quest:";
            // 
            // StarGradeCmbBox
            // 
            this.StarGradeCmbBox.DisplayMember = "0";
            this.StarGradeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StarGradeCmbBox.FormattingEnabled = true;
            this.StarGradeCmbBox.Items.AddRange(new object[] {
            "1☆ - Basso",
            "2☆ - Basso",
            "3☆ - Basso",
            "4☆ - Medio",
            "5☆ - Medio",
            "6★ - Alto",
            "7★ - Alto",
            "8★ - Alto"});
            this.StarGradeCmbBox.Location = new System.Drawing.Point(83, 159);
            this.StarGradeCmbBox.Name = "StarGradeCmbBox";
            this.StarGradeCmbBox.Size = new System.Drawing.Size(134, 21);
            this.StarGradeCmbBox.TabIndex = 6;
            this.StarGradeCmbBox.SelectedIndexChanged += new System.EventHandler(this.StarGradeCmbBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AccessibleDescription = "questinfo|level";
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Livello:";
            // 
            // LandingCmbBox
            // 
            this.LandingCmbBox.DisplayMember = "0";
            this.LandingCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LandingCmbBox.FormattingEnabled = true;
            this.LandingCmbBox.Items.AddRange(new object[] {
            "Campo Base",
            "Casuale",
            "Speciale"});
            this.LandingCmbBox.Location = new System.Drawing.Point(83, 212);
            this.LandingCmbBox.Name = "LandingCmbBox";
            this.LandingCmbBox.Size = new System.Drawing.Size(134, 21);
            this.LandingCmbBox.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AccessibleDescription = "questinfo|position";
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Pos. Iniziale:";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = "questinfo|map";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Luogo:";
            // 
            // groupQuestInfo
            // 
            this.groupQuestInfo.AccessibleDescription = "questinfo|info";
            this.groupQuestInfo.Controls.Add(this.randomizeIDButton);
            this.groupQuestInfo.Controls.Add(this.MonsterIconCmbBox5);
            this.groupQuestInfo.Controls.Add(this.MonsterIconCmbBox4);
            this.groupQuestInfo.Controls.Add(this.chkBoxBGM);
            this.groupQuestInfo.Controls.Add(this.MonsterIconCmbBox3);
            this.groupQuestInfo.Controls.Add(this.MonsterIconCmbBox2);
            this.groupQuestInfo.Controls.Add(this.MonsterIconCmbBox1);
            this.groupQuestInfo.Controls.Add(this.label101);
            this.groupQuestInfo.Controls.Add(this.taskTitleText);
            this.groupQuestInfo.Controls.Add(this.label25);
            this.groupQuestInfo.Controls.Add(this.SN_NumUpDown);
            this.groupQuestInfo.Controls.Add(this.taskLoseText);
            this.groupQuestInfo.Controls.Add(this.label6);
            this.groupQuestInfo.Controls.Add(this.label5);
            this.groupQuestInfo.Controls.Add(this.taskWinCondText);
            this.groupQuestInfo.Controls.Add(this.taskMostriText);
            this.groupQuestInfo.Controls.Add(this.label4);
            this.groupQuestInfo.Controls.Add(this.label3);
            this.groupQuestInfo.Controls.Add(this.taskDescriptionText);
            this.groupQuestInfo.Controls.Add(this.taskClientText);
            this.groupQuestInfo.Controls.Add(this.label2);
            this.groupQuestInfo.Controls.Add(this.label1);
            this.groupQuestInfo.Location = new System.Drawing.Point(6, 6);
            this.groupQuestInfo.Name = "groupQuestInfo";
            this.groupQuestInfo.Size = new System.Drawing.Size(278, 448);
            this.groupQuestInfo.TabIndex = 0;
            this.groupQuestInfo.TabStop = false;
            this.groupQuestInfo.Text = "Quest Info";
            // 
            // randomizeIDButton
            // 
            this.randomizeIDButton.AccessibleDescription = "other|randomize";
            this.randomizeIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeIDButton.Location = new System.Drawing.Point(131, 19);
            this.randomizeIDButton.Name = "randomizeIDButton";
            this.randomizeIDButton.Size = new System.Drawing.Size(75, 21);
            this.randomizeIDButton.TabIndex = 73;
            this.randomizeIDButton.Text = "Randomize";
            this.randomizeIDButton.UseVisualStyleBackColor = true;
            this.randomizeIDButton.Click += new System.EventHandler(this.randomizeIDButton_Click);
            // 
            // MonsterIconCmbBox5
            // 
            this.MonsterIconCmbBox5.FormattingEnabled = true;
            this.MonsterIconCmbBox5.Location = new System.Drawing.Point(187, 383);
            this.MonsterIconCmbBox5.Name = "MonsterIconCmbBox5";
            this.MonsterIconCmbBox5.Size = new System.Drawing.Size(85, 21);
            this.MonsterIconCmbBox5.TabIndex = 12;
            this.MonsterIconCmbBox5.Leave += new System.EventHandler(this.MonsterIconCmbBox_Leave);
            // 
            // MonsterIconCmbBox4
            // 
            this.MonsterIconCmbBox4.FormattingEnabled = true;
            this.MonsterIconCmbBox4.Location = new System.Drawing.Point(98, 383);
            this.MonsterIconCmbBox4.Name = "MonsterIconCmbBox4";
            this.MonsterIconCmbBox4.Size = new System.Drawing.Size(85, 21);
            this.MonsterIconCmbBox4.TabIndex = 11;
            this.MonsterIconCmbBox4.Leave += new System.EventHandler(this.MonsterIconCmbBox_Leave);
            // 
            // chkBoxBGM
            // 
            this.chkBoxBGM.AccessibleDescription = "questinfo|bgm";
            this.chkBoxBGM.AutoSize = true;
            this.chkBoxBGM.Location = new System.Drawing.Point(9, 425);
            this.chkBoxBGM.Name = "chkBoxBGM";
            this.chkBoxBGM.Size = new System.Drawing.Size(104, 17);
            this.chkBoxBGM.TabIndex = 72;
            this.chkBoxBGM.Text = "Musica Speciale";
            this.chkBoxBGM.UseVisualStyleBackColor = true;
            // 
            // MonsterIconCmbBox3
            // 
            this.MonsterIconCmbBox3.FormattingEnabled = true;
            this.MonsterIconCmbBox3.Location = new System.Drawing.Point(9, 383);
            this.MonsterIconCmbBox3.Name = "MonsterIconCmbBox3";
            this.MonsterIconCmbBox3.Size = new System.Drawing.Size(85, 21);
            this.MonsterIconCmbBox3.TabIndex = 10;
            this.MonsterIconCmbBox3.Leave += new System.EventHandler(this.MonsterIconCmbBox_Leave);
            // 
            // MonsterIconCmbBox2
            // 
            this.MonsterIconCmbBox2.FormattingEnabled = true;
            this.MonsterIconCmbBox2.Location = new System.Drawing.Point(162, 353);
            this.MonsterIconCmbBox2.Name = "MonsterIconCmbBox2";
            this.MonsterIconCmbBox2.Size = new System.Drawing.Size(90, 21);
            this.MonsterIconCmbBox2.TabIndex = 9;
            this.MonsterIconCmbBox2.Leave += new System.EventHandler(this.MonsterIconCmbBox_Leave);
            // 
            // MonsterIconCmbBox1
            // 
            this.MonsterIconCmbBox1.FormattingEnabled = true;
            this.MonsterIconCmbBox1.Location = new System.Drawing.Point(66, 353);
            this.MonsterIconCmbBox1.Name = "MonsterIconCmbBox1";
            this.MonsterIconCmbBox1.Size = new System.Drawing.Size(90, 21);
            this.MonsterIconCmbBox1.TabIndex = 8;
            this.MonsterIconCmbBox1.Leave += new System.EventHandler(this.MonsterIconCmbBox_Leave);
            // 
            // label101
            // 
            this.label101.AccessibleDescription = "questinfo|images";
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(6, 356);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(51, 13);
            this.label101.TabIndex = 16;
            this.label101.Text = "Immagini:";
            // 
            // taskTitleText
            // 
            this.taskTitleText.Location = new System.Drawing.Point(66, 48);
            this.taskTitleText.Name = "taskTitleText";
            this.taskTitleText.Size = new System.Drawing.Size(198, 20);
            this.taskTitleText.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AccessibleDescription = "questinfo|title";
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "Titolo:";
            // 
            // SN_NumUpDown
            // 
            this.SN_NumUpDown.BackColor = System.Drawing.Color.AliceBlue;
            this.SN_NumUpDown.Location = new System.Drawing.Point(66, 20);
            this.SN_NumUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SN_NumUpDown.Name = "SN_NumUpDown";
            this.SN_NumUpDown.Size = new System.Drawing.Size(59, 20);
            this.SN_NumUpDown.TabIndex = 0;
            this.SN_NumUpDown.Value = new decimal(new int[] {
            60006,
            0,
            0,
            0});
            // 
            // taskLoseText
            // 
            this.taskLoseText.Location = new System.Drawing.Point(77, 303);
            this.taskLoseText.Multiline = true;
            this.taskLoseText.Name = "taskLoseText";
            this.taskLoseText.Size = new System.Drawing.Size(170, 37);
            this.taskLoseText.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "questinfo|fail";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Condizioni\r\nSconfitta:";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "questinfo|goal";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condizioni\r\nVittoria:";
            // 
            // taskWinCondText
            // 
            this.taskWinCondText.Location = new System.Drawing.Point(77, 260);
            this.taskWinCondText.Multiline = true;
            this.taskWinCondText.Name = "taskWinCondText";
            this.taskWinCondText.Size = new System.Drawing.Size(170, 37);
            this.taskWinCondText.TabIndex = 5;
            // 
            // taskMostriText
            // 
            this.taskMostriText.Location = new System.Drawing.Point(77, 218);
            this.taskMostriText.Multiline = true;
            this.taskMostriText.Name = "taskMostriText";
            this.taskMostriText.Size = new System.Drawing.Size(170, 37);
            this.taskMostriText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "questinfo|mainmonsters";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mostri\r\nPrincipali:";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "questinfo|details";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dettagli:";
            // 
            // taskDescriptionText
            // 
            this.taskDescriptionText.Location = new System.Drawing.Point(66, 102);
            this.taskDescriptionText.Multiline = true;
            this.taskDescriptionText.Name = "taskDescriptionText";
            this.taskDescriptionText.Size = new System.Drawing.Size(198, 109);
            this.taskDescriptionText.TabIndex = 3;
            this.taskDescriptionText.WordWrap = false;
            // 
            // taskClientText
            // 
            this.taskClientText.Location = new System.Drawing.Point(66, 75);
            this.taskClientText.Name = "taskClientText";
            this.taskClientText.Size = new System.Drawing.Size(198, 20);
            this.taskClientText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "questinfo|client";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "questinfo|questid";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quest ID:";
            // 
            // BossTabPage
            // 
            this.BossTabPage.AccessibleDescription = "pages|monsters";
            this.BossTabPage.Controls.Add(this.label34);
            this.BossTabPage.Controls.Add(this.label114);
            this.BossTabPage.Controls.Add(this.label92);
            this.BossTabPage.Controls.Add(this.label111);
            this.BossTabPage.Controls.Add(this.label38);
            this.BossTabPage.Controls.Add(this.label73);
            this.BossTabPage.Controls.Add(this.label65);
            this.BossTabPage.Controls.Add(this.label67);
            this.BossTabPage.Controls.Add(this.label69);
            this.BossTabPage.Controls.Add(this.label70);
            this.BossTabPage.Controls.Add(this.label71);
            this.BossTabPage.Controls.Add(this.label113);
            this.BossTabPage.Controls.Add(this.BossPanel);
            this.BossTabPage.Controls.Add(this.groupMonsterOptions);
            this.BossTabPage.Controls.Add(this.BossListView);
            this.BossTabPage.Location = new System.Drawing.Point(4, 22);
            this.BossTabPage.Name = "BossTabPage";
            this.BossTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BossTabPage.Size = new System.Drawing.Size(566, 460);
            this.BossTabPage.TabIndex = 1;
            this.BossTabPage.Text = "Mostri";
            this.BossTabPage.UseVisualStyleBackColor = true;
            this.BossTabPage.Click += new System.EventHandler(this.BossTabPage_Click);
            // 
            // label34
            // 
            this.label34.AccessibleDescription = "edit|sta";
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(280, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 135;
            this.label34.Text = "Sta";
            // 
            // label114
            // 
            this.label114.AccessibleDescription = "edit|qty";
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(163, 33);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(24, 13);
            this.label114.TabIndex = 134;
            this.label114.Text = "Qtà";
            // 
            // label92
            // 
            this.label92.AccessibleDescription = "questmonster|title";
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label92.Location = new System.Drawing.Point(11, 14);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(128, 13);
            this.label92.TabIndex = 132;
            this.label92.Text = "Opzioni Mostri Grandi";
            // 
            // label111
            // 
            this.label111.AccessibleDescription = "edit|coef";
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(352, 33);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(32, 13);
            this.label111.TabIndex = 131;
            this.label111.Text = "Coef.";
            // 
            // label38
            // 
            this.label38.AccessibleDescription = "edit|def";
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(250, 33);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 13);
            this.label38.TabIndex = 130;
            this.label38.Text = "Def";
            // 
            // label73
            // 
            this.label73.AccessibleDescription = "edit|coord";
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(428, 33);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(98, 13);
            this.label73.TabIndex = 129;
            this.label73.Text = "┌─ Coord: X - Z - Y ─┐";
            // 
            // label65
            // 
            this.label65.AccessibleDescription = "edit|area";
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(393, 33);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(29, 13);
            this.label65.TabIndex = 128;
            this.label65.Text = "Area";
            // 
            // label67
            // 
            this.label67.AccessibleDescription = "edit|atk";
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(223, 33);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(23, 13);
            this.label67.TabIndex = 127;
            this.label67.Text = "Atk";
            // 
            // label69
            // 
            this.label69.AccessibleDescription = "edit|hp";
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(192, 33);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(22, 13);
            this.label69.TabIndex = 126;
            this.label69.Text = "HP";
            // 
            // label70
            // 
            this.label70.AccessibleDescription = "edit|name";
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(55, 33);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(35, 13);
            this.label70.TabIndex = 125;
            this.label70.Text = "Nome";
            // 
            // label71
            // 
            this.label71.AccessibleDescription = "edit|num";
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(12, 33);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(27, 13);
            this.label71.TabIndex = 124;
            this.label71.Text = "Ord.";
            // 
            // label113
            // 
            this.label113.AccessibleDescription = "edit|dim";
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(309, 33);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(45, 13);
            this.label113.TabIndex = 133;
            this.label113.Text = "Dimens.";
            // 
            // BossPanel
            // 
            this.BossPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BossPanel.Controls.Add(this.BossPanelCloseBtn);
            this.BossPanel.Controls.Add(this.BossSetGroupBox);
            this.BossPanel.Location = new System.Drawing.Point(55, 65);
            this.BossPanel.Name = "BossPanel";
            this.BossPanel.Size = new System.Drawing.Size(475, 126);
            this.BossPanel.TabIndex = 92;
            this.BossPanel.Visible = false;
            this.BossPanel.Leave += new System.EventHandler(this.BossPanel_Leave);
            // 
            // BossPanelCloseBtn
            // 
            this.BossPanelCloseBtn.Location = new System.Drawing.Point(448, 4);
            this.BossPanelCloseBtn.Name = "BossPanelCloseBtn";
            this.BossPanelCloseBtn.Size = new System.Drawing.Size(21, 23);
            this.BossPanelCloseBtn.TabIndex = 0;
            this.BossPanelCloseBtn.Text = "×";
            this.BossPanelCloseBtn.UseVisualStyleBackColor = true;
            this.BossPanelCloseBtn.Click += new System.EventHandler(this.BossPanelCloseBtn_Click);
            // 
            // BossSetGroupBox
            // 
            this.BossSetGroupBox.AccessibleDescription = "edit|title";
            this.BossSetGroupBox.Controls.Add(this.label110);
            this.BossSetGroupBox.Controls.Add(this.label66);
            this.BossSetGroupBox.Controls.Add(this.label37);
            this.BossSetGroupBox.Controls.Add(this.label36);
            this.BossSetGroupBox.Controls.Add(this.label35);
            this.BossSetGroupBox.Controls.Add(this.label47);
            this.BossSetGroupBox.Controls.Add(this.label32);
            this.BossSetGroupBox.Controls.Add(this.label72);
            this.BossSetGroupBox.Controls.Add(this.label115);
            this.BossSetGroupBox.Controls.Add(this.label33);
            this.BossSetGroupBox.Controls.Add(this.label31);
            this.BossSetGroupBox.Controls.Add(this.label30);
            this.BossSetGroupBox.Controls.Add(this.label29);
            this.BossSetGroupBox.Controls.Add(this.label151);
            this.BossSetGroupBox.Controls.Add(this.BossHPCmBox);
            this.BossSetGroupBox.Controls.Add(this.BOSSstyleNumUpD);
            this.BossSetGroupBox.Controls.Add(this.BossEnduranceNumUpD);
            this.BossSetGroupBox.Controls.Add(this.BossToFaceNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossDefenseNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossAttackNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossJumpNumUDn);
            this.BossSetGroupBox.Controls.Add(this.BossVolumnNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossSnNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossZNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossYNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossXNumUD);
            this.BossSetGroupBox.Controls.Add(this.BPointCmbBox);
            this.BossSetGroupBox.Controls.Add(this.BossNumNumUD);
            this.BossSetGroupBox.Controls.Add(this.BossNameCmbBox);
            this.BossSetGroupBox.Location = new System.Drawing.Point(7, 7);
            this.BossSetGroupBox.Name = "BossSetGroupBox";
            this.BossSetGroupBox.Size = new System.Drawing.Size(457, 112);
            this.BossSetGroupBox.TabIndex = 0;
            this.BossSetGroupBox.TabStop = false;
            this.BossSetGroupBox.Text = "Modifica";
            // 
            // label110
            // 
            this.label110.AccessibleDescription = "edit|coef";
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(70, 64);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(32, 13);
            this.label110.TabIndex = 130;
            this.label110.Text = "Coef.";
            // 
            // label66
            // 
            this.label66.AccessibleDescription = "edit|dim";
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 64);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(45, 13);
            this.label66.TabIndex = 129;
            this.label66.Text = "Dimens.";
            // 
            // label37
            // 
            this.label37.AccessibleDescription = "edit|direction";
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(387, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 13);
            this.label37.TabIndex = 128;
            this.label37.Text = "Direzione";
            // 
            // label36
            // 
            this.label36.AccessibleDescription = "edit|coord";
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(215, 64);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(98, 13);
            this.label36.TabIndex = 127;
            this.label36.Text = "┌─ Coord: X - Z - Y ─┐";
            // 
            // label35
            // 
            this.label35.AccessibleDescription = "edit|area";
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(132, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 13);
            this.label35.TabIndex = 126;
            this.label35.Text = "Area";
            // 
            // label47
            // 
            this.label47.AccessibleDescription = "edit|status";
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(409, 18);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(37, 13);
            this.label47.TabIndex = 125;
            this.label47.Text = "Status";
            // 
            // label32
            // 
            this.label32.AccessibleDescription = "edit|sta";
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(365, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 13);
            this.label32.TabIndex = 124;
            this.label32.Text = "Sta";
            // 
            // label72
            // 
            this.label72.AccessibleDescription = "edit|def";
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(325, 18);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(24, 13);
            this.label72.TabIndex = 123;
            this.label72.Text = "Def";
            // 
            // label115
            // 
            this.label115.AccessibleDescription = "edit|atk";
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(281, 18);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(23, 13);
            this.label115.TabIndex = 122;
            this.label115.Text = "Atk";
            // 
            // label33
            // 
            this.label33.AccessibleDescription = "edit|qty";
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(176, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 13);
            this.label33.TabIndex = 121;
            this.label33.Text = "Qtà";
            // 
            // label31
            // 
            this.label31.AccessibleDescription = "edit|hp";
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(230, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 13);
            this.label31.TabIndex = 120;
            this.label31.Text = "HP";
            // 
            // label30
            // 
            this.label30.AccessibleDescription = "edit|name";
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(70, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 13);
            this.label30.TabIndex = 119;
            this.label30.Text = "Nome";
            // 
            // label29
            // 
            this.label29.AccessibleDescription = "edit|num";
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 13);
            this.label29.TabIndex = 118;
            this.label29.Text = "Ord.";
            // 
            // label151
            // 
            this.label151.AccessibleDescription = "edit|coefsymbol";
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(50, 83);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(13, 13);
            this.label151.TabIndex = 117;
            this.label151.Text = "±";
            // 
            // BossHPCmBox
            // 
            this.BossHPCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BossHPCmBox.FormattingEnabled = true;
            this.BossHPCmBox.Location = new System.Drawing.Point(214, 34);
            this.BossHPCmBox.Name = "BossHPCmBox";
            this.BossHPCmBox.Size = new System.Drawing.Size(59, 21);
            this.BossHPCmBox.TabIndex = 116;
            this.BossHPCmBox.SelectedIndexChanged += new System.EventHandler(this.BossHPCmBox_SelectedIndexChanged);
            // 
            // BOSSstyleNumUpD
            // 
            this.BOSSstyleNumUpD.Location = new System.Drawing.Point(409, 33);
            this.BOSSstyleNumUpD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BOSSstyleNumUpD.Name = "BOSSstyleNumUpD";
            this.BOSSstyleNumUpD.Size = new System.Drawing.Size(40, 20);
            this.BOSSstyleNumUpD.TabIndex = 7;
            this.BOSSstyleNumUpD.ValueChanged += new System.EventHandler(this.BOSSstyleNumUpD_ValueChanged);
            // 
            // BossEnduranceNumUpD
            // 
            this.BossEnduranceNumUpD.BackColor = System.Drawing.SystemColors.Window;
            this.BossEnduranceNumUpD.Location = new System.Drawing.Point(365, 33);
            this.BossEnduranceNumUpD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BossEnduranceNumUpD.Name = "BossEnduranceNumUpD";
            this.BossEnduranceNumUpD.Size = new System.Drawing.Size(40, 20);
            this.BossEnduranceNumUpD.TabIndex = 6;
            this.BossEnduranceNumUpD.ValueChanged += new System.EventHandler(this.BossEnduranceNumUpD_ValueChanged);
            // 
            // BossToFaceNumUD
            // 
            this.BossToFaceNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossToFaceNumUD.Location = new System.Drawing.Point(386, 80);
            this.BossToFaceNumUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.BossToFaceNumUD.Name = "BossToFaceNumUD";
            this.BossToFaceNumUD.Size = new System.Drawing.Size(55, 20);
            this.BossToFaceNumUD.TabIndex = 14;
            this.BossToFaceNumUD.ValueChanged += new System.EventHandler(this.BossToFaceNumUD_ValueChanged);
            // 
            // BossDefenseNumUD
            // 
            this.BossDefenseNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossDefenseNumUD.Location = new System.Drawing.Point(322, 33);
            this.BossDefenseNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BossDefenseNumUD.Name = "BossDefenseNumUD";
            this.BossDefenseNumUD.Size = new System.Drawing.Size(40, 20);
            this.BossDefenseNumUD.TabIndex = 5;
            this.BossDefenseNumUD.ValueChanged += new System.EventHandler(this.BossDefenseNumUD_ValueChanged);
            // 
            // BossAttackNumUD
            // 
            this.BossAttackNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossAttackNumUD.Location = new System.Drawing.Point(279, 33);
            this.BossAttackNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BossAttackNumUD.Name = "BossAttackNumUD";
            this.BossAttackNumUD.Size = new System.Drawing.Size(40, 20);
            this.BossAttackNumUD.TabIndex = 4;
            this.BossAttackNumUD.ValueChanged += new System.EventHandler(this.BossAttackNumUD_ValueChanged);
            // 
            // BossJumpNumUDn
            // 
            this.BossJumpNumUDn.BackColor = System.Drawing.SystemColors.Window;
            this.BossJumpNumUDn.Location = new System.Drawing.Point(68, 80);
            this.BossJumpNumUDn.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BossJumpNumUDn.Name = "BossJumpNumUDn";
            this.BossJumpNumUDn.Size = new System.Drawing.Size(40, 20);
            this.BossJumpNumUDn.TabIndex = 9;
            this.BossJumpNumUDn.ValueChanged += new System.EventHandler(this.BossJumpNumUDn_ValueChanged);
            // 
            // BossVolumnNumUD
            // 
            this.BossVolumnNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossVolumnNumUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BossVolumnNumUD.Location = new System.Drawing.Point(6, 80);
            this.BossVolumnNumUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BossVolumnNumUD.Name = "BossVolumnNumUD";
            this.BossVolumnNumUD.Size = new System.Drawing.Size(42, 20);
            this.BossVolumnNumUD.TabIndex = 8;
            this.BossVolumnNumUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BossVolumnNumUD.ValueChanged += new System.EventHandler(this.BossVolumnNumUD_ValueChanged);
            // 
            // BossSnNumUD
            // 
            this.BossSnNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossSnNumUD.Location = new System.Drawing.Point(6, 34);
            this.BossSnNumUD.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.BossSnNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BossSnNumUD.Name = "BossSnNumUD";
            this.BossSnNumUD.Size = new System.Drawing.Size(30, 20);
            this.BossSnNumUD.TabIndex = 0;
            this.BossSnNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BossSnNumUD.ValueChanged += new System.EventHandler(this.BossSnNumUD_ValueChanged);
            // 
            // BossZNumUD
            // 
            this.BossZNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossZNumUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BossZNumUD.Location = new System.Drawing.Point(258, 80);
            this.BossZNumUD.Maximum = new decimal(new int[] {
            99900,
            0,
            0,
            0});
            this.BossZNumUD.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            -2147483648});
            this.BossZNumUD.Name = "BossZNumUD";
            this.BossZNumUD.Size = new System.Drawing.Size(55, 20);
            this.BossZNumUD.TabIndex = 12;
            this.BossZNumUD.ValueChanged += new System.EventHandler(this.BossZNumUD_ValueChanged);
            // 
            // BossYNumUD
            // 
            this.BossYNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossYNumUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BossYNumUD.Location = new System.Drawing.Point(315, 80);
            this.BossYNumUD.Maximum = new decimal(new int[] {
            99900,
            0,
            0,
            0});
            this.BossYNumUD.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            -2147483648});
            this.BossYNumUD.Name = "BossYNumUD";
            this.BossYNumUD.Size = new System.Drawing.Size(55, 20);
            this.BossYNumUD.TabIndex = 13;
            this.BossYNumUD.ValueChanged += new System.EventHandler(this.BossYNumUD_ValueChanged);
            // 
            // BossXNumUD
            // 
            this.BossXNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossXNumUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BossXNumUD.Location = new System.Drawing.Point(200, 80);
            this.BossXNumUD.Maximum = new decimal(new int[] {
            99900,
            0,
            0,
            0});
            this.BossXNumUD.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            -2147483648});
            this.BossXNumUD.Name = "BossXNumUD";
            this.BossXNumUD.Size = new System.Drawing.Size(55, 20);
            this.BossXNumUD.TabIndex = 11;
            this.BossXNumUD.ValueChanged += new System.EventHandler(this.BossXNumUD_ValueChanged);
            // 
            // BPointCmbBox
            // 
            this.BPointCmbBox.BackColor = System.Drawing.SystemColors.Window;
            this.BPointCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BPointCmbBox.FormattingEnabled = true;
            this.BPointCmbBox.Location = new System.Drawing.Point(115, 80);
            this.BPointCmbBox.Name = "BPointCmbBox";
            this.BPointCmbBox.Size = new System.Drawing.Size(74, 21);
            this.BPointCmbBox.TabIndex = 10;
            this.BPointCmbBox.SelectedIndexChanged += new System.EventHandler(this.BPointCmbBox_SelectedIndexChanged);
            // 
            // BossNumNumUD
            // 
            this.BossNumNumUD.BackColor = System.Drawing.SystemColors.Window;
            this.BossNumNumUD.Location = new System.Drawing.Point(171, 34);
            this.BossNumNumUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.BossNumNumUD.Name = "BossNumNumUD";
            this.BossNumNumUD.Size = new System.Drawing.Size(40, 20);
            this.BossNumNumUD.TabIndex = 2;
            this.BossNumNumUD.ValueChanged += new System.EventHandler(this.BossNumNumUD_ValueChanged);
            // 
            // BossNameCmbBox
            // 
            this.BossNameCmbBox.BackColor = System.Drawing.SystemColors.Window;
            this.BossNameCmbBox.FormattingEnabled = true;
            this.BossNameCmbBox.Location = new System.Drawing.Point(39, 34);
            this.BossNameCmbBox.Name = "BossNameCmbBox";
            this.BossNameCmbBox.Size = new System.Drawing.Size(128, 21);
            this.BossNameCmbBox.TabIndex = 1;
            this.BossNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.BossNameCmbBox_SelectedIndexChanged);
            this.BossNameCmbBox.Leave += new System.EventHandler(this.BossNameCmbBox_Leave);
            // 
            // groupMonsterOptions
            // 
            this.groupMonsterOptions.AccessibleDescription = "questmonster|options";
            this.groupMonsterOptions.Controls.Add(this.label150);
            this.groupMonsterOptions.Controls.Add(this.label147);
            this.groupMonsterOptions.Controls.Add(this.label24);
            this.groupMonsterOptions.Controls.Add(this.numUpDnDouNoTimeToDefer);
            this.groupMonsterOptions.Controls.Add(this.label146);
            this.groupMonsterOptions.Controls.Add(this.chkBoxDouNoTimeToDefer);
            this.groupMonsterOptions.Controls.Add(this.chkBoxBOSSJUMP);
            this.groupMonsterOptions.Controls.Add(this.label116);
            this.groupMonsterOptions.Controls.Add(this.BossRandomSysRadioBtn2);
            this.groupMonsterOptions.Controls.Add(this.BossRandomSysRadioBtn3);
            this.groupMonsterOptions.Controls.Add(this.BossRandomSysRadioBtn1);
            this.groupMonsterOptions.Controls.Add(this.AppearanceProbabilityNumUpD3);
            this.groupMonsterOptions.Controls.Add(this.label118);
            this.groupMonsterOptions.Controls.Add(this.label119);
            this.groupMonsterOptions.Controls.Add(this.BossRandomButton);
            this.groupMonsterOptions.Controls.Add(this.BossRandomUnknowValueTextBox);
            this.groupMonsterOptions.Controls.Add(this.label112);
            this.groupMonsterOptions.Controls.Add(this.AppearanceProbabilityNumUpD2);
            this.groupMonsterOptions.Controls.Add(this.label87);
            this.groupMonsterOptions.Controls.Add(this.label109);
            this.groupMonsterOptions.Controls.Add(this.AppearanceProbabilityNumUpD1);
            this.groupMonsterOptions.Controls.Add(this.label68);
            this.groupMonsterOptions.Controls.Add(this.label48);
            this.groupMonsterOptions.Controls.Add(this.label28);
            this.groupMonsterOptions.Controls.Add(this.label104);
            this.groupMonsterOptions.Controls.Add(this.label108);
            this.groupMonsterOptions.Controls.Add(this.label107);
            this.groupMonsterOptions.Controls.Add(this.WarningRemuntNumUpD);
            this.groupMonsterOptions.Controls.Add(this.WarningUnionNumUpD);
            this.groupMonsterOptions.Location = new System.Drawing.Point(11, 289);
            this.groupMonsterOptions.Name = "groupMonsterOptions";
            this.groupMonsterOptions.Size = new System.Drawing.Size(549, 165);
            this.groupMonsterOptions.TabIndex = 123;
            this.groupMonsterOptions.TabStop = false;
            this.groupMonsterOptions.Text = "Opzioni Speciali";
            // 
            // label150
            // 
            this.label150.AccessibleDescription = "questinfo|environment";
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(181, 26);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(54, 13);
            this.label150.TabIndex = 152;
            this.label150.Text = "Ambiente:";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label147.Location = new System.Drawing.Point(203, 46);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(10, 104);
            this.label147.TabIndex = 151;
            this.label147.Text = "│\r\n│\r\n│\r\n│\r\n│\r\n│\r\n│\r\n│";
            // 
            // label24
            // 
            this.label24.AccessibleDescription = "questmonster|basicopt";
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 150;
            this.label24.Text = "Base:";
            // 
            // numUpDnDouNoTimeToDefer
            // 
            this.numUpDnDouNoTimeToDefer.Location = new System.Drawing.Point(121, 76);
            this.numUpDnDouNoTimeToDefer.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.numUpDnDouNoTimeToDefer.Name = "numUpDnDouNoTimeToDefer";
            this.numUpDnDouNoTimeToDefer.Size = new System.Drawing.Size(40, 20);
            this.numUpDnDouNoTimeToDefer.TabIndex = 143;
            this.numUpDnDouNoTimeToDefer.ValueChanged += new System.EventHandler(this.numUpDnDouNoTimeToDefer_ValueChanged);
            // 
            // label146
            // 
            this.label146.AccessibleDescription = "game|minutes";
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(168, 78);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(24, 13);
            this.label146.TabIndex = 144;
            this.label146.Text = "Min";
            // 
            // chkBoxDouNoTimeToDefer
            // 
            this.chkBoxDouNoTimeToDefer.AccessibleDescription = "questmonster|delay";
            this.chkBoxDouNoTimeToDefer.AutoSize = true;
            this.chkBoxDouNoTimeToDefer.Location = new System.Drawing.Point(16, 77);
            this.chkBoxDouNoTimeToDefer.Name = "chkBoxDouNoTimeToDefer";
            this.chkBoxDouNoTimeToDefer.Size = new System.Drawing.Size(99, 17);
            this.chkBoxDouNoTimeToDefer.TabIndex = 142;
            this.chkBoxDouNoTimeToDefer.Text = "Ritardo Spawn:";
            this.chkBoxDouNoTimeToDefer.UseVisualStyleBackColor = true;
            // 
            // chkBoxBOSSJUMP
            // 
            this.chkBoxBOSSJUMP.AccessibleDescription = "questmonster|hrmoves";
            this.chkBoxBOSSJUMP.AutoSize = true;
            this.chkBoxBOSSJUMP.ForeColor = System.Drawing.Color.Maroon;
            this.chkBoxBOSSJUMP.Location = new System.Drawing.Point(16, 57);
            this.chkBoxBOSSJUMP.Name = "chkBoxBOSSJUMP";
            this.chkBoxBOSSJUMP.Size = new System.Drawing.Size(111, 17);
            this.chkBoxBOSSJUMP.TabIndex = 141;
            this.chkBoxBOSSJUMP.Text = "Mosse High Rank";
            this.chkBoxBOSSJUMP.UseVisualStyleBackColor = true;
            // 
            // label116
            // 
            this.label116.AccessibleDescription = "questmonster|warningcode";
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(241, 111);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(63, 13);
            this.label116.TabIndex = 140;
            this.label116.Text = "Codice Inst:";
            // 
            // BossRandomSysRadioBtn2
            // 
            this.BossRandomSysRadioBtn2.AccessibleDescription = "other|random";
            this.BossRandomSysRadioBtn2.AutoSize = true;
            this.BossRandomSysRadioBtn2.ForeColor = System.Drawing.Color.DarkBlue;
            this.BossRandomSysRadioBtn2.Location = new System.Drawing.Point(333, 24);
            this.BossRandomSysRadioBtn2.Name = "BossRandomSysRadioBtn2";
            this.BossRandomSysRadioBtn2.Size = new System.Drawing.Size(63, 17);
            this.BossRandomSysRadioBtn2.TabIndex = 1;
            this.BossRandomSysRadioBtn2.TabStop = true;
            this.BossRandomSysRadioBtn2.Text = "Casuale";
            this.BossRandomSysRadioBtn2.UseVisualStyleBackColor = true;
            this.BossRandomSysRadioBtn2.CheckedChanged += new System.EventHandler(this.BossRandomSysRadioBtn_CheckedChanged);
            // 
            // BossRandomSysRadioBtn3
            // 
            this.BossRandomSysRadioBtn3.AccessibleDescription = "game|unstable";
            this.BossRandomSysRadioBtn3.AutoSize = true;
            this.BossRandomSysRadioBtn3.ForeColor = System.Drawing.Color.DarkBlue;
            this.BossRandomSysRadioBtn3.Location = new System.Drawing.Point(413, 24);
            this.BossRandomSysRadioBtn3.Name = "BossRandomSysRadioBtn3";
            this.BossRandomSysRadioBtn3.Size = new System.Drawing.Size(64, 17);
            this.BossRandomSysRadioBtn3.TabIndex = 2;
            this.BossRandomSysRadioBtn3.Text = "Instabile";
            this.BossRandomSysRadioBtn3.UseVisualStyleBackColor = true;
            this.BossRandomSysRadioBtn3.CheckedChanged += new System.EventHandler(this.BossRandomSysRadioBtn_CheckedChanged);
            // 
            // BossRandomSysRadioBtn1
            // 
            this.BossRandomSysRadioBtn1.AccessibleDescription = "game|stable";
            this.BossRandomSysRadioBtn1.AutoSize = true;
            this.BossRandomSysRadioBtn1.Checked = true;
            this.BossRandomSysRadioBtn1.ForeColor = System.Drawing.Color.DarkBlue;
            this.BossRandomSysRadioBtn1.Location = new System.Drawing.Point(256, 24);
            this.BossRandomSysRadioBtn1.Name = "BossRandomSysRadioBtn1";
            this.BossRandomSysRadioBtn1.Size = new System.Drawing.Size(57, 17);
            this.BossRandomSysRadioBtn1.TabIndex = 0;
            this.BossRandomSysRadioBtn1.TabStop = true;
            this.BossRandomSysRadioBtn1.Text = "Stabile";
            this.BossRandomSysRadioBtn1.UseVisualStyleBackColor = true;
            this.BossRandomSysRadioBtn1.CheckedChanged += new System.EventHandler(this.BossRandomSysRadioBtn_CheckedChanged);
            // 
            // AppearanceProbabilityNumUpD3
            // 
            this.AppearanceProbabilityNumUpD3.Enabled = false;
            this.AppearanceProbabilityNumUpD3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AppearanceProbabilityNumUpD3.Location = new System.Drawing.Point(467, 126);
            this.AppearanceProbabilityNumUpD3.Name = "AppearanceProbabilityNumUpD3";
            this.AppearanceProbabilityNumUpD3.Size = new System.Drawing.Size(42, 20);
            this.AppearanceProbabilityNumUpD3.TabIndex = 9;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(511, 128);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(15, 13);
            this.label118.TabIndex = 135;
            this.label118.Text = "%";
            // 
            // label119
            // 
            this.label119.AccessibleDescription = "questmonster|num13";
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(422, 128);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(39, 13);
            this.label119.TabIndex = 134;
            this.label119.Text = "Ord.13";
            // 
            // BossRandomButton
            // 
            this.BossRandomButton.AccessibleDescription = "other|randomize";
            this.BossRandomButton.Enabled = false;
            this.BossRandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossRandomButton.Location = new System.Drawing.Point(308, 130);
            this.BossRandomButton.Name = "BossRandomButton";
            this.BossRandomButton.Size = new System.Drawing.Size(74, 20);
            this.BossRandomButton.TabIndex = 6;
            this.BossRandomButton.Text = "Casuale";
            this.BossRandomButton.UseVisualStyleBackColor = true;
            this.BossRandomButton.Click += new System.EventHandler(this.BossRandomButton_Click);
            // 
            // BossRandomUnknowValueTextBox
            // 
            this.BossRandomUnknowValueTextBox.Enabled = false;
            this.BossRandomUnknowValueTextBox.Location = new System.Drawing.Point(308, 108);
            this.BossRandomUnknowValueTextBox.MaxLength = 8;
            this.BossRandomUnknowValueTextBox.Name = "BossRandomUnknowValueTextBox";
            this.BossRandomUnknowValueTextBox.Size = new System.Drawing.Size(74, 20);
            this.BossRandomUnknowValueTextBox.TabIndex = 5;
            this.BossRandomUnknowValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BossRandomUnknowValueTextBox_KeyPress);
            // 
            // label112
            // 
            this.label112.AccessibleDescription = "questmonster|num11";
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(423, 75);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(39, 13);
            this.label112.TabIndex = 132;
            this.label112.Text = "Ord.11";
            // 
            // AppearanceProbabilityNumUpD2
            // 
            this.AppearanceProbabilityNumUpD2.Enabled = false;
            this.AppearanceProbabilityNumUpD2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AppearanceProbabilityNumUpD2.Location = new System.Drawing.Point(467, 100);
            this.AppearanceProbabilityNumUpD2.Name = "AppearanceProbabilityNumUpD2";
            this.AppearanceProbabilityNumUpD2.Size = new System.Drawing.Size(42, 20);
            this.AppearanceProbabilityNumUpD2.TabIndex = 8;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(511, 102);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(15, 13);
            this.label87.TabIndex = 4;
            this.label87.Text = "%";
            // 
            // label109
            // 
            this.label109.AccessibleDescription = "questmonster|num12";
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(423, 102);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(39, 13);
            this.label109.TabIndex = 3;
            this.label109.Text = "Ord.12";
            // 
            // AppearanceProbabilityNumUpD1
            // 
            this.AppearanceProbabilityNumUpD1.Enabled = false;
            this.AppearanceProbabilityNumUpD1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AppearanceProbabilityNumUpD1.Location = new System.Drawing.Point(466, 73);
            this.AppearanceProbabilityNumUpD1.Name = "AppearanceProbabilityNumUpD1";
            this.AppearanceProbabilityNumUpD1.Size = new System.Drawing.Size(42, 20);
            this.AppearanceProbabilityNumUpD1.TabIndex = 7;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(511, 75);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(15, 13);
            this.label68.TabIndex = 128;
            this.label68.Text = "%";
            // 
            // label48
            // 
            this.label48.AccessibleDescription = "questmonster|warningperc";
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(423, 56);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(103, 13);
            this.label48.TabIndex = 126;
            this.label48.Text = "Possibilità Instabilità:";
            // 
            // label28
            // 
            this.label28.AccessibleDescription = "game|z";
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(370, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(12, 13);
            this.label28.TabIndex = 125;
            this.label28.Text = "z";
            // 
            // label104
            // 
            this.label104.AccessibleDescription = "game|points";
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(370, 58);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(19, 13);
            this.label104.TabIndex = 125;
            this.label104.Text = "Pti";
            // 
            // label108
            // 
            this.label108.AccessibleDescription = "questinfo|money";
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(241, 83);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(33, 13);
            this.label108.TabIndex = 124;
            this.label108.Text = "Soldi:";
            // 
            // label107
            // 
            this.label107.AccessibleDescription = "questinfo|guildpoints";
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(241, 56);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(61, 13);
            this.label107.TabIndex = 124;
            this.label107.Text = "Punti Gilda:";
            // 
            // WarningRemuntNumUpD
            // 
            this.WarningRemuntNumUpD.Enabled = false;
            this.WarningRemuntNumUpD.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.WarningRemuntNumUpD.Location = new System.Drawing.Point(308, 81);
            this.WarningRemuntNumUpD.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.WarningRemuntNumUpD.Name = "WarningRemuntNumUpD";
            this.WarningRemuntNumUpD.Size = new System.Drawing.Size(59, 20);
            this.WarningRemuntNumUpD.TabIndex = 4;
            // 
            // WarningUnionNumUpD
            // 
            this.WarningUnionNumUpD.Enabled = false;
            this.WarningUnionNumUpD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WarningUnionNumUpD.Location = new System.Drawing.Point(308, 54);
            this.WarningUnionNumUpD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.WarningUnionNumUpD.Name = "WarningUnionNumUpD";
            this.WarningUnionNumUpD.Size = new System.Drawing.Size(59, 20);
            this.WarningUnionNumUpD.TabIndex = 3;
            // 
            // BossListView
            // 
            this.BossListView.BackColor = System.Drawing.SystemColors.Window;
            this.BossListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BossClmnHeader1,
            this.BossClmnHeader2,
            this.BossClmnHeader3,
            this.BossClmnHeader4,
            this.BossClmnHeader5,
            this.BossClmnHeader6,
            this.BossClmnHeader7,
            this.BossClmnHeader8,
            this.BossClmnHeader9,
            this.BossClmnHeader10,
            this.BossClmnHeader11,
            this.BossClmnHeader12,
            this.BossClmnHeader13});
            this.BossListView.FullRowSelect = true;
            this.BossListView.GridLines = true;
            this.BossListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.BossListView.Location = new System.Drawing.Point(9, 50);
            this.BossListView.MultiSelect = false;
            this.BossListView.Name = "BossListView";
            this.BossListView.Scrollable = false;
            this.BossListView.Size = new System.Drawing.Size(551, 233);
            this.BossListView.TabIndex = 0;
            this.BossListView.UseCompatibleStateImageBehavior = false;
            this.BossListView.View = System.Windows.Forms.View.Details;
            this.BossListView.Click += new System.EventHandler(this.BossListView_Click);
            // 
            // BossClmnHeader1
            // 
            this.BossClmnHeader1.Text = "Ord.";
            this.BossClmnHeader1.Width = 25;
            // 
            // BossClmnHeader2
            // 
            this.BossClmnHeader2.Text = "Nome";
            this.BossClmnHeader2.Width = 125;
            // 
            // BossClmnHeader3
            // 
            this.BossClmnHeader3.Text = "Qtà";
            this.BossClmnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader3.Width = 28;
            // 
            // BossClmnHeader4
            // 
            this.BossClmnHeader4.Text = "HP";
            this.BossClmnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader4.Width = 30;
            // 
            // BossClmnHeader5
            // 
            this.BossClmnHeader5.Text = "Atk";
            this.BossClmnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BossClmnHeader5.Width = 30;
            // 
            // BossClmnHeader6
            // 
            this.BossClmnHeader6.Text = "Def";
            this.BossClmnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader6.Width = 30;
            // 
            // BossClmnHeader7
            // 
            this.BossClmnHeader7.Text = "Sta";
            this.BossClmnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader7.Width = 30;
            // 
            // BossClmnHeader8
            // 
            this.BossClmnHeader8.Text = "Dim";
            this.BossClmnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader8.Width = 45;
            // 
            // BossClmnHeader9
            // 
            this.BossClmnHeader9.Text = "Coef.";
            this.BossClmnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BossClmnHeader9.Width = 30;
            // 
            // BossClmnHeader10
            // 
            this.BossClmnHeader10.Text = "Area";
            this.BossClmnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader10.Width = 50;
            // 
            // BossClmnHeader11
            // 
            this.BossClmnHeader11.Text = "X";
            this.BossClmnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader11.Width = 40;
            // 
            // BossClmnHeader12
            // 
            this.BossClmnHeader12.Text = "Z";
            this.BossClmnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader12.Width = 40;
            // 
            // BossClmnHeader13
            // 
            this.BossClmnHeader13.Text = "Y";
            this.BossClmnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BossClmnHeader13.Width = 40;
            // 
            // DogfishTabPage
            // 
            this.DogfishTabPage.AccessibleDescription = "pages|minions";
            this.DogfishTabPage.Controls.Add(this.groupMinionsBig);
            this.DogfishTabPage.Controls.Add(this.DogfishPanel);
            this.DogfishTabPage.Controls.Add(this.groupBox8);
            this.DogfishTabPage.Controls.Add(this.groupBox7);
            this.DogfishTabPage.Location = new System.Drawing.Point(4, 22);
            this.DogfishTabPage.Name = "DogfishTabPage";
            this.DogfishTabPage.Size = new System.Drawing.Size(566, 460);
            this.DogfishTabPage.TabIndex = 2;
            this.DogfishTabPage.Text = "Minori";
            this.DogfishTabPage.UseVisualStyleBackColor = true;
            this.DogfishTabPage.Click += new System.EventHandler(this.DogfishTabPage_Click);
            // 
            // groupMinionsBig
            // 
            this.groupMinionsBig.AccessibleDescription = "questminion|bigmonster";
            this.groupMinionsBig.Controls.Add(this.label152);
            this.groupMinionsBig.Controls.Add(this.NumUpDownDfEndurance);
            this.groupMinionsBig.Controls.Add(this.label145);
            this.groupMinionsBig.Controls.Add(this.DogfishToBossChkBox);
            this.groupMinionsBig.Controls.Add(this.DfVolumeNumUpD);
            this.groupMinionsBig.Controls.Add(this.label106);
            this.groupMinionsBig.Controls.Add(this.DfDefenseNumUpDown);
            this.groupMinionsBig.Controls.Add(this.label88);
            this.groupMinionsBig.Controls.Add(this.DfAttackNumUpDown);
            this.groupMinionsBig.Controls.Add(this.label27);
            this.groupMinionsBig.Controls.Add(this.DfGradeNumUpDown);
            this.groupMinionsBig.Controls.Add(this.label46);
            this.groupMinionsBig.Location = new System.Drawing.Point(273, 17);
            this.groupMinionsBig.Name = "groupMinionsBig";
            this.groupMinionsBig.Size = new System.Drawing.Size(280, 148);
            this.groupMinionsBig.TabIndex = 27;
            this.groupMinionsBig.TabStop = false;
            this.groupMinionsBig.Text = "Opzioni Mostri Grandi";
            // 
            // label152
            // 
            this.label152.AccessibleDescription = "questminion|message";
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.ForeColor = System.Drawing.Color.DarkRed;
            this.label152.Location = new System.Drawing.Point(5, 101);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(262, 39);
            this.label152.TabIndex = 34;
            this.label152.Text = "Those options are valid only for main monsters inserted\r\nas minions. Use them at " +
                "your own risk, they can freeze\r\nyour quest if not properly used.";
            // 
            // NumUpDownDfEndurance
            // 
            this.NumUpDownDfEndurance.Location = new System.Drawing.Point(180, 48);
            this.NumUpDownDfEndurance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUpDownDfEndurance.Name = "NumUpDownDfEndurance";
            this.NumUpDownDfEndurance.Size = new System.Drawing.Size(45, 20);
            this.NumUpDownDfEndurance.TabIndex = 29;
            // 
            // label145
            // 
            this.label145.AccessibleDescription = "edit|sta";
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(147, 50);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(26, 13);
            this.label145.TabIndex = 30;
            this.label145.Tag = "true";
            this.label145.Text = "Sta:";
            // 
            // DogfishToBossChkBox
            // 
            this.DogfishToBossChkBox.AccessibleDescription = "questminion|force";
            this.DogfishToBossChkBox.AutoSize = true;
            this.DogfishToBossChkBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DogfishToBossChkBox.Location = new System.Drawing.Point(17, 80);
            this.DogfishToBossChkBox.Name = "DogfishToBossChkBox";
            this.DogfishToBossChkBox.Size = new System.Drawing.Size(174, 17);
            this.DogfishToBossChkBox.TabIndex = 4;
            this.DogfishToBossChkBox.Text = "Forza Inserimento Mostri Grandi";
            this.DogfishToBossChkBox.UseVisualStyleBackColor = true;
            this.DogfishToBossChkBox.CheckedChanged += new System.EventHandler(this.DogfishToBossChkBox_CheckedChanged);
            // 
            // DfVolumeNumUpD
            // 
            this.DfVolumeNumUpD.Location = new System.Drawing.Point(86, 48);
            this.DfVolumeNumUpD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DfVolumeNumUpD.Name = "DfVolumeNumUpD";
            this.DfVolumeNumUpD.Size = new System.Drawing.Size(45, 20);
            this.DfVolumeNumUpD.TabIndex = 0;
            // 
            // label106
            // 
            this.label106.AccessibleDescription = "edit|dim";
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(33, 50);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(48, 13);
            this.label106.TabIndex = 28;
            this.label106.Tag = "true";
            this.label106.Text = "Dimens.:";
            // 
            // DfDefenseNumUpDown
            // 
            this.DfDefenseNumUpDown.Location = new System.Drawing.Point(222, 21);
            this.DfDefenseNumUpDown.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.DfDefenseNumUpDown.Name = "DfDefenseNumUpDown";
            this.DfDefenseNumUpDown.Size = new System.Drawing.Size(40, 20);
            this.DfDefenseNumUpDown.TabIndex = 3;
            // 
            // label88
            // 
            this.label88.AccessibleDescription = "edit|def";
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(189, 23);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(27, 13);
            this.label88.TabIndex = 26;
            this.label88.Tag = "true";
            this.label88.Text = "Def:";
            // 
            // DfAttackNumUpDown
            // 
            this.DfAttackNumUpDown.Location = new System.Drawing.Point(137, 21);
            this.DfAttackNumUpDown.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.DfAttackNumUpDown.Name = "DfAttackNumUpDown";
            this.DfAttackNumUpDown.Size = new System.Drawing.Size(40, 20);
            this.DfAttackNumUpDown.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AccessibleDescription = "edit|atk";
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(105, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 13);
            this.label27.TabIndex = 24;
            this.label27.Tag = "true";
            this.label27.Text = "Atk:";
            // 
            // DfGradeNumUpDown
            // 
            this.DfGradeNumUpDown.Location = new System.Drawing.Point(45, 21);
            this.DfGradeNumUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DfGradeNumUpDown.Name = "DfGradeNumUpDown";
            this.DfGradeNumUpDown.Size = new System.Drawing.Size(45, 20);
            this.DfGradeNumUpDown.TabIndex = 1;
            // 
            // label46
            // 
            this.label46.AccessibleDescription = "edit|hp";
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(14, 23);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(25, 13);
            this.label46.TabIndex = 22;
            this.label46.Tag = "true";
            this.label46.Text = "HP:";
            // 
            // DogfishPanel
            // 
            this.DogfishPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DogfishPanel.Controls.Add(this.button1);
            this.DogfishPanel.Controls.Add(this.groupBox9);
            this.DogfishPanel.Location = new System.Drawing.Point(134, 250);
            this.DogfishPanel.Name = "DogfishPanel";
            this.DogfishPanel.Size = new System.Drawing.Size(356, 119);
            this.DogfishPanel.TabIndex = 26;
            this.DogfishPanel.Visible = false;
            this.DogfishPanel.Leave += new System.EventHandler(this.DogfishPanel_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.AccessibleDescription = "edit|title";
            this.groupBox9.Controls.Add(this.label64);
            this.groupBox9.Controls.Add(this.label63);
            this.groupBox9.Controls.Add(this.label58);
            this.groupBox9.Controls.Add(this.label62);
            this.groupBox9.Controls.Add(this.label61);
            this.groupBox9.Controls.Add(this.label59);
            this.groupBox9.Controls.Add(this.label60);
            this.groupBox9.Controls.Add(this.DftoFaceNumUpD);
            this.groupBox9.Controls.Add(this.Df_YNumUD);
            this.groupBox9.Controls.Add(this.Df_ZNumUD);
            this.groupBox9.Controls.Add(this.Df_XNumUD);
            this.groupBox9.Controls.Add(this.DfNumNumUpD);
            this.groupBox9.Controls.Add(this.DfRoundTypeCmbBox);
            this.groupBox9.Controls.Add(this.DfTypeNumUpD);
            this.groupBox9.Controls.Add(this.DfNameCmbBox);
            this.groupBox9.Controls.Add(this.DfSnNumUpD);
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 105);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Modifica";
            // 
            // label64
            // 
            this.label64.AccessibleDescription = "edit|coord";
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(88, 62);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(98, 13);
            this.label64.TabIndex = 31;
            this.label64.Text = "┌─ Coord: X - Z - Y ─┐";
            // 
            // label63
            // 
            this.label63.AccessibleDescription = "edit|direction";
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(278, 62);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(51, 13);
            this.label63.TabIndex = 30;
            this.label63.Text = "Direzione";
            // 
            // label58
            // 
            this.label58.AccessibleDescription = "edit|color";
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(12, 62);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(37, 13);
            this.label58.TabIndex = 29;
            this.label58.Text = "Colore";
            // 
            // label62
            // 
            this.label62.AccessibleDescription = "edit|qty";
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(299, 15);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(24, 13);
            this.label62.TabIndex = 28;
            this.label62.Text = "Qtà";
            // 
            // label61
            // 
            this.label61.AccessibleDescription = "edit|respawn";
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(183, 15);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(100, 13);
            this.label61.TabIndex = 27;
            this.label61.Text = "Posizione Respawn";
            // 
            // label59
            // 
            this.label59.AccessibleDescription = "edit|name";
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(81, 15);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 13);
            this.label59.TabIndex = 26;
            this.label59.Text = "Nome";
            // 
            // label60
            // 
            this.label60.AccessibleDescription = "edit|num";
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(20, 15);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(27, 13);
            this.label60.TabIndex = 25;
            this.label60.Text = "Ord.";
            // 
            // DftoFaceNumUpD
            // 
            this.DftoFaceNumUpD.Location = new System.Drawing.Point(274, 78);
            this.DftoFaceNumUpD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.DftoFaceNumUpD.Name = "DftoFaceNumUpD";
            this.DftoFaceNumUpD.Size = new System.Drawing.Size(55, 20);
            this.DftoFaceNumUpD.TabIndex = 8;
            this.DftoFaceNumUpD.ValueChanged += new System.EventHandler(this.DftoFaceNumUpD_ValueChanged);
            // 
            // Df_YNumUD
            // 
            this.Df_YNumUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Df_YNumUD.Location = new System.Drawing.Point(200, 78);
            this.Df_YNumUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Df_YNumUD.Minimum = new decimal(new int[] {
            90000,
            0,
            0,
            -2147483648});
            this.Df_YNumUD.Name = "Df_YNumUD";
            this.Df_YNumUD.Size = new System.Drawing.Size(64, 20);
            this.Df_YNumUD.TabIndex = 7;
            this.Df_YNumUD.ValueChanged += new System.EventHandler(this.Df_YNumUD_ValueChanged);
            // 
            // Df_ZNumUD
            // 
            this.Df_ZNumUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Df_ZNumUD.Location = new System.Drawing.Point(130, 78);
            this.Df_ZNumUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Df_ZNumUD.Minimum = new decimal(new int[] {
            90000,
            0,
            0,
            -2147483648});
            this.Df_ZNumUD.Name = "Df_ZNumUD";
            this.Df_ZNumUD.Size = new System.Drawing.Size(66, 20);
            this.Df_ZNumUD.TabIndex = 6;
            this.Df_ZNumUD.ValueChanged += new System.EventHandler(this.Df_ZNumUD_ValueChanged);
            // 
            // Df_XNumUD
            // 
            this.Df_XNumUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Df_XNumUD.Location = new System.Drawing.Point(59, 78);
            this.Df_XNumUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Df_XNumUD.Minimum = new decimal(new int[] {
            90000,
            0,
            0,
            -2147483648});
            this.Df_XNumUD.Name = "Df_XNumUD";
            this.Df_XNumUD.Size = new System.Drawing.Size(68, 20);
            this.Df_XNumUD.TabIndex = 5;
            this.Df_XNumUD.ValueChanged += new System.EventHandler(this.Df_XNumUD_ValueChanged);
            // 
            // DfNumNumUpD
            // 
            this.DfNumNumUpD.Location = new System.Drawing.Point(284, 33);
            this.DfNumNumUpD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DfNumNumUpD.Name = "DfNumNumUpD";
            this.DfNumNumUpD.Size = new System.Drawing.Size(45, 20);
            this.DfNumNumUpD.TabIndex = 3;
            this.DfNumNumUpD.ValueChanged += new System.EventHandler(this.DfNumNumUpD_ValueChanged);
            // 
            // DfRoundTypeCmbBox
            // 
            this.DfRoundTypeCmbBox.DisplayMember = "1";
            this.DfRoundTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DfRoundTypeCmbBox.FormattingEnabled = true;
            this.DfRoundTypeCmbBox.Items.AddRange(new object[] {
            "Fissa",
            "Casuale",
            "Nascosta"});
            this.DfRoundTypeCmbBox.Location = new System.Drawing.Point(189, 32);
            this.DfRoundTypeCmbBox.Name = "DfRoundTypeCmbBox";
            this.DfRoundTypeCmbBox.Size = new System.Drawing.Size(87, 21);
            this.DfRoundTypeCmbBox.TabIndex = 2;
            this.DfRoundTypeCmbBox.SelectedIndexChanged += new System.EventHandler(this.DfRoundTypeCmbBox_SelectedIndexChanged);
            // 
            // DfTypeNumUpD
            // 
            this.DfTypeNumUpD.Location = new System.Drawing.Point(12, 78);
            this.DfTypeNumUpD.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DfTypeNumUpD.Name = "DfTypeNumUpD";
            this.DfTypeNumUpD.Size = new System.Drawing.Size(35, 20);
            this.DfTypeNumUpD.TabIndex = 4;
            this.DfTypeNumUpD.ValueChanged += new System.EventHandler(this.DfTypeNumUpD_ValueChanged);
            // 
            // DfNameCmbBox
            // 
            this.DfNameCmbBox.FormattingEnabled = true;
            this.DfNameCmbBox.Location = new System.Drawing.Point(53, 33);
            this.DfNameCmbBox.Name = "DfNameCmbBox";
            this.DfNameCmbBox.Size = new System.Drawing.Size(130, 21);
            this.DfNameCmbBox.TabIndex = 1;
            this.DfNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.DfNameCmbBox_SelectedIndexChanged);
            this.DfNameCmbBox.Leave += new System.EventHandler(this.DfNameCmbBox_Leave);
            // 
            // DfSnNumUpD
            // 
            this.DfSnNumUpD.Location = new System.Drawing.Point(12, 33);
            this.DfSnNumUpD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DfSnNumUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DfSnNumUpD.Name = "DfSnNumUpD";
            this.DfSnNumUpD.Size = new System.Drawing.Size(37, 20);
            this.DfSnNumUpD.TabIndex = 0;
            this.DfSnNumUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DfSnNumUpD.ValueChanged += new System.EventHandler(this.DfSnNumUpD_ValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.AccessibleDescription = "questminion|general";
            this.groupBox8.Controls.Add(this.label49);
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.label52);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.label56);
            this.groupBox8.Controls.Add(this.label57);
            this.groupBox8.Controls.Add(this.RoundRdButton3);
            this.groupBox8.Controls.Add(this.RoundRdButton2);
            this.groupBox8.Controls.Add(this.RoundRdButton1);
            this.groupBox8.Controls.Add(this.label55);
            this.groupBox8.Controls.Add(this.DfPointCmbBox);
            this.groupBox8.Controls.Add(this.label51);
            this.groupBox8.Controls.Add(this.DogfishListView);
            this.groupBox8.Location = new System.Drawing.Point(13, 171);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(540, 277);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Opzioni Generali";
            // 
            // label49
            // 
            this.label49.AccessibleDescription = "edit|direction";
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(441, 52);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(51, 13);
            this.label49.TabIndex = 29;
            this.label49.Text = "Direzione";
            // 
            // label50
            // 
            this.label50.AccessibleDescription = "edit|coord";
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(274, 52);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(98, 13);
            this.label50.TabIndex = 28;
            this.label50.Text = "┌─ Coord: X - Z - Y ─┐";
            // 
            // label52
            // 
            this.label52.AccessibleDescription = "edit|respawnshort";
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(188, 52);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(28, 13);
            this.label52.TabIndex = 27;
            this.label52.Text = "Pos.";
            // 
            // label53
            // 
            this.label53.AccessibleDescription = "edit|qty";
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(222, 52);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(24, 13);
            this.label53.TabIndex = 26;
            this.label53.Text = "Qtà";
            // 
            // label54
            // 
            this.label54.AccessibleDescription = "edit|colorshort";
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(159, 52);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(25, 13);
            this.label54.TabIndex = 25;
            this.label54.Text = "Col.";
            // 
            // label56
            // 
            this.label56.AccessibleDescription = "edit|name";
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(83, 52);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 13);
            this.label56.TabIndex = 24;
            this.label56.Text = "Nome";
            // 
            // label57
            // 
            this.label57.AccessibleDescription = "edit|num";
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(29, 52);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(27, 13);
            this.label57.TabIndex = 23;
            this.label57.Text = "Ord.";
            // 
            // RoundRdButton3
            // 
            this.RoundRdButton3.AccessibleDescription = "questminion|secondcond";
            this.RoundRdButton3.AutoSize = true;
            this.RoundRdButton3.Enabled = false;
            this.RoundRdButton3.Location = new System.Drawing.Point(417, 23);
            this.RoundRdButton3.Name = "RoundRdButton3";
            this.RoundRdButton3.Size = new System.Drawing.Size(86, 17);
            this.RoundRdButton3.TabIndex = 3;
            this.RoundRdButton3.TabStop = true;
            this.RoundRdButton3.Text = "Condizione 2";
            this.RoundRdButton3.UseVisualStyleBackColor = true;
            this.RoundRdButton3.CheckedChanged += new System.EventHandler(this.RoundRdButton3_CheckedChanged);
            // 
            // RoundRdButton2
            // 
            this.RoundRdButton2.AccessibleDescription = "questminion|firstcond";
            this.RoundRdButton2.AutoSize = true;
            this.RoundRdButton2.Enabled = false;
            this.RoundRdButton2.Location = new System.Drawing.Point(325, 23);
            this.RoundRdButton2.Name = "RoundRdButton2";
            this.RoundRdButton2.Size = new System.Drawing.Size(86, 17);
            this.RoundRdButton2.TabIndex = 2;
            this.RoundRdButton2.TabStop = true;
            this.RoundRdButton2.Text = "Condizione 1";
            this.RoundRdButton2.UseVisualStyleBackColor = true;
            this.RoundRdButton2.CheckedChanged += new System.EventHandler(this.RoundRdButton2_CheckedChanged);
            // 
            // RoundRdButton1
            // 
            this.RoundRdButton1.AccessibleDescription = "other|default";
            this.RoundRdButton1.AutoSize = true;
            this.RoundRdButton1.Checked = true;
            this.RoundRdButton1.Location = new System.Drawing.Point(257, 23);
            this.RoundRdButton1.Name = "RoundRdButton1";
            this.RoundRdButton1.Size = new System.Drawing.Size(59, 17);
            this.RoundRdButton1.TabIndex = 1;
            this.RoundRdButton1.TabStop = true;
            this.RoundRdButton1.Text = "Default";
            this.RoundRdButton1.UseVisualStyleBackColor = true;
            this.RoundRdButton1.CheckedChanged += new System.EventHandler(this.RoundRdButton1_CheckedChanged);
            // 
            // label55
            // 
            this.label55.AccessibleDescription = "questminion|waves";
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(206, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(45, 13);
            this.label55.TabIndex = 22;
            this.label55.Text = "Ondate:";
            // 
            // DfPointCmbBox
            // 
            this.DfPointCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DfPointCmbBox.FormattingEnabled = true;
            this.DfPointCmbBox.Location = new System.Drawing.Point(74, 22);
            this.DfPointCmbBox.Name = "DfPointCmbBox";
            this.DfPointCmbBox.Size = new System.Drawing.Size(114, 21);
            this.DfPointCmbBox.TabIndex = 0;
            this.DfPointCmbBox.SelectedIndexChanged += new System.EventHandler(this.DfPointCmbBox_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.AccessibleDescription = "edit|area";
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(28, 25);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(32, 13);
            this.label51.TabIndex = 20;
            this.label51.Text = "Area:";
            // 
            // DogfishListView
            // 
            this.DogfishListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DfClmnHeader1,
            this.DfClmnHeader2,
            this.DfClmnHeader3,
            this.DfClmnHeader4,
            this.DfClmnHeader5,
            this.DfClmnHeader6,
            this.DfClmnHeader7,
            this.DfClmnHeader8,
            this.DfClmnHeader9});
            this.DogfishListView.FullRowSelect = true;
            this.DogfishListView.GridLines = true;
            this.DogfishListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.DogfishListView.Location = new System.Drawing.Point(26, 68);
            this.DogfishListView.MultiSelect = false;
            this.DogfishListView.Name = "DogfishListView";
            this.DogfishListView.Scrollable = false;
            this.DogfishListView.Size = new System.Drawing.Size(490, 192);
            this.DogfishListView.TabIndex = 4;
            this.DogfishListView.UseCompatibleStateImageBehavior = false;
            this.DogfishListView.View = System.Windows.Forms.View.Details;
            this.DogfishListView.Click += new System.EventHandler(this.DogfishListView_Click);
            // 
            // DfClmnHeader1
            // 
            this.DfClmnHeader1.Text = "Ord.";
            this.DfClmnHeader1.Width = 28;
            // 
            // DfClmnHeader2
            // 
            this.DfClmnHeader2.Text = "Nome";
            this.DfClmnHeader2.Width = 100;
            // 
            // DfClmnHeader3
            // 
            this.DfClmnHeader3.Text = "Col.";
            this.DfClmnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DfClmnHeader3.Width = 30;
            // 
            // DfClmnHeader4
            // 
            this.DfClmnHeader4.Text = "Pos.";
            this.DfClmnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DfClmnHeader4.Width = 30;
            // 
            // DfClmnHeader5
            // 
            this.DfClmnHeader5.Text = "Qtà";
            this.DfClmnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DfClmnHeader5.Width = 35;
            // 
            // DfClmnHeader6
            // 
            this.DfClmnHeader6.Text = "X";
            this.DfClmnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DfClmnHeader7
            // 
            this.DfClmnHeader7.Text = "Z";
            this.DfClmnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DfClmnHeader8
            // 
            this.DfClmnHeader8.Text = "Y";
            this.DfClmnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DfClmnHeader9
            // 
            this.DfClmnHeader9.Text = "Direzione";
            this.DfClmnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DfClmnHeader9.Width = 70;
            // 
            // groupBox7
            // 
            this.groupBox7.AccessibleDescription = "questminion|title";
            this.groupBox7.Controls.Add(this.DfAddCmbBox2);
            this.groupBox7.Controls.Add(this.DogfRdButton3);
            this.groupBox7.Controls.Add(this.DfAddNumNumUpDown2);
            this.groupBox7.Controls.Add(this.DfAddNumNumUpDown1);
            this.groupBox7.Controls.Add(this.DfAddCmbBox1);
            this.groupBox7.Controls.Add(this.DogfRdButton2);
            this.groupBox7.Controls.Add(this.DogfRdButton1);
            this.groupBox7.Location = new System.Drawing.Point(13, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 148);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opzioni Mostri Piccoli";
            // 
            // DfAddCmbBox2
            // 
            this.DfAddCmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DfAddCmbBox2.Enabled = false;
            this.DfAddCmbBox2.FormattingEnabled = true;
            this.DfAddCmbBox2.Location = new System.Drawing.Point(46, 113);
            this.DfAddCmbBox2.Name = "DfAddCmbBox2";
            this.DfAddCmbBox2.Size = new System.Drawing.Size(138, 21);
            this.DfAddCmbBox2.TabIndex = 5;
            // 
            // DogfRdButton3
            // 
            this.DogfRdButton3.AccessibleDescription = "questminion|secondcond";
            this.DogfRdButton3.AutoSize = true;
            this.DogfRdButton3.Location = new System.Drawing.Point(12, 92);
            this.DogfRdButton3.Name = "DogfRdButton3";
            this.DogfRdButton3.Size = new System.Drawing.Size(86, 17);
            this.DogfRdButton3.TabIndex = 4;
            this.DogfRdButton3.TabStop = true;
            this.DogfRdButton3.Text = "Condizione 2";
            this.DogfRdButton3.UseVisualStyleBackColor = true;
            this.DogfRdButton3.CheckedChanged += new System.EventHandler(this.DogfRdButton_CheckedChanged);
            // 
            // DfAddNumNumUpDown2
            // 
            this.DfAddNumNumUpDown2.Enabled = false;
            this.DfAddNumNumUpDown2.Location = new System.Drawing.Point(190, 114);
            this.DfAddNumNumUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DfAddNumNumUpDown2.Name = "DfAddNumNumUpDown2";
            this.DfAddNumNumUpDown2.Size = new System.Drawing.Size(35, 20);
            this.DfAddNumNumUpDown2.TabIndex = 6;
            // 
            // DfAddNumNumUpDown1
            // 
            this.DfAddNumNumUpDown1.Enabled = false;
            this.DfAddNumNumUpDown1.Location = new System.Drawing.Point(189, 67);
            this.DfAddNumNumUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DfAddNumNumUpDown1.Name = "DfAddNumNumUpDown1";
            this.DfAddNumNumUpDown1.Size = new System.Drawing.Size(35, 20);
            this.DfAddNumNumUpDown1.TabIndex = 3;
            // 
            // DfAddCmbBox1
            // 
            this.DfAddCmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DfAddCmbBox1.Enabled = false;
            this.DfAddCmbBox1.FormattingEnabled = true;
            this.DfAddCmbBox1.Location = new System.Drawing.Point(46, 66);
            this.DfAddCmbBox1.Name = "DfAddCmbBox1";
            this.DfAddCmbBox1.Size = new System.Drawing.Size(138, 21);
            this.DfAddCmbBox1.TabIndex = 2;
            // 
            // DogfRdButton2
            // 
            this.DogfRdButton2.AccessibleDescription = "questminion|firstcond";
            this.DogfRdButton2.AutoSize = true;
            this.DogfRdButton2.Location = new System.Drawing.Point(12, 46);
            this.DogfRdButton2.Name = "DogfRdButton2";
            this.DogfRdButton2.Size = new System.Drawing.Size(86, 17);
            this.DogfRdButton2.TabIndex = 1;
            this.DogfRdButton2.TabStop = true;
            this.DogfRdButton2.Text = "Condizione 1";
            this.DogfRdButton2.UseVisualStyleBackColor = true;
            this.DogfRdButton2.CheckedChanged += new System.EventHandler(this.DogfRdButton_CheckedChanged);
            // 
            // DogfRdButton1
            // 
            this.DogfRdButton1.AccessibleDescription = "other|default";
            this.DogfRdButton1.AutoSize = true;
            this.DogfRdButton1.Checked = true;
            this.DogfRdButton1.Location = new System.Drawing.Point(12, 21);
            this.DogfRdButton1.Name = "DogfRdButton1";
            this.DogfRdButton1.Size = new System.Drawing.Size(59, 17);
            this.DogfRdButton1.TabIndex = 0;
            this.DogfRdButton1.TabStop = true;
            this.DogfRdButton1.Text = "Default";
            this.DogfRdButton1.UseVisualStyleBackColor = true;
            this.DogfRdButton1.CheckedChanged += new System.EventHandler(this.DogfRdButton_CheckedChanged);
            // 
            // FieldTabPage
            // 
            this.FieldTabPage.AccessibleDescription = "pages|supply";
            this.FieldTabPage.Controls.Add(this.pictureBox1);
            this.FieldTabPage.Controls.Add(this.BasePanel);
            this.FieldTabPage.Controls.Add(this.groupBox4);
            this.FieldTabPage.Controls.Add(this.LoadBaseSetButton);
            this.FieldTabPage.Controls.Add(this.SaveBaseSetButton);
            this.FieldTabPage.Controls.Add(this.groupBox17);
            this.FieldTabPage.Location = new System.Drawing.Point(4, 22);
            this.FieldTabPage.Name = "FieldTabPage";
            this.FieldTabPage.Size = new System.Drawing.Size(566, 460);
            this.FieldTabPage.TabIndex = 3;
            this.FieldTabPage.Text = "Rifornimenti";
            this.FieldTabPage.UseVisualStyleBackColor = true;
            this.FieldTabPage.Click += new System.EventHandler(this.FieldTabPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CQE.Properties.Resources.Items;
            this.pictureBox1.Location = new System.Drawing.Point(407, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.Transparent;
            this.BasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasePanel.Controls.Add(this.BasePlCloseBtn);
            this.BasePanel.Controls.Add(this.groupBox6);
            this.BasePanel.Location = new System.Drawing.Point(112, 65);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(285, 86);
            this.BasePanel.TabIndex = 3;
            this.BasePanel.Visible = false;
            this.BasePanel.Leave += new System.EventHandler(this.BasePanel_Leave);
            // 
            // BasePlCloseBtn
            // 
            this.BasePlCloseBtn.Location = new System.Drawing.Point(261, 4);
            this.BasePlCloseBtn.Name = "BasePlCloseBtn";
            this.BasePlCloseBtn.Size = new System.Drawing.Size(21, 23);
            this.BasePlCloseBtn.TabIndex = 6;
            this.BasePlCloseBtn.Text = "×";
            this.BasePlCloseBtn.UseVisualStyleBackColor = true;
            this.BasePlCloseBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.AccessibleDescription = "edit|title";
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.BaseNumNumUpD);
            this.groupBox6.Controls.Add(this.BaseCmbBox);
            this.groupBox6.Controls.Add(this.BaseSnNumUpD);
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 67);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modifica";
            // 
            // label45
            // 
            this.label45.AccessibleDescription = "edit|qty";
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(214, 19);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(24, 13);
            this.label45.TabIndex = 7;
            this.label45.Text = "Qtà";
            // 
            // label44
            // 
            this.label44.AccessibleDescription = "edit|item";
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(68, 19);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(76, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "Nome Oggetto";
            // 
            // label43
            // 
            this.label43.AccessibleDescription = "edit|num";
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(13, 19);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(27, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Ord.";
            // 
            // BaseNumNumUpD
            // 
            this.BaseNumNumUpD.Location = new System.Drawing.Point(212, 35);
            this.BaseNumNumUpD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.BaseNumNumUpD.Name = "BaseNumNumUpD";
            this.BaseNumNumUpD.Size = new System.Drawing.Size(37, 20);
            this.BaseNumNumUpD.TabIndex = 2;
            this.BaseNumNumUpD.ValueChanged += new System.EventHandler(this.BaseNumNumUpD_ValueChanged);
            // 
            // BaseCmbBox
            // 
            this.BaseCmbBox.FormattingEnabled = true;
            this.BaseCmbBox.Location = new System.Drawing.Point(59, 35);
            this.BaseCmbBox.Name = "BaseCmbBox";
            this.BaseCmbBox.Size = new System.Drawing.Size(147, 21);
            this.BaseCmbBox.TabIndex = 1;
            this.BaseCmbBox.SelectedIndexChanged += new System.EventHandler(this.BaseCmbBox_SelectedIndexChanged);
            this.BaseCmbBox.Leave += new System.EventHandler(this.BaseCmbBox_Leave);
            // 
            // BaseSnNumUpD
            // 
            this.BaseSnNumUpD.Location = new System.Drawing.Point(9, 35);
            this.BaseSnNumUpD.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.BaseSnNumUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BaseSnNumUpD.Name = "BaseSnNumUpD";
            this.BaseSnNumUpD.Size = new System.Drawing.Size(44, 20);
            this.BaseSnNumUpD.TabIndex = 0;
            this.BaseSnNumUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BaseSnNumUpD.ValueChanged += new System.EventHandler(this.BaseSnNumUpD_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = "questsupply|options";
            this.groupBox4.Controls.Add(this.RadioBtnRandomSysRation);
            this.groupBox4.Controls.Add(this.CmbBoxConditionsRation);
            this.groupBox4.Controls.Add(this.RadioBtnConditionsRation);
            this.groupBox4.Controls.Add(this.RadioBtnNothing);
            this.groupBox4.Controls.Add(this.ConditionsRationCmbBoxNumUpD);
            this.groupBox4.Controls.Add(this.label121);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.BaseRationNumUpD);
            this.groupBox4.Location = new System.Drawing.Point(412, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 251);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rifornimenti";
            // 
            // RadioBtnRandomSysRation
            // 
            this.RadioBtnRandomSysRation.AccessibleDescription = "other|random";
            this.RadioBtnRandomSysRation.AutoSize = true;
            this.RadioBtnRandomSysRation.ForeColor = System.Drawing.Color.Purple;
            this.RadioBtnRandomSysRation.Location = new System.Drawing.Point(14, 210);
            this.RadioBtnRandomSysRation.Name = "RadioBtnRandomSysRation";
            this.RadioBtnRandomSysRation.Size = new System.Drawing.Size(63, 17);
            this.RadioBtnRandomSysRation.TabIndex = 5;
            this.RadioBtnRandomSysRation.Text = "Casuale";
            this.RadioBtnRandomSysRation.UseVisualStyleBackColor = true;
            this.RadioBtnRandomSysRation.CheckedChanged += new System.EventHandler(this.RadioBtnRation_CheckedChanged);
            // 
            // CmbBoxConditionsRation
            // 
            this.CmbBoxConditionsRation.Enabled = false;
            this.CmbBoxConditionsRation.FormattingEnabled = true;
            this.CmbBoxConditionsRation.Location = new System.Drawing.Point(17, 145);
            this.CmbBoxConditionsRation.Name = "CmbBoxConditionsRation";
            this.CmbBoxConditionsRation.Size = new System.Drawing.Size(122, 21);
            this.CmbBoxConditionsRation.TabIndex = 3;
            // 
            // RadioBtnConditionsRation
            // 
            this.RadioBtnConditionsRation.AccessibleDescription = "questsupply|condition";
            this.RadioBtnConditionsRation.AutoSize = true;
            this.RadioBtnConditionsRation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RadioBtnConditionsRation.Location = new System.Drawing.Point(14, 126);
            this.RadioBtnConditionsRation.Name = "RadioBtnConditionsRation";
            this.RadioBtnConditionsRation.Size = new System.Drawing.Size(80, 17);
            this.RadioBtnConditionsRation.TabIndex = 2;
            this.RadioBtnConditionsRation.Text = "Condizione:";
            this.RadioBtnConditionsRation.UseVisualStyleBackColor = true;
            this.RadioBtnConditionsRation.CheckedChanged += new System.EventHandler(this.RadioBtnRation_CheckedChanged);
            // 
            // RadioBtnNothing
            // 
            this.RadioBtnNothing.AccessibleDescription = "questsupply|alwaysvisible";
            this.RadioBtnNothing.AutoSize = true;
            this.RadioBtnNothing.Checked = true;
            this.RadioBtnNothing.Location = new System.Drawing.Point(14, 93);
            this.RadioBtnNothing.Name = "RadioBtnNothing";
            this.RadioBtnNothing.Size = new System.Drawing.Size(81, 17);
            this.RadioBtnNothing.TabIndex = 1;
            this.RadioBtnNothing.TabStop = true;
            this.RadioBtnNothing.Text = "Sempre Vis.";
            this.RadioBtnNothing.UseVisualStyleBackColor = true;
            this.RadioBtnNothing.CheckedChanged += new System.EventHandler(this.RadioBtnRation_CheckedChanged);
            // 
            // ConditionsRationCmbBoxNumUpD
            // 
            this.ConditionsRationCmbBoxNumUpD.Enabled = false;
            this.ConditionsRationCmbBoxNumUpD.Location = new System.Drawing.Point(63, 173);
            this.ConditionsRationCmbBoxNumUpD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ConditionsRationCmbBoxNumUpD.Name = "ConditionsRationCmbBoxNumUpD";
            this.ConditionsRationCmbBoxNumUpD.Size = new System.Drawing.Size(43, 20);
            this.ConditionsRationCmbBoxNumUpD.TabIndex = 4;
            // 
            // label121
            // 
            this.label121.AccessibleDescription = "questsupply|qty";
            this.label121.AutoSize = true;
            this.label121.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label121.Location = new System.Drawing.Point(15, 175);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(32, 13);
            this.label121.TabIndex = 6;
            this.label121.Text = "Num:";
            // 
            // label23
            // 
            this.label23.AccessibleDescription = "questsupply|basevisible";
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Base Visibili:";
            // 
            // label26
            // 
            this.label26.AccessibleDescription = "questsupply|itemshort";
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(66, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Ogg.";
            // 
            // BaseRationNumUpD
            // 
            this.BaseRationNumUpD.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BaseRationNumUpD.Location = new System.Drawing.Point(17, 38);
            this.BaseRationNumUpD.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.BaseRationNumUpD.Name = "BaseRationNumUpD";
            this.BaseRationNumUpD.Size = new System.Drawing.Size(43, 20);
            this.BaseRationNumUpD.TabIndex = 0;
            this.BaseRationNumUpD.ValueChanged += new System.EventHandler(this.BaseContrNumUpDown_ValueChanged);
            // 
            // LoadBaseSetButton
            // 
            this.LoadBaseSetButton.AccessibleDescription = "other|loadlist";
            this.LoadBaseSetButton.Location = new System.Drawing.Point(239, 414);
            this.LoadBaseSetButton.Name = "LoadBaseSetButton";
            this.LoadBaseSetButton.Size = new System.Drawing.Size(110, 33);
            this.LoadBaseSetButton.TabIndex = 1;
            this.LoadBaseSetButton.Text = "Carica Lista";
            this.LoadBaseSetButton.UseVisualStyleBackColor = true;
            this.LoadBaseSetButton.Click += new System.EventHandler(this.LoadBaseSetButton_Click);
            // 
            // SaveBaseSetButton
            // 
            this.SaveBaseSetButton.AccessibleDescription = "other|savelist";
            this.SaveBaseSetButton.Location = new System.Drawing.Point(42, 414);
            this.SaveBaseSetButton.Name = "SaveBaseSetButton";
            this.SaveBaseSetButton.Size = new System.Drawing.Size(110, 33);
            this.SaveBaseSetButton.TabIndex = 0;
            this.SaveBaseSetButton.Text = "Salva Lista";
            this.SaveBaseSetButton.UseVisualStyleBackColor = true;
            this.SaveBaseSetButton.Click += new System.EventHandler(this.SaveBaseSetButton_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.AccessibleDescription = "questsupply|title";
            this.groupBox17.Controls.Add(this.label42);
            this.groupBox17.Controls.Add(this.label74);
            this.groupBox17.Controls.Add(this.label102);
            this.groupBox17.Controls.Add(this.label39);
            this.groupBox17.Controls.Add(this.label41);
            this.groupBox17.Controls.Add(this.label40);
            this.groupBox17.Controls.Add(this.BaseContrLstView2);
            this.groupBox17.Controls.Add(this.BaseContrLstView1);
            this.groupBox17.Location = new System.Drawing.Point(7, 12);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(397, 396);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Opzioni Oggetti";
            // 
            // label42
            // 
            this.label42.AccessibleDescription = "edit|num";
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(207, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 13);
            this.label42.TabIndex = 18;
            this.label42.Text = "Ord.";
            // 
            // label74
            // 
            this.label74.AccessibleDescription = "edit|qty";
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(346, 22);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(24, 13);
            this.label74.TabIndex = 20;
            this.label74.Text = "Qtà";
            // 
            // label102
            // 
            this.label102.AccessibleDescription = "edit|item";
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(239, 22);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(76, 13);
            this.label102.TabIndex = 19;
            this.label102.Text = "Nome Oggetto";
            // 
            // label39
            // 
            this.label39.AccessibleDescription = "edit|num";
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 22);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 15;
            this.label39.Text = "Ord.";
            // 
            // label41
            // 
            this.label41.AccessibleDescription = "edit|qty";
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(154, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(24, 13);
            this.label41.TabIndex = 17;
            this.label41.Text = "Qtà";
            // 
            // label40
            // 
            this.label40.AccessibleDescription = "edit|item";
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(49, 22);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(76, 13);
            this.label40.TabIndex = 16;
            this.label40.Text = "Nome Oggetto";
            // 
            // BaseContrLstView2
            // 
            this.BaseContrLstView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader17,
            this.columnHeader18});
            this.BaseContrLstView2.FullRowSelect = true;
            this.BaseContrLstView2.GridLines = true;
            this.BaseContrLstView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.BaseContrLstView2.Location = new System.Drawing.Point(204, 38);
            this.BaseContrLstView2.MultiSelect = false;
            this.BaseContrLstView2.Name = "BaseContrLstView2";
            this.BaseContrLstView2.Size = new System.Drawing.Size(180, 349);
            this.BaseContrLstView2.TabIndex = 1;
            this.BaseContrLstView2.UseCompatibleStateImageBehavior = false;
            this.BaseContrLstView2.View = System.Windows.Forms.View.Details;
            this.BaseContrLstView2.Click += new System.EventHandler(this.BaseContrLstView2_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ord.";
            this.columnHeader4.Width = 28;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Nome Oggetto";
            this.columnHeader17.Width = 110;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Qtà";
            this.columnHeader18.Width = 28;
            // 
            // BaseContrLstView1
            // 
            this.BaseContrLstView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.BaseContrLstView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BaseContrLstView1.FullRowSelect = true;
            this.BaseContrLstView1.GridLines = true;
            this.BaseContrLstView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.BaseContrLstView1.Location = new System.Drawing.Point(12, 38);
            this.BaseContrLstView1.MultiSelect = false;
            this.BaseContrLstView1.Name = "BaseContrLstView1";
            this.BaseContrLstView1.Size = new System.Drawing.Size(180, 349);
            this.BaseContrLstView1.TabIndex = 0;
            this.BaseContrLstView1.UseCompatibleStateImageBehavior = false;
            this.BaseContrLstView1.View = System.Windows.Forms.View.Details;
            this.BaseContrLstView1.Click += new System.EventHandler(this.BaseContrLstView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ord.";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome Oggetto";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qtà";
            this.columnHeader3.Width = 28;
            // 
            // ResourseTabPage
            // 
            this.ResourseTabPage.AccessibleDescription = "pages|gathering";
            this.ResourseTabPage.Controls.Add(this.ResourcesPanel);
            this.ResourseTabPage.Controls.Add(this.groupBox11);
            this.ResourseTabPage.Controls.Add(this.groupBox5);
            this.ResourseTabPage.Controls.Add(this.pictureBox2);
            this.ResourseTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResourseTabPage.Name = "ResourseTabPage";
            this.ResourseTabPage.Size = new System.Drawing.Size(566, 460);
            this.ResourseTabPage.TabIndex = 5;
            this.ResourseTabPage.Text = "Raccolta";
            this.ResourseTabPage.UseVisualStyleBackColor = true;
            this.ResourseTabPage.Click += new System.EventHandler(this.ResourseTabPage_Click);
            // 
            // ResourcesPanel
            // 
            this.ResourcesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResourcesPanel.Controls.Add(this.button2);
            this.ResourcesPanel.Controls.Add(this.groupBox12);
            this.ResourcesPanel.Location = new System.Drawing.Point(171, 177);
            this.ResourcesPanel.Name = "ResourcesPanel";
            this.ResourcesPanel.Size = new System.Drawing.Size(340, 81);
            this.ResourcesPanel.TabIndex = 5;
            this.ResourcesPanel.Visible = false;
            this.ResourcesPanel.Leave += new System.EventHandler(this.ResourcesPanel_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "×";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox12
            // 
            this.groupBox12.AccessibleDescription = "edit|title";
            this.groupBox12.Controls.Add(this.label83);
            this.groupBox12.Controls.Add(this.label84);
            this.groupBox12.Controls.Add(this.label85);
            this.groupBox12.Controls.Add(this.label86);
            this.groupBox12.Controls.Add(this.ResRareNumUpD);
            this.groupBox12.Controls.Add(this.ResNumNumUpD);
            this.groupBox12.Controls.Add(this.ResNameCmbBox);
            this.groupBox12.Controls.Add(this.ResSnNumUpD);
            this.groupBox12.Location = new System.Drawing.Point(5, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(323, 65);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Modifica";
            // 
            // label83
            // 
            this.label83.AccessibleDescription = "edit|num";
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(15, 18);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(27, 13);
            this.label83.TabIndex = 16;
            this.label83.Text = "Ord.";
            // 
            // label84
            // 
            this.label84.AccessibleDescription = "edit|percentage";
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(257, 18);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(43, 13);
            this.label84.TabIndex = 15;
            this.label84.Text = "Prob. %";
            // 
            // label85
            // 
            this.label85.AccessibleDescription = "edit|times";
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(197, 18);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 13);
            this.label85.TabIndex = 14;
            this.label85.Text = "Qtà/Volte";
            // 
            // label86
            // 
            this.label86.AccessibleDescription = "edit|item";
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(80, 18);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(35, 13);
            this.label86.TabIndex = 13;
            this.label86.Text = "Nome";
            // 
            // ResRareNumUpD
            // 
            this.ResRareNumUpD.Location = new System.Drawing.Point(255, 34);
            this.ResRareNumUpD.Name = "ResRareNumUpD";
            this.ResRareNumUpD.Size = new System.Drawing.Size(40, 20);
            this.ResRareNumUpD.TabIndex = 3;
            this.ResRareNumUpD.ValueChanged += new System.EventHandler(this.ResRareNumUpD_ValueChanged);
            // 
            // ResNumNumUpD
            // 
            this.ResNumNumUpD.Location = new System.Drawing.Point(202, 34);
            this.ResNumNumUpD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ResNumNumUpD.Name = "ResNumNumUpD";
            this.ResNumNumUpD.Size = new System.Drawing.Size(40, 20);
            this.ResNumNumUpD.TabIndex = 2;
            this.ResNumNumUpD.ValueChanged += new System.EventHandler(this.ResNumNumUpD_ValueChanged);
            // 
            // ResNameCmbBox
            // 
            this.ResNameCmbBox.FormattingEnabled = true;
            this.ResNameCmbBox.Location = new System.Drawing.Point(54, 34);
            this.ResNameCmbBox.Name = "ResNameCmbBox";
            this.ResNameCmbBox.Size = new System.Drawing.Size(142, 21);
            this.ResNameCmbBox.TabIndex = 1;
            this.ResNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ResNameCmbBox_SelectedIndexChanged);
            this.ResNameCmbBox.Leave += new System.EventHandler(this.ResNameCmbBox_Leave);
            // 
            // ResSnNumUpD
            // 
            this.ResSnNumUpD.Location = new System.Drawing.Point(8, 34);
            this.ResSnNumUpD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ResSnNumUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ResSnNumUpD.Name = "ResSnNumUpD";
            this.ResSnNumUpD.Size = new System.Drawing.Size(43, 20);
            this.ResSnNumUpD.TabIndex = 0;
            this.ResSnNumUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ResSnNumUpD.ValueChanged += new System.EventHandler(this.ResSnNumUpD_ValueChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.AccessibleDescription = "questgath|options";
            this.groupBox11.Controls.Add(this.label79);
            this.groupBox11.Controls.Add(this.RsrPointCmbBox);
            this.groupBox11.Controls.Add(this.RsMAXNumUpD);
            this.groupBox11.Controls.Add(this.RsMININumUpD);
            this.groupBox11.Controls.Add(this.label77);
            this.groupBox11.Controls.Add(this.label76);
            this.groupBox11.Controls.Add(this.RsrLandmassCmbBox);
            this.groupBox11.Controls.Add(this.label75);
            this.groupBox11.Location = new System.Drawing.Point(25, 10);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(475, 84);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Opzioni Raccolta";
            // 
            // label79
            // 
            this.label79.AccessibleDescription = "questgath|max";
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(291, 53);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(97, 13);
            this.label79.TabIndex = 16;
            this.label79.Text = "Raccolte Massime:";
            // 
            // RsrPointCmbBox
            // 
            this.RsrPointCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RsrPointCmbBox.FormattingEnabled = true;
            this.RsrPointCmbBox.Location = new System.Drawing.Point(112, 50);
            this.RsrPointCmbBox.Name = "RsrPointCmbBox";
            this.RsrPointCmbBox.Size = new System.Drawing.Size(143, 21);
            this.RsrPointCmbBox.TabIndex = 1;
            this.RsrPointCmbBox.SelectedIndexChanged += new System.EventHandler(this.RsrPointCmbBox_SelectedIndexChanged);
            // 
            // RsMAXNumUpD
            // 
            this.RsMAXNumUpD.Location = new System.Drawing.Point(402, 50);
            this.RsMAXNumUpD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RsMAXNumUpD.Name = "RsMAXNumUpD";
            this.RsMAXNumUpD.Size = new System.Drawing.Size(47, 20);
            this.RsMAXNumUpD.TabIndex = 3;
            this.RsMAXNumUpD.ValueChanged += new System.EventHandler(this.RsMAXNumUpD_ValueChanged);
            // 
            // RsMININumUpD
            // 
            this.RsMININumUpD.Location = new System.Drawing.Point(402, 24);
            this.RsMININumUpD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RsMININumUpD.Name = "RsMININumUpD";
            this.RsMININumUpD.Size = new System.Drawing.Size(47, 20);
            this.RsMININumUpD.TabIndex = 2;
            this.RsMININumUpD.ValueChanged += new System.EventHandler(this.RsMININumUpD_ValueChanged);
            // 
            // label77
            // 
            this.label77.AccessibleDescription = "questgath|min";
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(291, 27);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(89, 13);
            this.label77.TabIndex = 12;
            this.label77.Text = "Raccolte Minime:";
            // 
            // label76
            // 
            this.label76.AccessibleDescription = "questgath|point";
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(21, 53);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(84, 13);
            this.label76.TabIndex = 11;
            this.label76.Tag = "true";
            this.label76.Text = "Punto Raccolta:";
            // 
            // RsrLandmassCmbBox
            // 
            this.RsrLandmassCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RsrLandmassCmbBox.FormattingEnabled = true;
            this.RsrLandmassCmbBox.Location = new System.Drawing.Point(112, 24);
            this.RsrLandmassCmbBox.Name = "RsrLandmassCmbBox";
            this.RsrLandmassCmbBox.Size = new System.Drawing.Size(143, 21);
            this.RsrLandmassCmbBox.TabIndex = 0;
            this.RsrLandmassCmbBox.SelectedIndexChanged += new System.EventHandler(this.RsrLandmassCmbBox_SelectedIndexChanged);
            // 
            // label75
            // 
            this.label75.AccessibleDescription = "edit|area";
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(21, 27);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(32, 13);
            this.label75.TabIndex = 9;
            this.label75.Tag = "true";
            this.label75.Text = "Area:";
            // 
            // groupBox5
            // 
            this.groupBox5.AccessibleDescription = "questgath|title";
            this.groupBox5.Controls.Add(this.label82);
            this.groupBox5.Controls.Add(this.RsrRateLabel);
            this.groupBox5.Controls.Add(this.label80);
            this.groupBox5.Controls.Add(this.label78);
            this.groupBox5.Controls.Add(this.ResourcesListView);
            this.groupBox5.Location = new System.Drawing.Point(25, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 346);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Risorse";
            // 
            // label82
            // 
            this.label82.AccessibleDescription = "edit|num";
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(23, 24);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(27, 13);
            this.label82.TabIndex = 8;
            this.label82.Text = "Ord.";
            // 
            // RsrRateLabel
            // 
            this.RsrRateLabel.AccessibleDescription = "edit|percentage";
            this.RsrRateLabel.AutoSize = true;
            this.RsrRateLabel.Location = new System.Drawing.Point(257, 24);
            this.RsrRateLabel.Name = "RsrRateLabel";
            this.RsrRateLabel.Size = new System.Drawing.Size(55, 13);
            this.RsrRateLabel.TabIndex = 7;
            this.RsrRateLabel.Text = "Prob. (0%)";
            // 
            // label80
            // 
            this.label80.AccessibleDescription = "edit|times";
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(188, 24);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(53, 13);
            this.label80.TabIndex = 6;
            this.label80.Text = "Qtà/Volte";
            // 
            // label78
            // 
            this.label78.AccessibleDescription = "edit|item";
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(80, 24);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(35, 13);
            this.label78.TabIndex = 5;
            this.label78.Text = "Nome";
            // 
            // ResourcesListView
            // 
            this.ResourcesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ResourcesListView.FullRowSelect = true;
            this.ResourcesListView.GridLines = true;
            this.ResourcesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ResourcesListView.Location = new System.Drawing.Point(19, 40);
            this.ResourcesListView.MultiSelect = false;
            this.ResourcesListView.Name = "ResourcesListView";
            this.ResourcesListView.Size = new System.Drawing.Size(319, 300);
            this.ResourcesListView.TabIndex = 0;
            this.ResourcesListView.UseCompatibleStateImageBehavior = false;
            this.ResourcesListView.View = System.Windows.Forms.View.Details;
            this.ResourcesListView.Click += new System.EventHandler(this.ResourcesListView_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ord.";
            this.columnHeader5.Width = 35;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nome";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Qtà/Volte";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prob.";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CQE.Properties.Resources.Felyne;
            this.pictureBox2.Location = new System.Drawing.Point(396, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 321);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // MaterialTabPage
            // 
            this.MaterialTabPage.AccessibleDescription = "pages|reward";
            this.MaterialTabPage.Controls.Add(this.label153);
            this.MaterialTabPage.Controls.Add(this.MaterialPanel);
            this.MaterialTabPage.Controls.Add(this.LoadMaterialBtn);
            this.MaterialTabPage.Controls.Add(this.SaveMaterialBtn);
            this.MaterialTabPage.Controls.Add(this.groupBoxBonus);
            this.MaterialTabPage.Controls.Add(this.groupBox14);
            this.MaterialTabPage.Controls.Add(this.groupBox13);
            this.MaterialTabPage.Location = new System.Drawing.Point(4, 22);
            this.MaterialTabPage.Name = "MaterialTabPage";
            this.MaterialTabPage.Size = new System.Drawing.Size(566, 460);
            this.MaterialTabPage.TabIndex = 4;
            this.MaterialTabPage.Text = "Premio";
            this.MaterialTabPage.UseVisualStyleBackColor = true;
            this.MaterialTabPage.Click += new System.EventHandler(this.MaterialTabPage_Click);
            // 
            // label153
            // 
            this.label153.AccessibleDescription = "questreward|message";
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label153.Location = new System.Drawing.Point(14, 426);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(318, 13);
            this.label153.TabIndex = 8;
            this.label153.Text = "In order to insert rare materials, remember to do High Rank quests!";
            // 
            // MaterialPanel
            // 
            this.MaterialPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaterialPanel.Controls.Add(this.button3);
            this.MaterialPanel.Controls.Add(this.MaterialGroupBox);
            this.MaterialPanel.Location = new System.Drawing.Point(139, 195);
            this.MaterialPanel.Name = "MaterialPanel";
            this.MaterialPanel.Size = new System.Drawing.Size(343, 82);
            this.MaterialPanel.TabIndex = 6;
            this.MaterialPanel.Visible = false;
            this.MaterialPanel.Leave += new System.EventHandler(this.MaterialPanel_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MaterialGroupBox
            // 
            this.MaterialGroupBox.Controls.Add(this.label97);
            this.MaterialGroupBox.Controls.Add(this.label98);
            this.MaterialGroupBox.Controls.Add(this.label99);
            this.MaterialGroupBox.Controls.Add(this.label100);
            this.MaterialGroupBox.Controls.Add(this.MaterialnRareNmericUpDown);
            this.MaterialGroupBox.Controls.Add(this.MaterialNumNumUpD);
            this.MaterialGroupBox.Controls.Add(this.MaterialNameCmbBox);
            this.MaterialGroupBox.Controls.Add(this.MaterialSnNumUpD);
            this.MaterialGroupBox.Location = new System.Drawing.Point(5, 5);
            this.MaterialGroupBox.Name = "MaterialGroupBox";
            this.MaterialGroupBox.Size = new System.Drawing.Size(325, 65);
            this.MaterialGroupBox.TabIndex = 0;
            this.MaterialGroupBox.TabStop = false;
            this.MaterialGroupBox.Text = "(0)Modifica";
            // 
            // label97
            // 
            this.label97.AccessibleDescription = "edit|num";
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(13, 19);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(27, 13);
            this.label97.TabIndex = 16;
            this.label97.Text = "Ord.";
            // 
            // label98
            // 
            this.label98.AccessibleDescription = "edit|percentage";
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(269, 19);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(43, 13);
            this.label98.TabIndex = 15;
            this.label98.Text = "Prob. %";
            // 
            // label99
            // 
            this.label99.AccessibleDescription = "edit|qty";
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(225, 19);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(24, 13);
            this.label99.TabIndex = 14;
            this.label99.Text = "Qtà";
            // 
            // label100
            // 
            this.label100.AccessibleDescription = "edit|item";
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(83, 19);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(35, 13);
            this.label100.TabIndex = 13;
            this.label100.Text = "Nome";
            // 
            // MaterialnRareNmericUpDown
            // 
            this.MaterialnRareNmericUpDown.Location = new System.Drawing.Point(271, 35);
            this.MaterialnRareNmericUpDown.Name = "MaterialnRareNmericUpDown";
            this.MaterialnRareNmericUpDown.Size = new System.Drawing.Size(40, 20);
            this.MaterialnRareNmericUpDown.TabIndex = 3;
            this.MaterialnRareNmericUpDown.ValueChanged += new System.EventHandler(this.MaterialnRareNmericUpDown_ValueChanged);
            // 
            // MaterialNumNumUpD
            // 
            this.MaterialNumNumUpD.Location = new System.Drawing.Point(222, 35);
            this.MaterialNumNumUpD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaterialNumNumUpD.Name = "MaterialNumNumUpD";
            this.MaterialNumNumUpD.Size = new System.Drawing.Size(40, 20);
            this.MaterialNumNumUpD.TabIndex = 2;
            this.MaterialNumNumUpD.ValueChanged += new System.EventHandler(this.MaterialNumNumUpD_ValueChanged);
            // 
            // MaterialNameCmbBox
            // 
            this.MaterialNameCmbBox.FormattingEnabled = true;
            this.MaterialNameCmbBox.Location = new System.Drawing.Point(54, 35);
            this.MaterialNameCmbBox.Name = "MaterialNameCmbBox";
            this.MaterialNameCmbBox.Size = new System.Drawing.Size(162, 21);
            this.MaterialNameCmbBox.TabIndex = 1;
            this.MaterialNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.MaterialNameCmbBox_SelectedIndexChanged);
            this.MaterialNameCmbBox.Leave += new System.EventHandler(this.MaterialNameCmbBox_Leave);
            // 
            // MaterialSnNumUpD
            // 
            this.MaterialSnNumUpD.Location = new System.Drawing.Point(8, 34);
            this.MaterialSnNumUpD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaterialSnNumUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaterialSnNumUpD.Name = "MaterialSnNumUpD";
            this.MaterialSnNumUpD.Size = new System.Drawing.Size(43, 20);
            this.MaterialSnNumUpD.TabIndex = 0;
            this.MaterialSnNumUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaterialSnNumUpD.ValueChanged += new System.EventHandler(this.MaterialSnNumUpD_ValueChanged);
            // 
            // LoadMaterialBtn
            // 
            this.LoadMaterialBtn.AccessibleDescription = "other|loadlist";
            this.LoadMaterialBtn.Location = new System.Drawing.Point(431, 372);
            this.LoadMaterialBtn.Name = "LoadMaterialBtn";
            this.LoadMaterialBtn.Size = new System.Drawing.Size(117, 31);
            this.LoadMaterialBtn.TabIndex = 1;
            this.LoadMaterialBtn.Text = "Carica Lista";
            this.LoadMaterialBtn.UseVisualStyleBackColor = true;
            this.LoadMaterialBtn.Click += new System.EventHandler(this.LoadMaterialBtn_Click);
            // 
            // SaveMaterialBtn
            // 
            this.SaveMaterialBtn.AccessibleDescription = "other|savelist";
            this.SaveMaterialBtn.Location = new System.Drawing.Point(297, 372);
            this.SaveMaterialBtn.Name = "SaveMaterialBtn";
            this.SaveMaterialBtn.Size = new System.Drawing.Size(117, 31);
            this.SaveMaterialBtn.TabIndex = 0;
            this.SaveMaterialBtn.Text = "Salva Lista";
            this.SaveMaterialBtn.UseVisualStyleBackColor = true;
            this.SaveMaterialBtn.Click += new System.EventHandler(this.SaveMaterialBtn_Click);
            // 
            // groupBoxBonus
            // 
            this.groupBoxBonus.AccessibleDescription = "questreward|bonusreward";
            this.groupBoxBonus.Controls.Add(this.MtlExpRateLabe);
            this.groupBoxBonus.Controls.Add(this.label93);
            this.groupBoxBonus.Controls.Add(this.label94);
            this.groupBoxBonus.Controls.Add(this.label95);
            this.groupBoxBonus.Controls.Add(this.label96);
            this.groupBoxBonus.Controls.Add(this.ExpMaterialChooseCmbBox);
            this.groupBoxBonus.Controls.Add(this.MaterialListView2);
            this.groupBoxBonus.Location = new System.Drawing.Point(287, 88);
            this.groupBoxBonus.Name = "groupBoxBonus";
            this.groupBoxBonus.Size = new System.Drawing.Size(269, 275);
            this.groupBoxBonus.TabIndex = 2;
            this.groupBoxBonus.TabStop = false;
            this.groupBoxBonus.Text = "Premio Bonus";
            // 
            // MtlExpRateLabe
            // 
            this.MtlExpRateLabe.AccessibleDescription = "edit|percentage";
            this.MtlExpRateLabe.AutoSize = true;
            this.MtlExpRateLabe.Location = new System.Drawing.Point(196, 53);
            this.MtlExpRateLabe.Name = "MtlExpRateLabe";
            this.MtlExpRateLabe.Size = new System.Drawing.Size(55, 13);
            this.MtlExpRateLabe.TabIndex = 10;
            this.MtlExpRateLabe.Text = "Prob. (0%)";
            // 
            // label93
            // 
            this.label93.AccessibleDescription = "edit|qty";
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(166, 53);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(24, 13);
            this.label93.TabIndex = 9;
            this.label93.Text = "Qtà";
            // 
            // label94
            // 
            this.label94.AccessibleDescription = "edit|item";
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(68, 53);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(35, 13);
            this.label94.TabIndex = 8;
            this.label94.Text = "Nome";
            // 
            // label95
            // 
            this.label95.AccessibleDescription = "edit|num";
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(17, 53);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(27, 13);
            this.label95.TabIndex = 7;
            this.label95.Text = "Ord.";
            // 
            // label96
            // 
            this.label96.AccessibleDescription = "questreward|bonus";
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(19, 26);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(40, 13);
            this.label96.TabIndex = 6;
            this.label96.Tag = "true";
            this.label96.Text = "Bonus:";
            // 
            // ExpMaterialChooseCmbBox
            // 
            this.ExpMaterialChooseCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpMaterialChooseCmbBox.FormattingEnabled = true;
            this.ExpMaterialChooseCmbBox.Items.AddRange(new object[] {
            "Bonus 1",
            "Bonus 2",
            "Bonus 3",
            "Bonus 4",
            "Bonus 5"});
            this.ExpMaterialChooseCmbBox.Location = new System.Drawing.Point(65, 23);
            this.ExpMaterialChooseCmbBox.Name = "ExpMaterialChooseCmbBox";
            this.ExpMaterialChooseCmbBox.Size = new System.Drawing.Size(131, 21);
            this.ExpMaterialChooseCmbBox.TabIndex = 0;
            this.ExpMaterialChooseCmbBox.SelectedIndexChanged += new System.EventHandler(this.ExpMaterialChooseCmbBox_SelectedIndexChanged);
            // 
            // MaterialListView2
            // 
            this.MaterialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.MaterialListView2.FullRowSelect = true;
            this.MaterialListView2.GridLines = true;
            this.MaterialListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MaterialListView2.Location = new System.Drawing.Point(13, 69);
            this.MaterialListView2.MultiSelect = false;
            this.MaterialListView2.Name = "MaterialListView2";
            this.MaterialListView2.Size = new System.Drawing.Size(244, 192);
            this.MaterialListView2.TabIndex = 1;
            this.MaterialListView2.UseCompatibleStateImageBehavior = false;
            this.MaterialListView2.View = System.Windows.Forms.View.Details;
            this.MaterialListView2.Click += new System.EventHandler(this.MaterialListView2_Click);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ord.";
            this.columnHeader13.Width = 28;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Nome";
            this.columnHeader14.Width = 119;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Qtà";
            this.columnHeader15.Width = 32;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Prob.";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader16.Width = 55;
            // 
            // groupBox14
            // 
            this.groupBox14.AccessibleDescription = "questreward|title";
            this.groupBox14.Controls.Add(this.MtlRateLabel);
            this.groupBox14.Controls.Add(this.label91);
            this.groupBox14.Controls.Add(this.label90);
            this.groupBox14.Controls.Add(this.label89);
            this.groupBox14.Controls.Add(this.MaterialListView1);
            this.groupBox14.Location = new System.Drawing.Point(12, 17);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(269, 394);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Premio Base";
            // 
            // MtlRateLabel
            // 
            this.MtlRateLabel.AccessibleDescription = "edit|percentage";
            this.MtlRateLabel.AutoSize = true;
            this.MtlRateLabel.Location = new System.Drawing.Point(194, 23);
            this.MtlRateLabel.Name = "MtlRateLabel";
            this.MtlRateLabel.Size = new System.Drawing.Size(55, 13);
            this.MtlRateLabel.TabIndex = 8;
            this.MtlRateLabel.Text = "Prob. (0%)";
            // 
            // label91
            // 
            this.label91.AccessibleDescription = "edit|qty";
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(163, 23);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(24, 13);
            this.label91.TabIndex = 7;
            this.label91.Text = "Qtà";
            // 
            // label90
            // 
            this.label90.AccessibleDescription = "edit|item";
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(58, 23);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(35, 13);
            this.label90.TabIndex = 6;
            this.label90.Text = "Nome";
            // 
            // label89
            // 
            this.label89.AccessibleDescription = "edit|num";
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(13, 23);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(27, 13);
            this.label89.TabIndex = 5;
            this.label89.Text = "Ord.";
            // 
            // MaterialListView1
            // 
            this.MaterialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.MaterialListView1.FullRowSelect = true;
            this.MaterialListView1.GridLines = true;
            this.MaterialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MaterialListView1.Location = new System.Drawing.Point(11, 39);
            this.MaterialListView1.MultiSelect = false;
            this.MaterialListView1.Name = "MaterialListView1";
            this.MaterialListView1.Size = new System.Drawing.Size(250, 349);
            this.MaterialListView1.TabIndex = 0;
            this.MaterialListView1.UseCompatibleStateImageBehavior = false;
            this.MaterialListView1.View = System.Windows.Forms.View.Details;
            this.MaterialListView1.Click += new System.EventHandler(this.MaterialListView1_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ord.";
            this.columnHeader9.Width = 28;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nome";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Qtà";
            this.columnHeader11.Width = 30;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Prob.";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox13
            // 
            this.groupBox13.AccessibleDescription = "questreward|qtyvar";
            this.groupBox13.Controls.Add(this.MaterialNumNumUpD2);
            this.groupBox13.Controls.Add(this.MaterialNumNumUpD1);
            this.groupBox13.Controls.Add(this.label105);
            this.groupBox13.Controls.Add(this.label103);
            this.groupBox13.Location = new System.Drawing.Point(287, 17);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(269, 54);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Variabile Quantità";
            // 
            // MaterialNumNumUpD2
            // 
            this.MaterialNumNumUpD2.Location = new System.Drawing.Point(202, 23);
            this.MaterialNumNumUpD2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaterialNumNumUpD2.Name = "MaterialNumNumUpD2";
            this.MaterialNumNumUpD2.Size = new System.Drawing.Size(42, 20);
            this.MaterialNumNumUpD2.TabIndex = 1;
            // 
            // MaterialNumNumUpD1
            // 
            this.MaterialNumNumUpD1.Location = new System.Drawing.Point(129, 23);
            this.MaterialNumNumUpD1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaterialNumNumUpD1.Name = "MaterialNumNumUpD1";
            this.MaterialNumNumUpD1.Size = new System.Drawing.Size(42, 20);
            this.MaterialNumNumUpD1.TabIndex = 0;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(177, 26);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(10, 13);
            this.label105.TabIndex = 6;
            this.label105.Text = "～";
            // 
            // label103
            // 
            this.label103.AccessibleDescription = "questreward|rewqty";
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(18, 26);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(56, 13);
            this.label103.TabIndex = 2;
            this.label103.Text = "Qtà Premi:";
            // 
            // ChallengeTabPage
            // 
            this.ChallengeTabPage.AccessibleDescription = "pages|challenge";
            this.ChallengeTabPage.Controls.Add(this.challengeEquipmentsGroupBox);
            this.ChallengeTabPage.Controls.Add(this.groupBox19);
            this.ChallengeTabPage.Controls.Add(this.challengeOptionsGroupBox);
            this.ChallengeTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChallengeTabPage.Name = "ChallengeTabPage";
            this.ChallengeTabPage.Size = new System.Drawing.Size(566, 460);
            this.ChallengeTabPage.TabIndex = 7;
            this.ChallengeTabPage.Text = "Sfida";
            this.ChallengeTabPage.UseVisualStyleBackColor = true;
            // 
            // challengeEquipmentsGroupBox
            // 
            this.challengeEquipmentsGroupBox.AccessibleDescription = "questchallenge|setoptions";
            this.challengeEquipmentsGroupBox.Controls.Add(this.rdBtnArmor1);
            this.challengeEquipmentsGroupBox.Controls.Add(this.rdBtnArmor2);
            this.challengeEquipmentsGroupBox.Controls.Add(this.rdBtnArmor3);
            this.challengeEquipmentsGroupBox.Controls.Add(this.rdBtnArmor4);
            this.challengeEquipmentsGroupBox.Controls.Add(this.rdBtnArmor5);
            this.challengeEquipmentsGroupBox.Location = new System.Drawing.Point(198, 3);
            this.challengeEquipmentsGroupBox.Name = "challengeEquipmentsGroupBox";
            this.challengeEquipmentsGroupBox.Size = new System.Drawing.Size(330, 42);
            this.challengeEquipmentsGroupBox.TabIndex = 27;
            this.challengeEquipmentsGroupBox.TabStop = false;
            this.challengeEquipmentsGroupBox.Text = "Equipaggiamenti";
            // 
            // rdBtnArmor1
            // 
            this.rdBtnArmor1.AccessibleDescription = "questchallenge|set1";
            this.rdBtnArmor1.AutoSize = true;
            this.rdBtnArmor1.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBtnArmor1.Location = new System.Drawing.Point(20, 17);
            this.rdBtnArmor1.Name = "rdBtnArmor1";
            this.rdBtnArmor1.Size = new System.Drawing.Size(50, 17);
            this.rdBtnArmor1.TabIndex = 20;
            this.rdBtnArmor1.Text = "Set 1";
            this.rdBtnArmor1.UseVisualStyleBackColor = true;
            this.rdBtnArmor1.CheckedChanged += new System.EventHandler(this.rdBtnArmor_CheckedChanged);
            // 
            // rdBtnArmor2
            // 
            this.rdBtnArmor2.AccessibleDescription = "questchallenge|set2";
            this.rdBtnArmor2.AutoSize = true;
            this.rdBtnArmor2.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBtnArmor2.Location = new System.Drawing.Point(79, 17);
            this.rdBtnArmor2.Name = "rdBtnArmor2";
            this.rdBtnArmor2.Size = new System.Drawing.Size(50, 17);
            this.rdBtnArmor2.TabIndex = 21;
            this.rdBtnArmor2.Text = "Set 2";
            this.rdBtnArmor2.UseVisualStyleBackColor = true;
            this.rdBtnArmor2.CheckedChanged += new System.EventHandler(this.rdBtnArmor_CheckedChanged);
            // 
            // rdBtnArmor3
            // 
            this.rdBtnArmor3.AccessibleDescription = "questchallenge|set3";
            this.rdBtnArmor3.AutoSize = true;
            this.rdBtnArmor3.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBtnArmor3.Location = new System.Drawing.Point(138, 17);
            this.rdBtnArmor3.Name = "rdBtnArmor3";
            this.rdBtnArmor3.Size = new System.Drawing.Size(50, 17);
            this.rdBtnArmor3.TabIndex = 22;
            this.rdBtnArmor3.Text = "Set 3";
            this.rdBtnArmor3.UseVisualStyleBackColor = true;
            this.rdBtnArmor3.CheckedChanged += new System.EventHandler(this.rdBtnArmor_CheckedChanged);
            // 
            // rdBtnArmor4
            // 
            this.rdBtnArmor4.AccessibleDescription = "questchallenge|set4";
            this.rdBtnArmor4.AutoSize = true;
            this.rdBtnArmor4.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBtnArmor4.Location = new System.Drawing.Point(197, 17);
            this.rdBtnArmor4.Name = "rdBtnArmor4";
            this.rdBtnArmor4.Size = new System.Drawing.Size(50, 17);
            this.rdBtnArmor4.TabIndex = 23;
            this.rdBtnArmor4.Text = "Set 4";
            this.rdBtnArmor4.UseVisualStyleBackColor = true;
            this.rdBtnArmor4.CheckedChanged += new System.EventHandler(this.rdBtnArmor_CheckedChanged);
            // 
            // rdBtnArmor5
            // 
            this.rdBtnArmor5.AccessibleDescription = "questchallenge|set5";
            this.rdBtnArmor5.AutoSize = true;
            this.rdBtnArmor5.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdBtnArmor5.Location = new System.Drawing.Point(256, 17);
            this.rdBtnArmor5.Name = "rdBtnArmor5";
            this.rdBtnArmor5.Size = new System.Drawing.Size(50, 17);
            this.rdBtnArmor5.TabIndex = 24;
            this.rdBtnArmor5.Text = "Set 5";
            this.rdBtnArmor5.UseVisualStyleBackColor = true;
            this.rdBtnArmor5.CheckedChanged += new System.EventHandler(this.rdBtnArmor_CheckedChanged);
            // 
            // groupBox19
            // 
            this.groupBox19.AccessibleDescription = "questchallenge|details";
            this.groupBox19.Controls.Add(this.challengeDetailsTabControl);
            this.groupBox19.Location = new System.Drawing.Point(9, 46);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(546, 407);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Dettagli Sfida";
            // 
            // challengeDetailsTabControl
            // 
            this.challengeDetailsTabControl.Controls.Add(this.tabPage1);
            this.challengeDetailsTabControl.Controls.Add(this.tabPage4);
            this.challengeDetailsTabControl.Controls.Add(this.tabPage2);
            this.challengeDetailsTabControl.Location = new System.Drawing.Point(10, 19);
            this.challengeDetailsTabControl.Name = "challengeDetailsTabControl";
            this.challengeDetailsTabControl.SelectedIndex = 0;
            this.challengeDetailsTabControl.Size = new System.Drawing.Size(530, 382);
            this.challengeDetailsTabControl.TabIndex = 28;
            this.challengeDetailsTabControl.SelectedIndexChanged += new System.EventHandler(this.challengeDetailsTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = "questchallenge|equippage";
            this.tabPage1.Controls.Add(this.label130);
            this.tabPage1.Controls.Add(this.label129);
            this.tabPage1.Controls.Add(this.label128);
            this.tabPage1.Controls.Add(this.label127);
            this.tabPage1.Controls.Add(this.label125);
            this.tabPage1.Controls.Add(this.weaponPictureBox);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.cmbBoxFloatBeadInput);
            this.tabPage1.Controls.Add(this.cmbBoxWeaponType);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.cmbBoxWeaponName);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.cmbBoxHead);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.cmbBoxBody);
            this.tabPage1.Controls.Add(this.textBoxBead43);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.textBoxBead42);
            this.tabPage1.Controls.Add(this.cmbBoxArm);
            this.tabPage1.Controls.Add(this.textBoxBead41);
            this.tabPage1.Controls.Add(this.cmbBoxWaist);
            this.tabPage1.Controls.Add(this.textBoxBead33);
            this.tabPage1.Controls.Add(this.cmbBoxLeg);
            this.tabPage1.Controls.Add(this.textBoxBead32);
            this.tabPage1.Controls.Add(this.numUpDnHeadLV);
            this.tabPage1.Controls.Add(this.textBoxBead31);
            this.tabPage1.Controls.Add(this.numUpDnBodyLV);
            this.tabPage1.Controls.Add(this.textBoxBead23);
            this.tabPage1.Controls.Add(this.numUpDnArmLV);
            this.tabPage1.Controls.Add(this.textBoxBead22);
            this.tabPage1.Controls.Add(this.numUpDnWaistLV);
            this.tabPage1.Controls.Add(this.textBoxBead21);
            this.tabPage1.Controls.Add(this.numUpDnLegLV);
            this.tabPage1.Controls.Add(this.textBoxBead13);
            this.tabPage1.Controls.Add(this.challengeEditPanel);
            this.tabPage1.Controls.Add(this.textBoxBead12);
            this.tabPage1.Controls.Add(this.textBoxBead01);
            this.tabPage1.Controls.Add(this.textBoxBead11);
            this.tabPage1.Controls.Add(this.textBoxBead02);
            this.tabPage1.Controls.Add(this.textBoxBead53);
            this.tabPage1.Controls.Add(this.textBoxBead03);
            this.tabPage1.Controls.Add(this.textBoxBead52);
            this.tabPage1.Controls.Add(this.textBoxBead51);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label130
            // 
            this.label130.AccessibleDescription = "questchallenge|level";
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(233, 303);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(21, 13);
            this.label130.TabIndex = 98;
            this.label130.Text = "Lvl";
            // 
            // label129
            // 
            this.label129.AccessibleDescription = "questchallenge|level";
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(233, 250);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(21, 13);
            this.label129.TabIndex = 97;
            this.label129.Text = "Lvl";
            // 
            // label128
            // 
            this.label128.AccessibleDescription = "questchallenge|level";
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(233, 197);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(21, 13);
            this.label128.TabIndex = 96;
            this.label128.Text = "Lvl";
            // 
            // label127
            // 
            this.label127.AccessibleDescription = "questchallenge|level";
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(233, 144);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(21, 13);
            this.label127.TabIndex = 95;
            this.label127.Text = "Lvl";
            // 
            // label125
            // 
            this.label125.AccessibleDescription = "questchallenge|level";
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(233, 91);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(21, 13);
            this.label125.TabIndex = 94;
            this.label125.Text = "Lvl";
            // 
            // weaponPictureBox
            // 
            this.weaponPictureBox.Image = global::CQE.Challenge.LS;
            this.weaponPictureBox.Location = new System.Drawing.Point(6, 6);
            this.weaponPictureBox.Name = "weaponPictureBox";
            this.weaponPictureBox.Size = new System.Drawing.Size(21, 21);
            this.weaponPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weaponPictureBox.TabIndex = 93;
            this.weaponPictureBox.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CQE.Challenge.Leggings;
            this.pictureBox7.Location = new System.Drawing.Point(6, 300);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 92;
            this.pictureBox7.TabStop = false;
            // 
            // cmbBoxFloatBeadInput
            // 
            this.cmbBoxFloatBeadInput.FormattingEnabled = true;
            this.cmbBoxFloatBeadInput.Location = new System.Drawing.Point(33, 32);
            this.cmbBoxFloatBeadInput.MaxLength = 6;
            this.cmbBoxFloatBeadInput.Name = "cmbBoxFloatBeadInput";
            this.cmbBoxFloatBeadInput.Size = new System.Drawing.Size(156, 21);
            this.cmbBoxFloatBeadInput.TabIndex = 79;
            this.cmbBoxFloatBeadInput.Visible = false;
            this.cmbBoxFloatBeadInput.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFloatBeadInput_SelectedIndexChanged);
            this.cmbBoxFloatBeadInput.MouseLeave += new System.EventHandler(this.cmbBoxFloatBeadInput_MouseLeave);
            // 
            // cmbBoxWeaponType
            // 
            this.cmbBoxWeaponType.FormattingEnabled = true;
            this.cmbBoxWeaponType.Items.AddRange(new object[] {
            "Spadone",
            "Scudo e Spada",
            "Martello",
            "Lancia",
            "Balestra Pesante",
            "Balestra Leggera",
            "Spada Lunga",
            "Ascia",
            "Lancia-Fucile",
            "Arco",
            "Doppie Lame",
            "Corno"});
            this.cmbBoxWeaponType.Location = new System.Drawing.Point(33, 5);
            this.cmbBoxWeaponType.Name = "cmbBoxWeaponType";
            this.cmbBoxWeaponType.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxWeaponType.TabIndex = 5;
            this.cmbBoxWeaponType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxWeaponType_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CQE.Challenge.Waist;
            this.pictureBox6.Location = new System.Drawing.Point(6, 247);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 91;
            this.pictureBox6.TabStop = false;
            // 
            // cmbBoxWeaponName
            // 
            this.cmbBoxWeaponName.FormattingEnabled = true;
            this.cmbBoxWeaponName.Location = new System.Drawing.Point(159, 6);
            this.cmbBoxWeaponName.Name = "cmbBoxWeaponName";
            this.cmbBoxWeaponName.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxWeaponName.TabIndex = 8;
            this.cmbBoxWeaponName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxWeaponName_SelectedIndexChanged);
            this.cmbBoxWeaponName.Leave += new System.EventHandler(this.cmbBoxWeaponName_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CQE.Challenge.Gauntlets;
            this.pictureBox5.Location = new System.Drawing.Point(6, 194);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 90;
            this.pictureBox5.TabStop = false;
            // 
            // cmbBoxHead
            // 
            this.cmbBoxHead.FormattingEnabled = true;
            this.cmbBoxHead.Location = new System.Drawing.Point(33, 88);
            this.cmbBoxHead.Name = "cmbBoxHead";
            this.cmbBoxHead.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxHead.TabIndex = 9;
            this.cmbBoxHead.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArmor_SelectedIndexChanged);
            this.cmbBoxHead.Leave += new System.EventHandler(this.cmbBoxArmor_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CQE.Challenge.Plate;
            this.pictureBox4.Location = new System.Drawing.Point(6, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 89;
            this.pictureBox4.TabStop = false;
            // 
            // cmbBoxBody
            // 
            this.cmbBoxBody.FormattingEnabled = true;
            this.cmbBoxBody.Location = new System.Drawing.Point(33, 141);
            this.cmbBoxBody.Name = "cmbBoxBody";
            this.cmbBoxBody.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxBody.TabIndex = 11;
            this.cmbBoxBody.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArmor_SelectedIndexChanged);
            this.cmbBoxBody.Leave += new System.EventHandler(this.cmbBoxArmor_Leave);
            // 
            // textBoxBead43
            // 
            this.textBoxBead43.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead43.Location = new System.Drawing.Point(356, 327);
            this.textBoxBead43.Name = "textBoxBead43";
            this.textBoxBead43.ReadOnly = true;
            this.textBoxBead43.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead43.TabIndex = 77;
            this.textBoxBead43.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CQE.Challenge.Helm;
            this.pictureBox3.Location = new System.Drawing.Point(6, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxBead42
            // 
            this.textBoxBead42.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead42.Location = new System.Drawing.Point(195, 327);
            this.textBoxBead42.Name = "textBoxBead42";
            this.textBoxBead42.ReadOnly = true;
            this.textBoxBead42.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead42.TabIndex = 76;
            this.textBoxBead42.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // cmbBoxArm
            // 
            this.cmbBoxArm.FormattingEnabled = true;
            this.cmbBoxArm.Location = new System.Drawing.Point(33, 194);
            this.cmbBoxArm.Name = "cmbBoxArm";
            this.cmbBoxArm.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxArm.TabIndex = 13;
            this.cmbBoxArm.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArmor_SelectedIndexChanged);
            this.cmbBoxArm.Leave += new System.EventHandler(this.cmbBoxArmor_Leave);
            // 
            // textBoxBead41
            // 
            this.textBoxBead41.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead41.Location = new System.Drawing.Point(33, 327);
            this.textBoxBead41.Name = "textBoxBead41";
            this.textBoxBead41.ReadOnly = true;
            this.textBoxBead41.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead41.TabIndex = 75;
            this.textBoxBead41.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // cmbBoxWaist
            // 
            this.cmbBoxWaist.FormattingEnabled = true;
            this.cmbBoxWaist.Location = new System.Drawing.Point(33, 247);
            this.cmbBoxWaist.Name = "cmbBoxWaist";
            this.cmbBoxWaist.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxWaist.TabIndex = 15;
            this.cmbBoxWaist.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArmor_SelectedIndexChanged);
            this.cmbBoxWaist.Leave += new System.EventHandler(this.cmbBoxArmor_Leave);
            // 
            // textBoxBead33
            // 
            this.textBoxBead33.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead33.Location = new System.Drawing.Point(356, 274);
            this.textBoxBead33.Name = "textBoxBead33";
            this.textBoxBead33.ReadOnly = true;
            this.textBoxBead33.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead33.TabIndex = 74;
            this.textBoxBead33.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // cmbBoxLeg
            // 
            this.cmbBoxLeg.FormattingEnabled = true;
            this.cmbBoxLeg.Location = new System.Drawing.Point(33, 300);
            this.cmbBoxLeg.Name = "cmbBoxLeg";
            this.cmbBoxLeg.Size = new System.Drawing.Size(194, 21);
            this.cmbBoxLeg.TabIndex = 17;
            this.cmbBoxLeg.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArmor_SelectedIndexChanged);
            this.cmbBoxLeg.Leave += new System.EventHandler(this.cmbBoxArmor_Leave);
            // 
            // textBoxBead32
            // 
            this.textBoxBead32.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead32.Location = new System.Drawing.Point(195, 274);
            this.textBoxBead32.Name = "textBoxBead32";
            this.textBoxBead32.ReadOnly = true;
            this.textBoxBead32.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead32.TabIndex = 73;
            this.textBoxBead32.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // numUpDnHeadLV
            // 
            this.numUpDnHeadLV.Location = new System.Drawing.Point(260, 89);
            this.numUpDnHeadLV.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnHeadLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnHeadLV.Name = "numUpDnHeadLV";
            this.numUpDnHeadLV.Size = new System.Drawing.Size(36, 20);
            this.numUpDnHeadLV.TabIndex = 26;
            this.numUpDnHeadLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnHeadLV.ValueChanged += new System.EventHandler(this.numUpDnArmorLV_ValueChanged);
            // 
            // textBoxBead31
            // 
            this.textBoxBead31.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead31.Location = new System.Drawing.Point(33, 274);
            this.textBoxBead31.Name = "textBoxBead31";
            this.textBoxBead31.ReadOnly = true;
            this.textBoxBead31.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead31.TabIndex = 72;
            this.textBoxBead31.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // numUpDnBodyLV
            // 
            this.numUpDnBodyLV.Location = new System.Drawing.Point(260, 142);
            this.numUpDnBodyLV.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnBodyLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnBodyLV.Name = "numUpDnBodyLV";
            this.numUpDnBodyLV.Size = new System.Drawing.Size(36, 20);
            this.numUpDnBodyLV.TabIndex = 27;
            this.numUpDnBodyLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnBodyLV.ValueChanged += new System.EventHandler(this.numUpDnArmorLV_ValueChanged);
            // 
            // textBoxBead23
            // 
            this.textBoxBead23.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead23.Location = new System.Drawing.Point(356, 221);
            this.textBoxBead23.Name = "textBoxBead23";
            this.textBoxBead23.ReadOnly = true;
            this.textBoxBead23.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead23.TabIndex = 71;
            this.textBoxBead23.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // numUpDnArmLV
            // 
            this.numUpDnArmLV.Location = new System.Drawing.Point(260, 195);
            this.numUpDnArmLV.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnArmLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnArmLV.Name = "numUpDnArmLV";
            this.numUpDnArmLV.Size = new System.Drawing.Size(36, 20);
            this.numUpDnArmLV.TabIndex = 28;
            this.numUpDnArmLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnArmLV.ValueChanged += new System.EventHandler(this.numUpDnArmorLV_ValueChanged);
            // 
            // textBoxBead22
            // 
            this.textBoxBead22.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead22.Location = new System.Drawing.Point(195, 221);
            this.textBoxBead22.Name = "textBoxBead22";
            this.textBoxBead22.ReadOnly = true;
            this.textBoxBead22.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead22.TabIndex = 70;
            this.textBoxBead22.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // numUpDnWaistLV
            // 
            this.numUpDnWaistLV.Location = new System.Drawing.Point(260, 248);
            this.numUpDnWaistLV.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnWaistLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnWaistLV.Name = "numUpDnWaistLV";
            this.numUpDnWaistLV.Size = new System.Drawing.Size(36, 20);
            this.numUpDnWaistLV.TabIndex = 29;
            this.numUpDnWaistLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnWaistLV.ValueChanged += new System.EventHandler(this.numUpDnArmorLV_ValueChanged);
            // 
            // textBoxBead21
            // 
            this.textBoxBead21.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead21.Location = new System.Drawing.Point(33, 221);
            this.textBoxBead21.Name = "textBoxBead21";
            this.textBoxBead21.ReadOnly = true;
            this.textBoxBead21.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead21.TabIndex = 69;
            this.textBoxBead21.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // numUpDnLegLV
            // 
            this.numUpDnLegLV.Location = new System.Drawing.Point(260, 301);
            this.numUpDnLegLV.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnLegLV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnLegLV.Name = "numUpDnLegLV";
            this.numUpDnLegLV.Size = new System.Drawing.Size(36, 20);
            this.numUpDnLegLV.TabIndex = 30;
            this.numUpDnLegLV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnLegLV.ValueChanged += new System.EventHandler(this.numUpDnArmorLV_ValueChanged);
            // 
            // textBoxBead13
            // 
            this.textBoxBead13.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead13.Location = new System.Drawing.Point(356, 168);
            this.textBoxBead13.Name = "textBoxBead13";
            this.textBoxBead13.ReadOnly = true;
            this.textBoxBead13.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead13.TabIndex = 68;
            this.textBoxBead13.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // challengeEditPanel
            // 
            this.challengeEditPanel.Controls.Add(this.rdBtnWeaponStrength2);
            this.challengeEditPanel.Controls.Add(this.rdBtnWeaponStrength3);
            this.challengeEditPanel.Controls.Add(this.rdBtnWeaponStrength1);
            this.challengeEditPanel.Controls.Add(this.chkBoxWeaponStrength);
            this.challengeEditPanel.Location = new System.Drawing.Point(33, 59);
            this.challengeEditPanel.Name = "challengeEditPanel";
            this.challengeEditPanel.Size = new System.Drawing.Size(465, 24);
            this.challengeEditPanel.TabIndex = 19;
            // 
            // rdBtnWeaponStrength2
            // 
            this.rdBtnWeaponStrength2.AccessibleDescription = "questchallenge|update2";
            this.rdBtnWeaponStrength2.AutoSize = true;
            this.rdBtnWeaponStrength2.Location = new System.Drawing.Point(339, 3);
            this.rdBtnWeaponStrength2.Name = "rdBtnWeaponStrength2";
            this.rdBtnWeaponStrength2.Size = new System.Drawing.Size(100, 17);
            this.rdBtnWeaponStrength2.TabIndex = 1;
            this.rdBtnWeaponStrength2.TabStop = true;
            this.rdBtnWeaponStrength2.Text = "Potenza/Canna";
            this.rdBtnWeaponStrength2.UseVisualStyleBackColor = true;
            this.rdBtnWeaponStrength2.CheckedChanged += new System.EventHandler(this.rdBtnWeaponStrength_CheckedChanged);
            // 
            // rdBtnWeaponStrength3
            // 
            this.rdBtnWeaponStrength3.AccessibleDescription = "questchallenge|update1";
            this.rdBtnWeaponStrength3.AutoSize = true;
            this.rdBtnWeaponStrength3.Location = new System.Drawing.Point(190, 3);
            this.rdBtnWeaponStrength3.Name = "rdBtnWeaponStrength3";
            this.rdBtnWeaponStrength3.Size = new System.Drawing.Size(115, 17);
            this.rdBtnWeaponStrength3.TabIndex = 2;
            this.rdBtnWeaponStrength3.TabStop = true;
            this.rdBtnWeaponStrength3.Text = "Silenziatore/Scudo";
            this.rdBtnWeaponStrength3.UseVisualStyleBackColor = true;
            this.rdBtnWeaponStrength3.CheckedChanged += new System.EventHandler(this.rdBtnWeaponStrength_CheckedChanged);
            // 
            // rdBtnWeaponStrength1
            // 
            this.rdBtnWeaponStrength1.AccessibleDescription = "questchallenge|noupdate";
            this.rdBtnWeaponStrength1.AutoSize = true;
            this.rdBtnWeaponStrength1.Location = new System.Drawing.Point(97, 3);
            this.rdBtnWeaponStrength1.Name = "rdBtnWeaponStrength1";
            this.rdBtnWeaponStrength1.Size = new System.Drawing.Size(56, 17);
            this.rdBtnWeaponStrength1.TabIndex = 0;
            this.rdBtnWeaponStrength1.TabStop = true;
            this.rdBtnWeaponStrength1.Text = "Niente";
            this.rdBtnWeaponStrength1.UseVisualStyleBackColor = true;
            this.rdBtnWeaponStrength1.CheckedChanged += new System.EventHandler(this.rdBtnWeaponStrength_CheckedChanged);
            // 
            // chkBoxWeaponStrength
            // 
            this.chkBoxWeaponStrength.AccessibleDescription = "questchallenge|edits";
            this.chkBoxWeaponStrength.AutoSize = true;
            this.chkBoxWeaponStrength.Location = new System.Drawing.Point(3, 5);
            this.chkBoxWeaponStrength.Name = "chkBoxWeaponStrength";
            this.chkBoxWeaponStrength.Size = new System.Drawing.Size(72, 17);
            this.chkBoxWeaponStrength.TabIndex = 31;
            this.chkBoxWeaponStrength.Text = "Modifiche";
            this.chkBoxWeaponStrength.UseVisualStyleBackColor = true;
            this.chkBoxWeaponStrength.CheckedChanged += new System.EventHandler(this.chkBoxWeaponStrength_CheckedChanged);
            // 
            // textBoxBead12
            // 
            this.textBoxBead12.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead12.Location = new System.Drawing.Point(195, 168);
            this.textBoxBead12.Name = "textBoxBead12";
            this.textBoxBead12.ReadOnly = true;
            this.textBoxBead12.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead12.TabIndex = 67;
            this.textBoxBead12.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead01
            // 
            this.textBoxBead01.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead01.Location = new System.Drawing.Point(33, 33);
            this.textBoxBead01.Name = "textBoxBead01";
            this.textBoxBead01.ReadOnly = true;
            this.textBoxBead01.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead01.TabIndex = 60;
            this.textBoxBead01.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead11
            // 
            this.textBoxBead11.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead11.Location = new System.Drawing.Point(33, 168);
            this.textBoxBead11.Name = "textBoxBead11";
            this.textBoxBead11.ReadOnly = true;
            this.textBoxBead11.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead11.TabIndex = 66;
            this.textBoxBead11.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead02
            // 
            this.textBoxBead02.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead02.Location = new System.Drawing.Point(195, 33);
            this.textBoxBead02.Name = "textBoxBead02";
            this.textBoxBead02.ReadOnly = true;
            this.textBoxBead02.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead02.TabIndex = 61;
            this.textBoxBead02.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead53
            // 
            this.textBoxBead53.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead53.Location = new System.Drawing.Point(356, 115);
            this.textBoxBead53.Name = "textBoxBead53";
            this.textBoxBead53.ReadOnly = true;
            this.textBoxBead53.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead53.TabIndex = 65;
            this.textBoxBead53.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead03
            // 
            this.textBoxBead03.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead03.Location = new System.Drawing.Point(356, 33);
            this.textBoxBead03.Name = "textBoxBead03";
            this.textBoxBead03.ReadOnly = true;
            this.textBoxBead03.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead03.TabIndex = 62;
            this.textBoxBead03.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead52
            // 
            this.textBoxBead52.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead52.Location = new System.Drawing.Point(195, 115);
            this.textBoxBead52.Name = "textBoxBead52";
            this.textBoxBead52.ReadOnly = true;
            this.textBoxBead52.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead52.TabIndex = 64;
            this.textBoxBead52.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // textBoxBead51
            // 
            this.textBoxBead51.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead51.Location = new System.Drawing.Point(33, 115);
            this.textBoxBead51.Name = "textBoxBead51";
            this.textBoxBead51.ReadOnly = true;
            this.textBoxBead51.Size = new System.Drawing.Size(142, 20);
            this.textBoxBead51.TabIndex = 63;
            this.textBoxBead51.MouseHover += new System.EventHandler(this.textBoxBead_MouseHover);
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleDescription = "questchallenge|detailspage";
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.cmbBoxFloatBeadInputAmulet);
            this.tabPage4.Controls.Add(this.cmbBoxSymbolType);
            this.tabPage4.Controls.Add(this.cmbBoxSymbolList02);
            this.tabPage4.Controls.Add(this.textBoxSkillList);
            this.tabPage4.Controls.Add(this.textBoxBead63);
            this.tabPage4.Controls.Add(this.textBoxBead62);
            this.tabPage4.Controls.Add(this.numUpDnSkillPiont01);
            this.tabPage4.Controls.Add(this.textBoxBead61);
            this.tabPage4.Controls.Add(this.numUpDnSkillPiont02);
            this.tabPage4.Controls.Add(this.cmbBoxSymbolList01);
            this.tabPage4.Controls.Add(this.cmbBoxSymbolHole);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(522, 356);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dettagli";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "questchallenge|detailspage";
            this.groupBox1.Controls.Add(this.label122);
            this.groupBox1.Controls.Add(this.label126);
            this.groupBox1.Controls.Add(this.label137);
            this.groupBox1.Controls.Add(this.label143);
            this.groupBox1.Controls.Add(this.numUpDnEstimatePtB);
            this.groupBox1.Controls.Add(this.label123);
            this.groupBox1.Controls.Add(this.numUpDnEstimateSS2);
            this.groupBox1.Controls.Add(this.numUpDnEstimateS1);
            this.groupBox1.Controls.Add(this.label144);
            this.groupBox1.Controls.Add(this.numUpDnEstimateSS1);
            this.groupBox1.Controls.Add(this.label141);
            this.groupBox1.Controls.Add(this.numUpDnEstimateA2);
            this.groupBox1.Controls.Add(this.label138);
            this.groupBox1.Controls.Add(this.label136);
            this.groupBox1.Controls.Add(this.label142);
            this.groupBox1.Controls.Add(this.numUpDnEstimatePtA);
            this.groupBox1.Controls.Add(this.numUpDnEstimateS2);
            this.groupBox1.Controls.Add(this.label124);
            this.groupBox1.Controls.Add(this.label140);
            this.groupBox1.Controls.Add(this.label132);
            this.groupBox1.Controls.Add(this.label139);
            this.groupBox1.Controls.Add(this.numUpDnEstimatePtS);
            this.groupBox1.Controls.Add(this.numUpDnEstimateA1);
            this.groupBox1.Location = new System.Drawing.Point(18, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 121);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli";
            // 
            // label122
            // 
            this.label122.AccessibleDescription = "questchallenge|maxtime";
            this.label122.AutoSize = true;
            this.label122.ForeColor = System.Drawing.Color.Purple;
            this.label122.Location = new System.Drawing.Point(6, 16);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(87, 13);
            this.label122.TabIndex = 3;
            this.label122.Text = "Tempo Massimo:";
            // 
            // label126
            // 
            this.label126.AccessibleDescription = "game|seconds";
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(141, 62);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(29, 13);
            this.label126.TabIndex = 35;
            this.label126.Text = "Sec.";
            // 
            // label137
            // 
            this.label137.AccessibleDescription = "game|seconds";
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(141, 88);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(29, 13);
            this.label137.TabIndex = 40;
            this.label137.Text = "Sec.";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(186, 62);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(14, 13);
            this.label143.TabIndex = 46;
            this.label143.Text = "A";
            // 
            // numUpDnEstimatePtB
            // 
            this.numUpDnEstimatePtB.Location = new System.Drawing.Point(210, 84);
            this.numUpDnEstimatePtB.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDnEstimatePtB.Name = "numUpDnEstimatePtB";
            this.numUpDnEstimatePtB.Size = new System.Drawing.Size(50, 20);
            this.numUpDnEstimatePtB.TabIndex = 41;
            // 
            // label123
            // 
            this.label123.AccessibleDescription = "game|minutes";
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(75, 35);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(27, 13);
            this.label123.TabIndex = 5;
            this.label123.Text = "Min.";
            // 
            // numUpDnEstimateSS2
            // 
            this.numUpDnEstimateSS2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnEstimateSS2.Location = new System.Drawing.Point(104, 31);
            this.numUpDnEstimateSS2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDnEstimateSS2.Name = "numUpDnEstimateSS2";
            this.numUpDnEstimateSS2.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateSS2.TabIndex = 6;
            // 
            // numUpDnEstimateS1
            // 
            this.numUpDnEstimateS1.Location = new System.Drawing.Point(39, 58);
            this.numUpDnEstimateS1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnEstimateS1.Name = "numUpDnEstimateS1";
            this.numUpDnEstimateS1.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateS1.TabIndex = 32;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(186, 35);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(14, 13);
            this.label144.TabIndex = 45;
            this.label144.Text = "S";
            // 
            // numUpDnEstimateSS1
            // 
            this.numUpDnEstimateSS1.Location = new System.Drawing.Point(39, 31);
            this.numUpDnEstimateSS1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnEstimateSS1.Name = "numUpDnEstimateSS1";
            this.numUpDnEstimateSS1.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateSS1.TabIndex = 4;
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Enabled = false;
            this.label141.Location = new System.Drawing.Point(12, 35);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(21, 13);
            this.label141.TabIndex = 42;
            this.label141.Text = "SS";
            // 
            // numUpDnEstimateA2
            // 
            this.numUpDnEstimateA2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnEstimateA2.Location = new System.Drawing.Point(104, 84);
            this.numUpDnEstimateA2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDnEstimateA2.Name = "numUpDnEstimateA2";
            this.numUpDnEstimateA2.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateA2.TabIndex = 39;
            // 
            // label138
            // 
            this.label138.AccessibleDescription = "game|minutes";
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(75, 88);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(27, 13);
            this.label138.TabIndex = 38;
            this.label138.Text = "Min.";
            // 
            // label136
            // 
            this.label136.AccessibleDescription = "game|minutes";
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(75, 62);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(27, 13);
            this.label136.TabIndex = 33;
            this.label136.Text = "Min.";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(186, 88);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(14, 13);
            this.label142.TabIndex = 47;
            this.label142.Text = "B";
            // 
            // numUpDnEstimatePtA
            // 
            this.numUpDnEstimatePtA.Location = new System.Drawing.Point(210, 58);
            this.numUpDnEstimatePtA.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numUpDnEstimatePtA.Name = "numUpDnEstimatePtA";
            this.numUpDnEstimatePtA.Size = new System.Drawing.Size(50, 20);
            this.numUpDnEstimatePtA.TabIndex = 36;
            // 
            // numUpDnEstimateS2
            // 
            this.numUpDnEstimateS2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnEstimateS2.Location = new System.Drawing.Point(104, 58);
            this.numUpDnEstimateS2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpDnEstimateS2.Name = "numUpDnEstimateS2";
            this.numUpDnEstimateS2.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateS2.TabIndex = 34;
            // 
            // label124
            // 
            this.label124.AccessibleDescription = "game|seconds";
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(141, 35);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(29, 13);
            this.label124.TabIndex = 7;
            this.label124.Text = "Sec.";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(12, 62);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(14, 13);
            this.label140.TabIndex = 43;
            this.label140.Text = "S";
            // 
            // label132
            // 
            this.label132.AccessibleDescription = "questchallenge|points";
            this.label132.AutoSize = true;
            this.label132.ForeColor = System.Drawing.Color.Purple;
            this.label132.Location = new System.Drawing.Point(189, 16);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(34, 13);
            this.label132.TabIndex = 11;
            this.label132.Text = "Punti:";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(12, 88);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(14, 13);
            this.label139.TabIndex = 44;
            this.label139.Text = "A";
            // 
            // numUpDnEstimatePtS
            // 
            this.numUpDnEstimatePtS.Location = new System.Drawing.Point(210, 31);
            this.numUpDnEstimatePtS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnEstimatePtS.Name = "numUpDnEstimatePtS";
            this.numUpDnEstimatePtS.Size = new System.Drawing.Size(50, 20);
            this.numUpDnEstimatePtS.TabIndex = 10;
            // 
            // numUpDnEstimateA1
            // 
            this.numUpDnEstimateA1.Location = new System.Drawing.Point(39, 84);
            this.numUpDnEstimateA1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDnEstimateA1.Name = "numUpDnEstimateA1";
            this.numUpDnEstimateA1.Size = new System.Drawing.Size(36, 20);
            this.numUpDnEstimateA1.TabIndex = 37;
            // 
            // cmbBoxFloatBeadInputAmulet
            // 
            this.cmbBoxFloatBeadInputAmulet.FormattingEnabled = true;
            this.cmbBoxFloatBeadInputAmulet.Location = new System.Drawing.Point(18, 113);
            this.cmbBoxFloatBeadInputAmulet.MaxLength = 6;
            this.cmbBoxFloatBeadInputAmulet.Name = "cmbBoxFloatBeadInputAmulet";
            this.cmbBoxFloatBeadInputAmulet.Size = new System.Drawing.Size(205, 21);
            this.cmbBoxFloatBeadInputAmulet.TabIndex = 86;
            this.cmbBoxFloatBeadInputAmulet.Visible = false;
            this.cmbBoxFloatBeadInputAmulet.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFloatBeadInputAmulet_SelectedIndexChanged);
            this.cmbBoxFloatBeadInputAmulet.MouseLeave += new System.EventHandler(this.cmbBoxFloatBeadInputAmulet_MouseLeave);
            // 
            // cmbBoxSymbolType
            // 
            this.cmbBoxSymbolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSymbolType.FormattingEnabled = true;
            this.cmbBoxSymbolType.Items.AddRange(new object[] {
            "Nessuno",
            "Tal.Pedone",
            "Tal.Alfiere",
            "Tal.Cavallo",
            "Tal.Torre",
            "Tal.Regina",
            "Tal.Re",
            "Tal.Drago"});
            this.cmbBoxSymbolType.Location = new System.Drawing.Point(17, 24);
            this.cmbBoxSymbolType.Name = "cmbBoxSymbolType";
            this.cmbBoxSymbolType.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxSymbolType.TabIndex = 21;
            this.cmbBoxSymbolType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSymbolType_SelectedIndexChanged);
            // 
            // cmbBoxSymbolList02
            // 
            this.cmbBoxSymbolList02.FormattingEnabled = true;
            this.cmbBoxSymbolList02.Location = new System.Drawing.Point(17, 78);
            this.cmbBoxSymbolList02.Name = "cmbBoxSymbolList02";
            this.cmbBoxSymbolList02.Size = new System.Drawing.Size(205, 21);
            this.cmbBoxSymbolList02.TabIndex = 24;
            this.cmbBoxSymbolList02.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSymbolList_SelectedIndexChanged);
            this.cmbBoxSymbolList02.Leave += new System.EventHandler(this.cmbBoxSymbolList01_Leave);
            // 
            // textBoxSkillList
            // 
            this.textBoxSkillList.Location = new System.Drawing.Point(301, 24);
            this.textBoxSkillList.Multiline = true;
            this.textBoxSkillList.Name = "textBoxSkillList";
            this.textBoxSkillList.Size = new System.Drawing.Size(204, 315);
            this.textBoxSkillList.TabIndex = 80;
            // 
            // textBoxBead63
            // 
            this.textBoxBead63.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead63.Location = new System.Drawing.Point(16, 171);
            this.textBoxBead63.Name = "textBoxBead63";
            this.textBoxBead63.ReadOnly = true;
            this.textBoxBead63.Size = new System.Drawing.Size(177, 20);
            this.textBoxBead63.TabIndex = 84;
            this.textBoxBead63.MouseHover += new System.EventHandler(this.textBoxBead_Amulet_MouseHover);
            // 
            // textBoxBead62
            // 
            this.textBoxBead62.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead62.Location = new System.Drawing.Point(16, 140);
            this.textBoxBead62.Name = "textBoxBead62";
            this.textBoxBead62.ReadOnly = true;
            this.textBoxBead62.Size = new System.Drawing.Size(177, 20);
            this.textBoxBead62.TabIndex = 83;
            this.textBoxBead62.MouseHover += new System.EventHandler(this.textBoxBead_Amulet_MouseHover);
            // 
            // numUpDnSkillPiont01
            // 
            this.numUpDnSkillPiont01.Location = new System.Drawing.Point(229, 52);
            this.numUpDnSkillPiont01.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDnSkillPiont01.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numUpDnSkillPiont01.Name = "numUpDnSkillPiont01";
            this.numUpDnSkillPiont01.Size = new System.Drawing.Size(62, 20);
            this.numUpDnSkillPiont01.TabIndex = 23;
            this.numUpDnSkillPiont01.ValueChanged += new System.EventHandler(this.numUpDnSkillPiont_ValueChanged);
            // 
            // textBoxBead61
            // 
            this.textBoxBead61.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxBead61.Location = new System.Drawing.Point(16, 114);
            this.textBoxBead61.Name = "textBoxBead61";
            this.textBoxBead61.ReadOnly = true;
            this.textBoxBead61.Size = new System.Drawing.Size(177, 20);
            this.textBoxBead61.TabIndex = 82;
            this.textBoxBead61.MouseHover += new System.EventHandler(this.textBoxBead_Amulet_MouseHover);
            // 
            // numUpDnSkillPiont02
            // 
            this.numUpDnSkillPiont02.Location = new System.Drawing.Point(229, 79);
            this.numUpDnSkillPiont02.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDnSkillPiont02.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numUpDnSkillPiont02.Name = "numUpDnSkillPiont02";
            this.numUpDnSkillPiont02.Size = new System.Drawing.Size(62, 20);
            this.numUpDnSkillPiont02.TabIndex = 25;
            this.numUpDnSkillPiont02.ValueChanged += new System.EventHandler(this.numUpDnSkillPiont_ValueChanged);
            // 
            // cmbBoxSymbolList01
            // 
            this.cmbBoxSymbolList01.FormattingEnabled = true;
            this.cmbBoxSymbolList01.Location = new System.Drawing.Point(16, 51);
            this.cmbBoxSymbolList01.Name = "cmbBoxSymbolList01";
            this.cmbBoxSymbolList01.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxSymbolList01.TabIndex = 22;
            this.cmbBoxSymbolList01.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSymbolList_SelectedIndexChanged);
            this.cmbBoxSymbolList01.Leave += new System.EventHandler(this.cmbBoxSymbolList01_Leave);
            // 
            // cmbBoxSymbolHole
            // 
            this.cmbBoxSymbolHole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSymbolHole.FormattingEnabled = true;
            this.cmbBoxSymbolHole.Items.AddRange(new object[] {
            "---",
            "O--",
            "OO-",
            "OOO"});
            this.cmbBoxSymbolHole.Location = new System.Drawing.Point(229, 24);
            this.cmbBoxSymbolHole.Name = "cmbBoxSymbolHole";
            this.cmbBoxSymbolHole.Size = new System.Drawing.Size(62, 21);
            this.cmbBoxSymbolHole.TabIndex = 85;
            this.cmbBoxSymbolHole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSymbolHole_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleDescription = "questchallenge|itemspage";
            this.tabPage2.Controls.Add(this.pictureBox8);
            this.tabPage2.Controls.Add(this.btnBagThingsInput);
            this.tabPage2.Controls.Add(this.label133);
            this.tabPage2.Controls.Add(this.btnBagThingsOutput);
            this.tabPage2.Controls.Add(this.listViewBag);
            this.tabPage2.Controls.Add(this.numUpDnBagSN);
            this.tabPage2.Controls.Add(this.cmbBoxBagName);
            this.tabPage2.Controls.Add(this.label135);
            this.tabPage2.Controls.Add(this.numUpDnBagNum);
            this.tabPage2.Controls.Add(this.label134);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oggetti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CQE.Properties.Resources.challenge;
            this.pictureBox8.Location = new System.Drawing.Point(313, 47);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(192, 303);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 88;
            this.pictureBox8.TabStop = false;
            // 
            // btnBagThingsInput
            // 
            this.btnBagThingsInput.AccessibleDescription = "other|loadlist";
            this.btnBagThingsInput.Location = new System.Drawing.Point(416, 18);
            this.btnBagThingsInput.Name = "btnBagThingsInput";
            this.btnBagThingsInput.Size = new System.Drawing.Size(97, 23);
            this.btnBagThingsInput.TabIndex = 87;
            this.btnBagThingsInput.Text = "Carica Lista";
            this.btnBagThingsInput.UseVisualStyleBackColor = true;
            this.btnBagThingsInput.Click += new System.EventHandler(this.btnBagThingsInput_Click);
            // 
            // label133
            // 
            this.label133.AccessibleDescription = "edit|num";
            this.label133.AutoSize = true;
            this.label133.ForeColor = System.Drawing.Color.Indigo;
            this.label133.Location = new System.Drawing.Point(19, 6);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(27, 13);
            this.label133.TabIndex = 57;
            this.label133.Text = "Ord.";
            // 
            // btnBagThingsOutput
            // 
            this.btnBagThingsOutput.AccessibleDescription = "other|savelist";
            this.btnBagThingsOutput.Location = new System.Drawing.Point(313, 18);
            this.btnBagThingsOutput.Name = "btnBagThingsOutput";
            this.btnBagThingsOutput.Size = new System.Drawing.Size(97, 23);
            this.btnBagThingsOutput.TabIndex = 86;
            this.btnBagThingsOutput.Text = "Salva Lista";
            this.btnBagThingsOutput.UseVisualStyleBackColor = true;
            this.btnBagThingsOutput.Click += new System.EventHandler(this.btnBagThingsOutput_Click);
            // 
            // listViewBag
            // 
            this.listViewBag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bagColumnOrd,
            this.bagColumnName,
            this.bagColumnQty});
            this.listViewBag.FullRowSelect = true;
            this.listViewBag.GridLines = true;
            this.listViewBag.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewBag.Location = new System.Drawing.Point(15, 44);
            this.listViewBag.Name = "listViewBag";
            this.listViewBag.Size = new System.Drawing.Size(276, 306);
            this.listViewBag.TabIndex = 53;
            this.listViewBag.UseCompatibleStateImageBehavior = false;
            this.listViewBag.View = System.Windows.Forms.View.Details;
            this.listViewBag.Click += new System.EventHandler(this.listViewBag_Click);
            // 
            // bagColumnOrd
            // 
            this.bagColumnOrd.Text = "Ord.";
            this.bagColumnOrd.Width = 30;
            // 
            // bagColumnName
            // 
            this.bagColumnName.Text = "Name";
            this.bagColumnName.Width = 185;
            // 
            // bagColumnQty
            // 
            this.bagColumnQty.Text = "Qty";
            this.bagColumnQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bagColumnQty.Width = 38;
            // 
            // numUpDnBagSN
            // 
            this.numUpDnBagSN.Location = new System.Drawing.Point(16, 21);
            this.numUpDnBagSN.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUpDnBagSN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnBagSN.Name = "numUpDnBagSN";
            this.numUpDnBagSN.Size = new System.Drawing.Size(33, 20);
            this.numUpDnBagSN.TabIndex = 54;
            this.numUpDnBagSN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnBagSN.ValueChanged += new System.EventHandler(this.numUpDnBagSN_ValueChanged);
            // 
            // cmbBoxBagName
            // 
            this.cmbBoxBagName.FormattingEnabled = true;
            this.cmbBoxBagName.Location = new System.Drawing.Point(54, 21);
            this.cmbBoxBagName.Name = "cmbBoxBagName";
            this.cmbBoxBagName.Size = new System.Drawing.Size(177, 21);
            this.cmbBoxBagName.TabIndex = 55;
            this.cmbBoxBagName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBagName_SelectedIndexChanged);
            this.cmbBoxBagName.Leave += new System.EventHandler(this.cmbBoxBagName_Leave);
            // 
            // label135
            // 
            this.label135.AccessibleDescription = "edit|qty";
            this.label135.AutoSize = true;
            this.label135.ForeColor = System.Drawing.Color.Indigo;
            this.label135.Location = new System.Drawing.Point(239, 6);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(24, 13);
            this.label135.TabIndex = 59;
            this.label135.Text = "Qtà";
            // 
            // numUpDnBagNum
            // 
            this.numUpDnBagNum.Location = new System.Drawing.Point(235, 22);
            this.numUpDnBagNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDnBagNum.Name = "numUpDnBagNum";
            this.numUpDnBagNum.Size = new System.Drawing.Size(39, 20);
            this.numUpDnBagNum.TabIndex = 56;
            this.numUpDnBagNum.ValueChanged += new System.EventHandler(this.numUpDnBagNum_ValueChanged);
            // 
            // label134
            // 
            this.label134.AccessibleDescription = "edit|item";
            this.label134.AutoSize = true;
            this.label134.ForeColor = System.Drawing.Color.Indigo;
            this.label134.Location = new System.Drawing.Point(62, 6);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(76, 13);
            this.label134.TabIndex = 58;
            this.label134.Text = "Nome Oggetto";
            // 
            // challengeOptionsGroupBox
            // 
            this.challengeOptionsGroupBox.AccessibleDescription = "questchallenge|title";
            this.challengeOptionsGroupBox.Controls.Add(this.cmbBoxHunterNumber);
            this.challengeOptionsGroupBox.Controls.Add(this.label120);
            this.challengeOptionsGroupBox.Controls.Add(this.chkBoxStartExercise);
            this.challengeOptionsGroupBox.Location = new System.Drawing.Point(9, 3);
            this.challengeOptionsGroupBox.Name = "challengeOptionsGroupBox";
            this.challengeOptionsGroupBox.Size = new System.Drawing.Size(183, 42);
            this.challengeOptionsGroupBox.TabIndex = 18;
            this.challengeOptionsGroupBox.TabStop = false;
            this.challengeOptionsGroupBox.Text = "Opzioni Sfida";
            // 
            // cmbBoxHunterNumber
            // 
            this.cmbBoxHunterNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxHunterNumber.FormattingEnabled = true;
            this.cmbBoxHunterNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbBoxHunterNumber.Location = new System.Drawing.Point(125, 16);
            this.cmbBoxHunterNumber.Name = "cmbBoxHunterNumber";
            this.cmbBoxHunterNumber.Size = new System.Drawing.Size(47, 21);
            this.cmbBoxHunterNumber.TabIndex = 1;
            // 
            // label120
            // 
            this.label120.AccessibleDescription = "questchallenge|players";
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(70, 20);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(52, 13);
            this.label120.TabIndex = 2;
            this.label120.Text = "Giocatori:";
            // 
            // chkBoxStartExercise
            // 
            this.chkBoxStartExercise.AccessibleDescription = "other|enable";
            this.chkBoxStartExercise.AutoSize = true;
            this.chkBoxStartExercise.Enabled = false;
            this.chkBoxStartExercise.Location = new System.Drawing.Point(10, 19);
            this.chkBoxStartExercise.Name = "chkBoxStartExercise";
            this.chkBoxStartExercise.Size = new System.Drawing.Size(53, 17);
            this.chkBoxStartExercise.TabIndex = 0;
            this.chkBoxStartExercise.Text = "Attiva";
            this.chkBoxStartExercise.UseVisualStyleBackColor = true;
            this.chkBoxStartExercise.CheckedChanged += new System.EventHandler(this.chkBoxStartExercise_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CQEForm
            // 
            this.ClientSize = new System.Drawing.Size(598, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 570);
            this.MinimumSize = new System.Drawing.Size(614, 570);
            this.Name = "CQEForm";
            this.Text = "QS3 » CQE v";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.BaseTabPage.ResumeLayout(false);
            this.groupQuestReward.ResumeLayout(false);
            this.groupQuestReward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnionNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatCarNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemuntNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractNumUpDown)).EndInit();
            this.groupQuestData.ResumeLayout(false);
            this.groupQuestData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VicyTermNumUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VicyTermNumUpDown1)).EndInit();
            this.groupQuestInfo.ResumeLayout(false);
            this.groupQuestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SN_NumUpDown)).EndInit();
            this.BossTabPage.ResumeLayout(false);
            this.BossTabPage.PerformLayout();
            this.BossPanel.ResumeLayout(false);
            this.BossSetGroupBox.ResumeLayout(false);
            this.BossSetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOSSstyleNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossEnduranceNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossToFaceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossDefenseNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossAttackNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossJumpNumUDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossVolumnNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSnNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossZNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossYNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossXNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossNumNumUD)).EndInit();
            this.groupMonsterOptions.ResumeLayout(false);
            this.groupMonsterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnDouNoTimeToDefer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppearanceProbabilityNumUpD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningRemuntNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningUnionNumUpD)).EndInit();
            this.DogfishTabPage.ResumeLayout(false);
            this.groupMinionsBig.ResumeLayout(false);
            this.groupMinionsBig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDfEndurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfVolumeNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfDefenseNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfAttackNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfGradeNumUpDown)).EndInit();
            this.DogfishPanel.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DftoFaceNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_YNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_ZNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Df_XNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfNumNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfTypeNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfSnNumUpD)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DfAddNumNumUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DfAddNumNumUpDown1)).EndInit();
            this.FieldTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BasePanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseNumNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseSnNumUpD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionsRationCmbBoxNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseRationNumUpD)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResourseTabPage.ResumeLayout(false);
            this.ResourseTabPage.PerformLayout();
            this.ResourcesPanel.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResRareNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResNumNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResSnNumUpD)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RsMAXNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RsMININumUpD)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MaterialTabPage.ResumeLayout(false);
            this.MaterialTabPage.PerformLayout();
            this.MaterialPanel.ResumeLayout(false);
            this.MaterialGroupBox.ResumeLayout(false);
            this.MaterialGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialnRareNmericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialSnNumUpD)).EndInit();
            this.groupBoxBonus.ResumeLayout(false);
            this.groupBoxBonus.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNumNumUpD1)).EndInit();
            this.ChallengeTabPage.ResumeLayout(false);
            this.challengeEquipmentsGroupBox.ResumeLayout(false);
            this.challengeEquipmentsGroupBox.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.challengeDetailsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnHeadLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBodyLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnArmLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnWaistLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLegLV)).EndInit();
            this.challengeEditPanel.ResumeLayout(false);
            this.challengeEditPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateSS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateSS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimatePtS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnEstimateA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSkillPiont01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSkillPiont02)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBagSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBagNum)).EndInit();
            this.challengeOptionsGroupBox.ResumeLayout(false);
            this.challengeOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private NumericUpDown AppearanceProbabilityNumUpD1;
        private NumericUpDown AppearanceProbabilityNumUpD2;
        private NumericUpDown AppearanceProbabilityNumUpD3;
        private ComboBox BaseCmbBox;
        private ListView BaseContrLstView1;
        private ListView BaseContrLstView2;
        private NumericUpDown BaseNumNumUpD;
        private Panel BasePanel;
        private Button BasePlCloseBtn;
        private NumericUpDown BaseRationNumUpD;
        private NumericUpDown BaseSnNumUpD;
        private TabPage BaseTabPage;
        private NumericUpDown BossAttackNumUD;
        private ColumnHeader BossClmnHeader1;
        private ColumnHeader BossClmnHeader10;
        private ColumnHeader BossClmnHeader11;
        private ColumnHeader BossClmnHeader12;
        private ColumnHeader BossClmnHeader13;
        private ColumnHeader BossClmnHeader2;
        private ColumnHeader BossClmnHeader3;
        private ColumnHeader BossClmnHeader4;
        private ColumnHeader BossClmnHeader5;
        private ColumnHeader BossClmnHeader6;
        private ColumnHeader BossClmnHeader7;
        private ColumnHeader BossClmnHeader8;
        private ColumnHeader BossClmnHeader9;
        private NumericUpDown BossDefenseNumUD;
        private NumericUpDown BossEnduranceNumUpD;
        private ComboBox BossHPCmBox;
        private NumericUpDown BossJumpNumUDn;
        private ListView BossListView;
        private ComboBox BossNameCmbBox;
        private NumericUpDown BossNumNumUD;
        private Panel BossPanel;
        private Button BossPanelCloseBtn;
        private Button BossRandomButton;
        private RadioButton BossRandomSysRadioBtn1;
        private RadioButton BossRandomSysRadioBtn2;
        private RadioButton BossRandomSysRadioBtn3;
        private TextBox BossRandomUnknowValueTextBox;
        private GroupBox BossSetGroupBox;
        private NumericUpDown BossSnNumUD;
        private NumericUpDown BOSSstyleNumUpD;
        private TabPage BossTabPage;
        private NumericUpDown BossToFaceNumUD;
        private NumericUpDown BossVolumnNumUD;
        private NumericUpDown BossXNumUD;
        private NumericUpDown BossYNumUD;
        private NumericUpDown BossZNumUD;
        private ComboBox BPointCmbBox;
        private Button btnBagThingsInput;
        private Button btnBagThingsOutput;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox CaiYeChkBox;
        private NumericUpDown CatCarNumUpDown;
        private CheckBox CatChkBox;
        private CheckBox chkBoxBGM;
        private CheckBox chkBoxBOSSJUMP;
        private CheckBox chkBoxDouNoTimeToDefer;
        private CheckBox chkBoxStartExercise;
        private CheckBox chkBoxWeaponStrength;
        private ComboBox cmbBoxArm;
        private ComboBox cmbBoxBagName;
        private ComboBox cmbBoxBody;
        private ComboBox CmbBoxConditionsRation;
        private ComboBox cmbBoxFloatBeadInput;
        private ComboBox cmbBoxHead;
        private ComboBox cmbBoxHunterNumber;
        private ComboBox cmbBoxLeg;
        private ComboBox cmbBoxWaist;
        private ComboBox cmbBoxWeaponName;
        private ComboBox cmbBoxWeaponType;
        private ComboBox cmBoxStopTime;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader bagColumnOrd;
        private ColumnHeader bagColumnName;
        private ColumnHeader bagColumnQty;
        private NumericUpDown ConditionsRationCmbBoxNumUpD;
        private NumericUpDown ContractNumUpDown;
        private NumericUpDown Df_XNumUD;
        private NumericUpDown Df_YNumUD;
        private NumericUpDown Df_ZNumUD;
        private ComboBox DfAddCmbBox1;
        private ComboBox DfAddCmbBox2;
        private NumericUpDown DfAddNumNumUpDown1;
        private NumericUpDown DfAddNumNumUpDown2;
        private NumericUpDown DfAttackNumUpDown;
        private ColumnHeader DfClmnHeader1;
        private ColumnHeader DfClmnHeader2;
        private ColumnHeader DfClmnHeader3;
        private ColumnHeader DfClmnHeader4;
        private ColumnHeader DfClmnHeader5;
        private ColumnHeader DfClmnHeader6;
        private ColumnHeader DfClmnHeader7;
        private ColumnHeader DfClmnHeader8;
        private ColumnHeader DfClmnHeader9;
        private NumericUpDown DfDefenseNumUpDown;
        private NumericUpDown DfGradeNumUpDown;
        private ComboBox DfNameCmbBox;
        private NumericUpDown DfNumNumUpD;
        private ComboBox DfPointCmbBox;
        private ComboBox DfRoundTypeCmbBox;
        private NumericUpDown DfSnNumUpD;
        private NumericUpDown DftoFaceNumUpD;
        private NumericUpDown DfTypeNumUpD;
        private NumericUpDown DfVolumeNumUpD;
        private ListView DogfishListView;
        private Panel DogfishPanel;
        private TabPage DogfishTabPage;
        private CheckBox DogfishToBossChkBox;
        private RadioButton DogfRdButton1;
        private RadioButton DogfRdButton2;
        private RadioButton DogfRdButton3;
        private ComboBox EnvironmentCmbBox1;
        private ComboBox EnvironmentCmbBox2;
        private ComboBox ExpMaterialChooseCmbBox;
        private TabPage FieldTabPage;
        private GroupBox groupQuestInfo;
        private GroupBox groupMinionsBig;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private GroupBox groupBox14;
        private GroupBox groupBoxBonus;
        private GroupBox groupMonsterOptions;
        private GroupBox groupBox17;
        private GroupBox challengeOptionsGroupBox;
        private GroupBox groupBox19;
        private GroupBox groupQuestData;
        private GroupBox challengeEquipmentsGroupBox;
        private GroupBox groupQuestReward;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private Label label1;
        private Label label10;
        private Label label101;
        private Label label103;
        private Label label104;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label108;
        private Label label109;
        private Label label11;
        private Label label112;
        private Label label116;
        private Label label118;
        private Label label119;
        private Label label12;
        private Label label120;
        private Label label121;
        private Label label122;
        private Label label123;
        private Label label124;
        private Label label126;
        private Label label13;
        private Label label132;
        private Label label133;
        private Label label134;
        private Label label135;
        private Label label136;
        private Label label137;
        private Label label138;
        private Label label139;
        private Label label14;
        private Label label140;
        private Label label141;
        private Label label142;
        private Label label143;
        private Label label144;
        private Label label145;
        private Label label146;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label3;
        private Label label4;
        private Label label46;
        private Label label48;
        private Label label5;
        private Label label51;
        private Label label55;
        private Label label6;
        private Label label68;
        private Label label7;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label79;
        private Label label8;
        private Label label81;
        private Label label87;
        private Label label88;
        private Label label9;
        private Label label96;
        private ComboBox LandingCmbBox;
        private ListView listViewBag;
        private Button LoadBaseSetButton;
        private Button LoadMaterialBtn;
        private Label MapLabel;
        private ComboBox MapTimeCmbBox;
        private GroupBox MaterialGroupBox;
        private ListView MaterialListView1;
        private ListView MaterialListView2;
        private ComboBox MaterialNameCmbBox;
        private NumericUpDown MaterialnRareNmericUpDown;
        private NumericUpDown MaterialNumNumUpD;
        private NumericUpDown MaterialNumNumUpD1;
        private NumericUpDown MaterialNumNumUpD2;
        private Panel MaterialPanel;
        private NumericUpDown MaterialSnNumUpD;
        private TabPage MaterialTabPage;
        private MenuStrip menuStrip1;
        private ComboBox MonsterIconCmbBox1;
        private ComboBox MonsterIconCmbBox2;
        private ComboBox MonsterIconCmbBox3;
        private ComboBox MonsterIconCmbBox4;
        private ComboBox MonsterIconCmbBox5;
        private NumericUpDown numUpDnArmLV;
        private NumericUpDown numUpDnBagNum;
        private NumericUpDown numUpDnBagSN;
        private NumericUpDown numUpDnBodyLV;
        private NumericUpDown numUpDnDouNoTimeToDefer;
        private NumericUpDown numUpDnEstimateA1;
        private NumericUpDown numUpDnEstimateA2;
        private NumericUpDown numUpDnEstimatePtA;
        private NumericUpDown numUpDnEstimatePtB;
        private NumericUpDown numUpDnEstimatePtS;
        private NumericUpDown numUpDnEstimateS1;
        private NumericUpDown numUpDnEstimateS2;
        private NumericUpDown numUpDnEstimateSS1;
        private NumericUpDown numUpDnEstimateSS2;
        private NumericUpDown numUpDnHeadLV;
        private NumericUpDown numUpDnLegLV;
        private NumericUpDown numUpDnWaistLV;
        private NumericUpDown NumUpDownDfEndurance;
        private ComboBox OpenLimitCmbBox1;
        private ComboBox OpenLimitCmbBox2;
        private Panel challengeEditPanel;
        private RadioButton RadioBtnConditionsRation;
        private RadioButton RadioBtnNothing;
        private RadioButton RadioBtnRandomSysRation;
        private RadioButton rdBtnArmor1;
        private RadioButton rdBtnArmor2;
        private RadioButton rdBtnArmor3;
        private RadioButton rdBtnArmor4;
        private RadioButton rdBtnArmor5;
        private RadioButton rdBtnWeaponStrength1;
        private RadioButton rdBtnWeaponStrength2;
        private RadioButton rdBtnWeaponStrength3;
        private NumericUpDown RemuntNumUpDown;
        private ComboBox ResNameCmbBox;
        private NumericUpDown ResNumNumUpD;
        private ListView ResourcesListView;
        private Panel ResourcesPanel;
        private TabPage ResourseTabPage;
        private NumericUpDown ResRareNumUpD;
        private NumericUpDown ResSnNumUpD;
        private RadioButton RoundRdButton1;
        private RadioButton RoundRdButton2;
        private RadioButton RoundRdButton3;
        private NumericUpDown RsMAXNumUpD;
        private NumericUpDown RsMININumUpD;
        private ComboBox RsrLandmassCmbBox;
        private ComboBox RsrPointCmbBox;
        private Button SaveBaseSetButton;
        private SaveFileDialog saveFileDialog1;
        private Button SaveMaterialBtn;
        private NumericUpDown SN_NumUpDown;
        private ComboBox SndVicyTermCmbBox;
        private ComboBox StarGradeCmbBox;
        private TabControl tabControl1;
        private TabPage ChallengeTabPage;
        private ComboBox TaskTypeCmbBox;
        private TextBox taskDescriptionText;
        private TextBox taskTitleText;
        private TextBox taskLoseText;
        private TextBox taskClientText;
        private TextBox taskMostriText;
        private TextBox taskWinCondText;
        private TextBox textBoxBead01;
        private TextBox textBoxBead02;
        private TextBox textBoxBead03;
        private TextBox textBoxBead11;
        private TextBox textBoxBead12;
        private TextBox textBoxBead13;
        private TextBox textBoxBead21;
        private TextBox textBoxBead22;
        private TextBox textBoxBead23;
        private TextBox textBoxBead31;
        private TextBox textBoxBead32;
        private TextBox textBoxBead33;
        private TextBox textBoxBead41;
        private TextBox textBoxBead42;
        private TextBox textBoxBead43;
        private TextBox textBoxBead51;
        private TextBox textBoxBead52;
        private TextBox textBoxBead53;
        private NumericUpDown TimeNumUpDown;
        private ToolStripSeparator toolStripMenuItem3;
        private NumericUpDown UnionNumUpDown;
        private ComboBox VicyTermCmbBox1;
        private ComboBox VicyTermCmbBox2;
        private NumericUpDown VicyTermNumUpDown1;
        private NumericUpDown VicyTermNumUpDown2;
        private NumericUpDown WarningRemuntNumUpD;
        private NumericUpDown WarningUnionNumUpD;
        private ToolStripMenuItem HighRankToolStripMenuItem;
        private ToolStripMenuItem LowRankToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem TundraToolStripMenuItem1;
        private ToolStripMenuItem TundraToolStripMenuItem2;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripMenuItem IsolaToolStripMenuItem1;
        private ToolStripMenuItem IsolaToolStripMenuItem2;
        private ToolStripMenuItem ArenaPiccolaToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem ArenaToolStripMenuItem;
        private ToolStripMenuItem NewTaskToolStripMenuItem;
        private ToolStripMenuItem MapToolStripMenuItem;
        private ToolStripMenuItem ZonaPolareToolStripMenuItem;
        private ToolStripMenuItem ForestaToolStripMenuItem1;
        private ToolStripMenuItem ForestaToolStripMenuItem2;
        private ToolStripMenuItem CascateToolStripMenuItem1;
        private ToolStripMenuItem CascateToolStripMenuItem2;
        private ToolStripMenuItem CanyonLavaToolStripMenuItem;
        private ToolStripMenuItem VulcanoToolStripMenuItem1;
        private ToolStripMenuItem VulcanoToolStripMenuItem2;
        private ToolStripMenuItem CimaMontagnaToolStripMenuItem;
        private ToolStripMenuItem PianureToolStripMenuItem1;
        private ToolStripMenuItem PianureToolStripMenuItem2;
        private ToolStripMenuItem TerraSacraToolStripMenuItem;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private ToolStripMenuItem opzioniToolStripMenuItem;
        private ToolStripMenuItem controllaAutomaticamenteUpdatesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem controllaAggiornamentiToolStripMenuItem;
        private ToolStripMenuItem scaricaLingueToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem linguaToolStripMenuItem;
        private ToolStripMenuItem grandeDesertoToolStripMenuItem;
        private Label label148;
        private Label label117;
        private Label label149;
        private Button randomizeIDButton;
        private Label label34;
        private Label label114;
        private Label label92;
        private Label label111;
        private Label label38;
        private Label label73;
        private Label label65;
        private Label label67;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label113;
        private Label label150;
        private Label label147;
        private Label label24;
        private Label label151;
        private Label label110;
        private Label label66;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label47;
        private Label label32;
        private Label label72;
        private Label label115;
        private Label label33;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label152;
        private Label label64;
        private Label label63;
        private Label label58;
        private Label label62;
        private Label label61;
        private Label label59;
        private Label label60;
        private Label label49;
        private Label label50;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label56;
        private Label label57;
        private Label label45;
        private Label label44;
        private Label label43;
        private PictureBox pictureBox1;
        private Label label42;
        private Label label74;
        private Label label102;
        private Label label39;
        private Label label41;
        private Label label40;
        private PictureBox pictureBox2;
        private Label label82;
        private Label RsrRateLabel;
        private Label label80;
        private Label label78;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label MtlRateLabel;
        private Label label91;
        private Label label90;
        private Label label89;
        private Label label97;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label MtlExpRateLabe;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label153;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox weaponPictureBox;
        private TabControl challengeDetailsTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private ComboBox cmbBoxSymbolType;
        private ComboBox cmbBoxSymbolList02;
        private TextBox textBoxSkillList;
        private TextBox textBoxBead62;
        private NumericUpDown numUpDnSkillPiont01;
        private TextBox textBoxBead61;
        private NumericUpDown numUpDnSkillPiont02;
        private TextBox textBoxBead63;
        private ComboBox cmbBoxSymbolList01;
        private ComboBox cmbBoxSymbolHole;
        private ComboBox cmbBoxFloatBeadInputAmulet;
        private GroupBox groupBox1;
        private PictureBox pictureBox8;
        private Label label130;
        private Label label129;
        private Label label128;
        private Label label127;
        private Label label125;
    }
}