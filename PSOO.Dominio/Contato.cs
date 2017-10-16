using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOO.Dominio
{
    class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Usuario Usuario { get; }
        public byte[] Foto { get; set; }
        public int Numero { get; set; }
    }
}
