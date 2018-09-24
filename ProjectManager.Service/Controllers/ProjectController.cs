using CommonEntities;
using ProjectManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManager.Service.Controllers
{
    [RoutePrefix("Project")]
    public class ProjectController : ApiController
    {
        Project p1;
        public ProjectController()
        {
            p1 = new Project();
        }
        [Route("GetUsers")]
        [HttpGet]
        public List<UsersModel> GetUsers()
        {
            return p1.GetUsers();
        }

        [Route("AddUser")]
        [HttpPost]
        public bool AddUser(UsersModel user)
        {            
            return p1.AddUser(user);            
        }
    }
}
