using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using IBLL;
using BLL;


namespace DPCore.Controllers
{

    [ApiController]
    public class DefaultController : ControllerBase
    {
        IBLLStudent _bll;
        public DefaultController(IBLLStudent bLL)
        {
            _bll = bLL;
        }
        [RouteAttribute("api/[controller]/GetStudents")]
        [HttpGet]
        public List<StudentModel> GetStudents()
        {
            return _bll.GetStudents();
        }
        [RouteAttribute("api/[controller]/GetUserLogins")]
        [HttpGet]
        public List<UserLoginModel> GetUserLogins(string name="", string pwd="")
        {
            var modelt = _bll.GetUserLogins(name, pwd);

            return modelt;
        }
    }
}