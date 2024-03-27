using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBSD.CW2._14068._13716._14883.Models
{
    public class Employee
    {
        public int eId {  get; set; }
        public string eFirstName { get; set; }
        public string eLastName { get; set; }
        public string eJobPosition { get; set; }
        public string eEmail { get; set; }
        public string branchId { get; set; }
    }
}