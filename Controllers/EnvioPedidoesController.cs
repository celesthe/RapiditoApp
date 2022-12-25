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
    public class EnvioPedidoesController : Controller
    {
        private readonly RapiditoContext _context;

        public EnvioPedidoesController(RapiditoContext context)
        {
            _context = context;
        }

        // GET: EnvioPedidoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnvioPedido.ToListAsync());
        }

        // GET: EnvioPedidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var envioPedido = await _context.EnvioPedido
                .FirstOrDefaultAsync(m => m.ID == id);
            if (envioPedido == null)
            {
                return NotFound();
            }

            return View(envioPedido);
        }

        // GET: EnvioPedidoes/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Succes()
        {
            return View();
        }

        // POST: EnvioPedidoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DireccionOrigen,UbicacionGeograficaOrigen,IdCliente,productoAentregar,idCuotaPesoE,DireccionDestino,UbicacionGeograficaDestino,NombreClienteRecibe,doctoIdentificacion")] EnvioPedido envioPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(envioPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction("Succes");
            }
            return View(envioPedido);
        }

        // GET: EnvioPedidoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var envioPedido = await _context.EnvioPedido.FindAsync(id);
            if (envioPedido == null)
            {
                return NotFound();
            }
            return View(envioPedido);
        }

        // POST: EnvioPedidoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DireccionOrigen,UbicacionGeograficaOrigen,IdCliente,productoAentregar,idCuotaPesoE,DireccionDestino,UbicacionGeograficaDestino,NombreClienteRecibe,doctoIdentificacion")] EnvioPedido envioPedido)
        {
            if (id != envioPedido.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(envioPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnvioPedidoExists(envioPedido.ID))
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
            return View(envioPedido);
        }

        // GET: EnvioPedidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var envioPedido = await _context.EnvioPedido
                .FirstOrDefaultAsync(m => m.ID == id);
            if (envioPedido == null)
            {
                return NotFound();
            }

            return View(envioPedido);
        }

        // POST: EnvioPedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var envioPedido = await _context.EnvioPedido.FindAsync(id);
            _context.EnvioPedido.Remove(envioPedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnvioPedidoExists(int id)
        {
            return _context.EnvioPedido.Any(e => e.ID == id);
        }
    }
}
