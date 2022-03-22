#region ChangeLog

// 11-03-2022 - Implementação Inicial - Classes abstratas
// 21-03-2022 - Alterando para herança de classe autenticável

#endregion

using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        #region Propriedades



        #endregion

        #region Construtores

        public GerenteDeConta(string cpf): base(4000, cpf)
        {

        }

        #endregion

        #region Métodos

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        #endregion

    }
}
