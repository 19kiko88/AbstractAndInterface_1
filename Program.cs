// See https://aka.ms/new-console-template for more information
using AbstractAndInterface;

//Console.WriteLine("Hello, World!");

var autoMobile = new AutoMobile();
Console.WriteLine(autoMobile.Run());
Console.WriteLine(autoMobile.Navigation());

var bicycle = new Bicycle();
Console.WriteLine(bicycle.Run());
Console.WriteLine(bicycle.Navigation());

MotorCycle motorCycle = new MotorCycle();
Console.WriteLine(motorCycle.Run());
Console.WriteLine(motorCycle.Navigation());

Console.ReadLine();

