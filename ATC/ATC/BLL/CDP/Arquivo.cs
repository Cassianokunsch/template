using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC.SUBALUNO.BLL.CDP
{
    public class Arquivo
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

        public string Arq { get; set; }
        public string Aprovado { get; set; }
        public string Observacao { get; set; }
        public string CreditoAtividade { get; set; }
        public string DtRealizada { get; set; }

    }
}
