using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScratchTest
{
    [TestClass]
    public class DLNodeTest
    {

        [TestMethod]
        public void TestNodeVal()
        {
            ScratchGraphing.DLNode newNode = new ScratchGraphing.DLNode(5);
            var val = newNode.val;
            Assert.AreEqual(5, val);
        }
    }
}
