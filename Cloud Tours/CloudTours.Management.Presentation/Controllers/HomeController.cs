using CloudTours.Domain;
using CloudTours.Management.Application.Trips;
using CloudTours.Management.Presentation.Models;
using CloudTours.Management.Presentation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CloudTours.Management.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITripService tripService;

        public HomeController(ILogger<HomeController> logger, ITripService tripService)
        {
            _logger = logger;
            this.tripService = tripService;
        }

        public IActionResult Index(int page=1)
        {
            var trip = tripService.GetTrips();
            var tripsPerPage = 3;
            ViewBag.TotalPages = Math.Ceiling((decimal)trip.Count / tripsPerPage);
            var PaginatedTrip = trip.OrderBy(x=>x.Id).Skip((page-1)*tripsPerPage).Take(tripsPerPage);
            
            return View(PaginatedTrip);
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
