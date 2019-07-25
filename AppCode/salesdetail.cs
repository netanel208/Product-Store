using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SaleDetails
    {
        private int saleNO;
        private int itemId;
        private int quantity;

        public SaleDetails()
        {
        }

        public int SaleNo
        {
            get { return saleNo; }
            set { saleNo = value; }
        }

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public static int Count { get; set; }

        public int saleNo { get; set; }
    }
}
