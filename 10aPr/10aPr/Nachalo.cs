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
    public partial class Nachalo : Form
    {
        public Nachalo()
        {
            InitializeComponent();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proverka1.Hide();
            vhod1.Hide();
            galeriq1.Hide();
            kontakti1.Hide();
        }

        private void админToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Admin a1 = new Admin();
            a1.Show();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisak s1 = new Spisak();
            s1.Show();
        }

        private void входToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vhod1.BringToFront();
        }

        private void галерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            galeriq1.BringToFront();
        }

        private void контактиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontakti1.BringToFront();
        }
    }
}
