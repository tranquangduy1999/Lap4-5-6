using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranQuangDuy_lap456.Models;
using System.ComponentModel.DataAnnotations;

namespace TranQuangDuy_lap456.ViewModel
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}