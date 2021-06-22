using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RS.Configuration;
using RS.Web;

namespace RS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RSDbContextFactory : IDesignTimeDbContextFactory<RSDbContext>
    {
        public RSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RSConsts.ConnectionStringName));

            return new RSDbContext(builder.Options);
        }
    }
}
