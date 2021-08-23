using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste1
{
    public class Estudo
    {
        private bool _ensinoBasico;
        public bool EnsinoBasico
        {
            get { return _ensinoBasico; }
            set
            {
                if (value == true)
                {
                    AdicionaEscola();
                }
                _ensinoBasico = value;
            }
        }

        private bool _ensinoSuperior;
        public bool EnsinoSuperior
        {
            get { return _ensinoSuperior; }
            set
            {
                if (value == true)
                {
                    AdicionaUniversidade();
                }
                _ensinoSuperior = value;
            }
        }

        private string _escola;
        public string Escola
        {
            get { return _escola; }
            set { _escola = value; }
        }

        private string _universidade;
        public string Universidade
        {
            get { return _universidade; }
            set { _universidade = value; }
        }

        public void AdicionaEscola()
        {
            Console.Write("Informe o nome da escola: ");
            Escola = Console.ReadLine();
        }

        public void AdicionaUniversidade()
        {
            Console.Write("Informe o nome da universidade: ");
            Universidade = Console.ReadLine(); ;
        }

    }
}