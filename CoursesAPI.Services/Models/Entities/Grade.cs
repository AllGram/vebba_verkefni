using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Models.Entities
{
    public class Grade
    {
        /// <summary>
        /// Database generated ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The project that this grade belongs to
        /// </summary>
        public int ProjectID { get; set; }


        /// <summary>
        /// The grade given to the person with PersonID for the project with ProjectID
        /// </summary>
        public double TheGrade { get; set; }


        /// <summary>
        /// The person that was given this grade
        /// </summary>
        public int PersonID { get; set; }
    }
}
