using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_FibonacciPilha
{
    internal class StackFibonacci
    {
        Integer top;
        public StackFibonacci()
        {
            this.top = null;
        }
        bool IsEmpty()
        {
            return this.top == null;
        }
        public void Push(Integer aux)
        {
            if (IsEmpty())
            {
                this.top = aux;
            }
            else
            {
                aux.setPrevious(top);
                top = aux;
            }
        }
        public void Print()
        {
            Integer aux = this.top;
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty, nothing to print!");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getPrevious();
                } while (aux != null);
            }
        }
    }
}
        
