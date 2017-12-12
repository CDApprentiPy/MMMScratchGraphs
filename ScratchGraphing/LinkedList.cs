using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    public class LinkedList<dynamic>
    {
        private BaseNode<dynamic> head;
        public int Count;

        public LinkedList()
        {
            this.head = null;
            this.Count = 0;
        }
        public void add(dynamic thing)
        {
            
            if(Count == 0)
            {
                this.head = new BaseNode<dynamic>(thing);
            }
            else
            {
                BaseNode<dynamic> curr = this.head;
            }
        }

    }
}
