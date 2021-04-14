using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CeeLearnAndDo_WijOnt.Data;
using CeeLearnAndDo_WijOnt.Models;

namespace CeeLearnAndDo_WijOnt.Controllers
{
    public class FaQsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FaQsController(ApplicationDbContext context)
        {
            _context = context;
        }
        //get Faq overview
        public async Task<IActionResult> FaQs()
        {
            return View(await _context.FaQ.ToListAsync());
        }


        // GET: FaQs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FaQ.ToListAsync());
        }

        // GET: FaQs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faQ = await _context.FaQ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faQ == null)
            {
                return NotFound();
            }

            return View(faQ);
        }

        // GET: FaQs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FaQs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Question,Answer,CreationTime")] FaQ faQ)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faQ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faQ);
        }

        // GET: FaQs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faQ = await _context.FaQ.FindAsync(id);
            if (faQ == null)
            {
                return NotFound();
            }
            return View(faQ);
        }

        // POST: FaQs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,Answer,CreationTime")] FaQ faQ)
        {
            if (id != faQ.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faQ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaQExists(faQ.Id))
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
            return View(faQ);
        }

        // GET: FaQs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faQ = await _context.FaQ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faQ == null)
            {
                return NotFound();
            }

            return View(faQ);
        }

        // POST: FaQs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faQ = await _context.FaQ.FindAsync(id);
            _context.FaQ.Remove(faQ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaQExists(int id)
        {
            return _context.FaQ.Any(e => e.Id == id);
        }
    }
}
