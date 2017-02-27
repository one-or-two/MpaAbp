using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MpaAbp.MultiTenancy.Dto;

namespace MpaAbp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
