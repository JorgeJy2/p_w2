using System;
using System.Text.RegularExpressions;

public partial class AddPet : System.Web.UI.Page
{
    private Telefonia telefonia;

    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath(".") + "/smarthones_data.txt";
        telefonia = Telefonia.getInstance(path);
    }

    protected void btnAgregarClick(object sender, EventArgs e)
    {
   
            string sistema = ddl_sistema.SelectedItem.Text;
            string marca = txb_marca.Text;
            if (marca.Length > 0)
            {
                Regex exp = new Regex("^[a-zA-Z ]*$");
                if (exp.IsMatch(marca))
                {

                    string tamanio = txb_tamanio.Text.Trim();
                    if (tamanio.Length > 0)
                    {
                        try
                        {
                            float tamaniofloat = float.Parse(tamanio);
                            bool liberado = cbx_liberado.Checked;
                            SmartphoneBean smartphone = new SmartphoneBean();

                            smartphone.Sistema = ddl_sistema.SelectedItem.Text;
                            smartphone.Marca = txb_marca.Text;
                            smartphone.Tamanio = tamaniofloat;
                            smartphone.Liberado = cbx_liberado.Checked;

                            telefonia.agregarSmartphone(smartphone);
                            telefonia.save();
                            clearData();
                            showMessage("Smartphone agregada.");
                        }
                        catch { showMessage("Datos incorrectos para tamaño"); }
                    } else showMessage("Ingresa datos para tamaño"); 
                } else showMessage("Solo se aceptan letras en marca");
            } else showMessage("Ingresa datos para marca"); 
        }

    private void showMessage(string message) {
        divAlert.InnerHtml = message;
    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        clearData();
    }

    private void clearData() {
        ddl_sistema.SelectedIndex = 0;
        txb_marca.Text = "";
        txb_tamanio.Text = "";
        cbx_liberado.Checked = false;
    }
}