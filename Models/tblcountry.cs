using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcrazor.Models
{
    public class tblcountry
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
    }
}