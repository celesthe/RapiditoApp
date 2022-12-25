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
    public class MotoristaZonasController : Controller
    {
        private readonly RapiditoContext _context;

        public MotoristaZonasController(RapiditoContext context)
        {
            _context = context;
        }

        // GET: MotoristaZonas
        public async Task<IActionResult> Index()
        {
            return View(await _context.MotoristaZona.ToListAsync());
        }

        // GET: MotoristaZonas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristaZona = await _context.MotoristaZona
                .FirstOrDefaultAsync(m => m.ID == id);
            if (motoristaZona == null)
            {
                return NotFound();
            }

            return View(motoristaZona);
        }

        // GET: MotoristaZonas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotoristaZonas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IdZonaM,IdMotoristaM")] MotoristaZona motoristaZona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motoristaZona);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motoristaZona);
        }

        // GET: MotoristaZonas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristaZona = await _context.MotoristaZona.FindAsync(id);
            if (motoristaZona == null)
            {
                return NotFound();
            }
            return View(motoristaZona);
        }

        // POST: MotoristaZonas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IdZonaM,IdMotoristaM")] MotoristaZona motoristaZona)
        {
            if (id != motoristaZona.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motoristaZona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotoristaZonaExists(motoristaZona.ID))
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
            return View(motoristaZona);
        }

        // GET: MotoristaZonas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristaZona = await _context.MotoristaZona
                .FirstOrDefaultAsync(m => m.ID == id);
            if (motoristaZona == null)
            {
                return NotFound();
            }

            return View(motoristaZona);
        }

        // POST: MotoristaZonas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motoristaZona = await _context.MotoristaZona.FindAsync(id);
            _context.MotoristaZona.Remove(motoristaZona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoristaZonaExists(int id)
        {
            return _context.MotoristaZona.Any(e => e.ID == id);
        }
    }
}
