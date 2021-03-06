using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        private string _CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario , string cpf)
        {
            Salario = salario;
            _CPF = cpf;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios
        {
            get; private set;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
