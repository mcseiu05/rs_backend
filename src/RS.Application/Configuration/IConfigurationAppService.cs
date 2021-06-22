using System.Threading.Tasks;
using RS.Configuration.Dto;

namespace RS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
