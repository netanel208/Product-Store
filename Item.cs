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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            DbItem db = new DbItem();
            dataGridView1.DataSource = db.GetAllItems().Tables[0];
            comboBox1.DataSource = db.GetAllItems().Tables[0];//fill combo
            comboBox1.ValueMember = "itemId";//(שם הטור שיוצג  (לצורך הדוגמה מוצג מס פרי על אותו עקרון אפשר מספר ספק
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbItem db = new DbItem();
            item itm1 = new item();
            int Idw = int.Parse(textBox1.Text);
            if (db.Found(Idw) == true)
                MessageBox.Show("קיים משתמש עם ID זהה");//בודק שאין עוד משתמש עם אותה תז לפני עדכון בטבלה
            else
            {
                itm1.ItemId = Idw;//הכנסה לטבלה
                itm1.Itemname = textBox2.Text;
                itm1.ItemPrice = int.Parse(textBox3.Text);
                itm1.Quantity = int.Parse(textBox4.Text);
                itm1.idSup = int.Parse(comboBox1.Text);
                db.Insert(itm1);
                dataGridView1.DataSource = db.GetAllItems().Tables[0];//להציג את הטבלה בגריד אחרי העדכון
                MessageBox.Show("התווסף פריט");
            }

            textBox1.Text = null; //לאחר הוספת פריט, השדות יתרוקנו
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            comboBox1.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            item t = new item();
            t.ItemId = int.Parse(textBox6.Text);
            DbItem db = new DbItem();
            if (db.Found(t.ItemId) == false)
            {
                textBox1.BackColor = Color.Yellow;

                textBox1.Text = t.ItemId + " :לא נמצא לקוח עם ת.ז  ";

                // dataGridView1.DataSource = db.Searchclient(t.ClientId).Tables[0];
            }
            else
            {
                DataTable ds = db.Searchclient(t.ItemId).Tables[0];

                textBox1.Text = ds.Rows[0]["itemId"].ToString();
                textBox2.Text = ds.Rows[0]["itemName"].ToString();
                textBox3.Text = ds.Rows[0]["ItemPrice"].ToString();
                textBox4.Text = ds.Rows[0]["Quantity"].ToString();
                comboBox1.Text = ds.Rows[0]["id"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbItem db = new DbItem();


            item editItem = new item();
            editItem.ItemId = Convert.ToInt32(textBox1.Text);

            editItem.Itemname = textBox2.Text;
            editItem.ItemPrice = Convert.ToInt32(textBox3.Text);
            editItem.Quantity = Convert.ToInt32(textBox4.Text);
            editItem.idSup = Convert.ToInt32(comboBox1.Text);

            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                db.Update(editItem);
                MessageBox.Show("update item");
                dataGridView1.DataSource = db.GetAllItems().Tables[0];


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
        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            DbItem db = new DbItem();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.Delete(Convert.ToInt32(dr["ItemId"]));
                dataGridView1.DataSource = db.GetAllItems().Tables[0];
            }
        }
    }
}

        
