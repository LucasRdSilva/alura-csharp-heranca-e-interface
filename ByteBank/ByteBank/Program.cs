#region ChangeLog

// 10-03-2022 - Implementação Inicial

// 10-03-2022 - Construtores e objetos alterados para atender as alterações de Herança e Polimorfismo

// 11-03-2022 - Adaptando após implementações nos construores e e modificador de visibilidade

// 11-03-2022 - Trabalhando com classe abstrata e organizando código.

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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor lucas = new Desenvolvedor("400.616.202-42");
            lucas.Nome = "Lucas";

            gerenciadorBonificacao.Registrar(lucas);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
