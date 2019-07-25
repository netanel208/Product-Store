using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public  class client
    {
        private int clientId;
        private string clientFname;
        private string clientLname;
        private string clientAdress;
        private string clientPhon;
        private string clientEmail;
        public client()
        {
        }
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        public string FirstName
        {
            get { return clientFname; }
            set { clientFname = value; }
        }
        public string LastName
        {
            get { return clientLname; }
            set { clientLname = value; }
        }
     public string Adress
        {
            get { return clientAdress; }
            set {clientAdress = value; }
        }
        public string Phon
        {
            get { return clientPhon; }
            set { clientPhon = value; }
        }
        public string Email
        {
            get { return clientEmail; }
            set {clientEmail = value; }
        }




    }
}
