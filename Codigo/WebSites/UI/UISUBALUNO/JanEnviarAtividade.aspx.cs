using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UISUBALUNO_JanEnviarAtividade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void enviaAtv(object sender, EventArgs e)
    {
        // Recupera dados do HTML
        String atividade = Request.Form["atividade"];
        String categoria = Request.Form["categoria"];
        String arquivo = Request.Form["arquivo"];
        String creditos = Request.Form["creditos"];
        String data = Request.Form["data"];
        CtrlEnvioAtv ctrl = new CtrlEnvioAtv();
        String result = ctrl.sendWSEnvioAtv(atividade, categoria, arquivo, creditos, data);
        // Cria HTML Dinâmico

        dados dados = new dados(result);
        Session["dados"] = dados;
        Response.Redirect("JanEnviarAtividadeRetorno.aspx");

    }
}