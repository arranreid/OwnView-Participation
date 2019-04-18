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
                Image = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwj6javo29rhAhXpsVQKHVZ7DYMQjRx6BAgBEAU&url=https%3A%2F%2Fwww.drive.co.uk%2Fupdated-2019-mazda-mx-5-no-excuse-needed%2F&psig=AOvVaw3JGy3YUNSnGpQALWbfji7C&ust=1555713839029479",
                Manufacturer = "Mazda",
                Year = 2006,
                Color = "Red",
                Trim = "Sport",
                Price = 9499.99
            };

            Car Bruce = new Car()
            {
                Model = "Camaro",
                Image = "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjW8pL-29rhAhXP0J8KHSj3CUMQjRx6BAgBEAU&url=https%3A%2F%2Fwww.caranddriver.com%2Ffeatures%2Fa15101319%2Fchevrolet-camaro-ss-1le-at-lightning-lap-2016-feature%2F&psig=AOvVaw0d3fS0y1k11O6hu0Nn_oSf&ust=1555713877762579",
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