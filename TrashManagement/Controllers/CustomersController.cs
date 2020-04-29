using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashManagement.Data;
using TrashManagement.Models;

namespace TrashManagement.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }


        //// GET: Superhero/Details/5
        //public IActionResult Details(int superheroID)
        //{
        //    var superhero = context.Superhero.Where(s => s.Id == superheroID).SingleOrDefault();
        //    return View(superhero);
        //}

        // GET: Customers
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(customer);
            //var applicationDbContext = _context.Customer.Include(c => c.IdentityUser);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IdentityUserId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); 
                customer.IdentityUserId = userId;
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customer.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
        //    return View(customer);
        //}

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {

            var customer = _context.Customer.Where(s => s.Id == id).SingleOrDefault();
            

            return View(customer);
        }



        //[HttpPost]
        //public IActionResult Edit(Player player)
        //{
        //    // Tracking changes
        //    var playerInDB = _context.Players.Single(m => m.Id == player.Id);
        //    playerInDB.FirstName = player.FirstName;
        //    playerInDB.LastName = player.LastName;
        //    playerInDB.TeamId = player.TeamId;
        //    playerInDB.Teams = _context.Teams.ToList();
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Players");
        //}

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Customer collection)
        {
            try
            {
                var customer = _context.Customer.Where(s => s.Id == collection.Id).SingleOrDefault();
                customer.Name = collection.Name;
                customer.pickupDay = collection.pickupDay;
                customer.street = collection.street;
                customer.suspendEnd = collection.suspendEnd;
                customer.suspendStart = collection.suspendStart;
                customer.zipCode = collection.zipCode;
                customer.monthlyBalance = collection.monthlyBalance;
                
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IdentityUserId")] Customer customer)
        //{
        //    if (id != customer.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(customer);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CustomerExists(customer.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
        //    return View(customer);
        //}

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        //public async Task<IActionResult> MySettings()
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var loggedinCustomer = _context.Customer.Where(c => (c.Id).ToString() == userId).SingleOrDefault();
        //    //var applicationDbContext = _context.Customer.Include(e => e.IdentityUser);
        //    return View(loggedinCustomer);
        //}

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
