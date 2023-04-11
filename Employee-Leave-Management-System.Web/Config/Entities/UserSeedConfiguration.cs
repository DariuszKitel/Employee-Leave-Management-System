using Employee_Leave_Management_System.Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employee_Leave_Management_System.Web.Config.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "408aa945-3b98-2231-7321-9870eb22d909",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                },
                new Employee
                {
                    Id = "408aa925-3b98-2231-7321-9870eb22d332",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
                );
        }
    }
}