using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeUniversity.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        // Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}