// See https://aka.ms/new-console-template for more information
using AbstractAndInterface;

//Console.WriteLine("Hello, World!");

var autoMobile = new AutoMobile("汽車");
Console.WriteLine($"{autoMobile.Name}{autoMobile.Run()}");
Console.WriteLine($"{autoMobile.Name}{autoMobile.Navigation()}");
Console.WriteLine();


var bicycle = new Bicycle("腳踏車");
Console.WriteLine($"{bicycle.Name}{bicycle.Run()}");
Console.WriteLine($"{bicycle.Name}{bicycle.Navigation()}");
Console.WriteLine();

MotorCycle motorCycle = new MotorCycle("摩托車");
Console.WriteLine($"{motorCycle.Name}{motorCycle.Run()}");
Console.WriteLine($"{motorCycle.Name}{motorCycle.Navigation()}");
Console.WriteLine();

Console.ReadLine();

