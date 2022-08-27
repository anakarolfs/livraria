using System.ComponentModel.DataAnnotations;

namespace siteLivraria.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string senha { get; set; }
    }
}
