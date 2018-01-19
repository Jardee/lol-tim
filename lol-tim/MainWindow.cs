using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using lol_tim.Properties;

namespace lol_tim
{
    public partial class MainWindow : Form
    {
        private int _timeLeftSst1Top;
        private int _timeLeftSst2Top;
        private int _timeLeftSst1Jungle;
        private int _timeLeftSst2Jungle;
        private int _timeLeftSst1Mid;
        private int _timeLeftSst2Mid;
        private int _timeLeftSst1Adc;
        private int _timeLeftSst2Adc;
        private int _timeLeftSst1Support;
        private int _timeLeftSst2Support;

        private double _topactualcdr = 1.0;
        private double _jungleactualcdr = 1.0;
        private double _midactualcdr = 1.0;
        private double _adcactualcdr = 1.0;
        private double _supportactualcdr = 1.0;

        //constants like spells cooldown
        Dictionary<String, int> spells = new Dictionary<string, int>();

        //w razie jakby kiedyś zmienili cooldown na butach
        double shoesCDR = 0.1;

        SoundPlayer player;

        public MainWindow()
        {
            InitializeComponent();

            Stream str = Resources.beep_07;

            player = new SoundPlayer(str);

            //summoner spelle i sekundy cooldown'u
            spells.Add("Flash", 300);
            spells.Add("Teleport", 300);
            spells.Add("Ignite", 210);
            spells.Add("Heal", 240);
            spells.Add("Ghost", 180);
            spells.Add("Exhaust", 210);
            spells.Add("Cleanse", 210);
            spells.Add("Clarity", 240);
            spells.Add("Barrier", 180);

            comboBoxSST1TYPETOP.DisplayMember = "Key";
            comboBoxSST1TYPETOP.DataSource = new BindingSource(spells, null);

            comboBoxSST2TYPETOP.DisplayMember = "Key";
            comboBoxSST2TYPETOP.DataSource = new BindingSource(spells, null);

            comboBoxSST1TYPEJUNGLE.DisplayMember = "Key";
            comboBoxSST1TYPEJUNGLE.DataSource = new BindingSource(spells, null);

            comboBoxSST2TYPEJUNGLE.DisplayMember = "Key";
            comboBoxSST2TYPEJUNGLE.DataSource = new BindingSource(spells, null);

            comboBoxSST1TYPEMID.DisplayMember = "Key";
            comboBoxSST1TYPEMID.DataSource = new BindingSource(spells, null);

            comboBoxSST2TYPEMID.DisplayMember = "Key";
            comboBoxSST2TYPEMID.DataSource = new BindingSource(spells, null);

            comboBoxSST1TYPEADC.DisplayMember = "Key";
            comboBoxSST1TYPEADC.DataSource = new BindingSource(spells, null);

            comboBoxSST2TYPEADC.DisplayMember = "Key";
            comboBoxSST2TYPEADC.DataSource = new BindingSource(spells, null);

            comboBoxSST1TYPESUPPORT.DisplayMember = "Key";
            comboBoxSST1TYPESUPPORT.DataSource = new BindingSource(spells, null);

            comboBoxSST2TYPESUPPORT.DisplayMember = "Key";
            comboBoxSST2TYPESUPPORT.DataSource = new BindingSource(spells, null);
            
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonAppSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Not Implemented Yet");
        }

        private void ButtonChat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Not Implemented Yet");
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Not Implemented Yet");
        }

