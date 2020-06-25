﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranQuangDuy_lap456.DTOs;
using TranQuangDuy_lap456.Models;

namespace TranQuangDuy_lap456.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            //var userId = User.Identity.GetUserId();
            //if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == AttendanceDto.CourseId))
            //    return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
