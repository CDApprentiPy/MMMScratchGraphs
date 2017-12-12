using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScratchTest
{
    [TestClass]
    public class CLNodeTest
    {

        [TestMethod]
        public void Test1()
        {
            string prompt = "0000";
            ScratchGraphing.CLL circ = new ScratchGraphing.CLL();
            circ.StringToCLL(prompt);
            Assert.AreEqual(4, circ.Count);
        }
    }
}
