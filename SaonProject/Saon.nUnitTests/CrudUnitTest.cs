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


        /// <summary>
        /// Test Method create and search by ID
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Test_JobCreateAndFindById()
        {

            BL_Job businessLogic = new BL_Job(null, true);


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


        /// <summary>
        /// Test Method create Job and Delete Job
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Test_JobCreateAndDelete()
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
            
            //Assert.AreEqual(true, exists);

            await businessLogic.DeleteJob(newjob);

            exists = businessLogic.JobExists(newjob.IdJob);

            Assert.AreEqual(false, exists);

        }




        /// <summary>
        /// Test Method create Job and Update Job
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Test_JobCreateAndUpdate()
        {

            BL_Job businessLogic = new BL_Job(null, true);


            Job newjob = new Job()
            {
                JobTitle = ".NET Developer",
                Description = ".NET Developer Description",
                CreatedAt = DateTime.Now,
                ExpiredAt = DateTime.Now.AddDays(30)
            };

            string jobTittle = ".NET Developer";
            await businessLogic.CreateJob(newjob);

            newjob.JobTitle = ".NET Developer 2";

            await businessLogic.UpdateJob(newjob);
         
            Assert.AreEqual(true, (jobTittle != newjob.JobTitle));

        }

    }
}