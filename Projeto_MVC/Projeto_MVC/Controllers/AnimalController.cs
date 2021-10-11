using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Data;
using Projeto_MVC.Models;
using Projeto_MVC.FormataValores;

namespace Projeto_MVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly DatabaseContext _context;

        public AnimalController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Animal
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.AnimalModel.Include(a => a.Especie).Include(a => a.Proprietario);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Animal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel
                .Include(a => a.Especie)
                .Include(a => a.Proprietario)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animalModel == null)
            {
                return NotFound();
            }

            return View(animalModel);
        }

        // GET: Animal/Create
        public IActionResult Create()
        {
            ViewData["EspecieId"] = new SelectList(_context.EspecieModel, "EspecieId", "EspecieId");
            ViewData["ProprietarioId"] = new SelectList(_context.ProprietarioModel, "ProprietarioId", "ProprietarioId");
            return View();
        }

        // POST: Animal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnimalId,Nome,Peso,altura,Comprimento,Pedigree,EspecieId,ProprietarioId")] AnimalModel animalModel)
        {
            if (ModelState.IsValid)
            {
                animalModel.Nome = FormatarTexto.FormataMaiusculo(animalModel.Nome);
                animalModel.Pedigree = FormatarTexto.FormataMaiusculo(animalModel.Pedigree);

                _context.Add(animalModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EspecieId"] = new SelectList(_context.EspecieModel, "EspecieId", "EspecieId", animalModel.EspecieId);
            ViewData["ProprietarioId"] = new SelectList(_context.ProprietarioModel, "ProprietarioId", "ProprietarioId", animalModel.ProprietarioId);
            return View(animalModel);
        }
        // GET: Animal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel.FindAsync(id);
            if (animalModel == null)
            {
                return NotFound();
            }
            ViewData["EspecieId"] = new SelectList(_context.EspecieModel, "EspecieId", "EspecieId", animalModel.EspecieId);
            ViewData["ProprietarioId"] = new SelectList(_context.ProprietarioModel, "ProprietarioId", "ProprietarioId", animalModel.ProprietarioId);
            return View(animalModel);
        }

        // POST: Animal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Nome,Peso,altura,Comprimento,Pedigree,EspecieId,ProprietarioId")] AnimalModel animalModel)
        {
            if (id != animalModel.AnimalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    animalModel.Nome = FormatarTexto.FormataMaiusculo(animalModel.Nome);
                    animalModel.Pedigree = FormatarTexto.FormataMaiusculo(animalModel.Pedigree);

                    _context.Update(animalModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalModelExists(animalModel.AnimalId))
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
            ViewData["EspecieId"] = new SelectList(_context.EspecieModel, "EspecieId", "EspecieId", animalModel.EspecieId);
            ViewData["ProprietarioId"] = new SelectList(_context.ProprietarioModel, "ProprietarioId", "ProprietarioId", animalModel.ProprietarioId);
            return View(animalModel);
        }

        // GET: Animal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalModel = await _context.AnimalModel
                .Include(a => a.Especie)
                .Include(a => a.Proprietario)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animalModel == null)
            {
                return NotFound();
            }

            return View(animalModel);
        }

        // POST: Animal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animalModel = await _context.AnimalModel.FindAsync(id);
            _context.AnimalModel.Remove(animalModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalModelExists(int id)
        {
            return _context.AnimalModel.Any(e => e.AnimalId == id);
        }
    }
}
