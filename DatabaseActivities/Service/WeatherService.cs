using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class WeatherService
    {
        private WeatherRepository repository;

        public WeatherService()
        {
            repository = new WeatherRepository();
        }
        public void AddDay(Weather toAdd)
        {
            repository.AddDay(toAdd);
        }
        public List<Weather> GetAllWeather()
        {
            return repository.GetAllWeather();
        }
        public Weather GetWeatherByID(int id)
        {
            return repository.GetWeatherByID(id);
        }
        public void Delete(Weather weather)
        {
            repository.Delete(weather);
        }
    }
}