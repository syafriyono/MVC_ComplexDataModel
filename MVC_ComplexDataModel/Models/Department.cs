using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ComplexDataModel.Models
{
    public class Department
    {   
        [Key] 
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Department name is required.")]
        public int DepartmentID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0}")]
        [Required(ErrorMessage = "Budget is required.")]
        [Column(TypeName = "money")]
        public decimal? Budget { get; set; }

        [DisplayFormat(DataFormatString = "{0}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Administrator")]
        public int? InstructorID { get; set; }

        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}