using Employee_Leave_Management_System.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employee_Leave_Management_System.Web.Config.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "409aa945-3b98-2231-7321-9870eb22d922",
                    Name = Roles.ADMINISTRATOR,
                    NormalizedName = Roles.ADMINISTRATOR.ToUpper()
                },
                new IdentityRole
                {
                    Id = "411aa945-3b98-2231-7321-9870eb22d832",
                    Name = Roles.USER,
                    NormalizedName = Roles.USER.ToUpper()
                }
                ); ;
        }
    }
}