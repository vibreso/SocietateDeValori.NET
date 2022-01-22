using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Societate_de_Valori.Models
{
    public class Tranzactie
    {
        public int ID { get; set; }
        [Display(Name = "Investitor")]
        public int InvestitorID { get; set; }
        [Display(Name = "Investitor")]
        public Investitor Investitor { get; set; }
        public int PlatformaID { get; set; }
        [Display(Name = "Platforma")]
        public Platforma Platforma { get; set; }
        [Display(Name = "Firma")]
        public int FirmaID { get; set; }
        [Display(Name = "Firma")]
        public Firma Firma { get; set; }
        [RegularExpression(@"^[0-9''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar cifre, maxim = 30, minim = 3"), Required]
        public int Suma { get; set; }
        [Display(Name = "Valuta")]
        public int ValutaID { get; set; }
        [Display(Name = "Valuta")]
        public Valuta Valuta { get; set; }
        [Display(Name = "Tip Tranzactie")]
        public int TipTranzactieID {get; set; }
        [Display(Name = "Tip Tranzactie")]
        public TipTranzactie TipTranzactie { get; set; }
    }
}
