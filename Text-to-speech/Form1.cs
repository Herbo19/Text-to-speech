using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO; 

namespace Text_to_speech
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer falar = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
     
        private void save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {

                falar.Rate = (int)Reta.Value;
                falar.Volume = volumeTrackbar.Value * 10;
                save.Filter = "MP3 Files|*.mp3";
                save.Title = "Salva o audio em mp3.";
                  if(save.ShowDialog()==DialogResult.OK)
                  {
                      falar.SetOutputToWaveFile(save.FileName);
                      falar.SpeakAsync(textentrada.Text);
                  }
            }
        }

        private void Carregar_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog open=new OpenFileDialog())
            {
                open.Title = "Abre o ficheiro de texto";
                open.Filter = "Text files|*.txt";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string text = File.ReadAllText(open.FileName);
                    textentrada.Text = text;
                }
            }
        }

        private void textentrada_TextChanged(object sender, EventArgs e)
        {
                                                                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SpeechSynthesizer falar = new SpeechSynthesizer())
            {
                foreach (var voice in falar.GetInstalledVoices())
                {
                    comboBox1.Items.Add(voice.VoiceInfo.Name);
                }
            }

           comboBox1.SelectedIndex = 0;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Abre o ficheiro de texto";
                open.Filter = "Text files|*.txt";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string text = File.ReadAllText(open.FileName);
                    textentrada.Text = text;
                }
            }
        }

        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {

        }

        private void p_Click(object sender, EventArgs e)
        {
            if (textentrada.Text == "" || textentrada.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Preencha a caixa de texto");
            }


            falar.Rate = (int)Reta.Value;
            falar.Volume = volumeTrackbar.Value*10;
            falar.SpeakAsync(textentrada.Text);
           // falar.Speak(textentrada.Text);
            falar.SelectVoice(comboBox1.Text);
        }

        private void play_Click(object sender, EventArgs e)
        {

            if (textentrada.Text == "" || textentrada.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Preencha a caixa de texto");
            }


            falar.Rate = (int)Reta.Value;
            falar.Volume = volumeTrackbar.Value * 10;

            falar.SpeakAsync(textentrada.Text);
            falar.SelectVoice(comboBox1.Text);
        }


        private void btnsave_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {

                falar.Rate = Reta.Value;
                falar.Volume = volumeTrackbar.Value;
                save.Filter = "Mp3 Files|*.mp3";
                save.Title = "Salvar o audio em mp3.";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    falar.SetOutputToWaveFile(save.FileName);
                    falar.Speak(textentrada.Text);
                }
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            textentrada.Text = "";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            falar.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            falar.Resume();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
