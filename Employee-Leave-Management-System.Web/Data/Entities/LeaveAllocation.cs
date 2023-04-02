using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Leave_Management_System.Web.Data.Entities
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeID { get; set; }
    }
}
