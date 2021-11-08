using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    public class GerenciadorBonificacao
    {
        private double _totalBeneficios;
        public void Registrar(Funcionario funcionario)
        {
            _totalBeneficios += funcionario.GetBonificacao();

        }
        
        public double GetTotalBeneficios() 
        {
            return _totalBeneficios;
        }
    }
}
