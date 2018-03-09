using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class WeatherRepository
    {
        private ApplicationDbContext context;

        public WeatherRepository()
        {
            context = new ApplicationDbContext();
        }
        public void AddDay(Weather weather)
        {
            context.Weather.Add(weather);
            context.SaveChanges();
        }
        public List<Weather> GetAllWeather()
        {
            return context.Weather.ToList();
        }
        public Weather GetWeatherByID(int id)
        {
            return context.Weather.Find(id);
        }
        public void Delete(Weather toDelete)
        {
            context.Weather.Remove(toDelete);
            context.SaveChanges();
        }
    
    }
}