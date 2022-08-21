using siteLivraria.Data;
using siteLivraria.Models;

namespace siteLivraria.repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<ContatoModel> buscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           // throw new NotImplementedException();
           //gravar no banco de dados
           _bancoContext.Contatos.Add(contato);
           _bancoContext.SaveChanges();

            return contato;
        }

    }
}
