using System;
using System.Collections;

namespace BracketMatcher;

public class ProgramBracketMatcher
{
    public static string BracketMatcher(string str)
    {

        Stack stack = new Stack();

        foreach( var c in str)
        {
            if (c == '(')
            {
                stack.Push(c);
            }

            if (c == ')')
            {
                if (stack.Count > 0 && (char)stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
        }

        if(stack.Count != 0)
        {
            return 0.ToString();
        }

        return 1.ToString();
    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(BracketMatcher(Console.ReadLine()));

    }
}