using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Societate_de_Valori.Models
{
    public class Investitor
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar litere, maxim = 20, minim = 3"), Required]
        public string Nume { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$", ErrorMessage = "Va rog introduceti doar litere, maxim = 20, minim = 3"), Required]
        public string Prenume { get; set; }
        [Display(Name = "Subiect de Drept")]
        public int SubiectDeDreptID { get; set; }
        [Display(Name = "Subiect de Drept")]
        public SubiectDeDrept SubiectDeDrept { get; set; }

    }
}
