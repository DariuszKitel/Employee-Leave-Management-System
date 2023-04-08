using Employee_Leave_Management_System.Web.Contracts;
using Employee_Leave_Management_System.Web.Data;
using Employee_Leave_Management_System.Web.Data.Entities;

namespace Employee_Leave_Management_System.Web.Repositories
{
	public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
	{
		public LeaveTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}
