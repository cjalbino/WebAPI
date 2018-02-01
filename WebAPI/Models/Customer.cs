using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Customer
    {
        public int Id { set; get; }
        public string CustomerName { set; get; }
        public string Address { set; get;}
        public string City { set; get; }
        public string Pincode { set; get; }
    }
}