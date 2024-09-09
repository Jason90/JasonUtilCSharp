namespace Jason.Test;

using Jason.Util;

[TestClass]
public class UTStringUtil
{
    [TestMethod]
    public void ObjToJson()
    {
        String msg="Hello";
        Assert.IsTrue(msg.StartsWithUpper());

        msg="world";
        Assert.IsFalse(msg.StartsWithUpper());
    }
}