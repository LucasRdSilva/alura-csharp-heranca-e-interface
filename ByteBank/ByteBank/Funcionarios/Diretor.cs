#region ChangeLog

// 10-03-2021 - Implementação Inicial

// 10-03-2021 - Aplicando Herança e Polimorfismo

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        #region Propriedades

        #endregion

        #region Métodos

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        #endregion

    }
}
