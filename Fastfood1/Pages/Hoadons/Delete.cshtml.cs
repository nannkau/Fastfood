using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using Fastfood1.Data;

namespace Fastfood1.Pages.Hoadons
{
    public class DeleteModel : PageModel
    {
        private readonly Fastfood1.Data.FastfoodContext _context;

        public DeleteModel(Fastfood1.Data.FastfoodContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hoadon Hoadon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hoadon = await _context.Hoadon.FirstOrDefaultAsync(m => m.ID == id);

            if (Hoadon == null)
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

            Hoadon = await _context.Hoadon.FindAsync(id);

            if (Hoadon != null)
            {
                _context.Hoadon.Remove(Hoadon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
