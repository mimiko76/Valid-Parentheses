using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    internal class Program
    {

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false;
                }
            }

            return stack.Count == 0; 
        }

        public static void Main()
        {
            string input = "()";
            bool isValid = IsValid(input); // Проверяем допустимость введенной строки

            if (isValid)
            {
                Console.WriteLine("Введенная строка допустима.");
            }
            else
            {
                Console.WriteLine("Введенная строка не допустима.");
            }
        }
    }
}
