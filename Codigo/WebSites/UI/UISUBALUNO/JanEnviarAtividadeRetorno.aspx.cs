using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UISUBALUNO_JanEnviarAtividadeRetorno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                dados dados = (dados)Session["dados"];
                TextBox1.Text = dados.result;
                
            }
            catch
            {
                // Manipular erro caso não exista nada em Session["dados"].
            }
        }
    }
}