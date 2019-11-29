using System;

/// <summary>
/// Descripción breve de SmartphoneBean
/// </summary>
[Serializable]
public class SmartphoneBean
{
    public string Marca { get; set; }
    public string Sistema { get; set; }
    public float Tamanio { get; set; }
    public bool Liberado { get; set; }

    public SmartphoneBean()
    {
        Marca = "Samgung";
        Sistema = "Android";
        Tamanio = 20.5F;
        Liberado = true;
    }

    public SmartphoneBean(string marca, string sistema, float tamanio, bool liberado)
    {
        Marca = marca;
        Sistema = sistema;
        Tamanio = tamanio;
        Liberado = liberado;
    }

    public override string ToString()
    {
        return $"Smarphone = [ Marca= {Marca}, Sistema= {Sistema} , Tamanio= {Tamanio}, Liberado= {Liberado} ]";
    }

}