using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace Blog
{
    public class DeleteModel : PageModel
    {
        private readonly DataLayer.Models.BlogDBContext _context;

        public DeleteModel(DataLayer.Models.BlogDBContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PageGroups = await _context.PageGroups.FindAsync(id);

            if (PageGroups != null)
            {
                _context.PageGroups.Remove(PageGroups);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
