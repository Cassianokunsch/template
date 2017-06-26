using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATC.SUBALUNO.BLL.CDP;
using DAL;
using ATC.DAL;

namespace ATC.SUBALUNO.BLL.CGT
{
    public class AplEnvioAtividade
    {
        private BDATCEntities context;
        private GenericDALImpl<ARQUIVO> db;

        public AplEnvioAtividade()
        {
            context = DbConection.getContext();
            
        }

        public string enviarAtividade(RootObject rt)
        {
            if (Convert.ToInt32(rt.Arquivo.creditoAtividade) <= 10)
            {
                db.insert(rt.Arquivo);
                db.saveChanges();
                return "Atividade enviada com sucesso!";
            }

            return "Falha ao enviar a atividade, tente novamente";
        }
    }
}
