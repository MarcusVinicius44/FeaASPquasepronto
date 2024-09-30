using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class cadastro
    {
        public int idCadastre { get; set; }
        public string NomeCad { get; set; }
        public string EmailCad { get; set; }
        public string SenhaCad { get; set;}
    }
}
