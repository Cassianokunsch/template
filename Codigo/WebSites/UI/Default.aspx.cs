using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Meubotao_ServerClick(object sender, EventArgs e)
    {
        // Recupera dados do HTML
        String atividade = Request.Form["atividade"];
        String categoria = Request.Form["categoria"];
        String arquivo = Request.Form["arquivo"];
        String creditos = Request.Form["creditos"];

        CtrlEnvioAtv ctrl = new CtrlEnvioAtv();
        String result = ctrl.sendWSEnvioAtv(atividade, categoria, arquivo, creditos);
        // Cria HTML Dinâmico
        //Response.Write(result);
       
    }
}