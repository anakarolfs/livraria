using siteLivraria.Enums;
using System.ComponentModel.DataAnnotations;

namespace siteLivraria.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Digite o Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Escolha o Perfil")]
        public PerfilEnum? perfil { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string senha { get; set; }
        public DateTime dataCadastro { get; set; }  
        public DateTime? dataAtualizacao { get; set; }
    }
}
