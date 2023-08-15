using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form2 : Form
    {
        Data.connection myServer = new Data.connection();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.connection.datasource();
                myServer.connectionOpen();
                MessageBox.Show("Database connection Success");
                myServer.connectionClose();
            }
            catch (Exception)
            {
                MessageBox.Show("Databas Exception");
                myServer.connectionClose();
            }
            finally
            {
                myServer.connectionClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputBox = textBox1.Text;
            //string inserQuery = "INSERT INTO"

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
