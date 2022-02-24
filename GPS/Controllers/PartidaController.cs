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

//using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;
//using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace GPS.Controllers
{
    public class PartidaController : Controller
    {
        private readonly Contexto _context;

        public PartidaController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Index()
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

            ViewData["ParametroId"] = new SelectList(_context.Parametros, "Id", "DescParametro");
            return View();
        }


        // POST: Lancamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DtPartida,JogadorId,Presente,ParametroId,Ponto,Gol,Assistencia,ObsScout")] Scout scout)
        {
            //if (ModelState.IsValid)
            //{
            _context.Add(scout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //    ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
        //    ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "NameJogador", lancamento.JogadorId);
        //    return View(lancamento);
        //}
    }
}
