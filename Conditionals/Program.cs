﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var number = 10;

////////////************IF*****/////////////
if (number == 10)
{
    Console.WriteLine("Number is 10");

}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

Console.WriteLine(number == 10 ? "Number is10" : "Number is not 10");
Console.ReadLine();

////////////************Switch*****/////////////
switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is not 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;

}

