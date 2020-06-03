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
    public class IndexModel : PageModel
    {
        private readonly DataLayer.Models.BlogDBContext _context;

        public IndexModel(DataLayer.Models.BlogDBContext context)
        {
            _context = context;
        }

        public IList<PageGroups> PageGroups { get;set; }

        public async Task OnGetAsync()
        {
            PageGroups = await _context.PageGroups.ToListAsync();
        }
    }
}
