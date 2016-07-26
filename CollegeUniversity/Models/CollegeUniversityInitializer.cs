using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeUniversity.Models
{
    public class CollegeUniversityInitializer : System.Data.Entity.DropCreateDatabaseAlways<CollegeUniversityContext>
    {
        protected override void Seed(CollegeUniversityContext context)
        {
            context.Students.Add(new Student() { FirstName = "Bob", LastName = "Smith" });
            context.Students.Add(new Student() { FirstName = "Sally", LastName = "Sitwell" });
            context.Students.Add(new Student() { FirstName = "Fred", LastName = "Flintstone" });
            context.Students.Add(new Student() { FirstName = "Fred", LastName = "Durst" });
            context.Students.Add(new Student() { FirstName = "Bernie", LastName = "Kosar" });
            context.Students.Add(new Student() { FirstName = "James", LastName = "Smith" });
            context.Students.Add(new Student() { FirstName = "George", LastName = "Jetson" });
            context.Students.Add(new Student() { FirstName = "Johnny", LastName = "Appleseed" });
            context.Students.Add(new Student() { FirstName = "Peter", LastName = "Parker" });
            context.Students.Add(new Student() { FirstName = "Prince", LastName = "Williams" });
            context.Students.Add(new Student() { FirstName = "Olivia", LastName = "Taylor" });
            context.Students.Add(new Student() { FirstName = "James", LastName = "Allen" });
            context.Students.Add(new Student() { FirstName = "Joan", LastName = "Mayer Campbell" });
            context.Students.Add(new Student() { FirstName = "Daniel", LastName = "Vivacqua" });
            context.Students.Add(new Student() { FirstName = "Miles", LastName = "Morales" });
            context.Students.Add(new Student() { FirstName = "Jael", LastName = "Jones" });
            context.Students.Add(new Student() { FirstName = "Squirrel", LastName = "Girl" });
            context.Students.Add(new Student() { FirstName = "Denise", LastName = "Williams" });
            context.Students.Add(new Student() { FirstName = "Cierra", LastName = "Washington" });
            context.Students.Add(new Student() { FirstName = "Dion", LastName = "Jackson" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}