#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Societate_de_Valori.Data;
using Societate_de_Valori.Models;

namespace Societate_de_Valori.Pages.Tranzactii
{
    public class EditModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public EditModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tranzactie Tranzactie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tranzactie = await _context.Tranzactie
                .Include(t => t.Firma)
                .Include(t => t.Investitor)
                .Include(t => t.Platforma)
                .Include(t => t.TipTranzactie).FirstOrDefaultAsync(m => m.ID == id);

            if (Tranzactie == null)
            {
                return NotFound();
            }
           ViewData["FirmaID"] = new SelectList(_context.Firma, "ID", "Nume");
           ViewData["InvestitorID"] = new SelectList(_context.Investitor, "ID", "Nume");
           ViewData["PlatformaID"] = new SelectList(_context.Platforma, "ID", "Nume");
           ViewData["TipTranzactieID"] = new SelectList(_context.TipTranzactie, "ID", "Nume");
           ViewData["ValutaID"] = new SelectList(_context.TipTranzactie, "ID", "Nume");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tranzactie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TranzactieExists(Tranzactie.ID))
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

        private bool TranzactieExists(int id)
        {
            return _context.Tranzactie.Any(e => e.ID == id);
        }
    }
}
