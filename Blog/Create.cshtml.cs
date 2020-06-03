using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer.Models;

namespace Blog
{
    public class CreateModel : PageModel
    {
        private readonly DataLayer.Models.BlogDBContext _context;

        public CreateModel(DataLayer.Models.BlogDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PageGroups PageGroups { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PageGroups.Add(PageGroups);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
