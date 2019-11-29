using System.Collections.Generic;

/// <summary>
/// Descripción breve de Veterinario
/// </summary>
public class Telefonia
{

    private List<SmartphoneBean> smartphones;

    private static Telefonia instance;

    private Persistencia daoSmartphone;
    private Telefonia(string path)
    {
        daoSmartphone = Persistencia.getInstancia(path);
        smartphones = daoSmartphone.load();
    }

    public static Telefonia getInstance(string path)
    {
        if (instance == null)
        {
            instance = new Telefonia(path);
        }
        return instance;
    }

    public void agregarSmartphone(SmartphoneBean smartphone)
    {
        smartphones.Add(smartphone);
    }

    public SmartphoneBean obtenerIndice(int indice)
    {
        return smartphones[indice];
    }

    public List<SmartphoneBean> obtenerTodo()
    {
        return smartphones;
    }

    public int sizeSmartphones()
    {
        return smartphones.Count;
    }

    public void save()
    {
        daoSmartphone.save(smartphones);
    }
}