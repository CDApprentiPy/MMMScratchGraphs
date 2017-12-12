using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    public class BaseNode<dynamic>
    {
        public dynamic val;
        public BaseNode<dynamic> next;

        public BaseNode(dynamic thing){
            this.val = thing;
            this.next = null;
        }
    }
}
