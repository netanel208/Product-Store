using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public class Dbworker
    {

        private OleDbConnection cnn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private DataSet ds = new DataSet();
        public Dbworker()
        {
            // cnn.ConnectionString = @"Data Source=.\SQLExpress;Integrated Security=true; 
            //  AttachDbFilename=C:\AdoFinish\AdoFinish\App_Data\school.MDF;User Instance=true";
            // string path = "C:\Home\sara\WindowsFormsExem\WindowsFormsExem\db.accdb";
            cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=access\\db.accdb ;Persist Security Info=False";
            //  cnn.ConnectionString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=app_data\\db.accdb ;Persist Security Info=False";

        }
        //הפונקציה מחזירה את כל המורים במאגר הנתונים 
        public DataSet GetAllworkers()
        {
            DataSet ds = new DataSet();

            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = "select * from worker";
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
        public DataSet GetQuery(string sql)         //סוג של שליפה
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

        //הוספת מורה
        public void insertworker(worker s)
        {
            string SqlStr = string.Format("insert into worker(id,Fname,Lname,city)values({0},'{1}','{2}','{3}')", s.ID, s.FName, s.LName, s.City);
            InsDelUpd(SqlStr);
        }
        //מחיקת מורה
        public void deleteworker(int Id)  //למחוק מתוך הטבלה לפי תז
        {
            string SqlStr = string.Format("delete  from worker where id={0}", Id);
            InsDelUpd(SqlStr);
        }
        //עדכון פרטי מורה
        public void updateworker(worker s)
        {
            string SqlStr = string.Format("update worker   set Fname='{0}', Lname='{1}' ,city='{2}', where id={3}", s.FName, s.LName, s.City, s.ID);
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
        public DataSet Getworkerinfo(worker s)
        {
            DataSet ds = new DataSet();
            string SqlStr = string.Format("select * from worker where id={0}", s.ID);
            ds = ReturnDS(SqlStr);
            return ds;
        }
        //פעולה מחזירה אמת אם לקוח נמצא אחרת מחזירה שקר לפי תז
        public bool Found(int idworker)
        {
            DataSet ds = new DataSet();
            string str = string.Format("select * from worker where id={0} ", idworker);
            ds = ReturnDS(str);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        //פעולת חיפוש לקוח לפי ת.ז
        public DataSet Searchworker(int idworker)
        {
            DataSet ds = new DataSet();
            cmd = new OleDbCommand();
            try
            {
                cmd.CommandText = string.Format("select * from worker  where id={0}", idworker);
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
