using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Services.Models.Entities
{
    public class Course
    {
        /// <summary>
        /// A database-generated ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The Course name fx "Vefforritun I" 
        /// </summary>
        public string Name { get; set; }
    }
}
