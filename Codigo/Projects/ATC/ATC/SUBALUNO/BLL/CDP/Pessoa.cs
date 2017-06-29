using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC.SUBALUNO.BLL.CDP
{
    class Pessoa
    {
        private String nome;
        private String email;
        private bool permissoesADM;
        private String telefone;
        private int matricula;

        public Pessoa()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public bool PermissoesADM { get => permissoesADM; set => permissoesADM = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Matricula { get => matricula; set => matricula = value; }
    }
}
