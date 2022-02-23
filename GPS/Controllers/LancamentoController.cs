#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GPS;
using GPS.Models;

namespace GPS.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly Contexto _context;

        public LancamentoController(Contexto context)
        {
            _context = context;
        }

        // GET: Lancamento
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Financeiros.Include(l => l.Contas).Include(l => l.Jogadores);
            return View(await contexto.ToListAsync());
        }

        // GET: Lancamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Financeiros
                .Include(l => l.Contas)
                .Include(l => l.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // GET: Lancamento/Create
        public IActionResult Create()
        {
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta");
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            return View();
        }

        // POST: Lancamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContaId,JogadorId,Valor,ObsLancamento,DtPrevisao,DtBaixa,Inativo")] Lancamento lancamento)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(lancamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        //    ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
        //    ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "NameJogador", lancamento.JogadorId);
        //    return View(lancamento);
        //}

        // GET: Lancamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Financeiros.FindAsync(id);
            if (lancamento == null)
            {
                return NotFound();
            }
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Mensalista", lancamento.JogadorId);
            return View(lancamento);
        }

        // POST: Lancamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContaId,JogadorId,Valor,ObsLancamento,DtPrevisao,DtBaixa,Inativo")] Lancamento lancamento)
        {
            if (id != lancamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lancamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoExists(lancamento.Id))
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
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Mensalista", lancamento.JogadorId);
            return View(lancamento);
        }

        // GET: Lancamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Financeiros
                .Include(l => l.Contas)
                .Include(l => l.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // POST: Lancamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lancamento = await _context.Financeiros.FindAsync(id);
            _context.Financeiros.Remove(lancamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoExists(int id)
        {
            return _context.Financeiros.Any(e => e.Id == id);
        }
    }
}
