using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste1
{
    public class Colaborador : Estudo
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _matricula;
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
    }
}