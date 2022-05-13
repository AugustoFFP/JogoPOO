using Jogo.src;
using System;

class Program
{
    static void Main(string[] args)
    {

        Knight Arus = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
         
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));

    }
}

