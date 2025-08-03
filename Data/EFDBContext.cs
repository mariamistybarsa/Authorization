using Microsoft.EntityFrameworkCore;

namespace Authorization.Data
{
    public class EFDBContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {
        }
        public DbSet<Authorization.Models.User> Users { get; set; }
        public DbSet<Authorization.Models.UserType> UserTypes { get; set; }
    }
}
