//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATC.CLN.CDP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARQUIVO
    {
        public int codArquivo { get; set; }
        public string observacao { get; set; }
        public Nullable<int> creditoAtividade { get; set; }
        public string arquivoDocumento { get; set; }
        public string dtRealizada { get; set; }
        public string matricula { get; set; }
        public string aprovado { get; set; }
        public Nullable<int> codAtividade { get; set; }

        public bool validaCredito()
        {
            if (creditoAtividade <= 10) return true;
            return false;
        }
    }
}