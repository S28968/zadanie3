// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Hello, World!");

Container container = new Container(1, 1, 1, 1, 1);
Console.WriteLine(container.GetMass());

ContainerLiquid ContainerLiquid = new ContainerLiquid(1,1,1,1,1,true);
ContainerLiquid.RelaySN();
ContainerLiquid ContainerLiquid2 = new ContainerLiquid(1,1,1,1,1,true);
ContainerLiquid2.RelaySN();
ContainerGas ContainerGas = new ContainerGas(1,1,1,1,1,1);
ContainerGas.RelaySN();