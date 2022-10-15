using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using POCIdentity.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace POCIdentity.Areas.Identity
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<Users, IdentityRole>
    {
        public ApplicationUserClaimsPrincipalFactory(
            UserManager<Users> userManager,
             RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options
            ) : base(userManager, roleManager, options)
        {
        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Users user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("File",
                user.File
                ));
            return identity;
        }
    }
}
