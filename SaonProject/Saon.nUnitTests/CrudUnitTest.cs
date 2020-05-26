using NUnit.Framework;
using Saon.BusinessLogic;
using Saon.Entities;
using System;
using System.Threading.Tasks;

namespace Saon.nUnitTests
{
    public class CrudUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test_JobContext()
        {

            BL_Job businessLogic = new BL_Job(null,true);


            Job newjob = new Job()
            {
                JobTitle = ".NET Developer",
                Description = ".NET Developer Description",
                CreatedAt = DateTime.Now,
                ExpiredAt = DateTime.Now.AddDays(30)
            };

            await businessLogic.CreateJob(newjob);

            var exists = businessLogic.JobExists(newjob.IdJob);

            Assert.AreEqual(true, exists);

        }
    }
}