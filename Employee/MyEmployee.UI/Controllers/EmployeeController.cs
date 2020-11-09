using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.DAL.Repository;
using Employee.BL.RepositoryClasses;
using Employee.DAL.Entities;

namespace MyEmployee.UI.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _Employeerepo;

        public EmployeeController(IEmployeeRepository Employeerepo)
        {
            this._Employeerepo = Employeerepo;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(_Employeerepo.GetEmployeeNs().ToList());
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult CreateEmployee(EmployeeN emp)
        {

            return View();
        }
    }
}