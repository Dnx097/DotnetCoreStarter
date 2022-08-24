// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("escriba un Nombre");
int algo;
string some = Console.ReadLine();

bool somee = int.TryParse(some, out algo);

List<string> li = new List<string>();

li.Add(some);

foreach(string item in li){
    System.Console.WriteLine(item);
}

Console.WriteLine("Hello, World!");
