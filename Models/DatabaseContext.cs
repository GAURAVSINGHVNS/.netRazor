using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcrazor.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()  : base("abc")
        {

        }
        public DbSet<tblregistration> tblregistrations { get; set; }
        public DbSet<tbldepartment> tbldepartments { get; set; }
        public DbSet<tblcountry> tblcountries { get; set; }

    }
}