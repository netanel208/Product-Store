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
    public partial class Formworker : Form
    {
        public Formworker()
        {
            InitializeComponent();
        }

        private void Formworker_Load(object sender, EventArgs e)
        {
            Dbworker db = new Dbworker();//כדי לשלוף נתונים מהטבלה יש להגדיר את הטבלה במשתנה חדש
            dataGridView1.DataSource = db.GetAllworkers().Tables[0];//להציג את הטבלה בגריפ
        }
        private DataRow GetSelectedRow() // אין לי מושג מה זה , קשור למחיקה
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

        private void btsend_Click(object sender, EventArgs e)
        {
            Dbworker dbw1 = new Dbworker();
            worker w1 = new worker();
            int Idw = int.Parse(txtid.Text);
            if (dbw1.Found(Idw) == true)
                MessageBox.Show("קיים משתמש עם ID זהה");//בודק שאין עוד משתמש עם אותה תז לפני עדכון בטבלה
            else
            {
                w1.ID = Idw;//הכנסה לטבלה
                w1.FName = txtf.Text;
                w1.LName = txtl.Text;
                w1.City = txtc.Text;
                dbw1.insertworker(w1);
                dataGridView1.DataSource = dbw1.GetAllworkers().Tables[0];//להציג את הטבלה בגריד אחרי העדכון
                MessageBox.Show("התווסף פריט");
            }

            txtid.Text = null; //לאחר הוספת פריט, השדות יתרוקנו
            txtf.Text = null;
            txtl.Text = null;
            txtc.Text = null;
            
        }

        private void btser_Click(object sender, EventArgs e)
        {
            worker t = new worker();
            t.ID = int.Parse(txtser.Text);
            Dbworker db = new Dbworker();
            if (db.Found(t.ID) == false)
            {
                txtid.BackColor = Color.Yellow;//אם אין כזה בטבלה תכתוב הודעת שגיאה בטקס של האיי די, יש אפשרות להציג בכל מיני דרכים
                txtid.Text = t.ID + "לא נמצא לקוח עם ת.ז:";
            }
            else
            {
                DataTable dt = db.Searchworker(t.ID).Tables[0];//כששולפים מטבלה אפשר להשתמש או בדטה טייבל או דטה סט, פה השתמשנו בזה כי אנחנו רוצים לטפל בכל שדה בנפרד
                txtid.Text = dt.Rows[0]["Id"].ToString();
                txtf.Text = dt.Rows[0]["Fname"].ToString();
                txtl.Text = dt.Rows[0]["Lname"].ToString();
                txtc.Text = dt.Rows[0]["city"].ToString();
             
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {

            Dbworker db = new Dbworker();

            worker editw = new worker();
            editw.ID = int.Parse(txtid.Text); //מכניסה את הערכים למשתנה חדש שבסופו של דבר יכנס לטבלה במקום הלא מעודכן
            editw.FName = txtf.Text;
            editw.LName = txtl.Text;
            editw.City = txtc.Text;
      
            DialogResult result = System.Windows.Forms.DialogResult.OK;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                db.updateworker(editw); // תכניס לטבלה את המשתנה המעודכן
                MessageBox.Show("פריט עודכן בהצלחה");
                dataGridView1.DataSource = db.GetAllworkers().Tables[0]; // תראה את העדכון בטבלה


            }



        }

        private void btdelete_Click(object sender, EventArgs e)
        {

            DataRow dr = GetSelectedRow();
            if (dr == null)
                return;
            Dbworker db = new Dbworker();
            if (MessageBox.Show("למחוק את הרשומה?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.deleteworker(Convert.ToInt32(dr["id"]));
                dataGridView1.DataSource = db.GetAllworkers().Tables[0];
            }
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}