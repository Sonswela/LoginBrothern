using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Models.Entity
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public double high { get; set; }
        public double low { get; set; }
    }
}