using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    public class DLNode
    {
        public int val;
        public DLNode next;
        public DLNode last;

        public DLNode(int val)
        {
            this.val = val;
            next = null;
            last = null;
        }
    }
}
