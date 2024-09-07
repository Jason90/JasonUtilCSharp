namespace Jason.Util;

using Newtonsoft.Json;

public class SerializeUtil
{
    /// <summary>
    /// Serialize a object to Json
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static String ToJson<T>(T obj)
    {

        string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
        return json;
    }

}
