using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sales : Form
    {
        public string SaleNo;
        public object ClientId;
        public object idSup;
        public object SaleDate;
        public object Quantity;
        public object Total;
       
        public sales()
        {
            OleDbCommand cmd = new OleDbCommand();
            
           // int total = 0;//ישמש 2 פעולות (הכנסה ,והוצאה) מסל קניות לכן גלובלי 
            InitializeComponent();
        }
        DbItem db;
        private void label9_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {
            db = new DbItem();
            //    dataGridView1.DataSource = db.GetAllItems().Tables[0];
            //מכניס ערך של ההזמנה הכי חדשה.
            textBox1.Text = db.GetQuery("SELECT Count(*) FROM Sales").Tables[0].Rows[0][0].ToString();
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();

            DataTable dt = db.GetQuery("select * from client").Tables[0];
            comboBox1.DataSource = db.GetQuery("select * from client").Tables[0];//fill combo
            comboBox1.ValueMember = "clientId";//שם הטור שיוצג

            comboBox2.DataSource = db.GetQuery("select * from item").Tables[0];//fill combo
            comboBox2.ValueMember = "itemName";//שם הטור שיוצג

            dt = db.GetQuery("select * from worker").Tables[0];
            comboBox3.DataSource = db.GetQuery("select * from worker").Tables[0];//fill combo
            comboBox3.ValueMember = "id";//שם הטור שיוצג
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

     

        public int total { get; set; }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void totalSale_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // מילוי הסל 
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";
            dataGridView1.Columns[3].Name = "Product count";
            dataGridView1.Columns[4].Name = "Product count*Price";
            int sellCost = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(SaleQuantity.Value.ToString());
            string[] row = new string[] { textBox1.Text, comboBox2.Text, textBox4.Text, textBox5.Text.ToString(), sellCost.ToString() };
            dataGridView1.Rows.Add(row);

            total += sellCost;//צבירה
            totalSale.Text = total.ToString();//הצגת הסכום
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            // מחיקה מהסל

            total = int.Parse(totalSale.Text);
            int selectedCount = dataGridView1.SelectedRows.Count;

            while (selectedCount > 0)// נשתמש בלולאה ולא במשפט תנאי כדי לאפשר למחוק גם אם סומנו יותר שורה אחת
            {
                if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!dataGridView1.SelectedRows[0].IsNewRow)
                    {
                        total -= int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());// עידכון שדה סה"כ
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);//מחיקה מהסל 
                        selectedCount--;

                    }
                    else
                        MessageBox.Show("אין רשומות למחוק");
                }
                totalSale.Text = total.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //מילוי פרטי  לקוח לפי בחירת קוד לקוח
            if (comboBox1.Focus() == true)
            {
                string s = "select * from client where clientId =" + comboBox1.Text + "";

                textBox2.Text = db.GetQuery(s).Tables[0].Rows[0]["clientFname"].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //מילוי פרטי  מוצר לפי בחירת קוד מוצר
            if (comboBox2.Focus() == true)
            {
                string s = "select * from item where itemName = '" + comboBox2.Text + "'";

                textBox3.Text = db.GetQuery(s).Tables[0].Rows[0]["itemId"].ToString();
                textBox4.Text = db.GetQuery(s).Tables[0].Rows[0]["itemprice"].ToString();
                textBox5.Text = db.GetQuery(s).Tables[0].Rows[0]["quantity"].ToString();
            }
        }
    }
}