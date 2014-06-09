using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //creo el objeto
            //del modelo de datos
            PayrollDm nomina = new PayrollDm(
                @"C:\Users\chucholopez\Desktop\d5ana\EmployeeQuiz\Models\BASE.csv");

            //Busco el empleado dado su ID
            var empleado = nomina.GetEmployeeById(emp.Id);
           
            return View("WorkerView", empleado);
        }

    }
}
