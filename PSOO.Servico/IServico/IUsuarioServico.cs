using PSOO.Dominio;

namespace PSOO.Servico.IServico
{
    public interface IUsuarioServico
    {
        void InsereUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        bool VerificarLoginSenha(string login, string senha);
        Usuario BuscaUsuario(int idUsuario);
    }
}
