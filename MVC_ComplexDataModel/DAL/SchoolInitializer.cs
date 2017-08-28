using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVC_ComplexDataModel.Models;

namespace MVC_ComplexDataModel.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
           var students = new List<Student>
             {
                 new Student {FirstMidName="Thomas", LastName="Alexander", EnrollmentDate=DateTime.Parse("2005-09-01") },
                 new Student {FirstMidName="Ari", LastName="Alonso", EnrollmentDate=DateTime.Parse("2002-09-01") },
                 new Student {FirstMidName="Amir", LastName="Anand", EnrollmentDate=DateTime.Parse("2003-09-01") },
                 new Student {FirstMidName="Joseph", LastName="Barzdukas", EnrollmentDate=DateTime.Parse("2002-09-01") },
                 new Student {FirstMidName="Ellin", LastName="Li", EnrollmentDate=DateTime.Parse("2002-09-01") },
                 new Student {FirstMidName="Teguh", LastName="Justice", EnrollmentDate=DateTime.Parse("2001-09-01") },
                 new Student {FirstMidName="Toto", LastName="Norman", EnrollmentDate=DateTime.Parse("2003-09-01") },
                 new Student {FirstMidName="Ryan", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2005-09-01") }
             };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
                new Instructor {FirstMIdName ="Kim", LastName="Abercrombie", HireDate=DateTime.Parse("1995-03-11")},
                new Instructor {FirstMIdName ="Fadi", LastName="Fakhouri", HireDate=DateTime.Parse("2002-07-06")},
                new Instructor {FirstMIdName ="Roger", LastName="Harui", HireDate=DateTime.Parse("1998-07-01")},
                new Instructor {FirstMIdName ="Candace", LastName="Kapoor", HireDate=DateTime.Parse("2001-01-15")},
                new Instructor {FirstMIdName ="Roger", LastName="Zheng", HireDate=DateTime.Parse("2004-02-12") }
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var course = new List<Course>
            {
                new Course {CourseID=1050, Title="Chemistry", Credits=3, DepartmentID=3, Instructors= new List<Instructor>() },
                new Course {CourseID=4022, Title="Microeconomic", Credits=3, DepartmentID=4, Instructors = new List<Instructor>() },
                new Course {CourseID=4041, Title="Macroeconomic", Credits=3, DepartmentID=4, Instructors = new List<Instructor>() },
                new Course {CourseID=1045, Title="Calculus", Credits=4, DepartmentID=2, Instructors = new List<Instructor>() },
                new Course {CourseID=3141, Title="Trigonometry", Credits=4, DepartmentID=2, Instructors = new List<Instructor>() },
                new Course {CourseID=2021, Title="Composition", Credits=3, DepartmentID=1, Instructors = new List<Instructor>() },
                new Course {CourseID=2042, Title="Literature", Credits=4, DepartmentID=4, Instructors = new List<Instructor>() }
            };
            course.ForEach(s => context.Course.Add(s));
            context.SaveChanges();
            course[0].Instructors.Add(instructors[0]);
            course[1].Instructors.Add(instructors[1]);
            course[2].Instructors.Add(instructors[2]);
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department {Name="English", Budget=350000, StartDate=DateTime.Parse("2007-09-01"), InstructorID=1 },
                new Department {Name="Mathematic", Budget=100000, StartDate=DateTime.Parse("2007-09-01"), InstructorID=2 },
                new Department {Name="Engineering", Budget=350000, StartDate=DateTime.Parse("2007-09-01"), InstructorID=3 },
                new Department {Name="Economic", Budget=100000, StartDate=DateTime.Parse("2007-09-01"), InstructorID=4 }
            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var officeAssignment = new List<OfficeAssignment>
            {
                new OfficeAssignment {InstructorID = 1, Location = "Smith 17" },
                new OfficeAssignment {InstructorID = 2, Location = "Gowqn 27" },
                new OfficeAssignment {InstructorID = 3, Location = "Thompson 304" }
            };
            officeAssignment.ForEach(s => context.OfficeAssignments.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {StudentID=1, CourseID=1050, Grade=Grade.A },
                new Enrollment {StudentID=1, CourseID=4022, Grade=Grade.C },
                new Enrollment {StudentID=1, CourseID=4041, Grade=Grade.B },
                new Enrollment {StudentID=2, CourseID=1045, Grade=Grade.B },
                new Enrollment {StudentID=2, CourseID=3141, Grade=Grade.F },
                new Enrollment {StudentID=2, CourseID=2021, Grade=Grade.F },
                new Enrollment {StudentID=3, CourseID=1050, Grade=Grade.D },
                new Enrollment {StudentID=4, CourseID=1050, Grade=Grade.D },
                new Enrollment {StudentID=4, CourseID=4022, Grade=Grade.F },
                new Enrollment {StudentID=5, CourseID=4041, Grade=Grade.F },
                new Enrollment {StudentID=6, CourseID=1045, Grade=Grade.D },
                new Enrollment {StudentID=7, CourseID=3141, Grade=Grade.F }
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}