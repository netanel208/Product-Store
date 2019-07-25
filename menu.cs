using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.reports;

namespace WindowsFormsApplication1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void עובדיםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void רישוםעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formworker w = new Formworker();
            w.Show();
        }

        private void לקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void מוצריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void רישוםמוצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void רישוםהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales i = new sales();
            i.Show();
        }

        private void דוחלקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients_report i = new clients_report();
            i.Show();
        }

        private void דוחמכירהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_report i = new sales_report();
            i.Show();
        }

        private void הוסףלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 i = new Form2();
            i.Show();
        }

        private void רישוםספקToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
