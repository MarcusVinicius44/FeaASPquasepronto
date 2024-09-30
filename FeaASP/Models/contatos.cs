using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class contato
    {
        [Key]
        public int idContato { get; set; }
        public string nomeContato { get; set; }
        public string emailContato { get; set; }
        public string telefoneContato { get; set; }
        public string mensagem { get; set; }
    }
}
