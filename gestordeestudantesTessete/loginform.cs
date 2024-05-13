using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestordeestudantesTessete
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {
           
        }

        private void logarbotao_Click(object sender, EventArgs e)
        {
            meubancodedados meubancodedados = new meubancodedados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();
            MySqlCommand comandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`= @usuario AND `senha`= @senha", meubancodedados.getConexao);

            comandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textboxuser.Text;
            comandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxsenha.Text;

            meuAdaptadorSql.SelectCommand = comandoSql;

            meuAdaptadorSql.Fill(tabelaDeDados);

            if (tabelaDeDados.Rows.Count > 0)
            {
                MessageBox.Show("ENTRAGATINHA");
            }
            else
            {
                MessageBox.Show("SAIPIRANHA.", "burro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarbutao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
