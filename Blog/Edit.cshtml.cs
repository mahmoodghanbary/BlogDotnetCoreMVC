using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace Blog
{
    public class EditModel : PageModel
    {
        private readonly DataLayer.Models.BlogDBContext _context;

        public EditModel(DataLayer.Models.BlogDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PageGroups PageGroups { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PageGroups = await _context.PageGroups.FirstOrDefaultAsync(m => m.GroupID == id);

            if (PageGroups == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PageGroups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PageGroupsExists(PageGroups.GroupID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PageGroupsExists(int id)
        {
            return _context.PageGroups.Any(e => e.GroupID == id);
        }
    }
}
