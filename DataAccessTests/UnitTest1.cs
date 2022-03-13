using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;

using Entities;
using NUnit.Framework;

namespace DataAccessTests
{
    public class Tests
    {
        private IUserDal userDal = new EfUserDal();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            userDal.Add(new User
            {
                Id = 1,
                Name ="Admin2",
                Email = "admin@gmail.com",
                Description = "asdddsadsa",
                Password = "123abc",
                Role = 1,
            }) ;

            Assert.Pass();
        }
    }
}