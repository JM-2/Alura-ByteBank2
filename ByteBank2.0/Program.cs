using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar 2 funcionarios de cargos diferentes
            Auxiliar jose = new Auxiliar(2000, "236554125-10");
            jose.Nome = "Jose da Silva";

            Console.WriteLine("Nome: " + jose.Nome);
            Console.WriteLine("Salario: " + jose.Salario);


            Designer pedro = new Designer("362114523-20");
            pedro.Nome = "Pedro Silva";

            Console.WriteLine("Nome: " + pedro.Nome);
            Console.WriteLine("Salario: " + pedro.Salario);

            //Aumentar o salario deles
            jose.AumentarSalario();
            pedro.AumentarSalario();
            
            Console.WriteLine("Salario de " + jose.Nome + " aumentado : " + jose.Salario);
            Console.WriteLine("Salario de " + pedro.Nome + " umentado: " + pedro.Salario);

            //bonificar eles
            Console.WriteLine("Salario de " + jose.Nome + "  : " + jose.GetBonificacao());
            Console.WriteLine("Salario de " + pedro.Nome + " Bonificação: " + pedro.GetBonificacao());

            //mostra quantia de bonificaçoes
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            gerenciadorBonificacao.Registrar(jose);
            gerenciadorBonificacao.Registrar(pedro);
            Console.WriteLine("Quantia de bonificaçoes: " + gerenciadorBonificacao.GetTotalBeneficios());

            //Mostra quantidade de Funcionarios que foram registrados.
            Console.WriteLine("Quantidade de funcionarios cadastrados: " + Funcionario.TotalFuncionarios);

            Console.ReadLine();

        }

    }
}
