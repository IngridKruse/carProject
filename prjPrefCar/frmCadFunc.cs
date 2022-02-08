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
    public partial class frmCadFunc : Form
    {
	    public frmCadFunc()
        {
            InitializeComponent();
        }

		private void btnCadFunc_Click(object sender, EventArgs e)
		{
			String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
			SqlConnection conecta = new SqlConnection(c);
			conecta.Open();

			if (conecta.State == System.Data.ConnectionState.Open)
			{

				string com = "insert into Table_Funcionario(Nome, Cargo, Login, Senha, Status, ADM) values('" + txtNomeFunc.Text + "', '" + txtCargoFunc.Text + "', '" + txtLoginFunc.Text + "', '" + txtSenhaFunc.Text + "', 0, 0)";
				SqlCommand comando = new SqlCommand(com, conecta);
				comando.ExecuteNonQuery();

				txtCargoFunc.Text = "";
				txtNomeFunc.Text = "";
				txtLoginFunc.Text = "";
				txtSenhaFunc.Text = "";

				MessageBox.Show("Cadastrado com sucesso!!!!");
			}
			
			

		}

        private void frmCadFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
