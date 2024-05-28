using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proect10a
{
    public partial class proverka : UserControl
    {
        public proverka()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123456789")
            {
                MessageBox.Show("Dobre dohyla,Ivet!");

            }
            else
            {
                MessageBox.Show("Grehno EGN");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ivet")
            {
                MessageBox.Show("Dobre dohyla,Ivet!");
                label2.Text = "Zdravei, " + textBox2.Text + "!";
            }
            else
            {
                MessageBox.Show("Grehno ime");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

