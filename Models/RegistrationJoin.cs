﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcrazor.Models
{
    public class RegistrationJoin
    {
        public int rid { get; set; }
        public string rname { get; set; }
        public string remail { get; set; }
        public string rpassword { get; set; }
        public string rdepartment { get; set; }
        public string rcountry { get; set; }
    }
}