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
    public partial class frmAgendar : Form
    {
        static String c = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PrefCarBanco.mdf;Integrated Security=True;Connect Timeout=30";
        static string com;
        SqlConnection conecta = new SqlConnection(c);
        String seelec;
        Boolean ADM;
        public frmAgendar(String seelec, Boolean ADM)
        {
            InitializeComponent();
            this.seelec = seelec;
            this.ADM = ADM;
        }

        private void frmAgendar_Load(object sender, EventArgs e)
        {
            conecta.Open();
            com = "select * from Table_Carros where Placa = '" + seelec + "'";
            SqlCommand comando = new SqlCommand(com, conecta);
            comando.ExecuteNonQuery();

            SqlDataReader read = comando.ExecuteReader();

            read.Read();
            lblModelo.Text = read[1].ToString();
            lblMarca.Text = read[3].ToString();
            lblNumPortas.Text = read[2].ToString();
            chb_8.Checked = false;
            chb_9.Checked = false;
            chb_10.Checked = false;
            chb_11.Checked = false;
            chb_13.Checked = false;
            chb_14.Checked = false;
            chb_15.Checked = false;
            chb_16.Checked = false;
            read.Close();

            com = "select Horario, Dia, Mes from Table_AlugaCarros where Placa = '" + seelec + "'";
            SqlCommand comando2 = new SqlCommand(com, conecta);
            comando2.ExecuteNonQuery();

            SqlDataReader read2 = comando2.ExecuteReader();
            while (read2.Read())
            {
                if (read2[1].ToString() == dateTime_Alugar.Value.Day.ToString()
                    && read2[2].ToString() == dateTime_Alugar.Value.Month.ToString())
                {
                    if (read2[0].ToString() == "8")
                    {
                        chb_8.Visible = false;
                    }
                    if (read2[0].ToString() == "9")
                    {
                        chb_9.Visible = false;
                    }
                    if (read2[0].ToString() == "10")
                    {
                        chb_10.Visible = false;
                    }
                    if (read2[0].ToString() == "11")
                    {
                        chb_11.Visible = false;
                    }
                    if (read2[0].ToString() == "13")
                    {
                        chb_13.Visible = false;
                    }
                    if (read2[0].ToString() == "14")
                    {
                        chb_14.Visible = false;
                    }
                    if (read2[0].ToString() == "15")
                    {
                        chb_15.Visible = false;
                    }
                    if (read2[0].ToString() == "16")
                    {
                        chb_16.Visible = false;
                    }
                }
            }


            //           lbl_Modelo.Text = seelec;
            //            MessageBox.Show(""+seelec);
            read2.Close();
            conecta.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            conecta.Close();
            conecta.Open();
            com = "select Horario, Dia, Mes from Table_AlugaCarros where Placa = '" + seelec + "'";
            SqlCommand comando2 = new SqlCommand(com, conecta);
            comando2.ExecuteNonQuery();

            SqlDataReader read2 = comando2.ExecuteReader();
            while (read2.Read())
            {
                if (read2[1].ToString() == dateTime_Alugar.Value.Day.ToString()
                    && read2[2].ToString() == dateTime_Alugar.Value.Month.ToString())
                {
                    if (read2[0].ToString() == "8")
                    {
                        chb_8.Visible = false;
                    }
                    if (read2[0].ToString() == "9")
                    {
                        chb_9.Visible = false;
                    }
                    if (read2[0].ToString() == "10")
                    {
                        chb_10.Visible = false;
                    }
                    if (read2[0].ToString() == "11")
                    {
                        chb_11.Visible = false;
                    }
                    if (read2[0].ToString() == "13")
                    {
                        chb_13.Visible = false;
                    }
                    if (read2[0].ToString() == "14")
                    {
                        chb_14.Visible = false;
                    }
                    if (read2[0].ToString() == "15")
                    {
                        chb_15.Visible = false;
                    }
                    if (read2[0].ToString() == "16")
                    {
                        chb_16.Visible = false;
                    }
                }
            }

            //while ()
            conecta.Close();
        }

        private void dateTime_Alugar_ValueChanged(object sender, EventArgs e)
        {
            conecta.Close();
            conecta.Open();
            chb_8.Visible = true;
            chb_9.Visible = true;
            chb_10.Visible = true;
            chb_11.Visible = true;
            chb_13.Visible = true;
            chb_14.Visible = true;
            chb_15.Visible = true;
            chb_16.Visible = true;

            com = "select Horario, Dia, Mes from Table_AlugaCarros where Placa = '" + seelec + "'";
            SqlCommand comando2 = new SqlCommand(com, conecta);
            comando2.ExecuteNonQuery();

            SqlDataReader read2 = comando2.ExecuteReader();
            while (read2.Read())
            {

                if (read2[1].ToString() == dateTime_Alugar.Value.Day.ToString()
                    && read2[2].ToString() == dateTime_Alugar.Value.Month.ToString())
                {
                    if (read2[0].ToString() == "8")
                    {
                        chb_8.Visible = false;
                    }
                    if (read2[0].ToString() == "9")
                    {
                        chb_9.Visible = false;
                    }
                    if (read2[0].ToString() == "10")
                    {
                        chb_10.Visible = false;
                    }
                    if (read2[0].ToString() == "11")
                    {
                        chb_11.Visible = false;
                    }
                    if (read2[0].ToString() == "13")
                    {
                        chb_13.Visible = false;
                    }
                    if (read2[0].ToString() == "14")
                    {
                        chb_14.Visible = false;
                    }
                    if (read2[0].ToString() == "15")
                    {
                        chb_15.Visible = false;
                    }
                    if (read2[0].ToString() == "16")
                    {
                        chb_16.Visible = false;
                    }
                }
            }

            //while ()
            conecta.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            conecta.Close();
            conecta.Open();
            int dia = DateTime.Now.Day, x = 0;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;


            if (dateTime_Alugar.Value.Day <= dia)
            {
                if (dateTime_Alugar.Value.Month <= mes)
                {
                    if (dateTime_Alugar.Value.Year <= ano)
                    {
                        MessageBox.Show("Não é possivel cadastrar nessa data");
                        x = 1;
                    }
                }
            }
            if (x == 0)
            {
                dia = dateTime_Alugar.Value.Day;
                mes = dateTime_Alugar.Value.Month;
                ano = dateTime_Alugar.Value.Year;
                if (chb_8.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(8,'" + dia.ToString() + "'," +
                   " '" + mes.ToString() + "','" + ano.ToString() + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_8.Visible = false;
                }
                if (chb_9.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(9,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_9.Visible = false;
                }
                if (chb_10.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(10,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_10.Visible = false;
                }
                if (chb_11.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(11,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_11.Visible = false;
                }
                if (chb_13.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(13,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_13.Visible = false;
                }
                if (chb_14.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(14,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_14.Visible = false;
                }
                if (chb_15.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(15,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_15.Visible = false;
                }
                if (chb_16.Checked)
                {
                    com = "insert into Table_AlugaCarros(Horario, Dia, Mes, Ano, Placa) " +
                   "values(16,'" + dateTime_Alugar.Value.Day + "'," +
                   " '" + dateTime_Alugar.Value.Month + "','" + dateTime_Alugar.Value.Year + "'," +
                   "'" + seelec + "' )";
                    SqlCommand comando = new SqlCommand(com, conecta);
                    comando.ExecuteNonQuery();
                    chb_16.Visible = false;
                }
                MessageBox.Show("Cadastrado com sucesso");
                conecta.Close();
            }
            chb_8.Checked = false;
            chb_9.Checked = false;
            chb_10.Checked = false;
            chb_11.Checked = false;
            chb_13.Checked = false;
            chb_14.Checked = false;
            chb_15.Checked = false;
            chb_16.Checked = false;
            conecta.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
   