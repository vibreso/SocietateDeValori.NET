#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Societate_de_Valori.Models;

namespace Societate_de_Valori.Data
{
    public class Societate_de_ValoriContext : DbContext
    {
        public Societate_de_ValoriContext (DbContextOptions<Societate_de_ValoriContext> options)
            : base(options)
        {
        }

        public DbSet<Societate_de_Valori.Models.SubiectDeDrept> SubiectDeDrept { get; set; }

        public DbSet<Societate_de_Valori.Models.Platforma> Platforma { get; set; }

        public DbSet<Societate_de_Valori.Models.Valuta> Valuta { get; set; }

        public DbSet<Societate_de_Valori.Models.Investitor> Investitor { get; set; }

        public DbSet<Societate_de_Valori.Models.Firma> Firma { get; set; }

        public DbSet<Societate_de_Valori.Models.Tranzactie> Tranzactie { get; set; }

        public DbSet<Societate_de_Valori.Models.TipTranzactie> TipTranzactie { get; set; }
    }
}
