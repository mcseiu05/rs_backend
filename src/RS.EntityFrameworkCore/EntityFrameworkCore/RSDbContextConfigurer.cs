using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RS.EntityFrameworkCore
{
    public static class RSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
