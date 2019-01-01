using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using N.Data;
using N.Models;

namespace N.Controllers
{
    public class MemosController : Controller
    {
        private readonly NisContext _context;

        public MemosController(NisContext context)
        {
            _context = context;
        }

        // GET: Memos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Memos.ToListAsync());
        }

        // GET: Memos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memo = await _context.Memos
                .FirstOrDefaultAsync(m => m.Empid == id);
            if (memo == null)
            {
                return NotFound();
            }

            return View(memo);
        }

        // GET: Memos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Memos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Empid,Title,Memos")] Memo memo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memo);
        }

        // GET: Memos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memo = await _context.Memos.FindAsync(id);
            if (memo == null)
            {
                return NotFound();
            }
            return View(memo);
        }

        // POST: Memos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Empid,Title,Memos")] Memo memo)
        {
            if (id != memo.Empid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemoExists(memo.Empid))
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
            return View(memo);
        }

        // GET: Memos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memo = await _context.Memos
                .FirstOrDefaultAsync(m => m.Empid == id);
            if (memo == null)
            {
                return NotFound();
            }

            return View(memo);
        }

        // POST: Memos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var memo = await _context.Memos.FindAsync(id);
            _context.Memos.Remove(memo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemoExists(string id)
        {
            return _context.Memos.Any(e => e.Empid == id);
        }
    }
}
