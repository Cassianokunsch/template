using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CtrlEnvioAtv
/// </summary>
public class CtrlEnvioAtv
{
    public CtrlEnvioAtv()
    {
    }

    public string sendWSEnvioAtv(String atividade, String categoria, String arquivo, String creditos, String data)
    {
        ServiceReferenceATC.wsSoapClient ws = new ServiceReferenceATC.wsSoapClient();

        if (trataEntrada(atividade, categoria, arquivo, creditos, data))
        { 
            return ws.enviaAtividade(montaStringJson(atividade, categoria, arquivo, creditos, data)); ;
        }
        else
        {
            return "Algum campo está preenchido errado, verifique!";
        }
    }

    public bool trataEntrada(String atividade, String categoria, String arquivo, String creditos, String data)
    {
        if (atividade != "" && categoria != "" && arquivo != "" && creditos != "" && data != "")
        {
            return true;
        }
        return false;
    }

    public string montaStringJson(String atividade, String categoria, String arquivo, String creditos, String data)
    {
        return "{ " +
            "'Arquivo': { " +
                "'arquivoDocumento':'" + arquivo.Replace("\\", "") + "'," +
                "'aprovado':'"+ "Em Análise"+"'," +
                "'observacao':''," +
                "'creditoAtividade':"+ creditos + "," +
                "'dtRealizada':'"+ data + "'," +
                "'matricula':'" +"2013bsi0109"+ "'," +
                "'codAtividade':" + atividade + "}" + 
            "}";
    }
}