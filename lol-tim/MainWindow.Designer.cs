using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lol_tim
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
            this.panelMENU = new Panel();
            this.buttonAppSettings = new Button();
            this.buttonExit = new Button();
            this.buttonReport = new Button();
            this.buttonChat = new Button();
            this.buttonTimer = new Button();
            this.buttonEnableSettings = new Button();
            this.panelLOGO = new Panel();
            this.labelLOGO = new Label();
            this.panelTOP = new Panel();
            this.labelACTUALCDRTOP = new Label();
            this.comboBoxSST2TYPETOP = new ComboBox();
            this.comboBoxSST1TYPETOP = new ComboBox();
            this.labelSST2TYPETOP = new Label();
            this.labelSST1TYPETOP = new Label();
            this.comboBoxCDRTOPCHANGE = new ComboBox();
            this.buttonSST2TOPRESET = new Button();
            this.buttonSST2TOPSTART = new Button();
            this.buttonSST1TOPSTART = new Button();
            this.buttonSST1TOPRESET = new Button();
            this.checkBoxSHOESTOP = new CheckBox();
            this.labelSST2TOPTIME = new Label();
            this.labelSST1TOPTIME = new Label();
            this.labelSST2TOP = new Label();
            this.labelSST1TOP = new Label();
            this.labelCDRPERCENTTOP = new Label();
            this.labelCDRTOP = new Label();
            this.labelTOP = new Label();
            this.panelJUNGLE = new Panel();
            this.labelACTUALCDRJUNGLE = new Label();
            this.comboBoxSST2TYPEJUNGLE = new ComboBox();
            this.comboBoxSST1TYPEJUNGLE = new ComboBox();
            this.buttonSST2JUNGLERESET = new Button();
            this.buttonSST2JUNGLESTART = new Button();
            this.buttonSST1JUNGLESTART = new Button();
            this.buttonSST1JUNGLERESET = new Button();
            this.labelSST2TYPEJUNGLE = new Label();
            this.labelSST1TYPEJUNGLE = new Label();
            this.comboBoxCDRJUNGLECHANGE = new ComboBox();
            this.checkBoxSHOESJUNGLE = new CheckBox();
            this.labelSST2JUNGLETIME = new Label();
            this.labelSST1JUNGLETIME = new Label();
            this.labelSST2JUNGLE = new Label();
            this.labelSST1JUNGLE = new Label();
            this.labelCDRPERCENTJUNGLE = new Label();
            this.labelCDRJUNGLE = new Label();
            this.LabelJUNGLE = new Label();
            this.panelMID = new Panel();
            this.labelACTUALCDRMID = new Label();
            this.comboBoxSST2TYPEMID = new ComboBox();
            this.comboBoxSST1TYPEMID = new ComboBox();
            this.buttonSST2MIDRESET = new Button();
            this.buttonSST2MIDSTART = new Button();
            this.buttonSST1MIDSTART = new Button();
            this.buttonSST1MIDRESET = new Button();
            this.labelSST2TYPEMID = new Label();
            this.labelSST1TYPEMID = new Label();
            this.comboBoxCDRMIDCHANGE = new ComboBox();
            this.checkBoxSHOESMID = new CheckBox();
            this.labelSST2MIDTIME = new Label();
            this.labelSST1MIDTIME = new Label();
            this.labelSST2MID = new Label();
            this.labelSST1MID = new Label();
            this.labelCDRPERCENTMID = new Label();
            this.labelCDRMID = new Label();
            this.labelMID = new Label();
            this.panelADC = new Panel();
            this.labelACTUALCDRADC = new Label();
            this.comboBoxSST2TYPEADC = new ComboBox();
            this.comboBoxSST1TYPEADC = new ComboBox();
            this.buttonSST2ADCRESET = new Button();
            this.buttonSST2ADCSTART = new Button();
            this.buttonSST1ADCSTART = new Button();
            this.buttonSST1ADCRESET = new Button();
            this.labelSST2TYPEADC = new Label();
            this.labelSST1TYPEADC = new Label();
            this.comboBoxCDRADCCHANGE = new ComboBox();
            this.checkBoxSHOESADC = new CheckBox();
            this.labelSST2ADCTIME = new Label();
            this.labelSST1ADCTIME = new Label();
            this.labelSST2ADC = new Label();
            this.labelSST1ADC = new Label();
            this.labelCDRPERCENTADC = new Label();
            this.labelCDRADC = new Label();
            this.labelADC = new Label();
            this.panelSUPPORT = new Panel();
            this.labelACTUALCDRSUPPORT = new Label();
            this.comboBoxSST2TYPESUPPORT = new ComboBox();
            this.comboBoxSST1TYPESUPPORT = new ComboBox();
            this.buttonSST2SUPPORTRESET = new Button();
            this.buttonSST2SUPPORTSTART = new Button();
            this.buttonSST1SUPPORTSTART = new Button();
            this.buttonSST1SUPPORTRESET = new Button();
            this.labelSST2TYPESUPPORT = new Label();
            this.labelSST1TYPESUPPORT = new Label();
            this.comboBoxCDRSUPPORTCHANGE = new ComboBox();
            this.checkBoxSHOESSUPPORT = new CheckBox();
            this.labelSST2SUPPORTTIME = new Label();
            this.labelSST1SUPPORTTIME = new Label();
            this.labelSST2SUPPORT = new Label();
            this.labelCDRPERCENTSUPPORT = new Label();
            this.labelSST1SUPPORT = new Label();
            this.labelCDRSUPPORT = new Label();
            this.labelSUPPORT = new Label();
            this.timerBeep = new Timer(this.components);
            this.timerSST1TOP = new Timer(this.components);
            this.timerSST2TOP = new Timer(this.components);
            this.timerSST1JUNGLE = new Timer(this.components);
            this.timerSST2JUNGLE = new Timer(this.components);
            this.timerSST1MID = new Timer(this.components);
            this.timerSST2MID = new Timer(this.components);
            this.timerSST1ADC = new Timer(this.components);
            this.timerSST2ADC = new Timer(this.components);
            this.timerSST1SUPPORT = new Timer(this.components);
            this.timerSST2SUPPORT = new Timer(this.components);
            this.panelMENU.SuspendLayout();
            this.panelLOGO.SuspendLayout();
            this.panelTOP.SuspendLayout();
            this.panelJUNGLE.SuspendLayout();
            this.panelMID.SuspendLayout();
            this.panelADC.SuspendLayout();
            this.panelSUPPORT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMENU.Controls.Add(this.buttonAppSettings);
            this.panelMENU.Controls.Add(this.buttonExit);
            this.panelMENU.Controls.Add(this.buttonReport);
            this.panelMENU.Controls.Add(this.buttonChat);
            this.panelMENU.Controls.Add(this.buttonTimer);
            this.panelMENU.Controls.Add(this.buttonEnableSettings);
            this.panelMENU.Controls.Add(this.panelLOGO);
            this.panelMENU.Dock = DockStyle.Left;
            this.panelMENU.Location = new Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new Size(130, 400);
            this.panelMENU.TabIndex = 0;
            // 
            // buttonAppSettings
            // 
            this.buttonAppSettings.Dock = DockStyle.Top;
            this.buttonAppSettings.FlatAppearance.BorderSize = 0;
            this.buttonAppSettings.FlatStyle = FlatStyle.Flat;
            this.buttonAppSettings.ForeColor = Color.White;
            this.buttonAppSettings.Image = ((Image)(resources.GetObject("buttonAppSettings.Image")));
            this.buttonAppSettings.Location = new Point(0, 340);
            this.buttonAppSettings.Name = "buttonAppSettings";
            this.buttonAppSettings.Size = new Size(130, 60);
            this.buttonAppSettings.TabIndex = 6;
            this.buttonAppSettings.Text = "App Settings";
            this.buttonAppSettings.TextAlign = ContentAlignment.BottomCenter;
            this.buttonAppSettings.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonAppSettings.UseVisualStyleBackColor = true;
            this.buttonAppSettings.Click += new EventHandler(this.ButtonAppSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = DockStyle.Top;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = FlatStyle.Flat;
            this.buttonExit.ForeColor = Color.White;
            this.buttonExit.Image = ((Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new Point(0, 285);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(130, 55);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = ContentAlignment.BottomCenter;
            this.buttonExit.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.ButtonExit_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = FlatStyle.Flat;
            this.buttonReport.ForeColor = Color.White;
            this.buttonReport.Image = ((Image)(resources.GetObject("buttonReport.Image")));
            this.buttonReport.Location = new Point(0, 230);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new Size(130, 55);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.TextAlign = ContentAlignment.BottomCenter;
            this.buttonReport.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new EventHandler(this.ButtonReport_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.Dock = DockStyle.Top;
            this.buttonChat.FlatAppearance.BorderSize = 0;
            this.buttonChat.FlatStyle = FlatStyle.Flat;
            this.buttonChat.ForeColor = Color.White;
            this.buttonChat.Image = ((Image)(resources.GetObject("buttonChat.Image")));
            this.buttonChat.Location = new Point(0, 175);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new Size(130, 55);
            this.buttonChat.TabIndex = 3;
            this.buttonChat.Text = "Chat";
            this.buttonChat.TextAlign = ContentAlignment.BottomCenter;
            this.buttonChat.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new EventHandler(this.ButtonChat_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Dock = DockStyle.Top;
            this.buttonTimer.FlatAppearance.BorderSize = 0;
            this.buttonTimer.FlatStyle = FlatStyle.Flat;
            this.buttonTimer.ForeColor = Color.White;
            this.buttonTimer.Image = ((Image)(resources.GetObject("buttonTimer.Image")));
            this.buttonTimer.Location = new Point(0, 120);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new Size(130, 55);
            this.buttonTimer.TabIndex = 2;
            this.buttonTimer.Text = "Timer";
            this.buttonTimer.TextAlign = ContentAlignment.BottomCenter;
            this.buttonTimer.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new EventHandler(this.ButtonTimer_Click);
            // 
            // buttonEnableSettings
            // 
            this.buttonEnableSettings.Dock = DockStyle.Top;
            this.buttonEnableSettings.FlatAppearance.BorderSize = 0;
            this.buttonEnableSettings.FlatStyle = FlatStyle.Flat;
            this.buttonEnableSettings.ForeColor = Color.White;
            this.buttonEnableSettings.Image = ((Image)(resources.GetObject("buttonEnableSettings.Image")));
            this.buttonEnableSettings.Location = new Point(0, 65);
            this.buttonEnableSettings.Name = "buttonEnableSettings";
            this.buttonEnableSettings.Size = new Size(130, 55);
            this.buttonEnableSettings.TabIndex = 1;
            this.buttonEnableSettings.Text = "Change Settings";
            this.buttonEnableSettings.TextAlign = ContentAlignment.BottomCenter;
            this.buttonEnableSettings.TextImageRelation = TextImageRelation.ImageAboveText;
            this.buttonEnableSettings.UseVisualStyleBackColor = true;
            this.buttonEnableSettings.Click += new EventHandler(this.ButtonEnableSettings_Click);
            // 
            // panelLOGO
            // 
            this.panelLOGO.BackColor = Color.Gold;
            this.panelLOGO.Controls.Add(this.labelLOGO);
            this.panelLOGO.Dock = DockStyle.Top;
            this.panelLOGO.Location = new Point(0, 0);
            this.panelLOGO.Name = "panelLOGO";
            this.panelLOGO.Size = new Size(130, 65);
            this.panelLOGO.TabIndex = 0;
            // 
            // labelLOGO
            // 
            this.labelLOGO.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            this.labelLOGO.ForeColor = SystemColors.Highlight;
            this.labelLOGO.Location = new Point(6, 9);
            this.labelLOGO.Name = "labelLOGO";
            this.labelLOGO.Size = new Size(118, 42);
            this.labelLOGO.TabIndex = 0;
            this.labelLOGO.Text = "lol-tim";
            // 
            // panelTOP
            // 
            this.panelTOP.Controls.Add(this.labelACTUALCDRTOP);
            this.panelTOP.Controls.Add(this.comboBoxSST2TYPETOP);
            this.panelTOP.Controls.Add(this.comboBoxSST1TYPETOP);
            this.panelTOP.Controls.Add(this.labelSST2TYPETOP);
            this.panelTOP.Controls.Add(this.labelSST1TYPETOP);
            this.panelTOP.Controls.Add(this.comboBoxCDRTOPCHANGE);
            this.panelTOP.Controls.Add(this.buttonSST2TOPRESET);
            this.panelTOP.Controls.Add(this.buttonSST2TOPSTART);
            this.panelTOP.Controls.Add(this.buttonSST1TOPSTART);
            this.panelTOP.Controls.Add(this.buttonSST1TOPRESET);
            this.panelTOP.Controls.Add(this.checkBoxSHOESTOP);
            this.panelTOP.Controls.Add(this.labelSST2TOPTIME);
            this.panelTOP.Controls.Add(this.labelSST1TOPTIME);
            this.panelTOP.Controls.Add(this.labelSST2TOP);
            this.panelTOP.Controls.Add(this.labelSST1TOP);
            this.panelTOP.Controls.Add(this.labelCDRPERCENTTOP);
            this.panelTOP.Controls.Add(this.labelCDRTOP);
            this.panelTOP.Controls.Add(this.labelTOP);
            this.panelTOP.Dock = DockStyle.Top;
            this.panelTOP.Location = new Point(130, 0);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new Size(477, 80);
            this.panelTOP.TabIndex = 1;
            // 
            // labelACTUALCDRTOP
            // 
            this.labelACTUALCDRTOP.AutoSize = true;
            this.labelACTUALCDRTOP.Location = new Point(46, 0);
            this.labelACTUALCDRTOP.Name = "labelACTUALCDRTOP";
            this.labelACTUALCDRTOP.Size = new Size(18, 19);
            this.labelACTUALCDRTOP.TabIndex = 18;
            this.labelACTUALCDRTOP.Text = "1";
            // 
            // comboBoxSST2TYPETOP
            // 
            this.comboBoxSST2TYPETOP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST2TYPETOP.FormattingEnabled = true;
            this.comboBoxSST2TYPETOP.Location = new Point(164, 43);
            this.comboBoxSST2TYPETOP.Name = "comboBoxSST2TYPETOP";
            this.comboBoxSST2TYPETOP.Size = new Size(81, 27);
            this.comboBoxSST2TYPETOP.TabIndex = 17;
            this.comboBoxSST2TYPETOP.Visible = false;
            this.comboBoxSST2TYPETOP.SelectedIndexChanged += new EventHandler(this.ComboBoxSST2TYPETOP_SelectedIndexChanged);
            // 
            // comboBoxSST1TYPETOP
            // 
            this.comboBoxSST1TYPETOP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST1TYPETOP.FormattingEnabled = true;
            this.comboBoxSST1TYPETOP.Location = new Point(164, 10);
            this.comboBoxSST1TYPETOP.Name = "comboBoxSST1TYPETOP";
            this.comboBoxSST1TYPETOP.Size = new Size(81, 27);
            this.comboBoxSST1TYPETOP.TabIndex = 6;
            this.comboBoxSST1TYPETOP.Visible = false;
            this.comboBoxSST1TYPETOP.SelectedIndexChanged += new EventHandler(this.ComboBoxSST1TYPETOP_SelectedIndexChanged);
            // 
            // labelSST2TYPETOP
            // 
            this.labelSST2TYPETOP.AutoSize = true;
            this.labelSST2TYPETOP.Location = new Point(164, 46);
            this.labelSST2TYPETOP.Name = "labelSST2TYPETOP";
            this.labelSST2TYPETOP.Size = new Size(48, 19);
            this.labelSST2TYPETOP.TabIndex = 16;
            this.labelSST2TYPETOP.Text = "Ignite";
            this.labelSST2TYPETOP.DoubleClick += new EventHandler(this.LabelSST2TYPETOP_DoubleClick);
            // 
            // labelSST1TYPETOP
            // 
            this.labelSST1TYPETOP.AutoSize = true;
            this.labelSST1TYPETOP.Location = new Point(164, 13);
            this.labelSST1TYPETOP.Name = "labelSST1TYPETOP";
            this.labelSST1TYPETOP.Size = new Size(46, 19);
            this.labelSST1TYPETOP.TabIndex = 15;
            this.labelSST1TYPETOP.Text = "Flash";
            this.labelSST1TYPETOP.DoubleClick += new EventHandler(this.LabelSST1TYPETOP_DoubleClick);
            // 
            // comboBoxCDRTOPCHANGE
            // 
            this.comboBoxCDRTOPCHANGE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCDRTOPCHANGE.FormattingEnabled = true;
            this.comboBoxCDRTOPCHANGE.Items.AddRange(new object[] {
            "0%",
            "5%",
            "25%",
            "30%"});
            this.comboBoxCDRTOPCHANGE.Location = new Point(52, 36);
            this.comboBoxCDRTOPCHANGE.Name = "comboBoxCDRTOPCHANGE";
            this.comboBoxCDRTOPCHANGE.Size = new Size(53, 27);
            this.comboBoxCDRTOPCHANGE.TabIndex = 14;
            this.comboBoxCDRTOPCHANGE.Visible = false;
            this.comboBoxCDRTOPCHANGE.SelectedIndexChanged += new EventHandler(this.ComboBoxCDRTOPCHANGE_SelectedIndexChanged);
            // 
            // buttonSST2TOPRESET
            // 
            this.buttonSST2TOPRESET.Location = new Point(395, 41);
            this.buttonSST2TOPRESET.Name = "buttonSST2TOPRESET";
            this.buttonSST2TOPRESET.Size = new Size(75, 39);
            this.buttonSST2TOPRESET.TabIndex = 14;
            this.buttonSST2TOPRESET.Text = "RESET";
            this.buttonSST2TOPRESET.UseVisualStyleBackColor = true;
            this.buttonSST2TOPRESET.Click += new EventHandler(this.ButtonSST2TOPRESET_Click);
            // 
            // buttonSST2TOPSTART
            // 
            this.buttonSST2TOPSTART.Location = new Point(314, 41);
            this.buttonSST2TOPSTART.Name = "buttonSST2TOPSTART";
            this.buttonSST2TOPSTART.Size = new Size(75, 39);
            this.buttonSST2TOPSTART.TabIndex = 14;
            this.buttonSST2TOPSTART.Text = "START";
            this.buttonSST2TOPSTART.UseVisualStyleBackColor = true;
            this.buttonSST2TOPSTART.Click += new EventHandler(this.ButtonSST2TOPSTART_Click);
            // 
            // buttonSST1TOPSTART
            // 
            this.buttonSST1TOPSTART.Location = new Point(314, 0);
            this.buttonSST1TOPSTART.Name = "buttonSST1TOPSTART";
            this.buttonSST1TOPSTART.Size = new Size(75, 39);
            this.buttonSST1TOPSTART.TabIndex = 13;
            this.buttonSST1TOPSTART.Text = "START";
            this.buttonSST1TOPSTART.UseVisualStyleBackColor = true;
            this.buttonSST1TOPSTART.Click += new EventHandler(this.ButtonSST1TOPSTART_Click);
            // 
            // buttonSST1TOPRESET
            // 
            this.buttonSST1TOPRESET.Location = new Point(395, 0);
            this.buttonSST1TOPRESET.Name = "buttonSST1TOPRESET";
            this.buttonSST1TOPRESET.Size = new Size(75, 39);
            this.buttonSST1TOPRESET.TabIndex = 6;
            this.buttonSST1TOPRESET.Text = "RESET";
            this.buttonSST1TOPRESET.UseVisualStyleBackColor = true;
            this.buttonSST1TOPRESET.Click += new EventHandler(this.ButtonSST1TOPRESET_Click);
            // 
            // checkBoxSHOESTOP
            // 
            this.checkBoxSHOESTOP.AutoSize = true;
            this.checkBoxSHOESTOP.Location = new Point(26, 16);
            this.checkBoxSHOESTOP.Name = "checkBoxSHOESTOP";
            this.checkBoxSHOESTOP.Size = new Size(69, 23);
            this.checkBoxSHOESTOP.TabIndex = 12;
            this.checkBoxSHOESTOP.Text = "Shoes";
            this.checkBoxSHOESTOP.UseVisualStyleBackColor = true;
            this.checkBoxSHOESTOP.CheckedChanged += new EventHandler(this.CheckBoxSHOESTOP_CheckedChanged);
            // 
            // labelSST2TOPTIME
            // 
            this.labelSST2TOPTIME.AutoSize = true;
            this.labelSST2TOPTIME.Location = new Point(265, 46);
            this.labelSST2TOPTIME.Name = "labelSST2TOPTIME";
            this.labelSST2TOPTIME.Size = new Size(18, 19);
            this.labelSST2TOPTIME.TabIndex = 6;
            this.labelSST2TOPTIME.Text = "0";
            // 
            // labelSST1TOPTIME
            // 
            this.labelSST1TOPTIME.AutoSize = true;
            this.labelSST1TOPTIME.Location = new Point(265, 13);
            this.labelSST1TOPTIME.Name = "labelSST1TOPTIME";
            this.labelSST1TOPTIME.Size = new Size(18, 19);
            this.labelSST1TOPTIME.TabIndex = 5;
            this.labelSST1TOPTIME.Text = "0";
            // 
            // labelSST2TOP
            // 
            this.labelSST2TOP.AutoSize = true;
            this.labelSST2TOP.Location = new Point(111, 46);
            this.labelSST2TOP.Name = "labelSST2TOP";
            this.labelSST2TOP.Size = new Size(47, 19);
            this.labelSST2TOP.TabIndex = 4;
            this.labelSST2TOP.Text = "SST2:";
            // 
            // labelSST1TOP
            // 
            this.labelSST1TOP.AutoSize = true;
            this.labelSST1TOP.Location = new Point(111, 13);
            this.labelSST1TOP.Name = "labelSST1TOP";
            this.labelSST1TOP.Size = new Size(47, 19);
            this.labelSST1TOP.TabIndex = 3;
            this.labelSST1TOP.Text = "SST1:";
            // 
            // labelCDRPERCENTTOP
            // 
            this.labelCDRPERCENTTOP.AutoSize = true;
            this.labelCDRPERCENTTOP.Location = new Point(48, 39);
            this.labelCDRPERCENTTOP.Name = "labelCDRPERCENTTOP";
            this.labelCDRPERCENTTOP.Size = new Size(32, 19);
            this.labelCDRPERCENTTOP.TabIndex = 2;
            this.labelCDRPERCENTTOP.Text = "0%";
            this.labelCDRPERCENTTOP.TextChanged += new EventHandler(this.LabelCDRPERCENTTOP_TextChanged);
            this.labelCDRPERCENTTOP.DoubleClick += new EventHandler(this.LabelCDRPERCENTTOP_DoubleClick);
            // 
            // labelCDRTOP
            // 
            this.labelCDRTOP.AutoSize = true;
            this.labelCDRTOP.Location = new Point(3, 39);
            this.labelCDRTOP.Name = "labelCDRTOP";
            this.labelCDRTOP.Size = new Size(47, 19);
            this.labelCDRTOP.TabIndex = 1;
            this.labelCDRTOP.Text = "CDR: ";
            // 
            // labelTOP
            // 
            this.labelTOP.AutoSize = true;
            this.labelTOP.ForeColor = SystemColors.Control;
            this.labelTOP.Location = new Point(3, 0);
            this.labelTOP.Name = "labelTOP";
            this.labelTOP.Size = new Size(37, 19);
            this.labelTOP.TabIndex = 0;
            this.labelTOP.Text = "TOP";
            // 
            // panelJUNGLE
            // 
            this.panelJUNGLE.Controls.Add(this.labelACTUALCDRJUNGLE);
            this.panelJUNGLE.Controls.Add(this.comboBoxSST2TYPEJUNGLE);
            this.panelJUNGLE.Controls.Add(this.comboBoxSST1TYPEJUNGLE);
            this.panelJUNGLE.Controls.Add(this.buttonSST2JUNGLERESET);
            this.panelJUNGLE.Controls.Add(this.buttonSST2JUNGLESTART);
            this.panelJUNGLE.Controls.Add(this.buttonSST1JUNGLESTART);
            this.panelJUNGLE.Controls.Add(this.buttonSST1JUNGLERESET);
            this.panelJUNGLE.Controls.Add(this.labelSST2TYPEJUNGLE);
            this.panelJUNGLE.Controls.Add(this.labelSST1TYPEJUNGLE);
            this.panelJUNGLE.Controls.Add(this.comboBoxCDRJUNGLECHANGE);
            this.panelJUNGLE.Controls.Add(this.checkBoxSHOESJUNGLE);
            this.panelJUNGLE.Controls.Add(this.labelSST2JUNGLETIME);
            this.panelJUNGLE.Controls.Add(this.labelSST1JUNGLETIME);
            this.panelJUNGLE.Controls.Add(this.labelSST2JUNGLE);
            this.panelJUNGLE.Controls.Add(this.labelSST1JUNGLE);
            this.panelJUNGLE.Controls.Add(this.labelCDRPERCENTJUNGLE);
            this.panelJUNGLE.Controls.Add(this.labelCDRJUNGLE);
            this.panelJUNGLE.Controls.Add(this.LabelJUNGLE);
            this.panelJUNGLE.Dock = DockStyle.Top;
            this.panelJUNGLE.Location = new Point(130, 80);
            this.panelJUNGLE.Name = "panelJUNGLE";
            this.panelJUNGLE.Size = new Size(477, 80);
            this.panelJUNGLE.TabIndex = 2;
            // 
            // labelACTUALCDRJUNGLE
            // 
            this.labelACTUALCDRJUNGLE.AutoSize = true;
            this.labelACTUALCDRJUNGLE.Location = new Point(71, 3);
            this.labelACTUALCDRJUNGLE.Name = "labelACTUALCDRJUNGLE";
            this.labelACTUALCDRJUNGLE.Size = new Size(18, 19);
            this.labelACTUALCDRJUNGLE.TabIndex = 25;
            this.labelACTUALCDRJUNGLE.Text = "1";
            // 
            // comboBoxSST2TYPEJUNGLE
            // 
            this.comboBoxSST2TYPEJUNGLE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST2TYPEJUNGLE.FormattingEnabled = true;
            this.comboBoxSST2TYPEJUNGLE.Location = new Point(164, 46);
            this.comboBoxSST2TYPEJUNGLE.Name = "comboBoxSST2TYPEJUNGLE";
            this.comboBoxSST2TYPEJUNGLE.Size = new Size(81, 27);
            this.comboBoxSST2TYPEJUNGLE.TabIndex = 24;
            this.comboBoxSST2TYPEJUNGLE.Visible = false;
            this.comboBoxSST2TYPEJUNGLE.SelectedIndexChanged += new EventHandler(this.ComboBoxSST2TYPEJUNGLE_SelectedIndexChanged);
            // 
            // comboBoxSST1TYPEJUNGLE
            // 
            this.comboBoxSST1TYPEJUNGLE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST1TYPEJUNGLE.FormattingEnabled = true;
            this.comboBoxSST1TYPEJUNGLE.Location = new Point(164, 13);
            this.comboBoxSST1TYPEJUNGLE.Name = "comboBoxSST1TYPEJUNGLE";
            this.comboBoxSST1TYPEJUNGLE.Size = new Size(81, 27);
            this.comboBoxSST1TYPEJUNGLE.TabIndex = 23;
            this.comboBoxSST1TYPEJUNGLE.Visible = false;
            this.comboBoxSST1TYPEJUNGLE.SelectedIndexChanged += new EventHandler(this.ComboBoxSST1TYPEJUNGLE_SelectedIndexChanged);
            // 
            // buttonSST2JUNGLERESET
            // 
            this.buttonSST2JUNGLERESET.Location = new Point(395, 41);
            this.buttonSST2JUNGLERESET.Name = "buttonSST2JUNGLERESET";
            this.buttonSST2JUNGLERESET.Size = new Size(75, 39);
            this.buttonSST2JUNGLERESET.TabIndex = 21;
            this.buttonSST2JUNGLERESET.Text = "RESET";
            this.buttonSST2JUNGLERESET.UseVisualStyleBackColor = true;
            this.buttonSST2JUNGLERESET.Click += new EventHandler(this.ButtonSST2JUNGLERESET_Click);
            // 
            // buttonSST2JUNGLESTART
            // 
            this.buttonSST2JUNGLESTART.Location = new Point(314, 41);
            this.buttonSST2JUNGLESTART.Name = "buttonSST2JUNGLESTART";
            this.buttonSST2JUNGLESTART.Size = new Size(75, 39);
            this.buttonSST2JUNGLESTART.TabIndex = 22;
            this.buttonSST2JUNGLESTART.Text = "START";
            this.buttonSST2JUNGLESTART.UseVisualStyleBackColor = true;
            this.buttonSST2JUNGLESTART.Click += new EventHandler(this.ButtonSST2JUNGLESTART_Click);
            // 
            // buttonSST1JUNGLESTART
            // 
            this.buttonSST1JUNGLESTART.Location = new Point(314, 0);
            this.buttonSST1JUNGLESTART.Name = "buttonSST1JUNGLESTART";
            this.buttonSST1JUNGLESTART.Size = new Size(75, 39);
            this.buttonSST1JUNGLESTART.TabIndex = 20;
            this.buttonSST1JUNGLESTART.Text = "START";
            this.buttonSST1JUNGLESTART.UseVisualStyleBackColor = true;
            this.buttonSST1JUNGLESTART.Click += new EventHandler(this.ButtonSST1JUNGLESTART_Click);
            // 
            // buttonSST1JUNGLERESET
            // 
            this.buttonSST1JUNGLERESET.Location = new Point(395, 0);
            this.buttonSST1JUNGLERESET.Name = "buttonSST1JUNGLERESET";
            this.buttonSST1JUNGLERESET.Size = new Size(75, 39);
            this.buttonSST1JUNGLERESET.TabIndex = 19;
            this.buttonSST1JUNGLERESET.Text = "RESET";
            this.buttonSST1JUNGLERESET.UseVisualStyleBackColor = true;
            this.buttonSST1JUNGLERESET.Click += new EventHandler(this.ButtonSST1JUNGLERESET_Click);
            // 
            // labelSST2TYPEJUNGLE
            // 
            this.labelSST2TYPEJUNGLE.AutoSize = true;
            this.labelSST2TYPEJUNGLE.Location = new Point(164, 49);
            this.labelSST2TYPEJUNGLE.Name = "labelSST2TYPEJUNGLE";
            this.labelSST2TYPEJUNGLE.Size = new Size(48, 19);
            this.labelSST2TYPEJUNGLE.TabIndex = 18;
            this.labelSST2TYPEJUNGLE.Text = "Ignite";
            this.labelSST2TYPEJUNGLE.DoubleClick += new EventHandler(this.LabelSST2TYPEJUNGLE_DoubleClick);
            // 
            // labelSST1TYPEJUNGLE
            // 
            this.labelSST1TYPEJUNGLE.AutoSize = true;
            this.labelSST1TYPEJUNGLE.Location = new Point(164, 16);
            this.labelSST1TYPEJUNGLE.Name = "labelSST1TYPEJUNGLE";
            this.labelSST1TYPEJUNGLE.Size = new Size(46, 19);
            this.labelSST1TYPEJUNGLE.TabIndex = 17;
            this.labelSST1TYPEJUNGLE.Text = "Flash";
            this.labelSST1TYPEJUNGLE.DoubleClick += new EventHandler(this.LabelSST1TYPEJUNGLE_DoubleClick);
            // 
            // comboBoxCDRJUNGLECHANGE
            // 
            this.comboBoxCDRJUNGLECHANGE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCDRJUNGLECHANGE.FormattingEnabled = true;
            this.comboBoxCDRJUNGLECHANGE.Items.AddRange(new object[] {
            "0%",
            "5%",
            "25%",
            "30%"});
            this.comboBoxCDRJUNGLECHANGE.Location = new Point(50, 45);
            this.comboBoxCDRJUNGLECHANGE.Name = "comboBoxCDRJUNGLECHANGE";
            this.comboBoxCDRJUNGLECHANGE.Size = new Size(53, 27);
            this.comboBoxCDRJUNGLECHANGE.TabIndex = 15;
            this.comboBoxCDRJUNGLECHANGE.Visible = false;
            this.comboBoxCDRJUNGLECHANGE.SelectedIndexChanged += new EventHandler(this.ComboBoxCDRJUNGLECHANGE_SelectedIndexChanged);
            // 
            // checkBoxSHOESJUNGLE
            // 
            this.checkBoxSHOESJUNGLE.AutoSize = true;
            this.checkBoxSHOESJUNGLE.Location = new Point(20, 20);
            this.checkBoxSHOESJUNGLE.Name = "checkBoxSHOESJUNGLE";
            this.checkBoxSHOESJUNGLE.Size = new Size(69, 23);
            this.checkBoxSHOESJUNGLE.TabIndex = 13;
            this.checkBoxSHOESJUNGLE.Text = "Shoes";
            this.checkBoxSHOESJUNGLE.UseVisualStyleBackColor = true;
            this.checkBoxSHOESJUNGLE.CheckedChanged += new EventHandler(this.CheckBoxSHOESJUNGLE_CheckedChanged);
            // 
            // labelSST2JUNGLETIME
            // 
            this.labelSST2JUNGLETIME.AutoSize = true;
            this.labelSST2JUNGLETIME.Location = new Point(265, 48);
            this.labelSST2JUNGLETIME.Name = "labelSST2JUNGLETIME";
            this.labelSST2JUNGLETIME.Size = new Size(18, 19);
            this.labelSST2JUNGLETIME.TabIndex = 8;
            this.labelSST2JUNGLETIME.Text = "0";
            // 
            // labelSST1JUNGLETIME
            // 
            this.labelSST1JUNGLETIME.AutoSize = true;
            this.labelSST1JUNGLETIME.Location = new Point(265, 16);
            this.labelSST1JUNGLETIME.Name = "labelSST1JUNGLETIME";
            this.labelSST1JUNGLETIME.Size = new Size(18, 19);
            this.labelSST1JUNGLETIME.TabIndex = 7;
            this.labelSST1JUNGLETIME.Text = "0";
            // 
            // labelSST2JUNGLE
            // 
            this.labelSST2JUNGLE.AutoSize = true;
            this.labelSST2JUNGLE.Location = new Point(111, 49);
            this.labelSST2JUNGLE.Name = "labelSST2JUNGLE";
            this.labelSST2JUNGLE.Size = new Size(47, 19);
            this.labelSST2JUNGLE.TabIndex = 6;
            this.labelSST2JUNGLE.Text = "SST2:";
            // 
            // labelSST1JUNGLE
            // 
            this.labelSST1JUNGLE.AutoSize = true;
            this.labelSST1JUNGLE.Location = new Point(111, 16);
            this.labelSST1JUNGLE.Name = "labelSST1JUNGLE";
            this.labelSST1JUNGLE.Size = new Size(47, 19);
            this.labelSST1JUNGLE.TabIndex = 5;
            this.labelSST1JUNGLE.Text = "SST1:";
            // 
            // labelCDRPERCENTJUNGLE
            // 
            this.labelCDRPERCENTJUNGLE.AutoSize = true;
            this.labelCDRPERCENTJUNGLE.Location = new Point(48, 48);
            this.labelCDRPERCENTJUNGLE.Name = "labelCDRPERCENTJUNGLE";
            this.labelCDRPERCENTJUNGLE.Size = new Size(32, 19);
            this.labelCDRPERCENTJUNGLE.TabIndex = 3;
            this.labelCDRPERCENTJUNGLE.Text = "0%";
            this.labelCDRPERCENTJUNGLE.TextChanged += new EventHandler(this.LabelCDRPERCENTJUNGLE_TextChanged);
            this.labelCDRPERCENTJUNGLE.DoubleClick += new EventHandler(this.LabelCDRPERCENTJUNGLE_DoubleClick);
            // 
            // labelCDRJUNGLE
            // 
            this.labelCDRJUNGLE.AutoSize = true;
            this.labelCDRJUNGLE.Location = new Point(3, 48);
            this.labelCDRJUNGLE.Name = "labelCDRJUNGLE";
            this.labelCDRJUNGLE.Size = new Size(47, 19);
            this.labelCDRJUNGLE.TabIndex = 2;
            this.labelCDRJUNGLE.Text = "CDR: ";
            // 
            // LabelJUNGLE
            // 
            this.LabelJUNGLE.AutoSize = true;
            this.LabelJUNGLE.ForeColor = SystemColors.Control;
            this.LabelJUNGLE.Location = new Point(3, 3);
            this.LabelJUNGLE.Name = "LabelJUNGLE";
            this.LabelJUNGLE.Size = new Size(63, 19);
            this.LabelJUNGLE.TabIndex = 1;
            this.LabelJUNGLE.Text = "JUNGLE";
            // 
            // panelMID
            // 
            this.panelMID.Controls.Add(this.labelACTUALCDRMID);
            this.panelMID.Controls.Add(this.comboBoxSST2TYPEMID);
            this.panelMID.Controls.Add(this.comboBoxSST1TYPEMID);
            this.panelMID.Controls.Add(this.buttonSST2MIDRESET);
            this.panelMID.Controls.Add(this.buttonSST2MIDSTART);
            this.panelMID.Controls.Add(this.buttonSST1MIDSTART);
            this.panelMID.Controls.Add(this.buttonSST1MIDRESET);
            this.panelMID.Controls.Add(this.labelSST2TYPEMID);
            this.panelMID.Controls.Add(this.labelSST1TYPEMID);
            this.panelMID.Controls.Add(this.comboBoxCDRMIDCHANGE);
            this.panelMID.Controls.Add(this.checkBoxSHOESMID);
            this.panelMID.Controls.Add(this.labelSST2MIDTIME);
            this.panelMID.Controls.Add(this.labelSST1MIDTIME);
            this.panelMID.Controls.Add(this.labelSST2MID);
            this.panelMID.Controls.Add(this.labelSST1MID);
            this.panelMID.Controls.Add(this.labelCDRPERCENTMID);
            this.panelMID.Controls.Add(this.labelCDRMID);
            this.panelMID.Controls.Add(this.labelMID);
            this.panelMID.Dock = DockStyle.Top;
            this.panelMID.Location = new Point(130, 160);
            this.panelMID.Name = "panelMID";
            this.panelMID.Size = new Size(477, 80);
            this.panelMID.TabIndex = 3;
            // 
            // labelACTUALCDRMID
            // 
            this.labelACTUALCDRMID.AutoSize = true;
            this.labelACTUALCDRMID.Location = new Point(47, 3);
            this.labelACTUALCDRMID.Name = "labelACTUALCDRMID";
            this.labelACTUALCDRMID.Size = new Size(18, 19);
            this.labelACTUALCDRMID.TabIndex = 25;
            this.labelACTUALCDRMID.Text = "1";
            // 
            // comboBoxSST2TYPEMID
            // 
            this.comboBoxSST2TYPEMID.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST2TYPEMID.FormattingEnabled = true;
            this.comboBoxSST2TYPEMID.Location = new Point(164, 45);
            this.comboBoxSST2TYPEMID.Name = "comboBoxSST2TYPEMID";
            this.comboBoxSST2TYPEMID.Size = new Size(81, 27);
            this.comboBoxSST2TYPEMID.TabIndex = 24;
            this.comboBoxSST2TYPEMID.Visible = false;
            this.comboBoxSST2TYPEMID.SelectedIndexChanged += new EventHandler(this.ComboBoxSST2TYPEMID_SelectedIndexChanged);
            // 
            // comboBoxSST1TYPEMID
            // 
            this.comboBoxSST1TYPEMID.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST1TYPEMID.FormattingEnabled = true;
            this.comboBoxSST1TYPEMID.Location = new Point(164, 12);
            this.comboBoxSST1TYPEMID.Name = "comboBoxSST1TYPEMID";
            this.comboBoxSST1TYPEMID.Size = new Size(81, 27);
            this.comboBoxSST1TYPEMID.TabIndex = 23;
            this.comboBoxSST1TYPEMID.Visible = false;
            this.comboBoxSST1TYPEMID.SelectedIndexChanged += new EventHandler(this.ComboBoxSST1TYPEMID_SelectedIndexChanged);
            // 
            // buttonSST2MIDRESET
            // 
            this.buttonSST2MIDRESET.Location = new Point(395, 41);
            this.buttonSST2MIDRESET.Name = "buttonSST2MIDRESET";
            this.buttonSST2MIDRESET.Size = new Size(75, 39);
            this.buttonSST2MIDRESET.TabIndex = 21;
            this.buttonSST2MIDRESET.Text = "RESET";
            this.buttonSST2MIDRESET.UseVisualStyleBackColor = true;
            this.buttonSST2MIDRESET.Click += new EventHandler(this.ButtonSST2MIDRESET_Click);
            // 
            // buttonSST2MIDSTART
            // 
            this.buttonSST2MIDSTART.Location = new Point(314, 41);
            this.buttonSST2MIDSTART.Name = "buttonSST2MIDSTART";
            this.buttonSST2MIDSTART.Size = new Size(75, 39);
            this.buttonSST2MIDSTART.TabIndex = 22;
            this.buttonSST2MIDSTART.Text = "START";
            this.buttonSST2MIDSTART.UseVisualStyleBackColor = true;
            this.buttonSST2MIDSTART.Click += new EventHandler(this.ButtonSST2MIDSTART_Click);
            // 
            // buttonSST1MIDSTART
            // 
            this.buttonSST1MIDSTART.Location = new Point(314, 0);
            this.buttonSST1MIDSTART.Name = "buttonSST1MIDSTART";
            this.buttonSST1MIDSTART.Size = new Size(75, 39);
            this.buttonSST1MIDSTART.TabIndex = 20;
            this.buttonSST1MIDSTART.Text = "START";
            this.buttonSST1MIDSTART.UseVisualStyleBackColor = true;
            this.buttonSST1MIDSTART.Click += new EventHandler(this.ButtonSST1MIDSTART_Click);
            // 
            // buttonSST1MIDRESET
            // 
            this.buttonSST1MIDRESET.Location = new Point(395, 0);
            this.buttonSST1MIDRESET.Name = "buttonSST1MIDRESET";
            this.buttonSST1MIDRESET.Size = new Size(75, 39);
            this.buttonSST1MIDRESET.TabIndex = 19;
            this.buttonSST1MIDRESET.Text = "RESET";
            this.buttonSST1MIDRESET.UseVisualStyleBackColor = true;
            this.buttonSST1MIDRESET.Click += new EventHandler(this.ButtonSST1MIDRESET_Click);
            // 
            // labelSST2TYPEMID
            // 
            this.labelSST2TYPEMID.AutoSize = true;
            this.labelSST2TYPEMID.Location = new Point(164, 48);
            this.labelSST2TYPEMID.Name = "labelSST2TYPEMID";
            this.labelSST2TYPEMID.Size = new Size(48, 19);
            this.labelSST2TYPEMID.TabIndex = 18;
            this.labelSST2TYPEMID.Text = "Ignite";
            this.labelSST2TYPEMID.DoubleClick += new EventHandler(this.LabelSST2TYPEMID_DoubleClick);
            // 
            // labelSST1TYPEMID
            // 
            this.labelSST1TYPEMID.AutoSize = true;
            this.labelSST1TYPEMID.Location = new Point(164, 15);
            this.labelSST1TYPEMID.Name = "labelSST1TYPEMID";
            this.labelSST1TYPEMID.Size = new Size(46, 19);
            this.labelSST1TYPEMID.TabIndex = 17;
            this.labelSST1TYPEMID.Text = "Flash";
            this.labelSST1TYPEMID.DoubleClick += new EventHandler(this.LabelSST1TYPEMID_DoubleClick);
            // 
            // comboBoxCDRMIDCHANGE
            // 
            this.comboBoxCDRMIDCHANGE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCDRMIDCHANGE.FormattingEnabled = true;
            this.comboBoxCDRMIDCHANGE.Items.AddRange(new object[] {
            "0%",
            "5%",
            "25%",
            "30%"});
            this.comboBoxCDRMIDCHANGE.Location = new Point(50, 43);
            this.comboBoxCDRMIDCHANGE.Name = "comboBoxCDRMIDCHANGE";
            this.comboBoxCDRMIDCHANGE.Size = new Size(53, 27);
            this.comboBoxCDRMIDCHANGE.TabIndex = 15;
            this.comboBoxCDRMIDCHANGE.Visible = false;
            this.comboBoxCDRMIDCHANGE.SelectedIndexChanged += new EventHandler(this.ComboBoxCDRMIDCHANGE_SelectedIndexChanged);
            // 
            // checkBoxSHOESMID
            // 
            this.checkBoxSHOESMID.AutoSize = true;
            this.checkBoxSHOESMID.Location = new Point(26, 25);
            this.checkBoxSHOESMID.Name = "checkBoxSHOESMID";
            this.checkBoxSHOESMID.Size = new Size(69, 23);
            this.checkBoxSHOESMID.TabIndex = 13;
            this.checkBoxSHOESMID.Text = "Shoes";
            this.checkBoxSHOESMID.UseVisualStyleBackColor = true;
            this.checkBoxSHOESMID.CheckedChanged += new EventHandler(this.CheckBoxSHOESMID_CheckedChanged);
            // 
            // labelSST2MIDTIME
            // 
            this.labelSST2MIDTIME.AutoSize = true;
            this.labelSST2MIDTIME.Location = new Point(265, 46);
            this.labelSST2MIDTIME.Name = "labelSST2MIDTIME";
            this.labelSST2MIDTIME.Size = new Size(18, 19);
            this.labelSST2MIDTIME.TabIndex = 8;
            this.labelSST2MIDTIME.Text = "0";
            // 
            // labelSST1MIDTIME
            // 
            this.labelSST1MIDTIME.AutoSize = true;
            this.labelSST1MIDTIME.Location = new Point(265, 15);
            this.labelSST1MIDTIME.Name = "labelSST1MIDTIME";
            this.labelSST1MIDTIME.Size = new Size(18, 19);
            this.labelSST1MIDTIME.TabIndex = 7;
            this.labelSST1MIDTIME.Text = "0";
            // 
            // labelSST2MID
            // 
            this.labelSST2MID.AutoSize = true;
            this.labelSST2MID.Location = new Point(111, 48);
            this.labelSST2MID.Name = "labelSST2MID";
            this.labelSST2MID.Size = new Size(47, 19);
            this.labelSST2MID.TabIndex = 6;
            this.labelSST2MID.Text = "SST2:";
            // 
            // labelSST1MID
            // 
            this.labelSST1MID.AutoSize = true;
            this.labelSST1MID.Location = new Point(111, 15);
            this.labelSST1MID.Name = "labelSST1MID";
            this.labelSST1MID.Size = new Size(47, 19);
            this.labelSST1MID.TabIndex = 5;
            this.labelSST1MID.Text = "SST1:";
            // 
            // labelCDRPERCENTMID
            // 
            this.labelCDRPERCENTMID.AutoSize = true;
            this.labelCDRPERCENTMID.Location = new Point(48, 46);
            this.labelCDRPERCENTMID.Name = "labelCDRPERCENTMID";
            this.labelCDRPERCENTMID.Size = new Size(32, 19);
            this.labelCDRPERCENTMID.TabIndex = 4;
            this.labelCDRPERCENTMID.Text = "0%";
            this.labelCDRPERCENTMID.TextChanged += new EventHandler(this.LabelCDRPERCENTMID_TextChanged);
            this.labelCDRPERCENTMID.DoubleClick += new EventHandler(this.LabelCDRPERCENTMID_DoubleClick);
            // 
            // labelCDRMID
            // 
            this.labelCDRMID.AutoSize = true;
            this.labelCDRMID.Location = new Point(3, 46);
            this.labelCDRMID.Name = "labelCDRMID";
            this.labelCDRMID.Size = new Size(47, 19);
            this.labelCDRMID.TabIndex = 3;
            this.labelCDRMID.Text = "CDR: ";
            // 
            // labelMID
            // 
            this.labelMID.AutoSize = true;
            this.labelMID.ForeColor = SystemColors.Control;
            this.labelMID.Location = new Point(3, 3);
            this.labelMID.Name = "labelMID";
            this.labelMID.Size = new Size(38, 19);
            this.labelMID.TabIndex = 2;
            this.labelMID.Text = "MID";
            // 
            // panelADC
            // 
            this.panelADC.Controls.Add(this.labelACTUALCDRADC);
            this.panelADC.Controls.Add(this.comboBoxSST2TYPEADC);
            this.panelADC.Controls.Add(this.comboBoxSST1TYPEADC);
            this.panelADC.Controls.Add(this.buttonSST2ADCRESET);
            this.panelADC.Controls.Add(this.buttonSST2ADCSTART);
            this.panelADC.Controls.Add(this.buttonSST1ADCSTART);
            this.panelADC.Controls.Add(this.buttonSST1ADCRESET);
            this.panelADC.Controls.Add(this.labelSST2TYPEADC);
            this.panelADC.Controls.Add(this.labelSST1TYPEADC);
            this.panelADC.Controls.Add(this.comboBoxCDRADCCHANGE);
            this.panelADC.Controls.Add(this.checkBoxSHOESADC);
            this.panelADC.Controls.Add(this.labelSST2ADCTIME);
            this.panelADC.Controls.Add(this.labelSST1ADCTIME);
            this.panelADC.Controls.Add(this.labelSST2ADC);
            this.panelADC.Controls.Add(this.labelSST1ADC);
            this.panelADC.Controls.Add(this.labelCDRPERCENTADC);
            this.panelADC.Controls.Add(this.labelCDRADC);
            this.panelADC.Controls.Add(this.labelADC);
            this.panelADC.Dock = DockStyle.Top;
            this.panelADC.Location = new Point(130, 240);
            this.panelADC.Name = "panelADC";
            this.panelADC.Size = new Size(477, 80);
            this.panelADC.TabIndex = 4;
            // 
            // labelACTUALCDRADC
            // 
            this.labelACTUALCDRADC.AutoSize = true;
            this.labelACTUALCDRADC.Location = new Point(48, 3);
            this.labelACTUALCDRADC.Name = "labelACTUALCDRADC";
            this.labelACTUALCDRADC.Size = new Size(18, 19);
            this.labelACTUALCDRADC.TabIndex = 27;
            this.labelACTUALCDRADC.Text = "1";
            // 
            // comboBoxSST2TYPEADC
            // 
            this.comboBoxSST2TYPEADC.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST2TYPEADC.FormattingEnabled = true;
            this.comboBoxSST2TYPEADC.Location = new Point(164, 51);
            this.comboBoxSST2TYPEADC.Name = "comboBoxSST2TYPEADC";
            this.comboBoxSST2TYPEADC.Size = new Size(81, 27);
            this.comboBoxSST2TYPEADC.TabIndex = 26;
            this.comboBoxSST2TYPEADC.Visible = false;
            this.comboBoxSST2TYPEADC.SelectedIndexChanged += new EventHandler(this.ComboBoxSST2TYPEADC_SelectedIndexChanged);
            // 
            // comboBoxSST1TYPEADC
            // 
            this.comboBoxSST1TYPEADC.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST1TYPEADC.FormattingEnabled = true;
            this.comboBoxSST1TYPEADC.Location = new Point(164, 18);
            this.comboBoxSST1TYPEADC.Name = "comboBoxSST1TYPEADC";
            this.comboBoxSST1TYPEADC.Size = new Size(81, 27);
            this.comboBoxSST1TYPEADC.TabIndex = 25;
            this.comboBoxSST1TYPEADC.Visible = false;
            this.comboBoxSST1TYPEADC.SelectedIndexChanged += new EventHandler(this.ComboBoxSST1TYPEADC_SelectedIndexChanged);
            // 
            // buttonSST2ADCRESET
            // 
            this.buttonSST2ADCRESET.Location = new Point(395, 41);
            this.buttonSST2ADCRESET.Name = "buttonSST2ADCRESET";
            this.buttonSST2ADCRESET.Size = new Size(75, 39);
            this.buttonSST2ADCRESET.TabIndex = 21;
            this.buttonSST2ADCRESET.Text = "RESET";
            this.buttonSST2ADCRESET.UseVisualStyleBackColor = true;
            this.buttonSST2ADCRESET.Click += new EventHandler(this.ButtonSST2ADCRESET_Click);
            // 
            // buttonSST2ADCSTART
            // 
            this.buttonSST2ADCSTART.Location = new Point(314, 41);
            this.buttonSST2ADCSTART.Name = "buttonSST2ADCSTART";
            this.buttonSST2ADCSTART.Size = new Size(75, 39);
            this.buttonSST2ADCSTART.TabIndex = 22;
            this.buttonSST2ADCSTART.Text = "START";
            this.buttonSST2ADCSTART.UseVisualStyleBackColor = true;
            this.buttonSST2ADCSTART.Click += new EventHandler(this.ButtonSST2ADCSTART_Click);
            // 
            // buttonSST1ADCSTART
            // 
            this.buttonSST1ADCSTART.Location = new Point(314, 0);
            this.buttonSST1ADCSTART.Name = "buttonSST1ADCSTART";
            this.buttonSST1ADCSTART.Size = new Size(75, 39);
            this.buttonSST1ADCSTART.TabIndex = 20;
            this.buttonSST1ADCSTART.Text = "START";
            this.buttonSST1ADCSTART.UseVisualStyleBackColor = true;
            this.buttonSST1ADCSTART.Click += new EventHandler(this.ButtonSST1ADCSTART_Click);
            // 
            // buttonSST1ADCRESET
            // 
            this.buttonSST1ADCRESET.Location = new Point(395, 0);
            this.buttonSST1ADCRESET.Name = "buttonSST1ADCRESET";
            this.buttonSST1ADCRESET.Size = new Size(75, 39);
            this.buttonSST1ADCRESET.TabIndex = 19;
            this.buttonSST1ADCRESET.Text = "RESET";
            this.buttonSST1ADCRESET.UseVisualStyleBackColor = true;
            this.buttonSST1ADCRESET.Click += new EventHandler(this.ButtonSST1ADCRESET_Click);
            // 
            // labelSST2TYPEADC
            // 
            this.labelSST2TYPEADC.AutoSize = true;
            this.labelSST2TYPEADC.Location = new Point(164, 54);
            this.labelSST2TYPEADC.Name = "labelSST2TYPEADC";
            this.labelSST2TYPEADC.Size = new Size(48, 19);
            this.labelSST2TYPEADC.TabIndex = 18;
            this.labelSST2TYPEADC.Text = "Ignite";
            this.labelSST2TYPEADC.DoubleClick += new EventHandler(this.LabelSST2TYPEADC_DoubleClick);
            // 
            // labelSST1TYPEADC
            // 
            this.labelSST1TYPEADC.AutoSize = true;
            this.labelSST1TYPEADC.Location = new Point(164, 21);
            this.labelSST1TYPEADC.Name = "labelSST1TYPEADC";
            this.labelSST1TYPEADC.Size = new Size(46, 19);
            this.labelSST1TYPEADC.TabIndex = 17;
            this.labelSST1TYPEADC.Text = "Flash";
            this.labelSST1TYPEADC.DoubleClick += new EventHandler(this.LabelSST1TYPEADC_DoubleClick);
            // 
            // comboBoxCDRADCCHANGE
            // 
            this.comboBoxCDRADCCHANGE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCDRADCCHANGE.FormattingEnabled = true;
            this.comboBoxCDRADCCHANGE.Items.AddRange(new object[] {
            "0%",
            "5%",
            "25%",
            "30%"});
            this.comboBoxCDRADCCHANGE.Location = new Point(50, 42);
            this.comboBoxCDRADCCHANGE.Name = "comboBoxCDRADCCHANGE";
            this.comboBoxCDRADCCHANGE.Size = new Size(53, 27);
            this.comboBoxCDRADCCHANGE.TabIndex = 15;
            this.comboBoxCDRADCCHANGE.Visible = false;
            this.comboBoxCDRADCCHANGE.SelectedIndexChanged += new EventHandler(this.ComboBoxCDRADCCHANGE_SelectedIndexChanged);
            // 
            // checkBoxSHOESADC
            // 
            this.checkBoxSHOESADC.AutoSize = true;
            this.checkBoxSHOESADC.Location = new Point(26, 22);
            this.checkBoxSHOESADC.Name = "checkBoxSHOESADC";
            this.checkBoxSHOESADC.Size = new Size(69, 23);
            this.checkBoxSHOESADC.TabIndex = 13;
            this.checkBoxSHOESADC.Text = "Shoes";
            this.checkBoxSHOESADC.UseVisualStyleBackColor = true;
            this.checkBoxSHOESADC.CheckedChanged += new EventHandler(this.CheckBoxSHOESADC_CheckedChanged);
            // 
            // labelSST2ADCTIME
            // 
            this.labelSST2ADCTIME.AutoSize = true;
            this.labelSST2ADCTIME.Location = new Point(265, 54);
            this.labelSST2ADCTIME.Name = "labelSST2ADCTIME";
            this.labelSST2ADCTIME.Size = new Size(18, 19);
            this.labelSST2ADCTIME.TabIndex = 9;
            this.labelSST2ADCTIME.Text = "0";
            // 
            // labelSST1ADCTIME
            // 
            this.labelSST1ADCTIME.AutoSize = true;
            this.labelSST1ADCTIME.Location = new Point(265, 21);
            this.labelSST1ADCTIME.Name = "labelSST1ADCTIME";
            this.labelSST1ADCTIME.Size = new Size(18, 19);
            this.labelSST1ADCTIME.TabIndex = 8;
            this.labelSST1ADCTIME.Text = "0";
            // 
            // labelSST2ADC
            // 
            this.labelSST2ADC.AutoSize = true;
            this.labelSST2ADC.Location = new Point(111, 54);
            this.labelSST2ADC.Name = "labelSST2ADC";
            this.labelSST2ADC.Size = new Size(47, 19);
            this.labelSST2ADC.TabIndex = 7;
            this.labelSST2ADC.Text = "SST2:";
            // 
            // labelSST1ADC
            // 
            this.labelSST1ADC.AutoSize = true;
            this.labelSST1ADC.Location = new Point(111, 21);
            this.labelSST1ADC.Name = "labelSST1ADC";
            this.labelSST1ADC.Size = new Size(47, 19);
            this.labelSST1ADC.TabIndex = 6;
            this.labelSST1ADC.Text = "SST1:";
            // 
            // labelCDRPERCENTADC
            // 
            this.labelCDRPERCENTADC.AutoSize = true;
            this.labelCDRPERCENTADC.Location = new Point(48, 45);
            this.labelCDRPERCENTADC.Name = "labelCDRPERCENTADC";
            this.labelCDRPERCENTADC.Size = new Size(32, 19);
            this.labelCDRPERCENTADC.TabIndex = 5;
            this.labelCDRPERCENTADC.Text = "0%";
            this.labelCDRPERCENTADC.TextChanged += new EventHandler(this.LabelCDRPERCENTADC_TextChanged);
            this.labelCDRPERCENTADC.DoubleClick += new EventHandler(this.LabelCDRPERCENTADC_DoubleClick);
            // 
            // labelCDRADC
            // 
            this.labelCDRADC.AutoSize = true;
            this.labelCDRADC.Location = new Point(3, 45);
            this.labelCDRADC.Name = "labelCDRADC";
            this.labelCDRADC.Size = new Size(47, 19);
            this.labelCDRADC.TabIndex = 4;
            this.labelCDRADC.Text = "CDR: ";
            // 
            // labelADC
            // 
            this.labelADC.AutoSize = true;
            this.labelADC.ForeColor = SystemColors.Control;
            this.labelADC.Location = new Point(3, 3);
            this.labelADC.Name = "labelADC";
            this.labelADC.Size = new Size(39, 19);
            this.labelADC.TabIndex = 3;
            this.labelADC.Text = "ADC";
            // 
            // panelSUPPORT
            // 
            this.panelSUPPORT.Controls.Add(this.labelACTUALCDRSUPPORT);
            this.panelSUPPORT.Controls.Add(this.comboBoxSST2TYPESUPPORT);
            this.panelSUPPORT.Controls.Add(this.comboBoxSST1TYPESUPPORT);
            this.panelSUPPORT.Controls.Add(this.buttonSST2SUPPORTRESET);
            this.panelSUPPORT.Controls.Add(this.buttonSST2SUPPORTSTART);
            this.panelSUPPORT.Controls.Add(this.buttonSST1SUPPORTSTART);
            this.panelSUPPORT.Controls.Add(this.buttonSST1SUPPORTRESET);
            this.panelSUPPORT.Controls.Add(this.labelSST2TYPESUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelSST1TYPESUPPORT);
            this.panelSUPPORT.Controls.Add(this.comboBoxCDRSUPPORTCHANGE);
            this.panelSUPPORT.Controls.Add(this.checkBoxSHOESSUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelSST2SUPPORTTIME);
            this.panelSUPPORT.Controls.Add(this.labelSST1SUPPORTTIME);
            this.panelSUPPORT.Controls.Add(this.labelSST2SUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelCDRPERCENTSUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelSST1SUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelCDRSUPPORT);
            this.panelSUPPORT.Controls.Add(this.labelSUPPORT);
            this.panelSUPPORT.Dock = DockStyle.Top;
            this.panelSUPPORT.Location = new Point(130, 320);
            this.panelSUPPORT.Name = "panelSUPPORT";
            this.panelSUPPORT.Size = new Size(477, 80);
            this.panelSUPPORT.TabIndex = 5;
            // 
            // labelACTUALCDRSUPPORT
            // 
            this.labelACTUALCDRSUPPORT.AutoSize = true;
            this.labelACTUALCDRSUPPORT.Location = new Point(77, 3);
            this.labelACTUALCDRSUPPORT.Name = "labelACTUALCDRSUPPORT";
            this.labelACTUALCDRSUPPORT.Size = new Size(18, 19);
            this.labelACTUALCDRSUPPORT.TabIndex = 28;
            this.labelACTUALCDRSUPPORT.Text = "1";
            // 
            // comboBoxSST2TYPESUPPORT
            // 
            this.comboBoxSST2TYPESUPPORT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST2TYPESUPPORT.FormattingEnabled = true;
            this.comboBoxSST2TYPESUPPORT.Location = new Point(164, 50);
            this.comboBoxSST2TYPESUPPORT.Name = "comboBoxSST2TYPESUPPORT";
            this.comboBoxSST2TYPESUPPORT.Size = new Size(81, 27);
            this.comboBoxSST2TYPESUPPORT.TabIndex = 24;
            this.comboBoxSST2TYPESUPPORT.Visible = false;
            this.comboBoxSST2TYPESUPPORT.SelectedIndexChanged += new EventHandler(this.ComboBoxSST2TYPESUPPORT_SelectedIndexChanged);
            // 
            // comboBoxSST1TYPESUPPORT
            // 
            this.comboBoxSST1TYPESUPPORT.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSST1TYPESUPPORT.FormattingEnabled = true;
            this.comboBoxSST1TYPESUPPORT.Location = new Point(164, 18);
            this.comboBoxSST1TYPESUPPORT.Name = "comboBoxSST1TYPESUPPORT";
            this.comboBoxSST1TYPESUPPORT.Size = new Size(81, 27);
            this.comboBoxSST1TYPESUPPORT.TabIndex = 23;
            this.comboBoxSST1TYPESUPPORT.Visible = false;
            this.comboBoxSST1TYPESUPPORT.SelectedIndexChanged += new EventHandler(this.ComboBoxSST1TYPESUPPORT_SelectedIndexChanged);
            // 
            // buttonSST2SUPPORTRESET
            // 
            this.buttonSST2SUPPORTRESET.Location = new Point(395, 41);
            this.buttonSST2SUPPORTRESET.Name = "buttonSST2SUPPORTRESET";
            this.buttonSST2SUPPORTRESET.Size = new Size(75, 39);
            this.buttonSST2SUPPORTRESET.TabIndex = 21;
            this.buttonSST2SUPPORTRESET.Text = "RESET";
            this.buttonSST2SUPPORTRESET.UseVisualStyleBackColor = true;
            this.buttonSST2SUPPORTRESET.Click += new EventHandler(this.ButtonSST2SUPPORTRESET_Click);
            // 
            // buttonSST2SUPPORTSTART
            // 
            this.buttonSST2SUPPORTSTART.Location = new Point(314, 41);
            this.buttonSST2SUPPORTSTART.Name = "buttonSST2SUPPORTSTART";
            this.buttonSST2SUPPORTSTART.Size = new Size(75, 39);
            this.buttonSST2SUPPORTSTART.TabIndex = 22;
            this.buttonSST2SUPPORTSTART.Text = "START";
            this.buttonSST2SUPPORTSTART.UseVisualStyleBackColor = true;
            this.buttonSST2SUPPORTSTART.Click += new EventHandler(this.ButtonSST2SUPPORTSTART_Click);
            // 
            // buttonSST1SUPPORTSTART
            // 
            this.buttonSST1SUPPORTSTART.Location = new Point(314, 0);
            this.buttonSST1SUPPORTSTART.Name = "buttonSST1SUPPORTSTART";
            this.buttonSST1SUPPORTSTART.Size = new Size(75, 39);
            this.buttonSST1SUPPORTSTART.TabIndex = 20;
            this.buttonSST1SUPPORTSTART.Text = "START";
            this.buttonSST1SUPPORTSTART.UseVisualStyleBackColor = true;
            this.buttonSST1SUPPORTSTART.Click += new EventHandler(this.ButtonSST1SUPPORTSTART_Click);
            // 
            // buttonSST1SUPPORTRESET
            // 
            this.buttonSST1SUPPORTRESET.Location = new Point(395, 0);
            this.buttonSST1SUPPORTRESET.Name = "buttonSST1SUPPORTRESET";
            this.buttonSST1SUPPORTRESET.Size = new Size(75, 39);
            this.buttonSST1SUPPORTRESET.TabIndex = 19;
            this.buttonSST1SUPPORTRESET.Text = "RESET";
            this.buttonSST1SUPPORTRESET.UseVisualStyleBackColor = true;
            this.buttonSST1SUPPORTRESET.Click += new EventHandler(this.ButtonSST1SUPPORTRESET_Click);
            // 
            // labelSST2TYPESUPPORT
            // 
            this.labelSST2TYPESUPPORT.AutoSize = true;
            this.labelSST2TYPESUPPORT.Location = new Point(164, 53);
            this.labelSST2TYPESUPPORT.Name = "labelSST2TYPESUPPORT";
            this.labelSST2TYPESUPPORT.Size = new Size(48, 19);
            this.labelSST2TYPESUPPORT.TabIndex = 18;
            this.labelSST2TYPESUPPORT.Text = "Ignite";
            this.labelSST2TYPESUPPORT.DoubleClick += new EventHandler(this.LabelSST2TYPESUPPORT_DoubleClick);
            // 
            // labelSST1TYPESUPPORT
            // 
            this.labelSST1TYPESUPPORT.AutoSize = true;
            this.labelSST1TYPESUPPORT.Location = new Point(164, 20);
            this.labelSST1TYPESUPPORT.Name = "labelSST1TYPESUPPORT";
            this.labelSST1TYPESUPPORT.Size = new Size(46, 19);
            this.labelSST1TYPESUPPORT.TabIndex = 17;
            this.labelSST1TYPESUPPORT.Text = "Flash";
            this.labelSST1TYPESUPPORT.DoubleClick += new EventHandler(this.LabelSST1TYPESUPPORT_DoubleClick);
            // 
            // comboBoxCDRSUPPORTCHANGE
            // 
            this.comboBoxCDRSUPPORTCHANGE.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCDRSUPPORTCHANGE.FormattingEnabled = true;
            this.comboBoxCDRSUPPORTCHANGE.Items.AddRange(new object[] {
            "0%",
            "5%",
            "25%",
            "30%"});
            this.comboBoxCDRSUPPORTCHANGE.Location = new Point(50, 38);
            this.comboBoxCDRSUPPORTCHANGE.Name = "comboBoxCDRSUPPORTCHANGE";
            this.comboBoxCDRSUPPORTCHANGE.Size = new Size(53, 27);
            this.comboBoxCDRSUPPORTCHANGE.TabIndex = 16;
            this.comboBoxCDRSUPPORTCHANGE.Visible = false;
            this.comboBoxCDRSUPPORTCHANGE.SelectedIndexChanged += new EventHandler(this.ComboBoxCDRSUPPORTCHANGE_SelectedIndexChanged);
            // 
            // checkBoxSHOESSUPPORT
            // 
            this.checkBoxSHOESSUPPORT.AutoSize = true;
            this.checkBoxSHOESSUPPORT.Location = new Point(26, 20);
            this.checkBoxSHOESSUPPORT.Name = "checkBoxSHOESSUPPORT";
            this.checkBoxSHOESSUPPORT.Size = new Size(69, 23);
            this.checkBoxSHOESSUPPORT.TabIndex = 13;
            this.checkBoxSHOESSUPPORT.Text = "Shoes";
            this.checkBoxSHOESSUPPORT.UseVisualStyleBackColor = true;
            this.checkBoxSHOESSUPPORT.CheckedChanged += new EventHandler(this.CheckBoxSHOESSUPPORT_CheckedChanged);
            // 
            // labelSST2SUPPORTTIME
            // 
            this.labelSST2SUPPORTTIME.AutoSize = true;
            this.labelSST2SUPPORTTIME.Location = new Point(265, 53);
            this.labelSST2SUPPORTTIME.Name = "labelSST2SUPPORTTIME";
            this.labelSST2SUPPORTTIME.Size = new Size(18, 19);
            this.labelSST2SUPPORTTIME.TabIndex = 11;
            this.labelSST2SUPPORTTIME.Text = "0";
            // 
            // labelSST1SUPPORTTIME
            // 
            this.labelSST1SUPPORTTIME.AutoSize = true;
            this.labelSST1SUPPORTTIME.Location = new Point(265, 20);
            this.labelSST1SUPPORTTIME.Name = "labelSST1SUPPORTTIME";
            this.labelSST1SUPPORTTIME.Size = new Size(18, 19);
            this.labelSST1SUPPORTTIME.TabIndex = 10;
            this.labelSST1SUPPORTTIME.Text = "0";
            // 
            // labelSST2SUPPORT
            // 
            this.labelSST2SUPPORT.AutoSize = true;
            this.labelSST2SUPPORT.Location = new Point(111, 53);
            this.labelSST2SUPPORT.Name = "labelSST2SUPPORT";
            this.labelSST2SUPPORT.Size = new Size(47, 19);
            this.labelSST2SUPPORT.TabIndex = 9;
            this.labelSST2SUPPORT.Text = "SST2:";
            // 
            // labelCDRPERCENTSUPPORT
            // 
            this.labelCDRPERCENTSUPPORT.AutoSize = true;
            this.labelCDRPERCENTSUPPORT.Location = new Point(48, 41);
            this.labelCDRPERCENTSUPPORT.Name = "labelCDRPERCENTSUPPORT";
            this.labelCDRPERCENTSUPPORT.Size = new Size(32, 19);
            this.labelCDRPERCENTSUPPORT.TabIndex = 6;
            this.labelCDRPERCENTSUPPORT.Text = "0%";
            this.labelCDRPERCENTSUPPORT.TextChanged += new EventHandler(this.LabelCDRPERCENTSUPPORT_TextChanged);
            this.labelCDRPERCENTSUPPORT.DoubleClick += new EventHandler(this.LabelCDRPERCENTSUPPORT_DoubleClick);
            // 
            // labelSST1SUPPORT
            // 
            this.labelSST1SUPPORT.AutoSize = true;
            this.labelSST1SUPPORT.Location = new Point(111, 20);
            this.labelSST1SUPPORT.Name = "labelSST1SUPPORT";
            this.labelSST1SUPPORT.Size = new Size(47, 19);
            this.labelSST1SUPPORT.TabIndex = 8;
            this.labelSST1SUPPORT.Text = "SST1:";
            // 
            // labelCDRSUPPORT
            // 
            this.labelCDRSUPPORT.AutoSize = true;
            this.labelCDRSUPPORT.Location = new Point(3, 41);
            this.labelCDRSUPPORT.Name = "labelCDRSUPPORT";
            this.labelCDRSUPPORT.Size = new Size(47, 19);
            this.labelCDRSUPPORT.TabIndex = 5;
            this.labelCDRSUPPORT.Text = "CDR: ";
            // 
            // labelSUPPORT
            // 
            this.labelSUPPORT.AutoSize = true;
            this.labelSUPPORT.ForeColor = SystemColors.Control;
            this.labelSUPPORT.Location = new Point(3, 3);
            this.labelSUPPORT.Name = "labelSUPPORT";
            this.labelSUPPORT.Size = new Size(74, 19);
            this.labelSUPPORT.TabIndex = 4;
            this.labelSUPPORT.Text = "SUPPORT";
            // 
            // timerBeep
            // 
            this.timerBeep.Interval = 30000;
            this.timerBeep.Tick += new EventHandler(this.Beep);
            // 
            // timerSST1TOP
            // 
            this.timerSST1TOP.Interval = 1000;
            this.timerSST1TOP.Tick += new EventHandler(this.TimerSST1TOP_Tick);
            // 
            // timerSST2TOP
            // 
            this.timerSST2TOP.Interval = 1000;
            this.timerSST2TOP.Tick += new EventHandler(this.TimerSST2TOP_Tick);
            // 
            // timerSST1JUNGLE
            // 
            this.timerSST1JUNGLE.Interval = 1000;
            this.timerSST1JUNGLE.Tick += new EventHandler(this.TimerSST1JUNGLE_Tick);
            // 
            // timerSST2JUNGLE
            // 
            this.timerSST2JUNGLE.Interval = 1000;
            this.timerSST2JUNGLE.Tick += new EventHandler(this.TimerSST2JUNGLE_Tick);
            // 
            // timerSST1MID
            // 
            this.timerSST1MID.Interval = 1000;
            this.timerSST1MID.Tick += new EventHandler(this.TimerSST1MID_Tick);
            // 
            // timerSST2MID
            // 
            this.timerSST2MID.Interval = 1000;
            this.timerSST2MID.Tick += new EventHandler(this.TimerSST2MID_Tick);
            // 
            // timerSST1ADC
            // 
            this.timerSST1ADC.Interval = 1000;
            this.timerSST1ADC.Tick += new EventHandler(this.TimerSST1ADC_Tick);
            // 
            // timerSST2ADC
            // 
            this.timerSST2ADC.Interval = 1000;
            this.timerSST2ADC.Tick += new EventHandler(this.TimerSST2ADC_Tick);
            // 
            // timerSST1SUPPORT
            // 
            this.timerSST1SUPPORT.Interval = 1000;
            this.timerSST1SUPPORT.Tick += new EventHandler(this.TimerSST1SUPPORT_Tick);
            // 
            // timerSST2SUPPORT
            // 
            this.timerSST2SUPPORT.Interval = 1000;
            this.timerSST2SUPPORT.Tick += new EventHandler(this.TimerSST2SUPPORT_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = SystemColors.WindowFrame;
            this.ClientSize = new Size(607, 400);
            this.Controls.Add(this.panelSUPPORT);
            this.Controls.Add(this.panelADC);
            this.Controls.Add(this.panelMID);
            this.Controls.Add(this.panelJUNGLE);
            this.Controls.Add(this.panelTOP);
            this.Controls.Add(this.panelMENU);
            this.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Timer League Of Legends";
            this.panelMENU.ResumeLayout(false);
            this.panelLOGO.ResumeLayout(false);
            this.panelTOP.ResumeLayout(false);
            this.panelTOP.PerformLayout();
            this.panelJUNGLE.ResumeLayout(false);
            this.panelJUNGLE.PerformLayout();
            this.panelMID.ResumeLayout(false);
            this.panelMID.PerformLayout();
            this.panelADC.ResumeLayout(false);
            this.panelADC.PerformLayout();
            this.panelSUPPORT.ResumeLayout(false);
            this.panelSUPPORT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMENU;
        private Panel panelTOP;
        private Panel panelJUNGLE;
        private Panel panelMID;
        private Panel panelADC;
        private Panel panelSUPPORT;
        private Label labelTOP;
        private Panel panelLOGO;
        private Label labelLOGO;
        private Label LabelJUNGLE;
        private Label labelMID;
        private Label labelADC;
        private Label labelSUPPORT;
        private Button buttonEnableSettings;
        private Button buttonExit;
        private Button buttonReport;
        private Button buttonChat;
        private Button buttonTimer;
        private Button buttonAppSettings;
        private Timer timerBeep;
        private Label labelCDRPERCENTTOP;
        private Label labelCDRTOP;
        private Label labelCDRPERCENTJUNGLE;
        private Label labelCDRJUNGLE;
        private Label labelCDRPERCENTMID;
        private Label labelCDRMID;
        private Label labelCDRPERCENTADC;
        private Label labelCDRADC;
        private Label labelCDRPERCENTSUPPORT;
        private Label labelCDRSUPPORT;
        private Label labelSST2TOPTIME;
        private Label labelSST1TOPTIME;
        private Label labelSST2TOP;
        private Label labelSST1TOP;
        private Label labelSST2JUNGLETIME;
        private Label labelSST1JUNGLETIME;
        private Label labelSST2JUNGLE;
        private Label labelSST1JUNGLE;
        private Label labelSST2MIDTIME;
        private Label labelSST1MIDTIME;
        private Label labelSST2MID;
        private Label labelSST1MID;
        private Label labelSST2ADCTIME;
        private Label labelSST1ADCTIME;
        private Label labelSST2ADC;
        private Label labelSST1ADC;
        private Label labelSST2SUPPORTTIME;
        private Label labelSST1SUPPORTTIME;
        private Label labelSST2SUPPORT;
        private Label labelSST1SUPPORT;
        private Button buttonSST2TOPRESET;
        private Button buttonSST2TOPSTART;
        private Button buttonSST1TOPSTART;
        private Button buttonSST1TOPRESET;
        private CheckBox checkBoxSHOESTOP;
        private CheckBox checkBoxSHOESJUNGLE;
        private CheckBox checkBoxSHOESMID;
        private CheckBox checkBoxSHOESADC;
        private CheckBox checkBoxSHOESSUPPORT;
        private ComboBox comboBoxCDRTOPCHANGE;
        private ComboBox comboBoxCDRJUNGLECHANGE;
        private ComboBox comboBoxCDRMIDCHANGE;
        private ComboBox comboBoxCDRADCCHANGE;
        private ComboBox comboBoxCDRSUPPORTCHANGE;
        private Label labelSST2TYPETOP;
        private Label labelSST1TYPETOP;
        private Label labelSST2TYPEJUNGLE;
        private Label labelSST1TYPEJUNGLE;
        private Label labelSST2TYPEMID;
        private Label labelSST1TYPEMID;
        private Label labelSST2TYPEADC;
        private Label labelSST1TYPEADC;
        private Label labelSST2TYPESUPPORT;
        private Label labelSST1TYPESUPPORT;
        private Button buttonSST2JUNGLERESET;
        private Button buttonSST2JUNGLESTART;
        private Button buttonSST1JUNGLESTART;
        private Button buttonSST1JUNGLERESET;
        private Button buttonSST2MIDRESET;
        private Button buttonSST2MIDSTART;
        private Button buttonSST1MIDSTART;
        private Button buttonSST1MIDRESET;
        private Button buttonSST2ADCRESET;
        private Button buttonSST2ADCSTART;
        private Button buttonSST1ADCSTART;
        private Button buttonSST1ADCRESET;
        private Button buttonSST2SUPPORTRESET;
        private Button buttonSST2SUPPORTSTART;
        private Button buttonSST1SUPPORTSTART;
        private Button buttonSST1SUPPORTRESET;
        private Timer timerSST1TOP;
        private Timer timerSST2TOP;
        private Timer timerSST1JUNGLE;
        private Timer timerSST2JUNGLE;
        private Timer timerSST1MID;
        private Timer timerSST2MID;
        private Timer timerSST1ADC;
        private Timer timerSST2ADC;
        private Timer timerSST1SUPPORT;
        private Timer timerSST2SUPPORT;
        private ComboBox comboBoxSST2TYPETOP;
        private ComboBox comboBoxSST1TYPETOP;
        private ComboBox comboBoxSST2TYPEJUNGLE;
        private ComboBox comboBoxSST1TYPEJUNGLE;
        private ComboBox comboBoxSST2TYPEMID;
        private ComboBox comboBoxSST1TYPEMID;
        private ComboBox comboBoxSST2TYPEADC;
        private ComboBox comboBoxSST1TYPEADC;
        private ComboBox comboBoxSST2TYPESUPPORT;
        private ComboBox comboBoxSST1TYPESUPPORT;
        private Label labelACTUALCDRTOP;
        private Label labelACTUALCDRJUNGLE;
        private Label labelACTUALCDRMID;
        private Label labelACTUALCDRADC;
        private Label labelACTUALCDRSUPPORT;
    }
}

