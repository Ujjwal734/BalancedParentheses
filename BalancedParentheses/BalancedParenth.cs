using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    public class BalancedParenth
    {
        public Node top;
        public BalancedParenth()
        {
            top = null;
        }

        public void Push(int data)
            {
                Node node = new Node(data);
                if (top == null)
                {
                    node.next = null;
                }
                else
                {
                    node.next = top;
                }
                top = node;

            }

            public void Peek()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty!");
                    return;
                }
            }

            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("stack is empty");
                    return;
                }
                top = top.next;
            }

            public void Display()
            {
                Node temp = top;
                while (temp != null)
                {
                    System.Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
            public int IsEmpty()
            {
                while (top != null)
                {
                    Peek();
                    Pop();
                }
                return 0;
            }
    }
}
