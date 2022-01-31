using Cars;
Car toyota = new PassangerCar("Toyota Prius", 2008, 15000, 1200, Color.Green);

Car renault = new Bus("Renault Traffic", 2000, 9700, 2600, Color.White);

Car renault2 = new WarMashine("Tank", 2000, 9700, 2600, Color.White);

toyota.AddDistance(1000);
renault.AddDistance(3000.1);
toyota.AddDistance(10_000);
renault2.AddDistance(40_000);

Console.WriteLine("Is this car need to service? " + toyota.IsReadyToService());

renault.AddDistance(10_000);
Console.WriteLine("Is this car need to service? " + renault.IsReadyToService());
Console.WriteLine("Is Tank ready to service? " + renault2.IsReadyToService());

Console.WriteLine(toyota);
Console.WriteLine(renault);
Console.WriteLine(renault2 == (renault));