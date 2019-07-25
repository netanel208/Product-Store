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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("בבקשה התחבר");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Dbworker DbWorkers1 = new Dbworker();
            worker Workers1 = new worker();
            worker Workers2 = new worker();
            int x = int.Parse(textBox1.Text);
            if (DbWorkers1.Found(x) == false)

                MessageBox.Show("לא קיים עובד בעל ת.ז זה");
            else
            {
                Dbworker db = new Dbworker();
                string s = "select * from worker where id =" + textBox1.Text + "";
                int r = Convert.ToInt32(db.GetQuery(s).Tables[0].Rows[0]["rank"].ToString());

                //string s = "select * from item where Itemname = '" + comboBox2.Text + "'";

                //textBox3.Text = db.GetQuery(s).Tables[0].Rows[0]["itemId"].ToString();



                // Workers1.ID = int.Parse(textBox1.Text);
                //Workers1.Rank= int.Parse(textBox2.Text);




                if ((r != 2) && (r != 1))
                    MessageBox.Show("עובד לא קיים במערכת");


               //else if ((Workers1.Rank != 2) && (Workers1.Rank != 1))
                //   MessageBox.Show("עובד לא קיים במערכת");

                else if (r == 1)

                //else if (Workers1.Rank == 1)
                {
                    MessageBox.Show("התחברת בהצלחה");
                    menuworker i = new menuworker();
                    i.Show();
                }

                else 
                {
                    MessageBox.Show("התחברת בהצלחה");
                    menu i = new menu();
                    i.Show();
                }
            }
        }
    }
}

    

