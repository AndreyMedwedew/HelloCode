// See https://aka.ms/new-console-template for more information
Console.Write("Write your Name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("WoW, It s Masha!!!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}