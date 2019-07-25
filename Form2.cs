using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DbClient db = new DbClient();
            dataGridView1.DataSource = db.GetAllclient().Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                DbClient db = new DbClient();//create item's object 
                client itm = new client();
                itm.ClientId = int.Parse(textBox1.Text);
                itm.FirstName = textBox2.Text;
                itm.LastName = textBox3.Text;
                itm.Adress = textBox4.Text;
                itm.Phon = textBox5.Text;
                itm.Email = textBox6.Text;
              
           // itm. = dateTimePicker1.Value.ToShortDateString();
                
           for ( int i = 0 ; i<=8 ; i++)
           { if (i != 9)

                db.insertclient(itm);



                dataGridView1.DataSource = db.GetAllclient().Tables[0];
                MessageBox.Show("Add client");
            
     
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client t = new client();
            t.ClientId = int.Parse(textBox7.Text);
            DbClient db = new DbClient();
            if (db.Found(t.ClientId) == false)
            {
                textBox7.BackColor = Color.Yellow;

                textBox7.Text = t.ClientId + " :לא נמצא לקוח עם ת.ז  ";

                // dataGridView1.DataSource = db.Searchclient(t.ClientId).Tables[0];
            }
            else
            {
                DataTable ds = db.Searchclient(t.ClientId).Tables[0];

                textBox1.Text = ds.Rows[0]["clientId"].ToString();
                textBox2.Text = ds.Rows[0]["clientFname"].ToString();
                textBox3.Text = ds.Rows[0]["clientLname"].ToString();
                textBox4.Text = ds.Rows[0]["clientAdress"].ToString();
                textBox5.Text = ds.Rows[0]["clientPhon"].ToString();
                textBox6.Text = ds.Rows[0]["clientEmail"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DbClient db = new DbClient();


            client editClient = new client();
            editClient.ClientId = Convert.ToInt32(textBox1.Text);

            editClient.FirstName = textBox2.Text;
            editClient.LastName = textBox3.Text;
            editClient.Adress = textBox4.Text;
            editClient.Phon = textBox5.Text;
            editClient.Email = textBox6.Text; 



            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                db.updateclient(editClient);
                MessageBox.Show("update client");
                dataGridView1.DataSource = db.GetAllclient().Tables[0];


            }
        }

        private void DellBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            DbClient db = new DbClient();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.deleteclient(Convert.ToInt32(dr["ClientId"]));
                dataGridView1.DataSource = db.GetAllclient().Tables[0];

            }
        }

        private DataRow GetSelectedRow()
        {


            DataTable dt = null;
            if (dataGridView1.DataSource is DataTable)
                dt = dataGridView1.DataSource as DataTable;
            else if (dataGridView1.DataSource is BindingSource)
                dt = ((DataSet)((BindingSource)dataGridView1.DataSource).DataSource).Tables[0];
            else
                return null;

            return dt.Rows[this.dataGridView1.CurrentRow.Index];

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
