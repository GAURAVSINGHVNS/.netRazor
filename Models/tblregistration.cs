using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcrazor.Models
{
    public class tblregistration
    {
        [Key]
        public int rid { get; set; }
        public string rname { get; set; }
        public string remail { get; set; }
        public string rpassword { get; set; }
        public int rdepartment { get; set; }
        public int rcountry { get; set; }

    }
}