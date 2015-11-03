using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngularForMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularForMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployees()
        {
            List<EmployeeVM> list = new List<EmployeeVM>()
            {
                new EmployeeVM()
                {
                    FullName = "Alper Dortbudak"
                },
                new EmployeeVM()
                {
                    FullName = "Connor Dortbudak"
                }
            };

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, camelCaseFormatter),
                ContentType = "application/json"
            };


            return jsonResult;
        }

        public ActionResult Create(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(201, "New employee added");
            }

            var errors = new List<string> {"Insert Failed"};

            if (!ModelState.IsValidField("Notes"))
                errors.Add("Notes must be at least 5 characters long.");

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError,
                string.Join("  ",errors));
        }
    }
}