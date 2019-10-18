using Microsoft.EntityFrameworkCore;

namespace DotNetCoreDatabaseMigration.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>(user =>
            {
                user.HasIndex(x => x.Email).IsUnique(true);
            });

            builder.Entity<Roles>(role =>
            {
                role.HasIndex(x => x.RoleName).IsUnique(true);
            });
        }

        public DbSet<Roles> Role { get; set; }

        public DbSet<Users> User { get; set; }
    }
}
