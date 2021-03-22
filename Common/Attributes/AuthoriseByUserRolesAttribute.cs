using System.Linq;
using Common.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Common.Attributes
{
    public class AuthoriseByUserRolesAttribute : AuthorizeAttribute
    {
        public AuthoriseByUserRolesAttribute(params UserRole[] userRoles)
        {
            if (userRoles.Length > 0)
            {
                Roles = string.Join(',', userRoles.Select(x => x.ToString()));
            }
        }
    }
}
