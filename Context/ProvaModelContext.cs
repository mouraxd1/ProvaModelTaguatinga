using Microsoft.EntityFrameworkCore;
using ProvaModel.Entity;
using ProvaModel.Configuration;
namespace ProvaModel.Context{

    public class ProvaModelContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IConfiguration _configuration;

        public ProvaModelContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Level> Levels => Set<Level>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ProvaModel"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LevelConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}