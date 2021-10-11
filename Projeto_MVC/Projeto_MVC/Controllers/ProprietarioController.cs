using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Data;
using Projeto_MVC.FormataValores;
using Projeto_MVC.Models;

namespace Projeto_MVC.Controllers
{
    public class ProprietarioController : Controller
    {
        private readonly DatabaseContext _context;

        public ProprietarioController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Proprietario
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProprietarioModel.ToListAsync());
        }

        // GET: Proprietario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietarioModel = await _context.ProprietarioModel
                .FirstOrDefaultAsync(m => m.ProprietarioId == id);
            if (proprietarioModel == null)
            {
                return NotFound();
            }

            return View(proprietarioModel);
        }

        // GET: Proprietario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proprietario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProprietarioId,Nome,Rg,Cpf,Rua,Cidade")] ProprietarioModel proprietarioModel)
        {
            if (ModelState.IsValid)
            {
                proprietarioModel.Nome = FormatarTexto.FormataMaiusculo(proprietarioModel.Nome);
                proprietarioModel.Rua = FormatarTexto.FormataMaiusculo(proprietarioModel.Rua);
                proprietarioModel.Cidade = FormatarTexto.FormataMaiusculo(proprietarioModel.Cidade);

                _context.Add(proprietarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proprietarioModel);
        }

        // GET: Proprietario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietarioModel = await _context.ProprietarioModel.FindAsync(id);
            if (proprietarioModel == null)
            {
                return NotFound();
            }
            return View(proprietarioModel);
        }

        // POST: Proprietario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProprietarioId,Nome,Rg,Cpf,Rua,Cidade")] ProprietarioModel proprietarioModel)
        {
            if (id != proprietarioModel.ProprietarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    proprietarioModel.Nome = FormatarTexto.FormataMaiusculo(proprietarioModel.Nome);
                    proprietarioModel.Rua = FormatarTexto.FormataMaiusculo(proprietarioModel.Rua);
                    proprietarioModel.Cidade = FormatarTexto.FormataMaiusculo(proprietarioModel.Cidade);

                    _context.Update(proprietarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProprietarioModelExists(proprietarioModel.ProprietarioId))
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
            return View(proprietarioModel);
        }

        // GET: Proprietario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietarioModel = await _context.ProprietarioModel
                .FirstOrDefaultAsync(m => m.ProprietarioId == id);
            if (proprietarioModel == null)
            {
                return NotFound();
            }

            return View(proprietarioModel);
        }

        // POST: Proprietario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proprietarioModel = await _context.ProprietarioModel.FindAsync(id);
            _context.ProprietarioModel.Remove(proprietarioModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProprietarioModelExists(int id)
        {
            return _context.ProprietarioModel.Any(e => e.ProprietarioId == id);
        }
    }
}
