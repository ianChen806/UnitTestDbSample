using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace UnitTestDbSampleProd
{
    public interface ITestDbContext
    {
        DbSet<Member> Member { get; set; }

        DatabaseFacade Database { get; }

        int SaveChanges();

        int SaveChanges(bool acceptAllChangesOnSuccess);
    }
}