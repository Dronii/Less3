using System;

namespace Less3
{
    class Program
    {
        static void Main(string[] args)
        {

            //L1.1
            bool a, b, c;
            a = true;
            b = false;
            c = false;
            Console.WriteLine($"{a}\t{b}\t{c}");

            if (a | b == true)
            Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (a&b == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (b|c==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            //L 1.2
            bool x, y, z;
            x = false;
            y = true;
            z = false;
            if(x|z==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if(x&y==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if(x|z==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            //L 1.3

            if(!a&b==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if(a|!b==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if(a&b|c==true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }
    }
}
