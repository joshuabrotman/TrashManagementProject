using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashManagement.Data;
using TrashManagement.Models;

namespace TrashManagement.Controllers
{
    public class SuspendsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuspendsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Suspends
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Suspend.Include(s => s.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Suspends/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspend = await _context.Suspend
                .Include(s => s.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspend == null)
            {
                return NotFound();
            }

            return View(suspend);
        }

        // GET: Suspends/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            return View();
        }

        // POST: Suspends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SuspendStart,SuspendEnd,CustomerId")] Suspend suspend)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suspend);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", suspend.CustomerId);
            return View(suspend);
        }

        // GET: Suspends/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspend = await _context.Suspend.FindAsync(id);
            if (suspend == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", suspend.CustomerId);
            return View(suspend);
        }

        // POST: Suspends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SuspendStart,SuspendEnd,CustomerId")] Suspend suspend)
        {
            if (id != suspend.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suspend);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuspendExists(suspend.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", suspend.CustomerId);
            return View(suspend);
        }

        // GET: Suspends/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspend = await _context.Suspend
                .Include(s => s.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspend == null)
            {
                return NotFound();
            }

            return View(suspend);
        }

        // POST: Suspends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suspend = await _context.Suspend.FindAsync(id);
            _context.Suspend.Remove(suspend);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuspendExists(int id)
        {
            return _context.Suspend.Any(e => e.Id == id);
        }
    }
}
