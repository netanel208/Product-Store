using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class DbSaleDetails
    {
        private OleDbConnection cnn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private DataSet ds = new DataSet();
        public DbSaleDetails()
        {
            // cnn.ConnectionString = @"Data Source=.\SQLExpress;Integrated Security=true; 
            //  AttachDbFilename=C:\AdoFinish\AdoFinish\App_Data\school.MDF;User Instance=true";
            // string path = "C:\Home\sara\WindowsFormsExem\WindowsFormsExem\db.accdb";
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=Access\\db.accdb ;Persist Security Info=False"; ;
        }

        //הפונקציה מחזירה את כל הפריטים במאגר הנתונים 
        public DataSet GetAllSaleDetails()
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = "select * from salesDetails";
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }
            return ds;
        }

        //הפונקציה מחזירה נתונים לפי מחרוזת SQL   
        public DataSet GetQuery(string sql)
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cnn.Close(); }
            return ds;
        }

        //הוספת מכירה
        public void insertsaleDetails(SaleDetails s)
        {
            string SqlStr = string.Format("insert into salesDetails(saleNo,itemId,quantity )values({0},{1},{2})", s.SaleNo, s.ItemId, s.Quantity);
            InsDelUpd(SqlStr);
        }




        //מחיקת מכירה
        public void deletesaleDetails(int saleCode)
        {
            string SqlStr = string.Format("delete  from salesDetails where saleNo={0}", saleCode);
            InsDelUpd(SqlStr);
        }

        //עדכון פרטי פריט
        public void updatesaleDetails(SaleDetails s)
        {
            string SqlStr = string.Format("update salesDetails   set saleNo={0}  ,itemId={1}  ,quantity={2}  where saleNo={3}", s.SaleNo, s.ItemId , s.Quantity);
            InsDelUpd(SqlStr);
        }
        public void updatequantity(int itemcode, int quantity)
        {
            string SqlStr = string.Format("update item set quantity=(quantity-{0}) where itemId={1}", quantity, itemcode);
            InsDelUpd(SqlStr);
        }
        public void InsDelUpd(string SqlStr)
        {
            /*          טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
                   טענת יציאה : הפונקציה מעדכנת את בסיס הנתונים       
            */
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                // פתיחת ההתחברות עם בסיס הנתונים 
                cnn.Open();
                cmd.Connection = cnn;
                // sql  מאפיין אשר מאפשר לקבוע או לקבל את הוראת :CommandText המאפיין   
                cmd.CommandText = SqlStr;
                // (Delete,Update,Insert) לעדכון בסיס הנתונים sql מתודה שמבצעת הוראת 
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // סגירת ההתחברות (סגירת הקשר עם בסיס הנתונים חיונית בשביל לתרום ליעילות האפליקציה
                cnn.Close();
            }
        }

        /* טענת כניסה: הפונקציה מקבלת מחרוזת פקודה
              DataSet טענת יציאה: הפונקציה מחזירה
       */
        public DataSet ReturnDS(string SqlStr)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                //  sql מאפיין אשר מאפשר לקבוע או לקבל את הוראת :CommandText
                cmd.CommandText = SqlStr;
                //  OleDbConnection מאפיין אשר מאפשר לקבוע או לקבל את אובייקט ההתחברות מהמחלקה :Connection
                cmd.Connection = cnn;
                //DataSet ומשימה שנייה בכדי לעדכן את בסיס הנתונים בהתאם למידע שהתרחש ב  DataSet יצירת מופע למחלקה המייצגת אובייקט ההתחברות לבסיס הנתונים. ייצוג זה דרוש לשתי משימות משימה ראשונה בכדי להעביר נתונים מבסיס הנתונים ל 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                // DataSet טוענת את הנתונים לתוך אובייקט  Fill המתודה 
                da.Fill(ds);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
            finally
            {
                cnn.Close();
            }
            return ds;
        }

        public DataSet GetSaleDetailsinfo(SaleDetails s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from salesDetails where saleNo={0}", s.SaleNo);
            ds = ReturnDS(SqlStr);
            return ds;
        }
        //פעולה מחזירה אמת אם פריט נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int codesales)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from salesDetails where saleNo={0} ", codesales);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        public bool FoundSaleDetails(int codesales)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from salesDetails where saleNo={0} ", codesales);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }


        //פעולת חיפוש פריט לפי ת.ז

        //פעולת חיפוש פריט לפי ת.ז
        public DataSet SearchsaleDetails(int codesales)
        {
            DataSet ds = new DataSet();
            cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = string.Format("select * from salesDetails where saleNo={0}", codesales);
                cmd.Connection = cnn;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
            }
            catch { }
            finally
            {
                cnn.Close();
            }
            return ds;
        }
    }
}
