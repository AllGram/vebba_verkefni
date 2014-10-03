using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Models
{
    public class CreateProjectViewModel
    {
        [Required]
        public string Name { get; set; }

        public int? MinGradeToPass { get; set; }

        [Required]
        public int Weight { get; set; }

        public int? CountsIfHigherThanProjectID { get; set; }
    }
}
