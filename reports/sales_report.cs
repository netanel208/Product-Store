using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.reports
{
    public partial class sales_report : Form
    {
        public sales_report()
        {
            InitializeComponent();
        }

        private void saleRep_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Dbsales db = new Dbsales();

            DateTime dt1 = Convert.ToDateTime(textBox1.Text.ToString()); //Convert.ToDateTime(textBox1.Text.ToString());
            DateTime dt2 = Convert.ToDateTime(textBox2.Text.ToString());

            string str1 = dt1.ToString("{mm/dd/yyyy}");
            string str2 = dt2.ToString("{mm/dd/yyyy}");

            //          string s = "SELECT * FROM sales WHERE salelDate between " + str1 + " AND " + str2;
            string s = "SELECT * FROM sales WHERE salelDate between #01/01/2015# AND #12/31/2015#";
            //MessageBox.Show(s);
            DataTable dt = db.GetQuery(s).Tables[0];


            foreach (DataRow dr in dt.Rows)
            {    //
                ListViewItem item = new ListViewItem((dr["saleNo"].ToString()));

                item.SubItems.Add(dr["clientId"].ToString());
                item.SubItems.Add(dr["workerId"].ToString());
                item.SubItems.Add(dr["Total"].ToString());
                item.SubItems.Add(dr["salelDate"].ToString());
                listView1.Items.Add(item);
            }
            label2.Text = listView1.Items.Count.ToString();
        }
    }
}
