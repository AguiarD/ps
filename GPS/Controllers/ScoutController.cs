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
    public class ScoutController : Controller
    {
        private readonly Contexto _context;

        public ScoutController(Contexto context)
        {
            _context = context;
        }

        // GET: Scout
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Scouts.Include(s => s.Jogadores).Include(s => s.Parametros);
            return View(await contexto.ToListAsync());
        }

        // GET: Scout/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts
                .Include(s => s.Jogadores)
                .Include(s => s.Parametros)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scout == null)
            {
                return NotFound();
            }

            return View(scout);
        }

        // GET: Scout/Create
        public IActionResult Create()
        {
            ViewData["JogadorIdA1"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA2"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA3"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA4"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA5"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA6"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA7"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA8"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA9"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdA10"] = new SelectList(_context.Jogadores, "Id", "NameJogador");

            ViewData["JogadorIdB1"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB2"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB3"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB4"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB5"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB6"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB7"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB8"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB9"] = new SelectList(_context.Jogadores, "Id", "NameJogador");
            ViewData["JogadorIdB10"] = new SelectList(_context.Jogadores, "Id", "NameJogador");

            //ViewData["ParametroId"] = new SelectList(_context.Parametros, "Id", "DescParametro");
            return View();
        }

        // POST: Scout/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DateTime DtPartida, String ObsScout,
            int jogA1, int golA1,
            int jogA2, int golA2,
            int jogA3, int golA3,
            int jogA4, int golA4,
            int jogA5, int golA5,
            int jogA6, int golA6,
            int jogA7, int golA7,
            int jogA8, int golA8,
            int jogA9, int golA9,
            int jogA10, int golA10,
            int jogB1, int golB1,
            int jogB2, int golB2,
            int jogB3, int golB3,
            int jogB4, int golB4,
            int jogB5, int golB5,
            int jogB6, int golB6,
            int jogB7, int golB7,
            int jogB8, int golB8,
            int jogB9, int golB9,
            int jogB10, int golB10,
            [Bind("Id,DtPartida,JogadorId,Presente,ParametroId,Gol,Assistencia,ObsScout,Inativo")] Scout scout)
        {
            var GolA = golA1 + golA2 + golA3 + golA4 + golA5 + golA6 + golA7 + golA8 + golA9 + golA10;
            var GolB = golB1 + golB2 + golB3 + golB4 + golB5 + golB6 + golB7 + golB8 + golB9 + golB10;


            //if (ModelState.IsValid)
            //{
                if (GolA > GolB)
                {
                    scout.JogadorId = jogA1;
                    scout.Presente = 1;
                    scout.ParametroId = 3;
                    scout.Gol = golA1;
                    _context.Add(scout);
                    await _context.SaveChangesAsync();

                    scout.Id = 0;
                    scout.JogadorId = jogB1;
                    scout.Presente = 1;
                    scout.ParametroId = 5;
                    scout.Gol = golB1;
                    _context.Add(scout);
                    await _context.SaveChangesAsync();

                    //return RedirectToAction(nameof(Index));
                }
            //}
            //ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Mensalista", scout.JogadorId);
            //ViewData["ParametroId"] = new SelectList(_context.Parametros, "Id", "DescParametro", scout.ParametroId);
            return View(scout);
        }

        // GET: Scout/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts.FindAsync(id);
            if (scout == null)
            {
                return NotFound();
            }
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Mensalista", scout.JogadorId);
            ViewData["ParametroId"] = new SelectList(_context.Parametros, "Id", "DescParametro", scout.ParametroId);
            return View(scout);
        }

        // POST: Scout/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DtPartida,JogadorId,Presente,ParametroId,Gol,Assistencia,ObsScout,Inativo")] Scout scout)
        {
            if (id != scout.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoutExists(scout.Id))
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
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Mensalista", scout.JogadorId);
            ViewData["ParametroId"] = new SelectList(_context.Parametros, "Id", "DescParametro", scout.ParametroId);
            return View(scout);
        }

        // GET: Scout/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts
                .Include(s => s.Jogadores)
                .Include(s => s.Parametros)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scout == null)
            {
                return NotFound();
            }

            return View(scout);
        }

        // POST: Scout/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scout = await _context.Scouts.FindAsync(id);
            _context.Scouts.Remove(scout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoutExists(int id)
        {
            return _context.Scouts.Any(e => e.Id == id);
        }
    }
}
