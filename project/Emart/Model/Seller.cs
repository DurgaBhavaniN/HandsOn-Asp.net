using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Model
{
    public class Seller
    {
        public int s_id { get; set; }
        public string s_name { get; set; }
        public string s_pwd { get; set; }
        public string s_emailid { get; set; }
        public double gstin { get; set; }
        public string bank_details { get; set; }
        public string postal_address { get; set; }
        public Seller(int s_id, string s_name, string s_pwd, string s_emailid, string postal_address, double gstin, string bank_details)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            this.s_pwd = s_pwd;
            this.s_emailid = s_emailid;
            this.postal_address = postal_address; ;
            this.gstin = gstin;
            this.bank_details = bank_details;
        }

    
}
}
