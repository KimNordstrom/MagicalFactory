using System;
using MagicalFactoryV2;

var myWarehouse = new Warehouse();
var myFactory = new Factory();
bool done = false;
while (!done)
{
    //Console.Clear();
    myWarehouse.ListTruck();
    myWarehouse.ListInventory();
    Console.WriteLine("'Send' to send truck or 'Quit' to quit program.");
    Console.Write("Enter Material: ");
    var userInput = Console.ReadLine();
    if (userInput.ToLower() == "send")
    {
        Console.WriteLine("Sending...");
        myFactory.CreateProduct(myWarehouse.wTruck);
    } else if(userInput.ToLower() == "quit")
    {
        done = true;
    } else
    {
        myWarehouse.AddToTruck(userInput);
    }
}