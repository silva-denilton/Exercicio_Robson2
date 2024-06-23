using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson2
{
    internal class Fisico : Cliente
    {
        public string CPF { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Nome: {Nome} CPF: {CPF}");
           
        }
    }
}
