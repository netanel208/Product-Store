using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class item
    {
        private int itemId;
        private string itemname;
        private int itemPrice;
        private int quantity;
        private int id;//קוד ספק

        public item()
        {
        }
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }
        public int ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int idSup
        {
            get { return id; }
            set { id = value; }
        }

    }
}
