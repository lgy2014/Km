using System.Threading.Tasks;
using Abp.Application.Services;
using Lgy.Km.Roles.Dto;

namespace Lgy.Km.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
