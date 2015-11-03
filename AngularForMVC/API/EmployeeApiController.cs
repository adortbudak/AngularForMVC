using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularForMVC.Models;

namespace AngularForMVC.API
{
    public class EmployeeApiController : ApiController
    {
        public IEnumerable<EmployeeVM> Get()
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

            return list;
        }

        public HttpResponseMessage Post([FromBody] EmployeeVM employee)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK) {Content = new StringContent("12345")};

            return response;
        }
    }
}
