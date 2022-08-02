using System;
using System.ComponentModel.DataAnnotations;
namespace LMS.web.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage ="This is a required feild")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This {0} is required feild")]
        
        public string EmployeeName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Range(minimum:0,maximum:2000000, ErrorMessage ="{0} has to be beetween {1} and {2}")]
        public decimal Salary { get; set; }
        public bool IsEnabled { get; set; }

    }
}
