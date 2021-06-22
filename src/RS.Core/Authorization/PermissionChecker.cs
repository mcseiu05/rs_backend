using Abp.Authorization;
using RS.Authorization.Roles;
using RS.Authorization.Users;

namespace RS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
