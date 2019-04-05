using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Message message = new Message()
            {
                ThingsToSay = @"is simply dummy text of the 
                printing and typesetting industry. Lorem Ipsum 
                has been the industry's standard dummy text ever 
                since the 1500s, when an unknown printer took a 
                galley of type and scrambled it to make a type 
                specimen book. It has survived not only five centuries, 
                but also the leap into electronic typesetting, remaining 
                essentially unchanged. It was popularised in the 1960s 
                with the release of Letraset sheets containing Lorem 
                Ipsum passages, and more recently with desktop publishing 
                software like Aldus PageMaker including versions of Lorem Ipsum."
            };
            return View(message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6
            };
            return View(numbers);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User theGoat = new User
            {
                FirstName = "Jackie",
                LastName = "Moon"
            };

            return View(model: theGoat);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User user = new User
            {
                FirstName = "Cooper",
                LastName = "Strahan"
            };
            User userA = new User
            {
                FirstName = "Dylan",
                LastName = "Strahan"
            };
            User userB = new User
            {
                FirstName = "Wyatt",
                LastName = "Strahan"
            };
            User userC = new User
            {
                FirstName = "Scotty",
                LastName = "Strahan"
            };
            User userD = new User
            {
                FirstName = "Kathryn",
                LastName = "Strahan"
            };
            List<User> users = new List<User>
            {
                user,
                userA,
                userB,
                userC,
                userD,
            };
            return View(users);
        }
    
        
    }
}
