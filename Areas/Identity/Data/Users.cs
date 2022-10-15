using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace POCIdentity.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the POCIdentityUser class
    public class Users : IdentityUser
    {
        public string File { get; set; }
    }
}
