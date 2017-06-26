using ATC;
using ATC.SUBALUNO.BLL.CGT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WSATC
{
    /// <summary>
    /// Summary description for ws
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ws : System.Web.Services.WebService
    {

        [WebMethod]
        public string enviaAtividade(String strJson)
        {
            String result;
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            RootObject objret = new RootObject();
            AplEnvioAtividade AplEAT = new AplEnvioAtividade();
            objret = jsSerializer.Deserialize<RootObject>(strJson);

            result = AplEAT.enviarAtividade(objret);

            return result;
        }
    }
}
