using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }

        public HomeController(TripContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var trips = context.Trips.ToList();
            return View(trips);
        }

        [HttpGet]
        public IActionResult AddTrip1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTrip1(Trip trip)
        {
            TempData["ID"] = trip.TripID;
            TempData["DESTINATION"] = trip.Destination;
            TempData["STARTDATE"] = trip.StartDate;
            TempData["ENDDATE"] = trip.StartDate;
            TempData["ACCOMMODATION_NAME"] = trip.AccommodationName;

            var action = trip.AccommodationName == null ? "AddTrip3" : "AddTrip2";

            return RedirectToAction(action, trip);
        }

        [HttpGet]
        public IActionResult AddTrip2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTrip2(Trip trip)
        {
            TempData["ACCOMMODATION_PHONE"] = trip.AccommodationPhone;
            TempData["ACCOMMODATION_EMAIL"] = trip.AccommodationEmail;
            return RedirectToAction("AddTrip3", trip);
        }

        [HttpGet]
        public IActionResult AddTrip3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTrip3(Trip trip)
        {
            context.Trips.Add(trip);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Submit(Trip trip)
        {
            context.Trips.Add(trip);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
