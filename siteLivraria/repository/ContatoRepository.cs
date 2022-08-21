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
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.id == id);
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

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.id);

            if (contatoDB == null) throw new System.Exception("Erro na Atualização, Id não encontrado");

            contatoDB.nome = contato.nome;
            contatoDB.email = contato.email;
            contatoDB.telefone = contato.telefone;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Erro ao Apagar, Id não encontrado");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
