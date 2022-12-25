using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapiditoWEBAPP.Data;
using RapiditoWEBAPP.Models;

namespace RapiditoWEBAPP.Controllers
{
    public class ZonassController : Controller
    {
        private readonly RapiditoContext _context;

        public ZonassController(RapiditoContext context)
        {
            _context = context;
        }

        // GET: Zonass
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zonass.ToListAsync());
        }

        // GET: Zonass/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zonass = await _context.Zonass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zonass == null)
            {
                return NotFound();
            }

            return View(zonass);
        }

        // GET: Zonass/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zonass/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Zona,Departamento,Municipio,Estado")] Zonass zonass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zonass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zonass);
        }

        // GET: Zonass/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zonass = await _context.Zonass.FindAsync(id);
            if (zonass == null)
            {
                return NotFound();
            }
            return View(zonass);
        }

        // POST: Zonass/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Zona,Departamento,Municipio,Estado")] Zonass zonass)
        {
            if (id != zonass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zonass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZonassExists(zonass.ID))
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
            return View(zonass);
        }

        // GET: Zonass/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zonass = await _context.Zonass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zonass == null)
            {
                return NotFound();
            }

            return View(zonass);
        }

        // POST: Zonass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zonass = await _context.Zonass.FindAsync(id);
            _context.Zonass.Remove(zonass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZonassExists(int id)
        {
            return _context.Zonass.Any(e => e.ID == id);
        }
    }
}
