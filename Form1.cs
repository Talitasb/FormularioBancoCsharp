using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Banco_Monitoria_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OKSRU50;Initial Catalog=Monitoriac#;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "SELECT * FROM Aluno";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    listBox1.Items.Add(String.Format("Nome: {0} - Endereço: {1} - Cidade: {2} - Bairro: {3} - " + 
                        "UF: {4} - Sexo: {5} ", sqlDataReader["Nome"], sqlDataReader["Endereço"], sqlDataReader["Cidade"], 
                        sqlDataReader["Bairro"], sqlDataReader["UF"], sqlDataReader["Sexo"]));
                }
            }
            catch (SqlException abobora)
            {
                MessageBox.Show("deu um erro" + abobora.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OKSRU50;Initial Catalog=Monitoriac#;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand datacommand = new SqlCommand("INSERT INTO Aluno VALUES(@ID, @Nome, @Endereço, @Cidade, @Bairro, @UF, @Sexo )");
                datacommand.Connection = conn;
                datacommand.Parameters.AddWithValue("@ID", Convert.ToInt32(Id.Text));
                datacommand.Parameters.AddWithValue("@Nome", Nome.Text);
                datacommand.Parameters.AddWithValue("@Endereço", Endereço.Text);
                datacommand.Parameters.AddWithValue("@Cidade", Cidade.Text);
                datacommand.Parameters.AddWithValue("@Bairro", Bairro.Text);
                datacommand.Parameters.AddWithValue("@UF", UF.Text);
                datacommand.Parameters.AddWithValue("@Sexo", Sexo.Text);
                datacommand.ExecuteNonQuery();
                

                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            catch (SqlException abobora)
            {
                MessageBox.Show("deu um erro" + abobora.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OKSRU50;Initial Catalog=Monitoriac#;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand datacommand = new SqlCommand("DELETE FROM ALUNO WHERE id_aluno = @ID", conn);
                datacommand.Parameters.AddWithValue("@ID", Convert.ToInt32(Id.Text));
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso!");
            }
            catch (SqlException abobora)
            {
                MessageBox.Show("deu um erro" + abobora.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

