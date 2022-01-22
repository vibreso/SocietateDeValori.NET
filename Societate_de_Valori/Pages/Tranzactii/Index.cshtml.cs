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

namespace Societate_de_Valori.Pages.Tranzactii
{
    public class IndexModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public IndexModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        public IList<Tranzactie> Tranzactie { get;set; }

        public async Task OnGetAsync()
        {
            Tranzactie = await _context.Tranzactie
                .Include(t => t.Firma)
                .Include(t => t.Investitor)
                .Include(t => t.Platforma)
                .Include(t => t.Valuta)
                .Include(t => t.TipTranzactie).ToListAsync();
        }
    }
}
