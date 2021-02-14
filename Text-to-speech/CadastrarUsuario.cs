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
    public partial class CadastrarUsuario : DevComponents.DotNetBar.Metro.MetroForm
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                String talis = "server = 127.0.0.1; port = 3306; database = usuario; Uid = root; Pwd =  ";
                MySqlConnection isaura = new MySqlConnection(talis);
                isaura.Open();
                MySqlCommand jsmp = new MySqlCommand("PCD_Cadastro_Usuario", isaura);
                jsmp.CommandType = CommandType.StoredProcedure;
                jsmp.Parameters.AddWithValue("nom", TxtNome.Text);
                jsmp.Parameters.AddWithValue("pas", TxtSenha.Text);
                jsmp.Parameters.AddWithValue("nivel", CmbSexo.Text);
                jsmp.ExecuteNonQuery();
                
                MessageBox.Show("Cadastro de Feito Com Sucesso");
                isaura.Close();
                
            }
            catch (Exception jo)
            {

                MessageBox.Show(jo.Message);
                
            }
            
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}