using Employee_Leave_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Leave_Management_System.Contracts
{
    interface ILeaveAllocationRepository : IRepository<LeaveAllocation>
    {
    }
}
