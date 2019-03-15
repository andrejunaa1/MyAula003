using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostas, perguntas;

            
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Qual sua questao?");
                perguntas = Console.ReadLine();

                switch (perguntas)
                {
                    case "Onde voce mora?":
                        respostas = "Portugal ";
                break;
                    case "voce esta fodido em lp?":
                        respostas = "Com Certeza ";
                break;
                    case "Porque fazes video jogos":
                        respostas = "Soy Lokito ";
                break;
                default:
                        respostas = "é analfabeto fdp? ";
                break;
                }
                Console.WriteLine(respostas);
            }
          
               
            }
            
        }
    }
