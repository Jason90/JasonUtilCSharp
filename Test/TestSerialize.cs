namespace Jason.Test;

using Jason.Util;

[TestClass]
public class TestSerialize
{
    [TestMethod]
    public void ObjToJson()
    {
        //Hi: Anonymous types 匿名类型
        var account = new 
        {
            Name = "Jason Zhu",
            Email = "zhhot@hotmail.com",
            DOB = new DateTime(1980, 8, 13, 0, 0, 0, DateTimeKind.Utc),
        };

        string jsonActual = SerializeUtil.ToJson(account);
        Console.WriteLine(jsonActual);

        string jsonExpect=File.ReadAllText("data/account.json");
        Assert.AreEqual(jsonExpect.Replace(" ",""), jsonActual.Replace(" ",""));
    }
}