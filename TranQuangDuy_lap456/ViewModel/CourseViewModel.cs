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
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public string Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}