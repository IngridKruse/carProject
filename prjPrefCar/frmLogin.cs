using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjPrefCar
{
    public partial class frmLogin : Form
    {
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        SqlConnection conecta = new SqlConnection(c);
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFunc ger = new frmCadFunc();
            this.Hide();
            ger.ShowDialog();
            this.Show();
            frmLogin_Load(sender, e);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            conecta.Open();
            com = "select Login, Senha, Status, ADM from Table_Funcionario";
         //   com = "select COUNT(Id) from Table_Funcionario where Login = '" + txtLogin.Text.ToString()+"' and Senha = '"+txtSenha.Text.ToString()+ "' and Status = 1";
            SqlCommand comando = new SqlCommand(com, conecta);
            comando.ExecuteNonQuery();
            SqlDataReader read = comando.ExecuteReader();
            int x = 0;
            while (read.Read())
            {
                if (read[0].ToString() == txtLogin.Text.ToString() &&
                        read[1].ToString() == txtSenha.Text.ToString())
                {
                    x = 1;
                    if (read[2].Equals(true))
                    {
                        if(read[3].Equals(true))
                        {
                            frmListarCarro ger = new frmListarCarro(true);
                            this.Hide();
                            ger.ShowDialog();
                            this.Show();
                            frmLogin_Load(sender, e);
                            break;
                        }
                        else
                        {
                            frmListarCarro ger = new frmListarCarro(false);
                            this.Hide();
                            ger.ShowDialog();
                            this.Show();
                            frmLogin_Load(sender, e);
                            break;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Sua conta ainda não foi aprovada, entre em contato com o administrador ou aguarde");
                        break;
                    }
                }

            }
            if(x==0)
            {
                MessageBox.Show("Login ou Senha incorreta");
            }
            conecta.Close();
        }
    }
}
