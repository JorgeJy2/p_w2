using System;
using System.Collections.Generic;

public partial class consultar : System.Web.UI.Page
{
    private Telefonia telefonia;

    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath(".") + "/smarthones_data.txt";
        telefonia = Telefonia.getInstance(path);

        List<SmartphoneBean> smartphones = telefonia.obtenerTodo();
        divCenter.InnerHtml += "<ul>";
        foreach (SmartphoneBean smartphone in smartphones)
        {
            divCenter.InnerHtml += "<li>" + smartphone.ToString()+ "</li>";
        }
        divCenter.InnerHtml += "</ul>";
    }
}