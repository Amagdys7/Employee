using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.DAL.Repository;
using Employee.BL.RepositoryClasses;

namespace MyEmployee.UI.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository _Employeerepo;

        public EmployeeController(IEmployeeRepository Employeerepo)
        {
            this._Employeerepo = new EmployeeNRepository();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(_Employeerepo.GetEmployeeNs().ToList());
        }
    }
}