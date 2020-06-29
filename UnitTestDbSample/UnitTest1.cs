using System;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using UnitTestDbSampleProd;
using Xunit;

namespace UnitTestDbSample
{
    public class UnitTest1
    {
        private readonly MemberService _memberService;
        private readonly TestDbContext _testDbContext;

        public UnitTest1()
        {
            var dbContextOptions = new DbContextOptionsBuilder<TestDbContext>()
                                   .UseInMemoryDatabase(Guid.NewGuid().ToString("N"))
                                   .Options;
            _testDbContext = new TestDbContext(dbContextOptions);
            _memberService = new MemberService(_testDbContext);
        }

        [Fact]
        public void Is()
        {
            _testDbContext.Member.Add(new Member
            {
                Id = "id"
            });
            _testDbContext.SaveChanges();

            var isExists = _memberService.MemberIsExists("id");
            Assert.True(isExists);
        }

        [Fact]
        public void Not()
        {
            var isExists = _memberService.MemberIsExists("id");
            Assert.False(isExists);
        }
    }
}