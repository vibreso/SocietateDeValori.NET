#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Societate_de_Valori.Data;
using Societate_de_Valori.Models;

namespace Societate_de_Valori.Pages.Platforme
{
    public class DeleteModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public DeleteModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Platforma Platforma { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Platforma = await _context.Platforma.FirstOrDefaultAsync(m => m.ID == id);

            if (Platforma == null)
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

            Platforma = await _context.Platforma.FindAsync(id);

            if (Platforma != null)
            {
                _context.Platforma.Remove(Platforma);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
