// See https://aka.ms/new-console-template for more information
using Practical_3;


Console.WriteLine("-----------------------------Inheritance-Example---------------------------------");
Inheritance_Example.Team obj = new Inheritance_Example.Team();
obj.PrintInfo();


Console.WriteLine("-----------------------------PolyMorphism-Example---------------------------------");

Polymorphism_example.bird mybird = new Polymorphism_example.bird();
Polymorphism_example.Duck myduck = new Polymorphism_example.Duck();

mybird.Voice();
myduck.Voice();

Console.WriteLine("-----------------------------Abstraction-Example---------------------------------");

Abstraction_Example.laptop laptop = new Abstraction_Example.laptop();
laptop.LaptopDetails();


// cannot access motherboard information outside the class because of private access
