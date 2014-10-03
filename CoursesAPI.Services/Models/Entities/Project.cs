using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Models.Entities
{
    public class Project
    {
        /// <summary>
        /// Database generated ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The Name of the project fx "Netprof1"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A reference to the projectgroup that this project belongs to.
        /// </summary>
        public int ProjectGroupID { get; set; }

        /// <summary>
        /// A reference to the courseinstance that this project belongs to.
        /// </summary>
        public int CourseInstanceID { get; set; }

        /// <summary>
        /// The id of the project which will count towards the final grade if it is higher than the this projects grade
        /// </summary>
        public int CountsIfHigherThanProjectID { get; set; }

        /// <summary>
        /// The weight of this project in the course (max 100)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// The minimum grade to pass the course.
        /// </summary>
        public int MinGradeToPass { get; set; }

    }
}
