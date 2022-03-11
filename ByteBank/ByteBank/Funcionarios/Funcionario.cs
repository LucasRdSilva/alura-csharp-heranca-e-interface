#region ChangeLog

// 10-03-2022 - Implementação Inicial

// 10-03-2022 - Tornando o método GetBonificacao virtual

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {

        #region Propriedades

        public string Nome { get; set; }

        public string CPF { get; set; }

        public double Salario { get; set; }

        #endregion

        #region Métodos

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        #endregion

    }
}
