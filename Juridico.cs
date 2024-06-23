using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson2
{
    internal class Juridico : Cliente
    {
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        
        public override void Imprimir()
        {
            Console.WriteLine($"Cliente: {Nome}, CNPJ: {CNPJ} Inscrição Estadual: {InscricaoEstadual}");
        }

    }
}