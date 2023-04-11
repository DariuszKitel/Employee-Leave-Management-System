using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Employee_Leave_Management_System.Web.Config.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "409aa945-3b98-2231-7321-9870eb22d922",
                    UserId = "408aa945-3b98-2231-7321-9870eb22d909"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "411aa945-3b98-2231-7321-9870eb22d832",
                    UserId = "408aa925-3b98-2231-7321-9870eb22d332"
                }
                );
        }
    }
}