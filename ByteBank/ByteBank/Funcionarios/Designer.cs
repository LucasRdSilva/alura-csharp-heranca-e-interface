#region ChangeLog

// 11-03-2022 - Implementação Inicial - Classes abstratas

#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public  class Designer: Funcionario
    {
        #region Propriedades



        #endregion

        #region Construtores

        public Designer(string cpf): base(3000, cpf)
        {

        }

        #endregion

        #region Métodos

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        #endregion


    }
}
