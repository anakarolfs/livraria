using siteLivraria.Models;

namespace siteLivraria.repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> buscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
