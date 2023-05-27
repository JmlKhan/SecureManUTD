using nullCoalesing;

var security = new SecurityPassMaker();

var coach = new Coach();
coach.Title = "The Coach";

var result = security.GetDisplayName(new Manager());

Console.WriteLine(result);