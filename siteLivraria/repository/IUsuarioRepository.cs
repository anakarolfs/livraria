using siteLivraria.Models;

namespace siteLivraria.repository
{
    public interface IUsuarioRepository
    {
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> buscarTodos();
        UsuarioModel Adicionar(UsuarioModel contato);
        UsuarioModel Atualizar(UsuarioModel contato);
        bool Apagar(int id);
    }
}
