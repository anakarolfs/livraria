using siteLivraria.Models;

namespace siteLivraria.Helper
{
    public interface Isessao
    {
        void CriarSessaoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoUsuario();
        
    }
}
