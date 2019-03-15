using System;

namespace percorrestring
{
    class Program
    {
        static void Main(string[] args)
        {//declarar variaveis
            string s, cstring;
            char c;

            //pedir string o user
            Console.WriteLine("insira string:");
            s = Console.ReadLine();

            //pedir char ao user
            Console.WriteLine("insira o char:");
            cstring = Console.ReadLine();

            //converter o char(string) em char
            c = cstring[0];

            //imprimir string
            foreach (char cAtual in s) 
            {

                //caracter atual e diferente de c
                if (cAtual != c)
                {
                    Console.Write(cAtual);
                }
            }
            Console.WriteLine();
        }
    }
}
