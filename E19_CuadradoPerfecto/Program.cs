using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E19_CuadradoPerfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros cuadrados perfectos");
            for (int i = -2; i <= 400; i++)
                if(EsCuadradoPerfecto2(i))
                    Console.WriteLine("[{0}] ", i);
            int n = 3;
            Console.WriteLine("{0} {1} cuadrado perfecto", n, EsCuadradoPerfecto(n)? "es" : "no es" );
            Console.ReadLine();
        }
        public static bool EsCuadradoPerfecto(int n)
        {
            if (n > 0)            
                for(int i = 1; i<=n; i++)                
                    if (i * i == n)
                        return true;           
            return false;
        }

        public static bool EsCuadradoPerfecto2(int n)
        {
            return (n >= 0 && Math.Pow( (int)Math.Sqrt(n), 2) == n)? true : false;
        }
    }
}
