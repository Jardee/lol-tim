using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace lol_tim
{
    public partial class MainWindow : Form
    {
        private int timeLeftSST1TOP = 0;
        private int timeLeftSST2TOP = 0;
        private int timeLeftSST1JUNGLE = 0;
        private int timeLeftSST2JUNGLE = 0;
        private int timeLeftSST1MID = 0;
        private int timeLeftSST2MID = 0;
        private int timeLeftSST1ADC = 0;
        private int timeLeftSST2ADC = 0;
        private int timeLeftSST1SUPPORT = 0;
        private int timeLeftSST2SUPPORT = 0;

        private double TOPACTUALCDR = 1.0;
        private double JUNGLEACTUALCDR = 1.0;
        private double MIDACTUALCDR = 1.0;
        private double ADCACTUALCDR = 1.0;
        private double SUPPORTACTUALCDR = 1.0;

        //constants like spells cooldown
        Dictionary<String, int> spells = new Dictionary<string, int>();

        //w razie jakby kiedyś zmienili cooldown na butach
        double shoesCDR = 0.1;
        

        public MainWindow()
        {
            InitializeComponent();

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
            MessageBox.Show("Not Implemented Yet");
        }

        private void ButtonChat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
        }

        private void ButtonEnableSettings_Click(object sender, EventArgs e)
        {
            panelTOP.Enabled = panelTOP.Enabled == false ? true : false;
            panelJUNGLE.Enabled = panelJUNGLE.Enabled == false ? true : false;
            panelMID.Enabled = panelMID.Enabled == false ? true : false;
            panelADC.Enabled = panelADC.Enabled == false ? true : false;
            panelSUPPORT.Enabled = panelSUPPORT.Enabled == false ? true : false;

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
            SystemSounds.Asterisk.Play();
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
            if (timeLeftSST1TOP > 0)
            {
                timeLeftSST1TOP = timeLeftSST1TOP - 1;
                labelSST1TOPTIME.Text = timeLeftSST1TOP.ToString();

                if (timeLeftSST1TOP < 15)
                    labelSST1TOPTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST1TOP.Stop();
            }
        }

        private void ButtonSST1TOPSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST1TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * TOPACTUALCDR);
            labelSST1TOPTIME.Text = timeLeftSST1TOP.ToString();
            timerSST1TOP.Start();
        }

        private void ButtonSST1TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST1TOP.Stop();
            timeLeftSST1TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * TOPACTUALCDR);
            labelSST1TOPTIME.Text = "0";
            labelSST1TOPTIME.ForeColor = Color.Black;
        }

        private void TimerSST2TOP_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST2TOP > 0)
            {
                timeLeftSST2TOP = timeLeftSST2TOP - 1;
                labelSST2TOPTIME.Text = timeLeftSST2TOP.ToString();

                if (timeLeftSST2TOP < 15)
                    labelSST2TOPTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2TOP.Stop();
            }
        }

        private void ButtonSST2TOPSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * TOPACTUALCDR);
            labelSST2TOPTIME.Text = timeLeftSST2TOP.ToString();
            timerSST2TOP.Start();
        }

        private void ButtonSST2TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST2TOP.Stop();
            timeLeftSST2TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * TOPACTUALCDR);
            labelSST2TOPTIME.Text = "0";
            labelSST2TOPTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTTOP_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTTOP.Text == "0%")
            {
                TOPACTUALCDR = 1.0 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString(); 
            }
            else if (labelCDRPERCENTTOP.Text == "5%")
            {                                   
                TOPACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTTOP.Text == "25%")
            {
                TOPACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTTOP.Text == "30%")
            {
                TOPACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESTOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESTOP.Checked)
            {
                TOPACTUALCDR -= shoesCDR;
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString();
            }
            else
            {
                TOPACTUALCDR += shoesCDR;
                labelACTUALCDRTOP.Text = TOPACTUALCDR.ToString();
            }
                
        }

        //JUNGLE

        private void TimerSST1JUNGLE_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST1JUNGLE > 0)
            {
                timeLeftSST1JUNGLE = timeLeftSST1JUNGLE - 1;
                labelSST1JUNGLETIME.Text = timeLeftSST1JUNGLE.ToString();

                if (timeLeftSST1JUNGLE < 15)
                    labelSST1JUNGLETIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST1JUNGLE.Stop();
            }
        }

        private void ButtonSST1JUNGLESTART_Click(object sender, EventArgs e)
        {
            timeLeftSST1JUNGLE = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEJUNGLE.Text).Value * JUNGLEACTUALCDR);
            labelSST1JUNGLETIME.Text = timeLeftSST1JUNGLE.ToString();
            timerSST1JUNGLE.Start();
        }

        private void ButtonSST1JUNGLERESET_Click(object sender, EventArgs e)
        {
            timerSST1JUNGLE.Stop();
            timeLeftSST1JUNGLE = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEJUNGLE.Text).Value * JUNGLEACTUALCDR);
            labelSST1JUNGLETIME.Text = "0";
            labelSST1JUNGLETIME.ForeColor = Color.Black;
        }

        private void TimerSST2JUNGLE_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST2JUNGLE > 0)
            {
                timeLeftSST2JUNGLE = timeLeftSST2JUNGLE - 1;
                labelSST2JUNGLETIME.Text = timeLeftSST2JUNGLE.ToString();

                if (timeLeftSST2JUNGLE < 15)
                    labelSST2JUNGLETIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2JUNGLE.Stop();
            }
        }

        private void ButtonSST2JUNGLESTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2JUNGLE = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEJUNGLE.Text).Value * JUNGLEACTUALCDR);
            labelSST2JUNGLETIME.Text = timeLeftSST2JUNGLE.ToString();
            timerSST2JUNGLE.Start();
        }

        private void ButtonSST2JUNGLERESET_Click(object sender, EventArgs e)
        {
            timerSST2JUNGLE.Stop();
            timeLeftSST2JUNGLE = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEJUNGLE.Text).Value * JUNGLEACTUALCDR);
            labelSST2JUNGLETIME.Text = "0";
            labelSST2JUNGLETIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTJUNGLE_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTJUNGLE.Text == "0%")
            {
                JUNGLEACTUALCDR = 1.0 - (checkBoxSHOESJUNGLE.Checked ? 0.1 : 0.0);
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTJUNGLE.Text == "5%")
            {
                JUNGLEACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESJUNGLE.Checked ? 0.1 : 0.0);
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTJUNGLE.Text == "25%")
            {
                JUNGLEACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESJUNGLE.Checked ? 0.1 : 0.0);
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTJUNGLE.Text == "30%")
            {
                JUNGLEACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESJUNGLE.Checked ? 0.1 : 0.0);
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESJUNGLE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESJUNGLE.Checked)
            {
                JUNGLEACTUALCDR -= shoesCDR;
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }
            else
            {
                JUNGLEACTUALCDR += shoesCDR;
                labelACTUALCDRJUNGLE.Text = JUNGLEACTUALCDR.ToString();
            }

        }

        //MID

        private void TimerSST1MID_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST1MID > 0)
            {
                timeLeftSST1MID = timeLeftSST1MID - 1;
                labelSST1MIDTIME.Text = timeLeftSST1MID.ToString();

                if (timeLeftSST1MID < 15)
                    labelSST1MIDTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST1MID.Stop();
            }
        }

        private void ButtonSST1MIDSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST1MID = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEMID.Text).Value * MIDACTUALCDR);
            labelSST1MIDTIME.Text = timeLeftSST1MID.ToString();
            timerSST1MID.Start();
        }

        private void ButtonSST1MIDRESET_Click(object sender, EventArgs e)
        {
            timerSST1MID.Stop();
            timeLeftSST1MID = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEMID.Text).Value * MIDACTUALCDR);
            labelSST1MIDTIME.Text = "0";
            labelSST1MIDTIME.ForeColor = Color.Black;
        }

        private void TimerSST2MID_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST2MID > 0)
            {
                timeLeftSST2MID = timeLeftSST2MID - 1;
                labelSST2MIDTIME.Text = timeLeftSST2MID.ToString();

                if (timeLeftSST2MID < 15)
                    labelSST2MIDTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2MID.Stop();
            }
        }

        private void ButtonSST2MIDSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2MID = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEMID.Text).Value * MIDACTUALCDR);
            labelSST2MIDTIME.Text = timeLeftSST2MID.ToString();
            timerSST2MID.Start();
        }

        private void ButtonSST2MIDRESET_Click(object sender, EventArgs e)
        {
            timerSST2MID.Stop();
            timeLeftSST2MID = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEMID.Text).Value * MIDACTUALCDR);
            labelSST2MIDTIME.Text = "0";
            labelSST2MIDTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTMID_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTMID.Text == "0%")
            {
                MIDACTUALCDR = 1.0 - (checkBoxSHOESMID.Checked ? 0.1 : 0.0);
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTMID.Text == "5%")
            {
                MIDACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESMID.Checked ? 0.1 : 0.0);
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTMID.Text == "25%")
            {
                MIDACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESMID.Checked ? 0.1 : 0.0);
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTMID.Text == "30%")
            {
                MIDACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESMID.Checked ? 0.1 : 0.0);
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESMID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESMID.Checked)
            {
                MIDACTUALCDR -= shoesCDR;
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }
            else
            {
                MIDACTUALCDR += shoesCDR;
                labelACTUALCDRMID.Text = MIDACTUALCDR.ToString();
            }

        }

        //ADC

        private void TimerSST1ADC_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST1ADC > 0)
            {
                timeLeftSST1ADC = timeLeftSST1ADC - 1;
                labelSST1ADCTIME.Text = timeLeftSST1ADC.ToString();

                if (timeLeftSST1ADC < 15)
                    labelSST1ADCTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST1ADC.Stop();
            }
        }

        private void ButtonSST1ADCSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST1ADC = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEADC.Text).Value * ADCACTUALCDR);
            labelSST1ADCTIME.Text = timeLeftSST1ADC.ToString();
            timerSST1ADC.Start();
        }

        private void ButtonSST1ADCRESET_Click(object sender, EventArgs e)
        {
            timerSST1ADC.Stop();
            timeLeftSST1ADC = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPEADC.Text).Value * ADCACTUALCDR);
            labelSST1ADCTIME.Text = "0";
            labelSST1ADCTIME.ForeColor = Color.Black;
        }

        private void TimerSST2ADC_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST2ADC > 0)
            {
                timeLeftSST2ADC = timeLeftSST2ADC - 1;
                labelSST2ADCTIME.Text = timeLeftSST2ADC.ToString();

                if (timeLeftSST2ADC < 15)
                    labelSST2ADCTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2ADC.Stop();
            }
        }

        private void ButtonSST2ADCSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2ADC = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEADC.Text).Value * ADCACTUALCDR);
            labelSST2ADCTIME.Text = timeLeftSST2ADC.ToString();
            timerSST2ADC.Start();
        }

        private void ButtonSST2ADCRESET_Click(object sender, EventArgs e)
        {
            timerSST2ADC.Stop();
            timeLeftSST2ADC = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPEADC.Text).Value * ADCACTUALCDR);
            labelSST2ADCTIME.Text = "0";
            labelSST2ADCTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTADC_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTADC.Text == "0%")
            {
                ADCACTUALCDR = 1.0 - (checkBoxSHOESADC.Checked ? 0.1 : 0.0);
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTADC.Text == "5%")
            {
                ADCACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESADC.Checked ? 0.1 : 0.0);
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTADC.Text == "25%")
            {
                ADCACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESADC.Checked ? 0.1 : 0.0);
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTADC.Text == "30%")
            {
                ADCACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESADC.Checked ? 0.1 : 0.0);
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESADC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESADC.Checked)
            {
                ADCACTUALCDR -= shoesCDR;
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }
            else
            {
                ADCACTUALCDR += shoesCDR;
                labelACTUALCDRADC.Text = ADCACTUALCDR.ToString();
            }

        }

        //SUPPORT

        private void TimerSST1SUPPORT_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST1SUPPORT > 0)
            {
                timeLeftSST1SUPPORT = timeLeftSST1SUPPORT - 1;
                labelSST1SUPPORTTIME.Text = timeLeftSST1SUPPORT.ToString();

                if (timeLeftSST1SUPPORT < 15)
                    labelSST1SUPPORTTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST1SUPPORT.Stop();
            }
        }

        private void ButtonSST1SUPPORTSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST1SUPPORT = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPESUPPORT.Text).Value * SUPPORTACTUALCDR);
            labelSST1SUPPORTTIME.Text = timeLeftSST1SUPPORT.ToString();
            timerSST1SUPPORT.Start();
        }

        private void ButtonSST1SUPPORTRESET_Click(object sender, EventArgs e)
        {
            timerSST1SUPPORT.Stop();
            timeLeftSST1SUPPORT = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPESUPPORT.Text).Value * SUPPORTACTUALCDR);
            labelSST1SUPPORTTIME.Text = "0";
            labelSST1SUPPORTTIME.ForeColor = Color.Black;
        }

        private void TimerSST2SUPPORT_Tick(object sender, EventArgs e)
        {
            if (timeLeftSST2SUPPORT > 0)
            {
                timeLeftSST2SUPPORT = timeLeftSST2SUPPORT - 1;
                labelSST2SUPPORTTIME.Text = timeLeftSST2SUPPORT.ToString();

                if (timeLeftSST2SUPPORT < 15)
                    labelSST2SUPPORTTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2SUPPORT.Stop();
            }
        }

        private void ButtonSST2SUPPORTSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2SUPPORT = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPESUPPORT.Text).Value * SUPPORTACTUALCDR);
            labelSST2SUPPORTTIME.Text = timeLeftSST2SUPPORT.ToString();
            timerSST2SUPPORT.Start();
        }

        private void ButtonSST2SUPPORTRESET_Click(object sender, EventArgs e)
        {
            timerSST2SUPPORT.Stop();
            timeLeftSST2SUPPORT = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPESUPPORT.Text).Value * SUPPORTACTUALCDR);
            labelSST2SUPPORTTIME.Text = "0";
            labelSST2SUPPORTTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTSUPPORT_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTSUPPORT.Text == "0%")
            {
                SUPPORTACTUALCDR = 1.0 - (checkBoxSHOESSUPPORT.Checked ? 0.1 : 0.0);
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTSUPPORT.Text == "5%")
            {
                SUPPORTACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESSUPPORT.Checked ? 0.1 : 0.0);
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTSUPPORT.Text == "25%")
            {
                SUPPORTACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESSUPPORT.Checked ? 0.1 : 0.0);
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTSUPPORT.Text == "30%")
            {
                SUPPORTACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESSUPPORT.Checked ? 0.1 : 0.0);
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESSUPPORT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESSUPPORT.Checked)
            {
                SUPPORTACTUALCDR -= shoesCDR;
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }
            else
            {
                SUPPORTACTUALCDR += shoesCDR;
                labelACTUALCDRSUPPORT.Text = SUPPORTACTUALCDR.ToString();
            }

        }
    }
}
