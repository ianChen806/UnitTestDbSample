using System.Linq;

namespace UnitTestDbSampleProd
{
    public class MemberService
    {
        private readonly ITestDbContext _dbContext;

        public MemberService(ITestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool MemberIsExists(string id)
        {
            var member = _dbContext.Member.FirstOrDefault(r => r.Id == id);
            return member != null;
        }
    }
}