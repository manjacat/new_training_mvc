using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            List<Employee> emp = Employee.GetSampleEmployee();
            return View(emp);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            if (id > 10)
            {
                // Demonstrate how to return HTTP StatusCode
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            Employee emp = Employee.GetEmployee(id);
            return View(emp);
        }

        // Returns a JSON list
        public ActionResult IndexJson()
        {
            List<Employee> emp = Employee.GetSampleEmployee();
            return Json(emp);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Add insert script here
                    return RedirectToAction(nameof(Index), new { create = "success"});
                }
                else
                {
                    return View(emp);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp = Employee.GetEmployee(id);
            return View(emp);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Add Edit script here
                    //Update DB
                    return RedirectToAction(nameof(Index), new { edit = "success" });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = Employee.GetEmployee(id);
            return View(emp);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
