using CoursesAPI.Services.DataAccess;
using CoursesAPI.Services.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Extensions
{
    public static class ProjectGroupExtensions
    {
        public static ProjectGroup GetProjectGroupByID(this IRepository<ProjectGroup> repo, int ID)
        {
            var projectGroup = repo.All().SingleOrDefault(c => c.ID == ID);
            if (projectGroup == null)
            {
                throw new ArgumentException("Invalid projectGroup ID");
            }
            return projectGroup;
        }
    }
}
