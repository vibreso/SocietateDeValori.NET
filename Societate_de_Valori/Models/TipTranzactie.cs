using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Societate_de_Valori.Models
{
    public class TipTranzactie
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar litere, maxim = 30, minim = 3"), Required]
        public string Nume { get; set; }
    }
}
