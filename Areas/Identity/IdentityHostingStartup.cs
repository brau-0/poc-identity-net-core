using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POCIdentity.Areas.Identity.Data;
using POCIdentity.Data;

[assembly: HostingStartup(typeof(POCIdentity.Areas.Identity.IdentityHostingStartup))]
namespace POCIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<POCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("POCIdentityContextConnection")));

                //services.AddDefaultIdentity<POCIdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                //    .AddEntityFrameworkStores<POCIdentityContext>();
                services.AddIdentity<Users, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI()
                .AddEntityFrameworkStores<POCContext>()
                .AddDefaultTokenProviders();
                services.AddScoped<IUserClaimsPrincipalFactory<Users>,
                    ApplicationUserClaimsPrincipalFactory
                    >();
            });
        }
    }
}