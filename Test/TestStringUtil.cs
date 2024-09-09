namespace Jason.Test;

using Jason.Util;

[TestClass]
public class TestStringUtil
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