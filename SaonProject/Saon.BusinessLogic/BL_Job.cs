using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Saon.DataAccess;
using Saon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saon.BusinessLogic
{
    public class BL_Job
    {
        private readonly IConfiguration Configuration;

        public BL_Job(IConfiguration configuration) {

            Configuration = configuration;
        }
        /// <summary>
        /// This is the select equivalent, getting all job's list
        /// </summary>
        /// <returns></returns>
        public async Task<List<Job>> ListJobs()
        {
            using (var db = new TestContext(Configuration))
            {
                return await db.Jobs.ToListAsync();
            }
        }

        /// <summary>
        /// Getting a specific Job by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Job> GetJob(int id)
        {
            using (var db = new TestContext(Configuration))
            {
                return await db.Jobs.FirstOrDefaultAsync(m => m.IdJob == id);
            }
        }

        /// <summary>
        /// Creating a new Job Entity 
        /// </summary>
        /// <param name="newJob"></param>
        /// <returns></returns>
        public async Task<int> CreateJob(Job newJob)
        {
            using (var db = new TestContext(Configuration))
            {
                db.Jobs.Add(newJob);
                return await db.SaveChangesAsync();
            }
        }


        /// <summary>
        /// Updating a specific job
        /// </summary>
        /// <param name="updateJob"></param>
        /// <returns></returns>
         public async Task<int> UpdateJob(Job updatedJob)
        {
            using (var db = new TestContext(Configuration))
            {
                db.Jobs.Update(updatedJob);
                return await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Deliting a specific Job
        /// </summary>
        /// <param name="deletedJob"></param>
        /// <returns></returns>
        public async Task<int> DeleteJob(Job deletedJob)
        {
            using (var db = new TestContext(Configuration))
            {
                db.Jobs.Remove(deletedJob);
                return await db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Determinates if an object in database exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool JobExists(int id)
        {
            using (var db = new TestContext(Configuration))
            {
                return db.Jobs.Any(e => e.IdJob == id);
            }
        }

    }
}
