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

        public Categoria selecionaCategoria()
        {
            ///////////////////CRIA CATEGORIAS/////////////////////
            List<Categoria> lstCategoria = new List<Categoria>();
            Categoria cat1 = new Categoria();
            cat1.TipoCat = "Ensino1";
            Categoria cat2 = new Categoria();
            cat2.TipoCat = "Ensino2";
            Categoria cat3 = new Categoria();
            cat3.TipoCat = "Ensino3";
            lstCategoria.Add(cat1);
            lstCategoria.Add(cat2);
            lstCategoria.Add(cat3);
            ///////////////////////////////////////////////////////
            Console.WriteLine("Escolha a categoria:");
            Console.WriteLine("\n");

            for (int i = 0; i < lstCategoria.Count; i++)
            {
                Console.WriteLine(i + " - " + lstCategoria[i].TipoCat);
                Console.WriteLine("\n");
            }
            String opcao = Console.ReadLine();
            if (opcao == "0")
            {
                return lstCategoria[0];
            }
            else if(opcao == "1")
            {
                return lstCategoria[1];
            }
            else if (opcao == "2")
            {
                return lstCategoria[2];
            }

            return null;
        }

        public Atividade selecionaAtividade(Categoria cat)
        {
            //////////VAI VIRAR UMA FUNCAO DENTRO DE LISTAR/////
            List<Atividade> lstAtividade = new List<Atividade>();
            Atividade atividade1 = new Atividade();
            atividade1.AnoRegistro = new DateTime();
            atividade1.Ativo = true;
            atividade1.TipoAtividade = "Extra curricular";
            atividade1.UniAvali = "zzz";
            atividade1.ValorCredito = 50;

            Atividade atividade2 = new Atividade();
            atividade2.AnoRegistro = new DateTime();
            atividade2.Ativo = true;
            atividade2.TipoAtividade = "Palestra";
            atividade2.UniAvali = "yyy";
            atividade2.ValorCredito = 100;

            lstAtividade.Add(atividade1);
            lstAtividade.Add(atividade2);

            ///////////////////////////////////////////////////////
            Console.WriteLine("Escolha a atividade:");
            Console.WriteLine("\n");

            for (int i = 0; i < lstAtividade.Count; i++)
            {
                Console.WriteLine(i + " - " + lstAtividade[i].TipoAtividade);
                Console.WriteLine("\n");
            }
            String opcao = Console.ReadLine();
            if (opcao == "0")
            {
                lstAtividade[0].Cat = cat;
                return lstAtividade[0];
            }
            else if (opcao == "1")
            {
                lstAtividade[1].Cat = cat;
                return lstAtividade[1];
            }

            return null;
        }
    }
}
