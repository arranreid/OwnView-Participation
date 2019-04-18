using OwnView_Participation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwnView_Participation.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            Car Isla = new Car()
            {
                Model = "MX-5",
                Manufacturer = "Mazda",
                Year = 2006,
                Color = "Red",
                Trim = "Sport",
                Price = 9499.99
            };

            Car Bruce = new Car()
            {
                Model = "Camaro",
                Manufacturer = "Chevrolet",
                Year = 2017,
                Color = "White",
                Trim = "1LE",
                Price = 65000
            };

            Car Scotty = new Car()
            {
                Model = "Ranger",
                Manufacturer = "Ford",
                Year = 2000,
                Color = "Black",
                Trim = "XLT",
                Price = 2699.87
            };

            Car Flavia = new Car()
            {
                Model = "F-Type",
                Manufacturer = "Jaguar",
                Year = 2018,
                Color = "Orange",
                Trim = "R-Sport",
                Price = 94000
            };

            List<Car> cr = new List<Car>();
            cr.Add(Isla);
            cr.Add(Bruce);
            cr.Add(Scotty);
            cr.Add(Flavia);

            return View();
        }
    }
}