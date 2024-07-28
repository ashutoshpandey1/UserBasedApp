using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserBasedApp.Models.Data
{
    public class AppDBContext: IdentityDbContext<MyUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
       : base(options)
        {
        }
    }
}
