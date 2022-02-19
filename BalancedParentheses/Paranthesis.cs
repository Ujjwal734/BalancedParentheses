using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    public class Paranthesis
    {
        public BalancedParenth stack = new BalancedParenth();
        public string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";

        public void CheckBalanced()
        {
            char[] array = expression.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(')
                {
                    stack.Push(array[i]);
                }
                if (array[i] == ')')
                {
                    if (stack.top.Equals('('))
                    {
                        stack.Pop();
                    }
                }

            }

            if (stack.IsEmpty().Equals(0))
            {
                System.Console.WriteLine("Expression is Balanced");
            }
            else
            {
                System.Console.WriteLine("Expression is not balanced");
            }

        }
    }
}
