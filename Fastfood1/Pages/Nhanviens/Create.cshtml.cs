using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fastfood.Models;
using Fastfood1.Data;

namespace Fastfood1.Pages.Nhanviens
{
    public class CreateModel : PageModel
    {
        private readonly Fastfood1.Data.FastfoodContext _context;

        public CreateModel(Fastfood1.Data.FastfoodContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Nhanvien Nhanvien { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Nhanvien.Add(Nhanvien);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
