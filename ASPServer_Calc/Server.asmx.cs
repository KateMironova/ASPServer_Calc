using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASPServer_Calc
{
    /// <summary>
    /// Сводное описание для Server
    /// </summary>
    [WebService(Namespace = "http://localhost:50216/Server.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class Server : System.Web.Services.WebService
    {
        [WebMethod]
        public string Calculate(string a, string b, string op)
        {
            int res = 0;
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            switch (op)
            {
                case "plus":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }
            return res.ToString();
        }
    }
}
