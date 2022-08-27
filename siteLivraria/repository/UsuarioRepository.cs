using siteLivraria.Data;
using siteLivraria.Models;

namespace siteLivraria.repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.id == id);
        }
        public List<UsuarioModel> buscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
           // throw new NotImplementedException();
           //gravar no banco de dados
           usuario.dataCadastro = DateTime.Now;
           _bancoContext.Usuarios.Add(usuario);
           _bancoContext.SaveChanges();

            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.id);

            if (usuarioDB == null) throw new System.Exception("Erro na Atualização, Id não encontrado");

            usuarioDB.nome = usuario.nome;
            usuarioDB.email = usuario.email;
            usuarioDB.login = usuario.login;
            usuarioDB.perfil = usuario.perfil;
            usuarioDB.dataAtualizacao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new System.Exception("Erro ao Apagar, Id não encontrado");

            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
