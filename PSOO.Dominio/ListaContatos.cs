using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOO.Dominio
{
    class ListaContatos
    {
        public int Id { get; set; }
        //no diagrama id de ListaContatos é string, mas em todas outras classes ele é id
        public ICollection<Perfil> Perfis { get; set; }
        public void buscaLocalizacao(Contato contato) { }
        public void bloquearContato(Contato contato) { }
        public void addContato(Contato contato) { }
        //no diagrama tá addContatoContato, é assim mesmo?
    }
}
