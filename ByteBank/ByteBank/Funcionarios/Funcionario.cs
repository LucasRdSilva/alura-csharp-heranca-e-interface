#region ChangeLog

// 10-03-2022 - Implementação Inicial

// 10-03-2022 - Tornando o método GetBonificacao virtual

// 11-03-2022 - Trabalhando com construtores e e modificador de visibilidade

// 11-03-2022 - Trabalhando com classe abstrata

// 21-03-2022 - Trabalhando com métodos abstratos

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {

        #region Propriedades

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }

        public string CPF { get; private set; }

        public double Salario { get; protected set; }

        #endregion

        #region Construtores

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando um Funcionário.");

            CPF = cpf;
            Salario = salario;
            
            TotalDeFuncionarios++;
        }

        #endregion

        #region Métodos

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        #endregion

    }
}
