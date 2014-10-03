using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Models.Entities
{
    public class ProjectGroup
    {
        /// <summary>
        /// Database generated ID
        /// </summary>
        public int ID { get; set; }


        /// <summary>
        /// The Name of the project fx "Netprof"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of projects that will be taken into consideration in the calculation for the final grade.
        /// </summary>
        public int NumberOfProjectsThatCount { get; set; }


        /// <summary>
        /// The course that the projectgroup belongs to 
        /// </summary>
        public int CourseInstanceID { get; set; }
    }
}
