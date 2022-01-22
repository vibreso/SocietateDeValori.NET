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

namespace Societate_de_Valori.Pages.TipTranzactii
{
    public class DetailsModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public DetailsModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        public TipTranzactie TipTranzactie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipTranzactie = await _context.TipTranzactie.FirstOrDefaultAsync(m => m.ID == id);

            if (TipTranzactie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
