using CoursesAPI.Services.DataAccess;
using CoursesAPI.Services.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Extensions
{
    public static class ProjectExtensions
    {
        public static Project GetProjectByID(this IRepository<Project> repo, int? ID)
        {
            var project = repo.All().SingleOrDefault(p => p.ID == ID);
            if (project == null)
            {
                throw new ArgumentException("Invalid project ID");
            }
            return project;
        }
    }
}
