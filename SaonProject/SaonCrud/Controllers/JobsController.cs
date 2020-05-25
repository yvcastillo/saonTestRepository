using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Saon.BusinessLogic;
using Saon.DataAccess;
using Saon.Entities;

namespace SaonCrud.Controllers
{
    public class JobsController : Controller
    {
        private BL_Job businessLogicJob;

        public JobsController()
        {
            businessLogicJob = new BL_Job();
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            return View(await businessLogicJob.ListJobs());
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
