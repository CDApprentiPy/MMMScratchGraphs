using System;
using Xunit;

namespace ScratchGraphs
{
    public class NodeTest
    {
        [Fact]
        public void NodeCanBeInstantiated()
        {
            ScratchGraphing.BaseNode<int> newbie = new ScratchGraphing.BaseNode<int>(5);
            Assert.Equal(5, newbie.val);
        }

        [Fact]
        public void NodeCanHoldAString()
        {
            ScratchGraphing.BaseNode<string> newbie = new ScratchGraphing.BaseNode<string>("thing");
            Assert.Equal("thing", newbie.val);
        }
    }
}