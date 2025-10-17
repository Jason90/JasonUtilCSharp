using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jason.Algorithm;


namespace Test
{
    [TestClass]
    public class TestSequence
    {
        [TestMethod]
        public void TC_2000()
        {
            Assert.IsTrue(Sequence.Fib(6)==8);
        }
    }
}