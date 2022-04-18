using Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Data
{
    public class ProfilesDbContext : DbContext
    {
        public ProfilesDbContext(DbContextOptions<ProfilesDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Profile> Profile { get; set; }
        
        public DbSet<Bio> Bio{ get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSnakeCaseNamingConvention();
        }
    }
}