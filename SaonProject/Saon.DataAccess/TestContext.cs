using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Saon.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Saon.DataAccess
{
    public class TestContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }

        private bool InMemory;

        private readonly IConfiguration Configuration;

        public TestContext(IConfiguration configuration, bool inMemory = false)
        {
            Configuration = configuration;
            InMemory = inMemory;
        }            

        /// <summary>
        /// if the dbContext  is not configurated yet, then do it
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {


                if (!InMemory)
                {
                    string connectionString = ConfigurationExtensions.GetConnectionString(this.Configuration, "connectionString");
                    options.UseSqlServer(connectionString);

                }
                else
                {
                    options.UseInMemoryDatabase("Saon");
                }
            }
        }

    }


}

