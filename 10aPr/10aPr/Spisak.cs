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
    public partial class Spisak : Form
    {
        public Spisak()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //zatvori
        private void button3_Click(object sender, EventArgs e)
        {
            Spisak forma = new Spisak();
            forma.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //dobavi
        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            listBox1.Items.Add(number);
            labela2.Text =$"Вкарано : {number}";
        }
        //izchisti
        private void button2_Click(object sender, EventArgs e)
        {

            int number = int.Parse(textBox1.Text);
            textBox1.Clear();
        }
        //sortirai
        private void button4_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            foreach (int item in listBox1.Items)
            {
                list.Add(item);
            }
            list.Sort();
            listBox1.Items.Clear();
            foreach (int items in list)
            {
                listBox1.Items.Add(items);
            }
        }

        private void Spisak_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
