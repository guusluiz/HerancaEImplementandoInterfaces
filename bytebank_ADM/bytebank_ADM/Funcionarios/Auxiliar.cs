﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public Auxiliar(string cpf, double salario) : base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
