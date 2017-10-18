using System;
using System.Collections.Generic;

namespace PSOO.Dominio
{
    public class ListaContatos
    {
        public int Id { get; set; }
        public ICollection<Perfil> Perfis { get; set; }

        public void buscaLocalizacao(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void bloquearContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void addContato(Contato contato)
        {
            throw new NotImplementedException();
        }
    }
}
