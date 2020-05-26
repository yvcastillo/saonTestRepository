using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Saon.BusinessLogic;
using Saon.DataAccess;
using Saon.Entities;
using SaonCrud.Models;

namespace SaonCrud.Controllers
{
    public class JobsController : Controller
    {
        private BL_Job businessLogicJob;
    

        public JobsController(IConfiguration configuration)
        {
            businessLogicJob = new BL_Job(configuration);
        }

        // GET: Jobs
        //public async Task<IActionResult> Index()
        //{
        //    return View(await businessLogicJob.ListJobs());
        //}

        public async Task<IActionResult> Index(
                   string sortOrder,
                   string currentFilter,
                   string searchString,
                   int? pageNumber)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var jobsTask = await businessLogicJob.ListJobs();
            var jobs = jobsTask.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                jobs = jobs.Where(s => s.JobTitle.Contains(searchString)
                                       || s.Description.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    jobs = jobs.OrderByDescending(s => s.JobTitle);
                    break;
                case "Date":
                    jobs = jobs.OrderBy(s => s.CreatedAt);
                    break;
                case "date_desc":
                    jobs = jobs.OrderByDescending(s => s.CreatedAt);
                    break;
                default:
                    jobs = jobs.OrderBy(s => s.Description);
                    break;
            }

            int pageSize = 8;
            return View(PaginatedList<Job>.Create(jobs.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await businessLogicJob.GetJob((int) id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Jobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdJob,JobTitle,Description,CreatedAt,ExpiredAt")] Job job)
        {
            if (ModelState.IsValid)
            {
                await businessLogicJob.CreateJob(job);
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await businessLogicJob.GetJob((int)id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdJob,JobTitle,Description,CreatedAt,ExpiredAt")] Job job)
        {
            if (id != job.IdJob)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await businessLogicJob.UpdateJob(job);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!businessLogicJob.JobExists(job.IdJob))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(job);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await businessLogicJob.GetJob((int)id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await businessLogicJob.GetJob(id);
            await businessLogicJob.DeleteJob(job);
            return RedirectToAction(nameof(Index));
        }

    }
}
