#region ChangeLog

// 10-03-2022 - Implementação Inicial

// 10-03-2022 - Construtores e objetos alterados para atender as alterações de Herança e Polimorfismo

#endregion

using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
