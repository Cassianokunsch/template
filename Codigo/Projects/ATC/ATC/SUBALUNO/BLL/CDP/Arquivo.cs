using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC.SUBALUNO.BLL.CDP
{
    class Arquivo
    {
        private String observacao;
        private String arq;
        private int creditoAtividade;
        private DateTime dtRealizada;
        private String aprovado;
        private Aluno aluno;
        private Atividade atividade;

        public Arquivo()
        {
        }

        public void enviarArquivo()
        {
            Console.WriteLine("Arquivo salvo com sucesso");
        }

        public string Observacao { get => observacao; set => observacao = value; }
        public int CreditoAtividade { get => creditoAtividade; set => creditoAtividade = value; }
        public DateTime DtRealizada { get => dtRealizada; set => dtRealizada = value; }
        public string Arq { get => arq; set => arq = value; }
        public string Aprovado { get => aprovado; set => aprovado = value; }
        internal Aluno Aluno { get => aluno; set => aluno = value; }
        internal Atividade Atividade { get => atividade; set => atividade = value; }
    }
}
