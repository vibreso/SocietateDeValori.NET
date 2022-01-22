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

namespace Societate_de_Valori.Pages.Tranzactii
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
            ViewData["FirmaID"] = new SelectList(_context.Firma, "ID", "Nume");
            ViewData["InvestitorID"] = new SelectList(_context.Investitor, "ID", "Nume");
            ViewData["PlatformaID"] = new SelectList(_context.Platforma, "ID", "Nume");
            ViewData["TipTranzactieID"] = new SelectList(_context.TipTranzactie, "ID", "Nume");
            ViewData["ValutaID"] = new SelectList(_context.Valuta, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Tranzactie Tranzactie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Tranzactie.Add(Tranzactie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
