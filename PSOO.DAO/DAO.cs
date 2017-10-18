using PSOO.Dominio;
using PSOO.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PSOO.DAO
{
    public abstract class DAO<T> : IDAO<T> where T : class, IEntidade
    {
        protected IConexao Conexao {  get; private set; }

        public DAO(IConexao Conexao)
        {
            this.Conexao = Conexao;
            Dados.Gerar();
        }

        public T BuscarPorId(int id)
        {
            if (typeof(T) == typeof(Usuario))
                return (T)Convert.ChangeType(Dados.listaUsuario.Where(x => x.Id == id).FirstOrDefault(), typeof(T));
            else if(typeof(T) == typeof(Contato))
                return (T)Convert.ChangeType(Dados.listaContato.Where(x => x.Id == id).FirstOrDefault(), typeof(T));
            else if (typeof(T) == typeof(Mensagem))
                return (T)Convert.ChangeType(Dados.listaMensagem.Where(x => x.Id == id).FirstOrDefault(), typeof(T));
            else if (typeof(T) == typeof(Perfil))
                return (T)Convert.ChangeType(Dados.listaPerfil.Where(x => x.Id == id).FirstOrDefault(), typeof(T));

            return null;
        }

        public void Deletar(T entidade)
        {
            if (typeof(T) == typeof(Usuario))
            {
                var user = (Usuario)Convert.ChangeType(entidade, typeof(Usuario));

                Dados.listaUsuario.Remove(user);
            }
            else if (typeof(T) == typeof(Contato))
            {
                var user = (Usuario)Convert.ChangeType(entidade, typeof(Usuario));

                Dados.listaUsuario.Remove(user);
            }
            else if (typeof(T) == typeof(Mensagem))
            {
                var user = (Usuario)Convert.ChangeType(entidade, typeof(Usuario));

                Dados.listaUsuario.Remove(user);
            }
            else if (typeof(T) == typeof(Perfil))
            {
                var user = (Usuario)Convert.ChangeType(entidade, typeof(Usuario));

                Dados.listaUsuario.Remove(user);
            }
        }

        public List<T> Listar()
        {
            if (typeof(T) == typeof(Usuario))
                return (List<T>)Convert.ChangeType(Dados.listaUsuario, typeof(List<T>));
            else if (typeof(T) == typeof(Contato))
                return (List<T>)Convert.ChangeType(Dados.listaContato, typeof(List<T>));
            else if (typeof(T) == typeof(Mensagem))
                return (List<T>)Convert.ChangeType(Dados.listaMensagem, typeof(List<T>));
            else if (typeof(T) == typeof(Perfil))
                return (List<T>)Convert.ChangeType(Dados.listaPerfil, typeof(List<T>));

            return null;
        }

        public void Salvar(T entidade)
        {
            if (typeof(T) == typeof(Usuario))
                Dados.listaUsuario.Add((Usuario)Convert.ChangeType(entidade, typeof(Usuario)));
            else if (typeof(T) == typeof(Contato))
                Dados.listaContato.Add((Contato)Convert.ChangeType(entidade, typeof(Usuario)));
            else if (typeof(T) == typeof(Mensagem))
                Dados.listaMensagem.Add((Mensagem)Convert.ChangeType(entidade, typeof(Usuario)));
            else if (typeof(T) == typeof(Perfil))
                Dados.listaPerfil.Add((Perfil)Convert.ChangeType(entidade, typeof(Perfil)));
        }
    }
}
