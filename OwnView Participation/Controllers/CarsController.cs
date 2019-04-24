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
                Image = "http://www.blogcdn.com/www.autoblog.com/media/2008/06/03_abgarage_08_mx5_450op.jpg",
                Manufacturer = "Mazda",
                Year = 2006,
                Color = "Red",
                Trim = "Sport",
                Price = 9499.99
            };

            Car Bruce = new Car()
            {
                Model = "Camaro",
                Image = "https://cdn.motor1.com/images/mgl/jAjO7/s1/2017-chevrolet-camaro-1le-first-drive.jpg",
                Manufacturer = "Chevrolet",
                Year = 2017,
                Color = "White",
                Trim = "1LE",
                Price = 65000
            };

            Car Scotty = new Car()
            {
                Model = "Ranger",
                Image = "http://images.dealerrevs.com/pictures/51029587.jpg",
                Manufacturer = "Ford",
                Year = 2000,
                Color = "Black",
                Trim = "XLT",
                Price = 2699.87
            };

            Car Flavia = new Car()
            {
                Model = "F-Type",
                Image = "https://topgear.wwmindia.com/content/2018/sep/2016Feb17001613.jpg",
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

            return View(cr);
        }
    }
}