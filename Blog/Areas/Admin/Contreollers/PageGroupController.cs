using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace Blog.Areas.Admin.Contreollers
{
    [Area("Admin")]
    public class PageGroupController : Controller
    {
        private readonly BlogDBContext _context;

        public PageGroupController(BlogDBContext context)
        {
            _context = context;
        }

        // GET: Admin/PageGroup
        public async Task<IActionResult> Index()
        {
              
            return View(await _context.PageGroups.ToListAsync());
        }

        // GET: Admin/PageGroup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = await _context.PageGroups
                .FirstOrDefaultAsync(m => m.GroupID == id);
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PageGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pageGroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = await _context.PageGroups.FindAsync(id);
            if (pageGroups == null)
            {
                return NotFound();
            }
            return View(pageGroups);
        }

        // POST: Admin/PageGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupID,GroupTitle")] PageGroups pageGroups)
        {
            if (id != pageGroups.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pageGroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageGroupsExists(pageGroups.GroupID))
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
            return View(pageGroups);
        }

        // GET: Admin/PageGroup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageGroups = await _context.PageGroups
                .FirstOrDefaultAsync(m => m.GroupID == id);
            if (pageGroups == null)
            {
                return NotFound();
            }

            return View(pageGroups);
        }

        // POST: Admin/PageGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pageGroups = await _context.PageGroups.FindAsync(id);
            _context.PageGroups.Remove(pageGroups);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PageGroupsExists(int id)
        {
            return _context.PageGroups.Any(e => e.GroupID == id);
        }
    }
}
