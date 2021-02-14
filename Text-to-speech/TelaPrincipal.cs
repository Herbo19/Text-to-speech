using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Text_to_speech
{
    public partial class TelaPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public TelaPrincipal(string uso)
        {
            InitializeComponent();
            LbNome.Text = uso;
        }

        private void metroTabPanel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPanel2_Click(object sender, EventArgs e)
        {

        }

        

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            LbSom.Visible = false;
            if (LbNome.Text == "Adm")
            {

            }
            else
            {
                metroTabItem4.Visible = false;
            }
        }

        private void LbSom_Click(object sender, EventArgs e)
        {
            Form1 som = new Form1();
            som.Show();
        }

        private void LbCadastro_Click(object sender, EventArgs e)
        {
            CadastrarUsuario uso = new CadastrarUsuario();
            uso.Show();
        }

        private void LbListar_Click(object sender, EventArgs e)
        {
            ListarUsuario listar = new ListarUsuario();
            listar.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 som = new Form2();
            som.Show();
        }

        private void PtDesenvolvidores_Click(object sender, EventArgs e)
        {
            SobreDesenv talis = new SobreDesenv();
            talis.Show();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            SobreDesenv talis = new SobreDesenv();
            talis.Show();
        }

        private void PtSoft_Click(object sender, EventArgs e)
        {
            SobreSoft isaura = new SobreSoft();
            isaura.Show();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            SobreSoft isaura = new SobreSoft();
            isaura.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help joaty = new Help();
            joaty.Show();
        }
    }
}