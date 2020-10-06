using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp5.Models
{
    public class Facility
    {
        [Key]
        public int fID { get; set; }
        public string fName { get; set; }
        public string fDesc { get; set; }
        public string fModel { get; set; }
        public int fPrice { get; set; }
    }
}