#region ChangeLog

// 10-03-2022 - Implementação Inicial

// 10-03-2022 - Aplicando Herança e Polimorfismo

// 11-03-2022 - Trabalhando com construtores e modificador de visibilidade

// 11-03-2022 - Trabalhando com classe abstrata

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
    public class Diretor : Autenticavel
    {

        #region Propriedades


        #endregion

        #region Construtores

        public Diretor(string cpf): base(5000, cpf)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        #endregion

        #region Métodos

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }


        #endregion

    }
}
