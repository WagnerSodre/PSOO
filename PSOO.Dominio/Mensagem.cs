using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOO.Dominio
{
    class Mensagem
    {
        public int Id { get; set; }
        public Usuario Iniciador { get; set; }
        public ICollection<Contato> listaContatos { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataHora { get; set; }
        public string Texto { get; set; }
        public void addContatoMensagem(Contato Contato) { }
        public void enviarMensagem() { }
        public void enviarTexto(string texto) { }
    }
}
