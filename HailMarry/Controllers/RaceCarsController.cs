using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackupProject.Models;
using HailMarry.Data;

namespace HailMarry.Controllers
{
    public class RaceCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RaceCars
        public async Task<IActionResult> Index()
        {
            return View(await _context.RaceCars.ToListAsync());
        }

        // GET: RaceCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceCars = await _context.RaceCars
                .FirstOrDefaultAsync(m => m.RaceCarsId == id);
            if (raceCars == null)
            {
                return NotFound();
            }

            return View(raceCars);
        }

        // GET: RaceCars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RaceCars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RaceCarsId,Make,Model,Year,Photo")] RaceCars raceCars)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raceCars);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raceCars);
        }

        // GET: RaceCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceCars = await _context.RaceCars.FindAsync(id);
            if (raceCars == null)
            {
                return NotFound();
            }
            return View(raceCars);
        }

        // POST: RaceCars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RaceCarsId,Make,Model,Year,Photo")] RaceCars raceCars)
        {
            if (id != raceCars.RaceCarsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raceCars);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceCarsExists(raceCars.RaceCarsId))
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
            return View(raceCars);
        }

        // GET: RaceCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raceCars = await _context.RaceCars
                .FirstOrDefaultAsync(m => m.RaceCarsId == id);
            if (raceCars == null)
            {
                return NotFound();
            }

            return View(raceCars);
        }

        // POST: RaceCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var raceCars = await _context.RaceCars.FindAsync(id);
            _context.RaceCars.Remove(raceCars);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaceCarsExists(int id)
        {
            return _context.RaceCars.Any(e => e.RaceCarsId == id);
        }
    }
}
