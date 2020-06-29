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

        public Member GetMember(string id)
        {
            return Queryable.First<Member>(_dbContext.Member, r => r.Id == id);
        }
    }
}