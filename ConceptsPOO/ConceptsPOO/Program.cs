
using ConceptsPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}