using System.ComponentModel.DataAnnotations;

namespace siteLivraria.Models
{
    public class ContatoModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        [Phone(ErrorMessage = "Telefone Inválido")]
        public string telefone { get; set; }
    }
}
