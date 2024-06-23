using Exercicio_Robson2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Robson2
{
    internal class Cadastro
    {
        public List<Fisico> _Fisico = new List<Fisico>();
        public List<Juridico> _Juridico = new List<Juridico>();

        public void SalvarCliente()
        {
            int opcaocliente = int.Parse(Console.ReadLine());
            if (opcaocliente == 1)
            {
                Console.WriteLine("Digite a quantidade de clientes que deseja cadastrar:");
                int qtdcliente = int.Parse(Console.ReadLine());
                Fisico _fis;
                for (int i = 0; i < qtdcliente; i++)
                {
                    _fis = new Fisico();
                    Console.WriteLine("Digite o nome do cliente:");
                    _fis.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do clinte");
                    _fis.CPF = Console.ReadLine();
                    _Fisico.Add(_fis);
                }
            }
            else if (opcaocliente == 2)
            {
                Console.WriteLine("Digite a quantidade de clientes que deseja cadastrar:");
                int qtdcliente = int.Parse(Console.ReadLine());
                Juridico _juri;
                for (int i = 0; i < qtdcliente; i++)
                {
                    _juri = new Juridico();
                    Console.WriteLine("Digite o nome Juridico:");
                    _juri.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o CNPJ:");
                    _juri.CNPJ = Console.ReadLine();
                    Console.WriteLine("Digite a incrição estadual");
                    _juri.InscricaoEstadual = Console.ReadLine();
                    _Juridico.Add(_juri);
                }
            }
        }
        public void ImprimirCliente()
        {
            int opcaoCliente = int.Parse(Console.ReadLine());
            if (opcaoCliente == 1)
            {
                foreach (var fisio in _Fisico)
                {
                    fisio.Imprimir();
                }

            }
            else if (opcaoCliente == 2)
            {
                foreach (var juridico in _Juridico)
                {
                    juridico.Imprimir();
                }
            }
        }
        public void GerarMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("(1) para cadastrar cliente:");
                Console.WriteLine("(2) para verificar cliente:");
                Console.WriteLine("(0) para fechar:");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Deseja cadastrar:");
                    Console.WriteLine("(1) para pessoa fisica:");
                    Console.WriteLine("(2) para juridica");
                    SalvarCliente();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Deseja verificar:");
                    Console.WriteLine("(1) para pessoa fisica:");
                    Console.WriteLine("(2) para juridica");
                    ImprimirCliente();
                }
            }
            while (opcao != 0);
        }
    }
}

