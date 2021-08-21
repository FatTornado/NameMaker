using NameMaker.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameMaker
{
    public partial class Form1 : Form
    {
        private delegate int trackBarDelegate();
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private ManualResetEvent resetEvent = new ManualResetEvent(true);

        private Random random = new Random();
        private bool isSpeak = false;

        public Form1()
        {
            InitializeComponent();
            this.Icon = Resources.name;

            this.resetEvent.Reset();
            new TaskFactory().StartNew(CreateName);

            this.speech.Volume = 100;
            this.speech.Rate = this.trackBar1.Value;
            IList<InstalledVoice> list = this.speech.GetInstalledVoices();
            this.cmbVoices.Items.AddRange(list.Select(t=>t.VoiceInfo.Name).ToArray());
            this.cmbVoices.Items.Add("无");
            this.cmbVoices.Text = this.cmbVoices.Items[0].ToString();
        }

        private async void CreateName()
        {
            while (true)
            {
                this.resetEvent.WaitOne();
                string strName = this.txtLastName.Text;
                strName += this.randomWord();
                if (this.rbLength3.Checked ||
                    (this.rbRandom.Checked && this.random.Next(0, 2) > 0))
                {
                    strName += this.randomWord();
                }
                this.lbName.Invoke((Action)(() => this.lbName.Text = strName));

                if (this.isSpeak)
                {
                    this.speech.Speak(strName);
                }
                else
                {
                    Thread.Sleep(1000 - (int)this.trackBar1.Invoke((Func<int>)(() => this.trackBar1.Value)) * 100);
                }
            }
        }

        private string randomWord()
        {
            Encoding e = Encoding.GetEncoding("gb2312");
            int regionCode = this.random.Next(16, 56);
            int positionCode = this.random.Next(1, regionCode == 55 ? 90 : 95);
            return e.GetString(new byte[] { (byte)(regionCode + 160), (byte)(positionCode + 160) });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Tag.ToString() == "0")
            {
                this.button1.Tag = "1";
                this.button1.Text = "◼";
                this.resetEvent.Set();
            }
            else
            {
                this.button1.Tag = "0";
                this.button1.Text = "▶";
                this.resetEvent.Reset();
            }
        }

        private void cmbVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbVoices.Text == "无")
            {
                this.isSpeak = false;
                return;
            }
            this.speech.SelectVoice(this.cmbVoices.Text);
            this.isSpeak = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.speech.Rate = this.trackBar1.Value;
        }
    }
}
