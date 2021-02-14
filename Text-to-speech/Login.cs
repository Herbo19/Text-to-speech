using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace Text_to_speech
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public void logar_Usuario()
        {
            try
            {
                String talis = "server = 127.0.0.1; port = 3306; database = usuario; Uid = root; Pwd =  ";
                MySqlConnection isaura = new MySqlConnection(talis);
                MySqlCommand jsmp = new MySqlCommand("PCD_Autenticar_Usuario", isaura);
                jsmp.CommandType = CommandType.StoredProcedure;
                jsmp.Parameters.AddWithValue("nome_login", TxtNome.Text);
                jsmp.Parameters.AddWithValue("pasword", TxtSenha.Text);
                MySqlDataReader dataReader;
                isaura.Open();
                dataReader = jsmp.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    while (dataReader.Read())
                    {
                        LbUsuario.Text = dataReader["Acesso"].ToString();

                       TelaPrincipal s = new TelaPrincipal(LbUsuario.Text);
                        s.Show();
                        Visible = false;



                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtAutenticar_Click(object sender, EventArgs e)
        {
            logar_Usuario();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            // Botão para cancelar
            Application.Exit();
        }
    }
}