#region ChangeLog

// 10-03-2022 - Implementação Inicial

#endregion

using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public  class GerenciadorBonificacao
    {
        #region Propriedades

        private double _totalBonificacao;

        #endregion

        #region Métodos

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

        #endregion


    }
}
