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
    public class PickupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PickupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pickups
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pickup.Include(p => p.Customer).Include(p => p.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pickups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickup = await _context.Pickup
                .Include(p => p.Customer)
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickup == null)
            {
                return NotFound();
            }

            return View(pickup);
        }

        // GET: Pickups/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id");
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id");
            return View();
        }

        // POST: Pickups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TimeScheduled,TimeCompleted,CustomerId,EmployeeId")] Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pickup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", pickup.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", pickup.EmployeeId);
            return View(pickup);
        }

        // GET: Pickups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickup = await _context.Pickup.FindAsync(id);
            if (pickup == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", pickup.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", pickup.EmployeeId);
            return View(pickup);
        }

        // POST: Pickups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TimeScheduled,TimeCompleted,CustomerId,EmployeeId")] Pickup pickup)
        {
            if (id != pickup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pickup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PickupExists(pickup.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", pickup.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "Id", "Id", pickup.EmployeeId);
            return View(pickup);
        }

        // GET: Pickups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickup = await _context.Pickup
                .Include(p => p.Customer)
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pickup == null)
            {
                return NotFound();
            }

            return View(pickup);
        }

        // POST: Pickups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pickup = await _context.Pickup.FindAsync(id);
            _context.Pickup.Remove(pickup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PickupExists(int id)
        {
            return _context.Pickup.Any(e => e.Id == id);
        }
    }
}
