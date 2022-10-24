using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public GerenteDeContas(string cpf, double salario) : base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
