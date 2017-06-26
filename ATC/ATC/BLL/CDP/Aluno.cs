using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC.SUBALUNO.BLL.CDP
{
    class Aluno
    {
        private DateTime dtConclusao;
        private int creditos;
        private Arquivo arquivo;

        public Aluno()
        {
        }

        public DateTime DtConclusao { get => dtConclusao; set => dtConclusao = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        internal Arquivo Arquivo { get => arquivo; set => arquivo = value; }
    }
}
