using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOO.Dominio
{
    public class Usuario : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Localizacao { get; set; }
        public byte[] Foto { get; set; } //alterar diagrama de img para blob
        public string Status { get; set; }
        public int Numero { get; set; }

        //Crie lista assim
        public ICollection<Contato> Contatos { get; set; }
        public ICollection<Perfil> Perfis { get; set; }
    }
}
