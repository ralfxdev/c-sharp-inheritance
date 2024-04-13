using c_sharp_inheritance.ChildClass;

Nintendo nintendo = new Nintendo();
nintendo.brand = "Switch";
nintendo.yearLaunch = 2019;
nintendo.isPortable = true;
Console.WriteLine(nintendo.ShowDetailsNintendo());

PlayStation playStation = new PlayStation();
playStation.brand = "PlayStation 5";
playStation.yearLaunch = 2020;
playStation.driveModel = "Blu-Ray";
Console.WriteLine(playStation.ShowDetailsPlayStation());

Xbox xbox = new Xbox();
xbox.brand = "Xbox Series X";
xbox.yearLaunch = 2020;
xbox.edition = "Halo Infinite";
Console.WriteLine(xbox.ShowDetailsXbox());

SegaDreamCast segaDreamCast = new SegaDreamCast();
segaDreamCast.brand = "Sega DreamCast";
segaDreamCast.yearLaunch = 1999;
segaDreamCast.games = new string[] { "Sonic Adventure", "Resident Evil 2", "Marvel vs. Capcom" };
Console.WriteLine(segaDreamCast.ShowDetailsSegaDreamCast());