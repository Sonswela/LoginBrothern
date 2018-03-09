using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class WeatherController : Controller
    {
        private WeatherService service = new WeatherService();
        // GET: Weather
        public ActionResult Index()
        {
            return View(service.GetAllWeather());
        }
        //SHOW: CREATE
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Weather weather)
        {
           
                service.AddDay(weather);
                return RedirectToAction("Index");
            

        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Weather weather = service.GetWeatherByID((int)id);
            if (weather == null)
            {
                return HttpNotFound();
            }
            return View(weather);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            Weather weather = service.GetWeatherByID(id);
            service.Delete(weather);
            return RedirectToAction("Index");
        }
    }
}