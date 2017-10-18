using Ninject;
using PSOO.Servico.IServico;
using PSOO.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PSOO.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        //Injeção de dependência
        [Inject]
        public IUsuarioServico usuarioServico { private get; set; }

        [Inject]
        public IPerfilServico perfilServico { private get; set; }
        

        public HttpResponseMessage Get(int id)
        {
            var user = usuarioServico.BuscaUsuario(id);
            
            return new UsuarioModel(user).RetornoOK();
        }
        


            //+ UsuarioController(user : UsuarioServico) : void
            //+ setNovoContato(usuario : UsuarioModel, perfis : List<Perfil>) : void
            //+ AtualizaPerfil(perfils : List<Perfil>) : void
    }
}
