#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Societate_de_Valori.Data;
using Societate_de_Valori.Models;

namespace Societate_de_Valori.Pages.Investitori
{
    public class CreateModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public CreateModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SubiectDeDreptID"] = new SelectList(_context.SubiectDeDrept, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Investitor Investitor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
            _context.Investitor.Add(Investitor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
