using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using viewmodel_fun.Models;

namespace viewmodel_fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string messageString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            return View("Index", messageString);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> Users = new List<User>()
            {
                new User() {FirstName="Moose", LastName="Phillips"},
                new User() {FirstName="Sarah", LastName=""},
                new User() {FirstName="Jerry", LastName=""},
                new User() {FirstName="Rene", LastName="Ricky"},
                new User() {FirstName="Barbarah", LastName=""},
            };
            return View("Users", Users);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User User = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("User", User);
        }
    }
}
