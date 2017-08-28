using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVC_ComplexDataModel.Models;

namespace MVC_ComplexDataModel.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }       
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Instructor>().HasOptional(p => p.OfficeAssignment).WithRequired(p => p.Instructor);
            modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses).Map(t => t.MapLeftKey("CourseID").MapRightKey("InstructorID").ToTable("CourseInstructor"));
            modelBuilder.Entity<Department>().HasOptional(x => x.Administrator);
            modelBuilder.Entity<Course>().HasMany(s => s.Department).WithMany(i => i.Courses).Map(t => t.MapRightKey("CourseID").MapLeftKey("DepartmentID").ToTable("CourseDepartment"));
        }
    }
}