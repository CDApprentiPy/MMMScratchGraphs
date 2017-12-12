using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    public class SLNode
    {
        public int val;
        public SLNode next;

        public SLNode(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
}
