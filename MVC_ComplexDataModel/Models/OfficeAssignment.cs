using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ComplexDataModel.Models
{
    public class OfficeAssignment
    {
       [Key]
       [ForeignKey("Instructor")] 
       public int InstructorID { get; set; }
       [MaxLength(50)]
       [Display(Name = "Office Location")]
       public string Location { get; set; }
       public virtual Instructor Instructor { get; set; }
    }
}