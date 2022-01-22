using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Societate_de_Valori.Models
{
    public class Firma
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar litere si cifre, maxim = 30, minim = 3"), Required]
        public string Nume { get; set; }
        [RegularExpression(@"^[0-9''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar cifre, maxim = 30, minim = 3"), Required]
        public int NumarAngajati { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar litere si cifre, maxim = 30, minim = 3"), Required]
        public string NumeActiune { get; set; }
        public string Tara { get; set; }
    }
}
