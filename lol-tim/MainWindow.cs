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
        int timeLeftSST1TOP = 0;
        int timeLeftSST2TOP = 0;
        int timeLeftSST1JUNGLE = 0;
        int timeLeftSST2JUNGLE = 0;
        int timeLeftSST1MID = 0;
        int timeLeftSST2MID = 0;
        int timeLeftSST1ADC = 0;
        int timeLeftSST2ADC = 0;
        int timeLeftSST1SUPPORT = 0;
        int timeLeftSST2SUPPORT = 0;

        double SST1TOPACTUALCDR = 1.0;
        double SST2TOPACTUALCDR = 1.0;
        double SST1JUNGLEACTUALCDR = 1.0;
        double SST2JUNGLEACTUALCDR = 1.0;
        double SST1MIDACTUALCDR = 1.0;
        double SST2MIDACTUALCDR = 1.0;
        double SST1ADCACTUALCDR = 1.0;
        double SST2ADCACTUALCDR = 1.0;
        double SST1SUPPORTACTUALCDR = 1.0;
        double SST2SUPPORTACTUALCDR = 1.0;

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
            timeLeftSST1TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * SST1TOPACTUALCDR);
            labelSST1TOPTIME.Text = timeLeftSST1TOP.ToString();
            timerSST1TOP.Start();
        }

        private void ButtonSST1TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST1TOP.Stop();
            timeLeftSST1TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST1TYPETOP.Text).Value * SST1TOPACTUALCDR);
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
                    labelSST1TOPTIME.ForeColor = Color.Red;
            }
            else
            {
                timerSST2TOP.Stop();
            }
        }

        private void ButtonSST2TOPSTART_Click(object sender, EventArgs e)
        {
            timeLeftSST2TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * SST2TOPACTUALCDR);
            labelSST2TOPTIME.Text = timeLeftSST2TOP.ToString();
            timerSST2TOP.Start();
        }

        private void ButtonSST2TOPRESET_Click(object sender, EventArgs e)
        {
            timerSST2TOP.Stop();
            timeLeftSST2TOP = (int)((double)spells.FirstOrDefault(t => t.Key == labelSST2TYPETOP.Text).Value * SST2TOPACTUALCDR);
            labelSST2TOPTIME.Text = "0";
            labelSST2TOPTIME.ForeColor = Color.Black;
        }

        private void LabelCDRPERCENTTOP_TextChanged(object sender, EventArgs e)
        {
            if (labelCDRPERCENTTOP.Text == "0%")
            {
                SST1TOPACTUALCDR = 1.0 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString(); 
            }
            else if (labelCDRPERCENTTOP.Text == "5%")
            {                                   
                SST1TOPACTUALCDR = 1.0 - 0.05 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTTOP.Text == "25%")
            {
                SST1TOPACTUALCDR = 1.0 - 0.25 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString();
            }
            else if (labelCDRPERCENTTOP.Text == "30%")
            {
                SST1TOPACTUALCDR = 1.0 - 0.3 - (checkBoxSHOESTOP.Checked ? 0.1 : 0.0);
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString();
            }
        }

        private void CheckBoxSHOESTOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHOESTOP.Checked)
            {
                SST1TOPACTUALCDR -= shoesCDR;
                SST2TOPACTUALCDR -= shoesCDR;
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString();
            }
            else
            {
                SST1TOPACTUALCDR += shoesCDR;
                SST2TOPACTUALCDR += shoesCDR;
                labelACTUALCDRTOP.Text = SST1TOPACTUALCDR.ToString();
            }
                
        }


    }
}
