using System;
using Projeto.src.Entities;

namespace Projeto
{
    class Program
    {

        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizzard jennica = new Wizzard("Jennica", 23, "White Wizzard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack());
        }
    }
    
}