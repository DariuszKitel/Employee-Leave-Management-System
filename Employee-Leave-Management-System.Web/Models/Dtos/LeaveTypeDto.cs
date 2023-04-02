using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Employee_Leave_Management_System.Web.Models.Dtos
{
    public class LeaveTypeDto : BaseDto
    {
        [Display(Name = "Leave type name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required]
        [Range(1, 26, ErrorMessage = "Please enter a valid number between 1 to 26")]
        [Numeric]
        public int DefaultDays { get; set; }
    }
}
