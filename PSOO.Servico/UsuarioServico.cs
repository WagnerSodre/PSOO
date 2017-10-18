using PSOO.Dominio;
using PSOO.IDAO;
using PSOO.Servico.IServico;
using System;

namespace PSOO.Servico
{
    public sealed class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioDao dao;

        public UsuarioServico(IUsuarioDao dao)
        {
            this.dao = dao;
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscaUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void InsereUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool VerificarLoginSenha(string login, string senha)
        {
            var user = dao.BuscarPorLogin(login);

            return user.Senha == senha;
        }
    }
}
