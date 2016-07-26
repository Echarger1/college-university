using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeUniversity.Models
{
    public class CollegeUniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CollegeUniversityContext>
    {
        protected override void Seed(CollegeUniversityContext context)
        {
            context.Students.Add(new Models.Student() { FirstName = "Bob", LastName = "Smith" });
            context.Students.Add(new Models.Student() { FirstName = "Sally", LastName = "Sitwell" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}