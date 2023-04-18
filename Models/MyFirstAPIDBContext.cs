using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models;
namespace MyFirstAPI.Models
{
    public class MyFirstAPIDBContext : DbContext
    {
        protected readonly IConfiguration Configuation;

        public MyFirstAPIDBContext(DbContextOptions<MyFirstAPIDBContext> options, IConfiguration configuation)
            : base(options)
        {
            Configuation = configuation;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuation.GetConnectionString("CustomerDataServce");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Email> Emails { get; set; } = null;
    }
}
