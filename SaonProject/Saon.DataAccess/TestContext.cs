using Microsoft.EntityFrameworkCore;
using Saon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saon.DataAccess
{
    public class TestContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }



        /// <summary>
        /// if the dbContext  is not configurated yet, then do it
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                // options.UseSqlServer("Server=localhost\\sqlexpress; Database=Saon;User Id=sa; Password=eltiempovuela16.");
                 options.UseSqlServer("Server=localhost\\sqlexpress;Database=Saon;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        /// <summary>
        /// Adding Data Test to te database (migration excercise)
        /// </summary>
        /// <param name="modelBuilder"></param>
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasData(
                    new Job
                    {
                        IdJob = 1,
                        JobTitle = ".NET Developer",
                        Description= "Descripcion about .net developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 2,
                        JobTitle = ".QA Analyst",
                        Description = "Descripcion about QA Analyst",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 3,
                        JobTitle = "Solution Architec",
                        Description = "Descripcion about Solution Architec",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    }
                );
        }
    }


}

