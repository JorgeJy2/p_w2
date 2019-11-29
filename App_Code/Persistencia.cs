using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// Descripción breve de Persistencia
/// </summary>
public class Persistencia
{
    private static String NAME_FILE = "";

    private static Persistencia instancia;

    private Persistencia() { }

    public static Persistencia getInstancia(string path)
    {
        NAME_FILE = path;

        if (instancia == null)
            instancia = new Persistencia();
        return instancia;
    }


    public List<SmartphoneBean> load()
    {

        List<SmartphoneBean> smartphones = new List<SmartphoneBean>();

        IFormatter formatter = null;
        Stream stream = null;
        try
        {
            Console.WriteLine(  "llamanda...");
            formatter = new BinaryFormatter();
            stream = new FileStream(@NAME_FILE, FileMode.OpenOrCreate, FileAccess.Read);
            Object obj = formatter.Deserialize(stream);
            while (obj != null)
            {
                SmartphoneBean smartphoneObj = (SmartphoneBean)obj;
                smartphones.Add(smartphoneObj);
                obj = formatter.Deserialize(stream);
            }
        }
        catch (SerializationException ex)
        {
            Console.WriteLine("Error");
        }
        stream.Close();
        return smartphones;
    }

    public bool save(List<SmartphoneBean> list)
    {
        IFormatter formatter = null;
        Stream stream = null;
        try
        {
            formatter = new BinaryFormatter();
            stream = new FileStream(@NAME_FILE, FileMode.OpenOrCreate, FileAccess.Write);
            foreach (SmartphoneBean smartphone in list)
            {
                formatter.Serialize(stream, smartphone);
            }
        }
        catch
        {
            Console.WriteLine("Error");
            return false;
        }
        stream.Close();
        return true;
    }
}