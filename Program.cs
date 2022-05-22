using System;
using source.src.Entities;

namespace dotnet
{
    class Program
    {
static void Main(string[] args)
{ 
    Knight arus = new Knight("Arus",21,"Knigth");
    Wizard wizard = new Wizard("Jennic",23," White Wizard");
    Ninja ninja = new Ninja("Wedee",22,"Ninja");
    BlackWizard blackwizard = new BlackWizard("Topapa",24," Black Wizard");
    Demon demon = new Demon("Demon",99," Demon");
    
    Console.WriteLine(arus.Attack(1));
    Console.WriteLine(wizard.Attack(6));
    Console.WriteLine(ninja.Attack(9));
    Console.WriteLine(blackwizard.Attack(2));
    Console.WriteLine(demon.Attack());
    Console.WriteLine("Demon Win HAGAHAGA!");
    
    }



    }
}

