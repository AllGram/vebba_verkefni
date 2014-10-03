using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAPI.Models
{
    public class CreateProjectGroupViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberOfProjectsThatCount { get; set; }

    }
}
