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
    public class IndexModel : PageModel
    {
        private readonly Fastfood1.Data.FastfoodContext _context;

        public IndexModel(Fastfood1.Data.FastfoodContext context)
        {
            _context = context;
        }

        public IList<Hoadon> Hoadon { get;set; }

        public async Task OnGetAsync()
        {
            Hoadon = await _context.Hoadon.ToListAsync();
        }
    }
}
