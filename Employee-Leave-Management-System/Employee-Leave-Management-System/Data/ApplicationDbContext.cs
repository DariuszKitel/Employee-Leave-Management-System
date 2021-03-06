﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Employee_Leave_Management_System.Models;

namespace Employee_Leave_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<Employee_Leave_Management_System.Models.LeaveTypeVM> LeaveTypeVM { get; set; }
        //public DbSet<Employee_Leave_Management_System.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
    }
}
