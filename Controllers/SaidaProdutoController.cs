﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class SaidaProdutoController : Controller
    {
        private readonly Contexto _context;

        public SaidaProdutoController(Contexto context)
        {
            _context = context;
        }

        // GET: SaidaProduto
        public async Task<IActionResult> Index()
        {
              return _context.SaidaProduto != null ? 
                          View(await _context.SaidaProduto.ToListAsync()) :
                          Problem("Entity set 'Contexto.SaidaProduto'  is null.");
        }

        // GET: SaidaProduto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto
                .FirstOrDefaultAsync(m => m.SaidaProdutoId == id);
            if (saidaProduto == null)
            {
                return NotFound();
            }

            return View(saidaProduto);
        }

        // GET: SaidaProduto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SaidaProduto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SaidaProdutoId,ProdutoId,DataSaida,QuantidadeSaidaId,UsuarioId,ClienteId,TipoSaidaId")] SaidaProduto saidaProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saidaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saidaProduto);
        }

        // GET: SaidaProduto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto.FindAsync(id);
            if (saidaProduto == null)
            {
                return NotFound();
            }
            return View(saidaProduto);
        }

        // POST: SaidaProduto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SaidaProdutoId,ProdutoId,DataSaida,QuantidadeSaidaId,UsuarioId,ClienteId,TipoSaidaId")] SaidaProduto saidaProduto)
        {
            if (id != saidaProduto.SaidaProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saidaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaidaProdutoExists(saidaProduto.SaidaProdutoId))
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
            return View(saidaProduto);
        }

        // GET: SaidaProduto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto
                .FirstOrDefaultAsync(m => m.SaidaProdutoId == id);
            if (saidaProduto == null)
            {
                return NotFound();
            }

            return View(saidaProduto);
        }

        // POST: SaidaProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SaidaProduto == null)
            {
                return Problem("Entity set 'Contexto.SaidaProduto'  is null.");
            }
            var saidaProduto = await _context.SaidaProduto.FindAsync(id);
            if (saidaProduto != null)
            {
                _context.SaidaProduto.Remove(saidaProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaidaProdutoExists(int id)
        {
          return (_context.SaidaProduto?.Any(e => e.SaidaProdutoId == id)).GetValueOrDefault();
        }
    }
}
