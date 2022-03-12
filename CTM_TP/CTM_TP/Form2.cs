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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RO1SEE1;Initial Catalog=CTM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr; 

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //enregistre 
            try
            {
                cnx.Open();
                cmd = new SqlCommand("insert into law3lm values (" + int.Parse(textBox1.Text) + ",'" + comboBox1.SelectedItem + "','" + textBox8.Text + "'," + float.Parse(textBox7.Text) + " "  + ")", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Bien Ajouter");
            }
            catch
            {
                MessageBox.Show("Non Ajouter");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox8.Text = DateTime.Now.ToString();
        }
    }
}
