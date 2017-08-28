using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ComplexDataModel.Models
{
    public class Instructor
    {   
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorID { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstMIdName { get; set; }

        [DisplayFormat(DataFormatString = "{0}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Hire date is Required.")]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        public string FullName
        {
            get {
                return LastName + ", " + FirstMIdName;
            }
        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}