using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using Fastfood1.Data;

namespace Fastfood1.Pages.Nhanviens
{
    public class EditModel : PageModel
    {
        private readonly Fastfood1.Data.FastfoodContext _context;

        public EditModel(Fastfood1.Data.FastfoodContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Nhanvien Nhanvien { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nhanvien = await _context.Nhanvien.FirstOrDefaultAsync(m => m.ID == id);

            if (Nhanvien == null)
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

            _context.Attach(Nhanvien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhanvienExists(Nhanvien.ID))
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

        private bool NhanvienExists(int id)
        {
            return _context.Nhanvien.Any(e => e.ID == id);
        }
    }
}
