using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Saon.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Saon.DataAccess
{
    public class TestContextMigration : DbContext
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
                IConfigurationBuilder builder = new ConfigurationBuilder();
                builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange : true);

                var root = builder.Build();
                var connectionString = root.GetConnectionString("connectionString");
                //string connectionString = ConfigurationManager.AppSettings["connectionString"];
                //string connectionString = "Server=localhost\\sqlexpress;Database=Saon;Integrated Security=True;Trusted_Connection=True;";
                options.UseSqlServer(connectionString);
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
                        Description = "Descripcion about .net developer",
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
                    },
                    new Job
                    {
                        IdJob = 4,
                        JobTitle = "Developer Manager",
                        Description = "Descripcion about Developer Manager",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 5,
                        JobTitle = "Human Resource Talent Hunter",
                        Description = "Descripcion about Human Resource Talent Hunter",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 6,
                        JobTitle = "Junior Java Developer",
                        Description = "Descripcion about Junior Java Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 7,
                        JobTitle = "Senior Java Developer",
                        Description = "Descripcion about Senior Java Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 8,
                        JobTitle = "Junior Javascript Developer",
                        Description = "Descripcion about Junior Javascript Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 9,
                        JobTitle = "Senior Javascript Developer",
                        Description = "Descripcion about Senior Javascript Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 10,
                        JobTitle = "Junior React Developer",
                        Description = "Descripcion about Junior React Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 11,
                        JobTitle = "Senior React Developer",
                        Description = "Descripcion about Senior React Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 12,
                        JobTitle = "Junior Phyton Developer",
                        Description = "Descripcion about Junior Phyton Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 13,
                        JobTitle = "Senior Phyton Developer",
                        Description = "Descripcion about Senior Phyton Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 14,
                        JobTitle = "Junior React Developer",
                        Description = "Descripcion about Junior React  Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    },
                    new Job
                    {
                        IdJob = 15,
                        JobTitle = "Senior React Developer",
                        Description = "Descripcion about Senior React Developer",
                        CreatedAt = DateTime.Now,
                        ExpiredAt = DateTime.Now.AddDays(30)
                    }
                );
        }
    }


}
