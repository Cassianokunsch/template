using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATC.SUBALUNO.BLL.CDP;

namespace ATC.SUBALUNO.BLL.CGT
{
    class AplEnvioAtividade
    {
        public void efetuarEnvio(Aluno aluno, List<String> lstdocumento)
        {
            foreach(String documento in lstdocumento)
            {
                Categoria cat = aluno.selecionaCategoria();
                Atividade ati = aluno.selecionaAtividade(cat);
                DateTime data = new DateTime(); //seleciona a data
                Arquivo arq = new Arquivo();
                arq.Aluno = aluno;
                arq.Observacao = "";
                arq.CreditoAtividade = 5;
                arq.DtRealizada = data;
                arq.Atividade = ati;
                arq.Aprovado = "AGUARDANDO";
                arq.Arq = documento;// anexando o arquivo

                arq.enviarArquivo();//;
            }
            

        }
    }
}
