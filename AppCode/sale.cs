using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    public class sale
    {
        private int saleNo;//קוד הזמנה
        private string clientId;//ת.ז לקוח
        private DateTime saleDate;//תאריך הזמנה
        private int workerId;//ת.ז עובד
        private int total;//סך הכל לתשלום
        private int quantity;//כמות
        public sale()
        {
        }

        public int SaleNo
        {
            get { return saleNo; }
            set { saleNo = value; }
        }
        public string ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int idSup
        {
            get { return workerId; }
            set { workerId = value; }
        }

    }

}