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
    public partial class clients_report : Form
    {
        public clients_report()
        {
            InitializeComponent();
        }

        private void clientRep_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            DbClient db = new DbClient();
            string s = "select * from client ORDER BY client.[clientLname] ";
            DataTable dt = db.ReturnDS(s).Tables[0];

            label3.Text = dt.Rows.Count.ToString();
            foreach (DataRow dr in dt.Rows)
            {    //
                ListViewItem item = new ListViewItem((dr["clientLname"].ToString()));

                item.SubItems.Add(dr["clientFname"].ToString());
                item.SubItems.Add(dr["clientAdress"].ToString());
                item.SubItems.Add(dr["clientPhon"].ToString());
                item.SubItems.Add(dr["clientEmail"].ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
