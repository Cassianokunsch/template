using System;
using DAL;
using ATC.CLN.CDP;

namespace ATC.SUBALUNO.BLL.CGT
{
    public class AplEnvioAtividade
    {
        private BDATCEntities context;
        private GenericDALImpl<ARQUIVO> db;

        public AplEnvioAtividade()
        {
            context = DbConection.getContext();
            db = new GenericDALImpl<ARQUIVO>();
            
        }

        public string enviarAtividade(RootObject rt)
        {
            if (rt.Arquivo.validaCredito()){
                db.insert(rt.Arquivo);
                return "Atividade enviada com sucesso!";
            }
            else
            {
                return "Falha ao enviar a atividade, tente novamente";
            }            
        }
    }
}
