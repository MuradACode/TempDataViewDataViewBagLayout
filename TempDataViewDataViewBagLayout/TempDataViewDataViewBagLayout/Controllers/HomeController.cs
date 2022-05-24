using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempDataViewDataViewBagLayout.Models;

namespace TempDataViewDataViewBagLayout
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Cards = new List<Card>()
            {
                new Card()
                {
                    Id = 1,
                    Title = "Title1"
                },
                new Card()
                {
                    Id = 2,
                    Title = "Title2"
                },
                new Card()
                {
                    Id = 3,
                    Title = "Title3"
                },
                new Card()
                {
                    Id = 4,
                    Title = "Title4"
                },
                new Card()
                {
                    Id = 5,
                    Title = "Title5"
                }
            };
        }

        public List<Card> Cards { get; set; }
        public IActionResult Index()
        {
            int number = 24;

            ViewData["Number"] = number;

            return View(Cards);
        }
    }
}
