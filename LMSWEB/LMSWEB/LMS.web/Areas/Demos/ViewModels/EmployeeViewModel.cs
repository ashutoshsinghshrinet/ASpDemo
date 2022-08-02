using System;
using System.ComponentModel.DataAnnotations;
namespace LMS.web.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Enter the Employee ID:")]
        [Required(ErrorMessage ="This is a required feild")]
        public int EmployeeId { get; set; }
        [Display(Name ="Enter the Employee Name:")]
        [MinLength(2,ErrorMessage = "The name must not be less that 2 characters")]
        [MaxLength(50,ErrorMessage ="The name must not be more that 50 characters")]
        [Required(ErrorMessage ="This {0} is required feild")]
        
        public string EmployeeName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Range(minimum:0,maximum:2000000, ErrorMessage ="{0} has to be beetween {1} and {2}")]
        public decimal Salary { get; set; }
        public bool IsEnabled { get; set; }

    }
}
