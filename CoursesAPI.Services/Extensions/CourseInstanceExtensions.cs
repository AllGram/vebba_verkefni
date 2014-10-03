using CoursesAPI.Services.DataAccess;
using CoursesAPI.Services.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Extensions
{
    public static class CoursesExtensions
    {
        public static CourseInstance GetCourseInstanceByID(this IRepository<CourseInstance> repo, int ID)
        {
            var courseInstance = repo.All().SingleOrDefault(c => c.ID == ID);
            if (courseInstance == null)
            {
                throw new ArgumentException("Invalid courseInstance ID");
            }
            return courseInstance;
        }

    }
}
