using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.IO;

namespace Text_to_speech
{
    public partial class Form2 : DevComponents.DotNetBar.Metro.MetroForm
    {
        //Formar as declarações...
        SpeechSynthesizer fala;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            fala = new SpeechSynthesizer();
            // Leitura do formulario
            AddVozLista();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            // Botão de play
            fala = new SpeechSynthesizer();

            if (txtMensagem.Text == "" || txtMensagem.Text == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor preencha a caixa de texto");
            }

            fala.SelectVoice(cBVozes.Text);
            fala.Rate = trackBarVelocidade.Value;
            fala.Volume = trackBarVolume.Value * 10;
            fala.SpeakAsync(txtMensagem.Text);
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            fala.Pause();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            fala.Resume();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Botão para guardar em ficheiro de audio
            SpeechSynthesizer fala = new SpeechSynthesizer();

            using (SaveFileDialog salvar = new SaveFileDialog())
            {

                fala.SelectVoice(cBVozes.Text);
                fala.Rate = trackBarVelocidade.Value;
                fala.Volume = trackBarVolume.Value*10;
                salvar.Filter = "Mp3 Files|*.mp3";
                salvar.Title = "Salvar o audio em mp3.";
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    fala.SetOutputToWaveFile(salvar.FileName);
                    fala.Speak(txtMensagem.Text);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Botão para cancelar
            //Application.Exit();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = "";
        }

        private void cBVozes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnTxt_Click(object sender, EventArgs e)
        {
            //Botão para carregar o arquivo .txt para a Caixa de Texto. 
            using (OpenFileDialog abrir = new OpenFileDialog())
            {
                abrir.Title = "Abre o ficheiro de texto";
                abrir.Filter = "Text files|*.txt";
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    string text = File.ReadAllText(abrir.FileName);
                    txtMensagem.Text = text;
                }
            }
        }

        private void AddVozLista()
        {
            using (SpeechSynthesizer fala = new SpeechSynthesizer())
            {
                foreach (var voz in fala.GetInstalledVoices())
                {
                    cBVozes.Items.Add(voz.VoiceInfo.Name);
                }
            }

            cBVozes.SelectedIndex = 0;
        }
    }
}