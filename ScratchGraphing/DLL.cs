using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    class DLL
    {
        private DLNode head;
        private DLNode tail;
        public int Count;

        //Create
        public DLL()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        //Read pt 1
        public Boolean Contains(int val)
        {
            DLNode curr = head;
            while(curr != null)
            {
                if(curr.val == val)
                {
                    return true;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return false;
        }
        //Read pt 2
        public DLNode GetHead()
        {
            return head;
        }
        //Read pt 3
        public DLNode GetTail()
        {
            return tail;
        }
        //Update
        public void Add(int val)
        {
            if(head == null)
            {
                head = new DLNode(val);
                tail = new DLNode(val);
            }
            else
            {
                DLNode curr = tail;
                curr.next = new DLNode(val);
                tail = curr.next;
            }
            Count++;
        }
        //Delete
        public DLNode Remove(int val)
        {
            DLNode result = null;
            if(!Contains(val))
            {
                return null;
            }
            else if(head.val == val && head == tail)
            {
                result = head;
                head = null;
                tail = null;
            }
            else if(head.val == val)
            {
                result = head;
                head = head.next;
            }
            else
            {
                DLNode curr = head;
                while(curr.next != null)
                {
                    if(curr.next.val == val)
                    {
                        result = curr.next;
                        if(tail == curr.next)
                        {
                            tail = curr;
                        }
                        curr.next = curr.next.next;
                    }
                    curr = curr.next;
                }
            }
            Count--;
            return result;
        }
    }
}
