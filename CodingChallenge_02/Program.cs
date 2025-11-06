using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public static class Program
    {
        public static int a = 0;
        public static int b = 1;
        public static int c;
        public static void Main(string[] args)
        {
            Console.WriteLine(a);
            Console.WriteLine(b); 
            FibonacciOf(9);
        }


        public static void FibonacciOf(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }


    
}



/*PseudoCode
 * int a = 0;
int b = 1;

FibonacciOf(int n) {

    for (int i = 1; i <= n; i++) {
        c = a + b;
        a = b;
        b = c;
//c is being declared but is never being printed
    }
}

// Main Function
main() {
    print(a);
    print(b);
    FibonacciOf(10);
//As the challengue requires to print eleven numbers of the sequence, and we have already printed 2, we must only print 9 numbers from the function 
}
 * 
 * 
    */