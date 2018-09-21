using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskManager.Service.Controllers
{
    public class TaskController : ApiController
    {
        public string Get()
        {
            return "Hi";
        }
    }
}
