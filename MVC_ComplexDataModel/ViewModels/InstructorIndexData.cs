using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_ComplexDataModel.Models;

namespace MVC_ComplexDataModel.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollment { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}