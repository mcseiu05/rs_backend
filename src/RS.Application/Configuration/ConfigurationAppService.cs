using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RS.Configuration.Dto;

namespace RS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
