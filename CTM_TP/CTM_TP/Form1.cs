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

namespace CTM_TP
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RO1SEE1;Initial Catalog=CTM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //remplisage des villeDepart 
            cnx.Open();
            cmd = new SqlCommand("select villeDepart from Trajet  ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();

            //remplisage des villeArrivee

            cmd = new SqlCommand("select villeDarrivee from Trajet  ", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            dr.Close();

            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            dataGridView1.Rows.Clear();
            
            cmd = new SqlCommand($"select * from Trajet where villeDepart = '{comboBox1.Text}' and villeDarrivee = '{comboBox2.Text}'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[1], dr[2], dr[3],dr[4],dr[5]);
            }
            cnx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
