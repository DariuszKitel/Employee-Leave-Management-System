namespace Employee_Leave_Management_System.Web.Data.Entities
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
