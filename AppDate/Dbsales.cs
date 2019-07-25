using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Dbsales
    {

        private OleDbConnection cnn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private DataSet ds = new DataSet();
        public Dbsales()
        {
            // cnn.ConnectionString = @"Data Source=.\SQLExpress;Integrated Security=true; 
            //  AttachDbFilename=C:\AdoFinish\AdoFinish\App_Data\school.MDF;User Instance=true";
            // string path = "C:\Home\sara\WindowsFormsExem\WindowsFormsExem\db.accdb";
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=access\\db.accdb ;Persist Security Info=False";
        }
        //הפונקציה מחזירה את כל המכירות במאגר הנתונים 
        public DataSet GetAllSales()
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = "select * from sales";
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

        //הוספת הזמנה
        public void Insert(sales s)
        {
            string SqlStr = string.Format("insert into sales(saleNo,clientId,workerId,saleDate,total,quantity)values({0},{1},{2},'{3}',{4},{5})", s.SaleNo, s.ClientId, s.idSup, s.SaleDate, s.Total ,s.Quantity);
            InsDelUpd(SqlStr);
        }
        //מחיקת מורה
        public void Delete(sales s)
        {
            string SqlStr = string.Format("delete  from sales where SaleNo={0}",s );
            InsDelUpd(SqlStr);
        }
        //עדכון פרטי מורה
        public void Update(sales s)
        {
            string SqlStr = string.Format("update sales   set  clientId={0} ,worekerId={1},saleDate='{2}',total={3},quantity={4} where saleNo={5}", s.SaleNo,s.ClientId, s.idSup, s.SaleDate,s.Total, s.Quantity);
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
        public DataSet GetIteminfo(sales s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from sales where SaleNo={0}", s.SaleNo);
            ds = ReturnDS(SqlStr);
            return ds;
        }
        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int ClientId)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from sales where clientId={0}", ClientId);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        //פעולת חיפוש לקוח לפי ת.ז
        public DataSet Search(int ClientId)
        {
            DataSet ds = new DataSet();
            cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = string.Format("select * from sales  where clientId={0}", ClientId);
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
