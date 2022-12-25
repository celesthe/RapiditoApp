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
    public class CuotaPesoesController : Controller
    {
        private readonly RapiditoContext _context;

        public CuotaPesoesController(RapiditoContext context)
        {
            _context = context;
        }

        // GET: CuotaPesoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CuotaPeso.ToListAsync());
        }

        // GET: CuotaPesoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuotaPeso = await _context.CuotaPeso
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cuotaPeso == null)
            {
                return NotFound();
            }

            return View(cuotaPeso);
        }

        // GET: CuotaPesoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CuotaPesoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Peso,Monto")] CuotaPeso cuotaPeso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuotaPeso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuotaPeso);
        }

        // GET: CuotaPesoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuotaPeso = await _context.CuotaPeso.FindAsync(id);
            if (cuotaPeso == null)
            {
                return NotFound();
            }
            return View(cuotaPeso);
        }

        // POST: CuotaPesoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Peso,Monto")] CuotaPeso cuotaPeso)
        {
            if (id != cuotaPeso.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuotaPeso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuotaPesoExists(cuotaPeso.ID))
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
            return View(cuotaPeso);
        }

        // GET: CuotaPesoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuotaPeso = await _context.CuotaPeso
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cuotaPeso == null)
            {
                return NotFound();
            }

            return View(cuotaPeso);
        }

        // POST: CuotaPesoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuotaPeso = await _context.CuotaPeso.FindAsync(id);
            _context.CuotaPeso.Remove(cuotaPeso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuotaPesoExists(int id)
        {
            return _context.CuotaPeso.Any(e => e.ID == id);
        }
    }
}
