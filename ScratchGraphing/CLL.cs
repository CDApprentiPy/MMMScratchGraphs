using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    public class CLL
    {
        private DLNode head;
        private DLNode tail;
        public int Count;

        public CLL()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public void Add(int val)
        {
            if(head == null)
            {
                head = new DLNode(val);
                head.next = head;
                head.last = head;
                tail = head;
            }
            else
            {
                tail.next = new DLNode(val);
                tail.next.next = head;
                tail.next.last = tail;
                tail = tail.next;                
            }
        }
        public CLL AddChar(string val)
        {
            if (head == null)
            {
                head = new DLNode(Convert.ToInt32(val));
                head.next = head;
                head.last = head;
                tail = head;
            }
            else
            {
                tail.next = new DLNode(Convert.ToInt32(val));
                tail.next.next = head;
                tail.next.last = tail;
                tail = tail.next;
            }
            return this;
        }
        public CLL StringToCLL(string val)
        {
            foreach(char item in val)
            {
                if (head == null)
                {
                    head = new DLNode(Convert.ToInt32(item));
                    head.next = head;
                    head.last = head;
                    tail = head;
                }
                else
                {
                    tail.next = new DLNode(Convert.ToInt32(item));
                    tail.next.next = head;
                    tail.next.last = tail;
                    tail = tail.next;
                }
            }
            return this;
        }
        public int Captcha1()
        {
            int result = 0;
            int lCount = 0;
            DLNode curr = head;
            while(lCount < Count)
            {
                if(curr.val == curr.last.val)
                {
                    result += curr.val;
                }
                lCount++;
                curr = curr.next;
            }
            return result;
        }
        public DLNode GetHead()
        {
            return head;
        }
    }
}
