using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class EntradaProdutoController : Controller
    {
        private readonly Contexto _context;

        public EntradaProdutoController(Contexto context)
        {
            _context = context;
        }

        // GET: EntradaProduto
        public async Task<IActionResult> Index()
        {
              return _context.EntradaProduto != null ? 
                          View(await _context.EntradaProduto.ToListAsync()) :
                          Problem("Entity set 'Contexto.EntradaProduto'  is null.");
        }

        // GET: EntradaProduto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EntradaProduto == null)
            {
                return NotFound();
            }

            var entradaProduto = await _context.EntradaProduto
                .FirstOrDefaultAsync(m => m.EntradaProdutoId == id);
            if (entradaProduto == null)
            {
                return NotFound();
            }

            return View(entradaProduto);
        }

        // GET: EntradaProduto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EntradaProduto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntradaProdutoId,ProdutoId,DataEntrada,QuantidadeEntradaId")] EntradaProduto entradaProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entradaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entradaProduto);
        }

        // GET: EntradaProduto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EntradaProduto == null)
            {
                return NotFound();
            }

            var entradaProduto = await _context.EntradaProduto.FindAsync(id);
            if (entradaProduto == null)
            {
                return NotFound();
            }
            return View(entradaProduto);
        }

        // POST: EntradaProduto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntradaProdutoId,ProdutoId,DataEntrada,QuantidadeEntradaId")] EntradaProduto entradaProduto)
        {
            if (id != entradaProduto.EntradaProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entradaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntradaProdutoExists(entradaProduto.EntradaProdutoId))
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
            return View(entradaProduto);
        }

        // GET: EntradaProduto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EntradaProduto == null)
            {
                return NotFound();
            }

            var entradaProduto = await _context.EntradaProduto
                .FirstOrDefaultAsync(m => m.EntradaProdutoId == id);
            if (entradaProduto == null)
            {
                return NotFound();
            }

            return View(entradaProduto);
        }

        // POST: EntradaProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EntradaProduto == null)
            {
                return Problem("Entity set 'Contexto.EntradaProduto'  is null.");
            }
            var entradaProduto = await _context.EntradaProduto.FindAsync(id);
            if (entradaProduto != null)
            {
                _context.EntradaProduto.Remove(entradaProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntradaProdutoExists(int id)
        {
          return (_context.EntradaProduto?.Any(e => e.EntradaProdutoId == id)).GetValueOrDefault();
        }
    }
}
