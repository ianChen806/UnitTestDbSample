using Microsoft.EntityFrameworkCore;

namespace UnitTestDbSampleProd
{
    public class TestDbContext : DbContext, ITestDbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}