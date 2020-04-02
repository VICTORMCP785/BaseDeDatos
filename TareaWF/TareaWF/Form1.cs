using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace TareaWF
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection ("Server=localhost; Database=lastone; Uid=root");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlCommand Comando = new MySqlCommand("Select * from animales", conexion);
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            Adapter.SelectCommand = Comando;
            DataTable table = new DataTable();
            Adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO animales (ID, NOMBRE, ESPECIE) VALUES ('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
            MySqlCommand Comando = new MySqlCommand(Query, conexion);

            Comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" Datos Insertados ");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
