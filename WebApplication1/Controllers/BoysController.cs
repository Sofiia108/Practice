using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BoysController : Controller
    {
        private readonly WebApplication1Context _context;

        public BoysController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Boys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boy.ToListAsync());
        }

        // GET: Boys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boy = await _context.Boy
                .FirstOrDefaultAsync(m => m.ID == id);
            if (boy == null)
            {
                return NotFound();
            }

            return View(boy);
        }

        // GET: Boys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Behevior,SumGirls")] Boy boy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boy);
        }

        // GET: Boys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boy = await _context.Boy.FindAsync(id);
            if (boy == null)
            {
                return NotFound();
            }
            return View(boy);
        }

        // POST: Boys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Behevior,SumGirls")] Boy boy)
        {
            if (id != boy.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoyExists(boy.ID))
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
            return View(boy);
        }

        // GET: Boys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boy = await _context.Boy
                .FirstOrDefaultAsync(m => m.ID == id);
            if (boy == null)
            {
                return NotFound();
            }

            return View(boy);
        }

        // POST: Boys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boy = await _context.Boy.FindAsync(id);
            _context.Boy.Remove(boy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoyExists(int id)
        {
            return _context.Boy.Any(e => e.ID == id);
        }
    }
}
