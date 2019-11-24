using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using Fastfood1.Data;

namespace Fastfood1.Pages.Monans
{
    public class DetailsModel : PageModel
    {
        private readonly Fastfood1.Data.FastfoodContext _context;

        public DetailsModel(Fastfood1.Data.FastfoodContext context)
        {
            _context = context;
        }

        public Monan Monan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monan = await _context.Monan.FirstOrDefaultAsync(m => m.ID == id);

            if (Monan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
