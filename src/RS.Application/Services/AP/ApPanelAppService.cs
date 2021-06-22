using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using RS.Authorization;
using RS.Domain.AP;
using RS.Services.AP.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.Services.AP
{
    [AbpAuthorize(PermissionNames.Pages_ApPanels)]
    public class ApPanelAppService : CrudAppService<ApPanel, ApPanelDto>
    {
        public ApPanelAppService(IRepository<ApPanel, int> repository) : base(repository)
        {
        }
    }
}
