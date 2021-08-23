using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Colaborador col = new Colaborador();

            Console.Write("Você concluiu o ensino básico? Sim ou Não ");
            var resposta = Console.ReadLine();
            if (resposta == "Sim" || resposta == "sim")
            {

                Console.Write("Informe o seu nome: ");
                col.Nome = Console.ReadLine();
                Console.Write("Informe a sua matrícula: ");
                col.Matricula = Console.ReadLine();

                col.EnsinoBasico = true;

                Console.Write("Você concluiu o ensino superior? Sim ou Não ");
                var retorno = Console.ReadLine();
                if (retorno == "Sim" || retorno == "sim")
                {
                    col.EnsinoSuperior = true;

                }
            }
            else if (resposta == "Não" || resposta == "não")
            {
                Console.Write("Informe o seu nome: ");
                col.Nome = Console.ReadLine();
                Console.Write("Informe a sua matrícula: ");
                col.Matricula = Console.ReadLine();
            }

            Console.Write("Nome: " + col.Nome);
            Console.Write("Matricula: " + col.Matricula);
            if (col.EnsinoBasico)
            {
                Console.Write("Escola: " + col.Escola);
                if (col.EnsinoSuperior)
                {
                    Console.Write("Universidade: " + col.Universidade);
                }
            }

            Console.ReadKey();
        }
    }
}
