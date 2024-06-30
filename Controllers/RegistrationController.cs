using mvcrazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mvcrazor.Controllers
{
    public class RegistrationController : Controller
    {
        DatabaseContext _db = new DatabaseContext();
        [HttpGet]
        public ActionResult Registrationform(int A = 0)
        {
            ViewBag.dpt = _db.tbldepartments.ToList();
            ViewBag.ctr = _db.tblcountries.ToList();
            tblregistration obj = new tblregistration();
            if (A > 0)
            {
                var data = (from R in _db.tblregistrations where R.rid == A select R).ToList();
                obj.rid = data[0].rid;
                obj.rname = data[0].rname;
                obj.remail = data[0].remail;
                obj.rpassword = data[0].rpassword;
                obj.rdepartment = data[0].rdepartment;
                obj.rcountry = data[0].rcountry;
                ViewBag.BT = "Update Data";
            }

            return View(obj);
        }
        [HttpPost]
          public ActionResult InsertUser(tblregistration _reg)
        {
            _db.tblregistrations.Add(_reg);
            _db.SaveChanges();
            return RedirectToAction("ShowUser");
            
        }
        public ActionResult DeleteUser(int A = 0)
        {
            var data = _db.tblregistrations.Find(A);
            _db.tblregistrations.Remove(data);
            _db.SaveChanges();
            return RedirectToAction("ShowUser");
        }
        public ActionResult ShowUser()
        {
            var data = (from R in _db.tblregistrations
                        join D in _db.tbldepartments on R.rdepartment equals D.did 
                        join C in _db.tblcountries on R.rcountry equals C.cid
                        select new  RegistrationJoin{
                            rid = R.rid,
                            rname = R.rname,''''''''''''''''''''''''''''''''''''''''''''''
                            remail = R.remail,
                            rpassword = R.rpassword,
                            rdepartment = D.dname,
                            rcountry = C.cname,
                        }).ToList();
            return View(data);


        }
    }
}