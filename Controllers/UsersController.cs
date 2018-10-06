using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CucaFunApi.Models;

namespace CucaFunApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CucafunContext _context;

        public UsersController(CucafunContext context)
        {
            _context = context;

            if (_context.Users.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Users.Add(new User { username = "default", email = "test@test.com", password = "password" });
                _context.SaveChanges();
            }
        }
    }
}