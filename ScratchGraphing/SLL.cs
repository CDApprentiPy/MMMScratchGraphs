using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchGraphing
{
    //SLL CRUD
    public class SLL
    {
        private SLNode head;
        public int Count;

        //Create
        public SLL()
        {
            head = null;
            Count = 0;
        }
        //Read part 1
        public Boolean Contains(int val)
        {
            SLNode curr = head;
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
        //Update
        public void Add(int val)
        {
            if(head == null)
            {
                head = new SLNode(val);
            }
            else
            {
                SLNode curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = new SLNode(val);
            }
            Count++;
        }
        //Delete
        public SLNode Remove(int val)
        {
            if(!Contains(val))
            {
                Console.WriteLine("Value Not Found!");
            }
            else
            {
                if(head.val == val)
                {
                    SLNode temp = head;
                    head = head.next;
                    Count--;
                    return temp;
                }
                else
                {
                    SLNode curr = head;
                    while(curr.next != null)
                    {
                        if(curr.next.val == val)
                        {
                            SLNode temp = curr.next;
                            curr.next = curr.next.next;
                            Count--;
                            return temp;
                        }
                        else
                        {
                            curr = curr.next;
                        }
                    }
                }
            }
            return null;
        }
    }
}
