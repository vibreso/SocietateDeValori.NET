﻿#nullable disable
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
    public class DetailsModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public DetailsModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
