using System.Threading.Tasks;
using Abp.Application.Services;
using MpaAbp.Roles.Dto;

namespace MpaAbp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
