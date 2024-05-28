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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //momicheta
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //momcheta
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //8а момичета
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //8а момчета
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //8б момичета
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //8б момчета
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //8в момичета
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //8в момчета
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //pokaji
        private void button2_Click(object sender, EventArgs e)
        {
            //8a
            int a1 = int.Parse(textBox1.Text);
            int a2 = int.Parse(textBox2.Text);
            //8b
            int a3 = int.Parse(textBox3.Text);
            int a4 = int.Parse(textBox4.Text);
            //8v
            int a5 = int.Parse(textBox5.Text);
            int a6 = int.Parse(textBox6.Text);
            int sum = 0;
            // momicheta
            if (radioButton1.Checked)
            {
                if(checkBox1.Checked && checkBox2.Checked)
                {
                    sum = a1 + a3;
                }
                else if(checkBox1.Checked && checkBox3.Checked)
                {
                    sum = a1 + a5;
                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    sum = a3 + a5;
                }
                else if (checkBox1.Checked)
                {
                    sum = a1;
                }
                else if(checkBox2.Checked) 
                {
                    sum = a3;
                }
                else if(radioButton3.Checked)
                {
                    sum = a5;
                }

            }
            //momcheta
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    sum = a2 + a4;
                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    sum = a2 + a6;
                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    sum = a4 + a6;
                }
                else if (checkBox1.Checked)
                {
                    sum = a2;
                }
                else if (checkBox2.Checked)
                {
                    sum = a4;
                }
                else if (radioButton3.Checked)
                {
                    sum = a6;
                }

            }
            // obhto
            if (radioButton3.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    sum = a1 + a2 + a3+ a4;
                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    sum = a1 + a2 +a5+ a6;
                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    sum = a3 + a4 + a5+a6;
                }
                else if (checkBox1.Checked)
                {
                    sum = a1+ a2;
                }
                else if (checkBox2.Checked)
                {
                    sum = a3 + a4;
                }
                else if (radioButton3.Checked)
                {
                    sum = a5 + a6;
                }

            }

            //int sum = a1 + a2 + a3 + a4+a5+a6;
            label2.Text = $"Брой: {sum}";
        }
    }
}
