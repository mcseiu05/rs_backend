using System.Threading.Tasks;
using Abp.Application.Services;
using RS.Sessions.Dto;

namespace RS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
