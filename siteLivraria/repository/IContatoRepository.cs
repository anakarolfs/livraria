using siteLivraria.Models;

namespace siteLivraria.repository
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> buscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
