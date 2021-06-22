﻿using System.Threading.Tasks;
using Abp.Application.Services;
using RS.Authorization.Accounts.Dto;

namespace RS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
