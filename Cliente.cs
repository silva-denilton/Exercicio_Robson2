using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson2
{
    public abstract class Cliente
    {
        public string Nome { get; set; }

        public abstract void Imprimir();
    }
}
