using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeUniversity.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [MaxLength(50)]
        public string CourseName { get; set; }
        [MaxLength(50)]
        public string Department { get; set; }
        [MaxLength(50)]
        public string Instructor { get; set; }
        public double Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}