        private void ButtonEnableSettings_Click(object sender, EventArgs e)
        {
            panelTOP.Enabled = panelTOP.Enabled == false;
            panelJUNGLE.Enabled = panelJUNGLE.Enabled == false;
            panelMID.Enabled = panelMID.Enabled == false;
            panelADC.Enabled = panelADC.Enabled == false;
            panelSUPPORT.Enabled = panelSUPPORT.Enabled == false;

        }

        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            if (timerBeep.Enabled == false)
            {
                timerBeep.Start();
                buttonTimer.ForeColor = Color.FromName("Green");
            }
            else
            {
                timerBeep.Stop();
                buttonTimer.ForeColor = Color.FromName("White");
            }
        }

        private void Beep(object sender, EventArgs e)
        {
            player.Play();
        }

        private void LabelCDRPERCENTTOP_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCDRTOPCHANGE.Visible = true;
        }

        private void LabelCDRPERCENTSUPPORT_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCDRSUPPORTCHANGE.Visible = true;
        }

        private void LabelCDRPERCENTMID_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCDRMIDCHANGE.Visible = true;
        }

        private void LabelCDRPERCENTJUNGLE_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCDRJUNGLECHANGE.Visible = true;
        }

        private void LabelCDRPERCENTADC_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCDRADCCHANGE.Visible = true;
        }

        private void ComboBoxCDRTOPCHANGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCDRPERCENTTOP.Text = comboBoxCDRTOPCHANGE.Text;
            comboBoxCDRTOPCHANGE.Visible = false;
        }

        private void ComboBoxCDRJUNGLECHANGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCDRPERCENTJUNGLE.Text = comboBoxCDRJUNGLECHANGE.Text;
            comboBoxCDRJUNGLECHANGE.Visible = false;
        }

        private void ComboBoxCDRMIDCHANGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCDRPERCENTMID.Text = comboBoxCDRMIDCHANGE.Text;
            comboBoxCDRMIDCHANGE.Visible = false;
        }

        private void ComboBoxCDRADCCHANGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCDRPERCENTADC.Text = comboBoxCDRADCCHANGE.Text;
            comboBoxCDRADCCHANGE.Visible = false;
        }

        private void ComboBoxCDRSUPPORTCHANGE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCDRPERCENTSUPPORT.Text = comboBoxCDRSUPPORTCHANGE.Text;
            comboBoxCDRSUPPORTCHANGE.Visible = false;
        }

        private void LabelSST1TYPETOP_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST1TYPETOP.Visible = true;
        }

        private void LabelSST2TYPETOP_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST2TYPETOP.Visible = true;
        }

        private void LabelSST1TYPEJUNGLE_DoubleClick(object sender, EventArgs e)
        {
            
            comboBoxSST1TYPEJUNGLE.Visible = true;
        }

        private void LabelSST2TYPEJUNGLE_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST2TYPEJUNGLE.Visible = true;
        }

        private void LabelSST1TYPEMID_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST1TYPEMID.Visible = true;
        }

        private void LabelSST2TYPEMID_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST2TYPEMID.Visible = true;
        }

        private void LabelSST1TYPEADC_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST1TYPEADC.Visible = true;
        }

        private void LabelSST2TYPEADC_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST2TYPEADC.Visible = true;
        }

        private void LabelSST1TYPESUPPORT_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST1TYPESUPPORT.Visible = true;
        }

        private void LabelSST2TYPESUPPORT_DoubleClick(object sender, EventArgs e)
        {
            comboBoxSST2TYPESUPPORT.Visible = true;
        }

        private void ComboBoxSST1TYPETOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST1TYPETOP.Text = comboBoxSST1TYPETOP.Text;
            comboBoxSST1TYPETOP.Visible = false;
        }

        private void ComboBoxSST2TYPETOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST2TYPETOP.Text = comboBoxSST2TYPETOP.Text;
            comboBoxSST2TYPETOP.Visible = false;
        }

        private void ComboBoxSST1TYPEJUNGLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST1TYPEJUNGLE.Text = comboBoxSST1TYPEJUNGLE.Text;
            comboBoxSST1TYPEJUNGLE.Visible = false;
        }

        private void ComboBoxSST2TYPEJUNGLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST2TYPEJUNGLE.Text = comboBoxSST2TYPEJUNGLE.Text;
            comboBoxSST2TYPEJUNGLE.Visible = false;
        }

        private void ComboBoxSST1TYPEMID_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST1TYPEMID.Text = comboBoxSST1TYPEMID.Text;
            comboBoxSST1TYPEMID.Visible = false;
        }

        private void ComboBoxSST2TYPEMID_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST2TYPEMID.Text = comboBoxSST2TYPEMID.Text;
            comboBoxSST2TYPEMID.Visible = false;
        }

        private void ComboBoxSST1TYPEADC_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST1TYPEADC.Text = comboBoxSST1TYPEADC.Text;
            comboBoxSST1TYPEADC.Visible = false;
        }

        private void ComboBoxSST2TYPEADC_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST2TYPEADC.Text = comboBoxSST2TYPEADC.Text;
            comboBoxSST2TYPEADC.Visible = false;
        }

        private void ComboBoxSST1TYPESUPPORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST1TYPESUPPORT.Text = comboBoxSST1TYPESUPPORT.Text;
            comboBoxSST1TYPESUPPORT.Visible = false;
        }

        private void ComboBoxSST2TYPESUPPORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSST2TYPESUPPORT.Text = comboBoxSST2TYPESUPPORT.Text;
            comboBoxSST2TYPESUPPORT.Visible = false;
        }

        //TOP

        private void TimerSST1TOP_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst1Top > 0)
            {
                _timeLeftSst1Top = _timeLeftSst1Top - 1;
                labelSST1TOPTIME.Text = _timeLeftSst1Top.ToString();

                if (_timeLeftSst1Top < 15)
                    labelSST1TOPTIME.ForeColor = Color.Red;
            }
            else
                timerSST1TOP.Stop();
        }

        private void ButtonSST1TOPSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst1Top = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * _topactualcdr);
            labelSST1TOPTIME.Text = _timeLeftSst1Top.ToString();
            timerSST1TOP.Start();
        }

        private void ButtonSST1TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST1TOP.Stop();
            _timeLeftSst1Top = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * _topactualcdr);
            labelSST1TOPTIME.Text = @"0";
            labelSST1TOPTIME.ForeColor = Color.Black;
        }

        private void TimerSST2TOP_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst2Top > 0)
            {
                _timeLeftSst2Top = _timeLeftSst2Top - 1;
                labelSST2TOPTIME.Text = _timeLeftSst2Top.ToString();

                if (_timeLeftSst2Top < 15)
                    labelSST2TOPTIME.ForeColor = Color.Red;
            }
            else
                timerSST2TOP.Stop();
        }

        private void ButtonSST2TOPSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst2Top = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * _topactualcdr);
            labelSST2TOPTIME.Text = _timeLeftSst2Top.ToString();
            timerSST2TOP.Start();
        }

        private void ButtonSST2TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST2TOP.Stop();
            _timeLeftSst2Top = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * _topactualcdr);
            labelSST2TOPTIME.Text = @"0";
            labelSST2TOPTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTTOP_TextChanged(object sender, EventArgs e)
        {
            switch (labelCDRPERCENTTOP.Text)
            {
                case "0%":
                    _topactualcdr = 1.0 - (checkBoxSHOESTOP.Checked ? shoesCDR : 0.0);
                    break;
                case "5%":
                    _topactualcdr = 1.0 - 0.05 - (checkBoxSHOESTOP.Checked ? shoesCDR : 0.0);
                    break;
                case "25%":
                    _topactualcdr = 1.0 - 0.25 - (checkBoxSHOESTOP.Checked ? shoesCDR : 0.0);
                    break;
                case "30%":
                    _topactualcdr = 1.0 - 0.3 - (checkBoxSHOESTOP.Checked ? shoesCDR : 0.0);
                    break;
            }

            labelACTUALCDRTOP.Text = _topactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        private void CheckBoxSHOESTOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESTOP.Checked)
                _topactualcdr -= shoesCDR;
            else
                _topactualcdr += shoesCDR;
            labelACTUALCDRTOP.Text = _topactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        //JUNGLE

        private void TimerSST1JUNGLE_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst1Jungle > 0)
            {
                _timeLeftSst1Jungle = _timeLeftSst1Jungle - 1;
                labelSST1JUNGLETIME.Text = _timeLeftSst1Jungle.ToString();

                if (_timeLeftSst1Jungle < 15)
                    labelSST1JUNGLETIME.ForeColor = Color.Red;
            }
            else
                timerSST1JUNGLE.Stop();
        }

        private void ButtonSST1JUNGLESTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst1Jungle = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEJUNGLE.Text).Value * _jungleactualcdr);
            labelSST1JUNGLETIME.Text = _timeLeftSst1Jungle.ToString();
            timerSST1JUNGLE.Start();
        }

        private void ButtonSST1JUNGLERESET_Click(object sender, EventArgs e)
        {
            timerSST1JUNGLE.Stop();
            _timeLeftSst1Jungle = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEJUNGLE.Text).Value * _jungleactualcdr);
            labelSST1JUNGLETIME.Text = @"0";
            labelSST1JUNGLETIME.ForeColor = Color.Black;
        }

        private void TimerSST2JUNGLE_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst2Jungle > 0)
            {
                _timeLeftSst2Jungle = _timeLeftSst2Jungle - 1;
                labelSST2JUNGLETIME.Text = _timeLeftSst2Jungle.ToString();

                if (_timeLeftSst2Jungle < 15)
                    labelSST2JUNGLETIME.ForeColor = Color.Red;
            }
            else
                timerSST2JUNGLE.Stop();
        }

        private void ButtonSST2JUNGLESTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst2Jungle = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEJUNGLE.Text).Value * _jungleactualcdr);
            labelSST2JUNGLETIME.Text = _timeLeftSst2Jungle.ToString();
            timerSST2JUNGLE.Start();
        }

        private void ButtonSST2JUNGLERESET_Click(object sender, EventArgs e)
        {
            timerSST2JUNGLE.Stop();
            _timeLeftSst2Jungle = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEJUNGLE.Text).Value * _jungleactualcdr);
            labelSST2JUNGLETIME.Text = @"0";
            labelSST2JUNGLETIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTJUNGLE_TextChanged(object sender, EventArgs e)
        {
            switch (labelCDRPERCENTJUNGLE.Text)
            {
                case "0%":
                    _jungleactualcdr = 1.0 - (checkBoxSHOESJUNGLE.Checked ? shoesCDR : 0.0);
                    break;
                case "5%":
                    _jungleactualcdr = 1.0 - 0.05 - (checkBoxSHOESJUNGLE.Checked ? shoesCDR : 0.0);
                    break;
                case "25%":
                    _jungleactualcdr = 1.0 - 0.25 - (checkBoxSHOESJUNGLE.Checked ? shoesCDR : 0.0);
                    break;
                case "30%":
                    _jungleactualcdr = 1.0 - 0.3 - (checkBoxSHOESJUNGLE.Checked ? shoesCDR : 0.0);
                    break;
            }

            labelACTUALCDRJUNGLE.Text = _jungleactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        private void CheckBoxSHOESJUNGLE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESJUNGLE.Checked)
                _jungleactualcdr -= shoesCDR;
            else
                _jungleactualcdr += shoesCDR;
                
            labelACTUALCDRJUNGLE.Text = _jungleactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        //MID

        private void TimerSST1MID_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst1Mid > 0)
            {
                _timeLeftSst1Mid = _timeLeftSst1Mid - 1;
                labelSST1MIDTIME.Text = _timeLeftSst1Mid.ToString();

                if (_timeLeftSst1Mid < 15)
                    labelSST1MIDTIME.ForeColor = Color.Red;
            }
            else
                timerSST1MID.Stop();
        }

        private void ButtonSST1MIDSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst1Mid = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEMID.Text).Value * _midactualcdr);
            labelSST1MIDTIME.Text = _timeLeftSst1Mid.ToString();
            timerSST1MID.Start();
        }

        private void ButtonSST1MIDRESET_Click(object sender, EventArgs e)
        {
            timerSST1MID.Stop();
            _timeLeftSst1Mid = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEMID.Text).Value * _midactualcdr);
            labelSST1MIDTIME.Text = @"0";
            labelSST1MIDTIME.ForeColor = Color.Black;
        }

        private void TimerSST2MID_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst2Mid > 0)
            {
                _timeLeftSst2Mid = _timeLeftSst2Mid - 1;
                labelSST2MIDTIME.Text = _timeLeftSst2Mid.ToString();

                if (_timeLeftSst2Mid < 15)
                    labelSST2MIDTIME.ForeColor = Color.Red;
            }
            else
                timerSST2MID.Stop();
        }

        private void ButtonSST2MIDSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst2Mid = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEMID.Text).Value * _midactualcdr);
            labelSST2MIDTIME.Text = _timeLeftSst2Mid.ToString();
            timerSST2MID.Start();
        }

        private void ButtonSST2MIDRESET_Click(object sender, EventArgs e)
        {
            timerSST2MID.Stop();
            _timeLeftSst2Mid = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEMID.Text).Value * _midactualcdr);
            labelSST2MIDTIME.Text = @"0";
            labelSST2MIDTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTMID_TextChanged(object sender, EventArgs e)
        {
            switch (labelCDRPERCENTMID.Text)
            {
                case "0%":
                    _midactualcdr = 1.0 - (checkBoxSHOESMID.Checked ? shoesCDR : 0.0);
                    break;
                case "5%":
                    _midactualcdr = 1.0 - 0.05 - (checkBoxSHOESMID.Checked ? shoesCDR : 0.0);
                    break;
                case "25%":
                    _midactualcdr = 1.0 - 0.25 - (checkBoxSHOESMID.Checked ? shoesCDR : 0.0);
                    break;
                case "30%":
                    _midactualcdr = 1.0 - 0.3 - (checkBoxSHOESMID.Checked ? shoesCDR : 0.0);
                    break;
            }

            labelACTUALCDRMID.Text = _midactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        private void CheckBoxSHOESMID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESMID.Checked)
                _midactualcdr -= shoesCDR;
            else
                _midactualcdr += shoesCDR;

            labelACTUALCDRMID.Text = _midactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        //ADC

        private void TimerSST1ADC_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst1Adc > 0)
            {
                _timeLeftSst1Adc = _timeLeftSst1Adc - 1;
                labelSST1ADCTIME.Text = _timeLeftSst1Adc.ToString();

                if (_timeLeftSst1Adc < 15)
                    labelSST1ADCTIME.ForeColor = Color.Red;
            }
            else
                timerSST1ADC.Stop();
        }

        private void ButtonSST1ADCSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst1Adc = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEADC.Text).Value * _adcactualcdr);
            labelSST1ADCTIME.Text = _timeLeftSst1Adc.ToString();
            timerSST1ADC.Start();
        }

        private void ButtonSST1ADCRESET_Click(object sender, EventArgs e)
        {
            timerSST1ADC.Stop();
            _timeLeftSst1Adc = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPEADC.Text).Value * _adcactualcdr);
            labelSST1ADCTIME.Text = @"0";
            labelSST1ADCTIME.ForeColor = Color.Black;
        }

        private void TimerSST2ADC_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst2Adc > 0)
            {
                _timeLeftSst2Adc = _timeLeftSst2Adc - 1;
                labelSST2ADCTIME.Text = _timeLeftSst2Adc.ToString();

                if (_timeLeftSst2Adc < 15)
                    labelSST2ADCTIME.ForeColor = Color.Red;
            }
            else
                timerSST2ADC.Stop();
        }

        private void ButtonSST2ADCSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst2Adc = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEADC.Text).Value * _adcactualcdr);
            labelSST2ADCTIME.Text = _timeLeftSst2Adc.ToString();
            timerSST2ADC.Start();
        }

        private void ButtonSST2ADCRESET_Click(object sender, EventArgs e)
        {
            timerSST2ADC.Stop();
            _timeLeftSst2Adc = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPEADC.Text).Value * _adcactualcdr);
            labelSST2ADCTIME.Text = @"0";
            labelSST2ADCTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTADC_TextChanged(object sender, EventArgs e)
        {
            switch (labelCDRPERCENTADC.Text)
            {
                case "0%":
                    _adcactualcdr = 1.0 - (checkBoxSHOESADC.Checked ? shoesCDR : 0.0);
                    break;
                case "5%":
                    _adcactualcdr = 1.0 - 0.05 - (checkBoxSHOESADC.Checked ? shoesCDR : 0.0);
                    break;
                case "25%":
                    _adcactualcdr = 1.0 - 0.25 - (checkBoxSHOESADC.Checked ? shoesCDR : 0.0);
                    break;
                case "30%":
                    _adcactualcdr = 1.0 - 0.3 - (checkBoxSHOESADC.Checked ? shoesCDR : 0.0);
                    break;
            }

            labelACTUALCDRADC.Text = _adcactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        private void CheckBoxSHOESADC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESADC.Checked)
                _adcactualcdr -= shoesCDR;
            else
                _adcactualcdr += shoesCDR;

            labelACTUALCDRADC.Text = _adcactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        //SUPPORT

        private void TimerSST1SUPPORT_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst1Support > 0)
            {
                _timeLeftSst1Support = _timeLeftSst1Support - 1;
                labelSST1SUPPORTTIME.Text = _timeLeftSst1Support.ToString();

                if (_timeLeftSst1Support < 15)
                    labelSST1SUPPORTTIME.ForeColor = Color.Red;
            }
            else
                timerSST1SUPPORT.Stop();
        }

        private void ButtonSST1SUPPORTSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst1Support = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPESUPPORT.Text).Value * _supportactualcdr);
            labelSST1SUPPORTTIME.Text = _timeLeftSst1Support.ToString();
            timerSST1SUPPORT.Start();
        }

        private void ButtonSST1SUPPORTRESET_Click(object sender, EventArgs e)
        {
            timerSST1SUPPORT.Stop();
            _timeLeftSst1Support = (int)(spells.FirstOrDefault(t => t.Key == labelSST1TYPESUPPORT.Text).Value * _supportactualcdr);
            labelSST1SUPPORTTIME.Text = @"0";
            labelSST1SUPPORTTIME.ForeColor = Color.Black;
        }

        private void TimerSST2SUPPORT_Tick(object sender, EventArgs e)
        {
            if (_timeLeftSst2Support > 0)
            {
                _timeLeftSst2Support = _timeLeftSst2Support - 1;
                labelSST2SUPPORTTIME.Text = _timeLeftSst2Support.ToString();

                if (_timeLeftSst2Support < 15)
                    labelSST2SUPPORTTIME.ForeColor = Color.Red;
            }
            else
                timerSST2SUPPORT.Stop();
        }

        private void ButtonSST2SUPPORTSTART_Click(object sender, EventArgs e)
        {
            _timeLeftSst2Support = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPESUPPORT.Text).Value * _supportactualcdr);
            labelSST2SUPPORTTIME.Text = _timeLeftSst2Support.ToString();
            timerSST2SUPPORT.Start();
        }

        private void ButtonSST2SUPPORTRESET_Click(object sender, EventArgs e)
        {
            timerSST2SUPPORT.Stop();
            _timeLeftSst2Support = (int)(spells.FirstOrDefault(t => t.Key == labelSST2TYPESUPPORT.Text).Value * _supportactualcdr);
            labelSST2SUPPORTTIME.Text = @"0";
            labelSST2SUPPORTTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTSUPPORT_TextChanged(object sender, EventArgs e)
        {
            switch (labelCDRPERCENTSUPPORT.Text)
            {
                case "0%":
                    _supportactualcdr = 1.0 - (checkBoxSHOESSUPPORT.Checked ? shoesCDR : 0.0);
                    break;
                case "5%":
                    _supportactualcdr = 1.0 - 0.05 - (checkBoxSHOESSUPPORT.Checked ? shoesCDR : 0.0);
                    break;
                case "25%":
                    _supportactualcdr = 1.0 - 0.25 - (checkBoxSHOESSUPPORT.Checked ? shoesCDR : 0.0);
                    break;
                case "30%":
                    _supportactualcdr = 1.0 - 0.3 - (checkBoxSHOESSUPPORT.Checked ? shoesCDR : 0.0);
                    break;
            }

            labelACTUALCDRSUPPORT.Text = _supportactualcdr.ToString(CultureInfo.CurrentCulture);
        }

        private void CheckBoxSHOESSUPPORT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESSUPPORT.Checked)
                _supportactualcdr -= shoesCDR;
            else
                _supportactualcdr += shoesCDR;

            labelACTUALCDRSUPPORT.Text = _supportactualcdr.ToString(CultureInfo.CurrentCulture);
        }
    }
}
