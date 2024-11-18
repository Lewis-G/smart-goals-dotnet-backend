using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {

        [HttpGet]
        public string GetUsers()
        {
            return "Hello";
        }

        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            return $"Hello {id}";
        }

    }
}
