using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RS.EntityFrameworkCore;
using RS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RS.Web.Tests
{
    [DependsOn(
        typeof(RSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RSWebTestModule : AbpModule
    {
        public RSWebTestModule(RSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RSWebMvcModule).Assembly);
        }
    }
}