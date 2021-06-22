using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RS.Authorization;

namespace RS
{
    [DependsOn(
        typeof(RSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
