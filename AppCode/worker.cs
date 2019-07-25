using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class worker
    {
        private int Id;
        private string Fname;
        private string Lname;
        private string city;
       

        public worker()
        {
        }
        public int ID  // לשים לב שהשם של הפעולה באות גדולה והתכונה באות קטנה, לא יכול להיות אותו דבר!
        {
            get { return Id; }
            set { Id = value; }
        }
        public string FName
        {
            get { return Fname; }
            set { Fname = value; }
        }
        public string LName
        {
            get { return Lname; }
            set { Lname = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
      

      
    }
}
