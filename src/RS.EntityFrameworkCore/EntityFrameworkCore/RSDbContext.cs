using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RS.Authorization.Roles;
using RS.Authorization.Users;
using RS.MultiTenancy;
using RS.Domain.AP;

namespace RS.EntityFrameworkCore
{
    public class RSDbContext : AbpZeroDbContext<Tenant, Role, User, RSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ApPanel> ApPanels { get; set; }
        public RSDbContext(DbContextOptions<RSDbContext> options)
            : base(options)
        {
        }
    }
}
