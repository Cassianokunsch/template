using ATC.SUBALUNO.BLL.CDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC.CONTROLEATIVIDADE.BLL.CGT
{
    class AplAvaliaAtividade
    {
        public void avaliarAtividade(List<Arquivo> lstarquivos)
        {
            foreach (Arquivo arquivo in lstarquivos)
            {
                Console.WriteLine(arquivo.Arq);// abrindo arquivo kkk
                arquivo.Observacao = "Tudo certo";
                arquivo.Aprovado = "APROVADO";
                arquivo.CreditoAtividade = 5;

                Avaliador ava = new Avaliador();
                ava.enviarAvaliacao();
            }
            
        }
    }
}
