using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Controllers
{
    public class HomeController : Controller
    {
        private MovieReviewContext _movieContext { get; set; }
        //the constructor
        public HomeController(MovieReviewContext submission)
        {
            _movieContext = submission;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet] /*This httpget will be looking to get the inputted variables on the first view and the returned view below will post the variables to the database*/
        public IActionResult MovieReview()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieReview(ApplicationResponse ar)
        {
            _movieContext.Add(ar);
            _movieContext.SaveChanges();

            return View("Confirmation", ar);
        }
        [HttpGet]

        public IActionResult MovieList ()
        {
            var movieslist = _movieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
             
            return View(movieslist);
        }

    }
}
