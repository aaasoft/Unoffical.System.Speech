using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private System.Speech.Synthesis.SpeechSynthesizer speechSynthesizer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            speechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            var voiceList = speechSynthesizer.GetInstalledVoices().Select(t => t.VoiceInfo).ToArray();
            cbVoiceList.DataSource = voiceList;
            cbVoiceList.DisplayMember = nameof(VoiceInfo.Name);
            cbVoiceList.ValueMember = nameof(VoiceInfo.Id);
            gbTest.Enabled = true;
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            btnSpeak.Enabled = false;
            try
            {
                VoiceInfo voice = (VoiceInfo)cbVoiceList.SelectedItem;
                speechSynthesizer.SelectVoice(voice.Name);
                speechSynthesizer.Speak(txtContent.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnSpeak.Enabled = true;
        }
    }
}
