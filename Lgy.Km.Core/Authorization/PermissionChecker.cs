using Abp.Authorization;
using Lgy.Km.Authorization.Roles;
using Lgy.Km.MultiTenancy;
using Lgy.Km.Users;

namespace Lgy.Km.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
