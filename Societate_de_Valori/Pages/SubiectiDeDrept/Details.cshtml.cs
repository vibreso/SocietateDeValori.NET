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

namespace Societate_de_Valori.Pages.SubiectiDeDrept
{
    public class DetailsModel : PageModel
    {
        private readonly Societate_de_Valori.Data.Societate_de_ValoriContext _context;

        public DetailsModel(Societate_de_Valori.Data.Societate_de_ValoriContext context)
        {
            _context = context;
        }

        public SubiectDeDrept SubiectDeDrept { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SubiectDeDrept = await _context.SubiectDeDrept.FirstOrDefaultAsync(m => m.ID == id);

            if (SubiectDeDrept == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
