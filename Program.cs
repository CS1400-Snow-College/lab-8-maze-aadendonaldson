// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Hello, World!");
//Aaden Donaldson, 10/29/2025, Maze
Console.WriteLine("Welcome to the maze!. You will be given a starting point to then move to the ending point, which will be marked by a '*'. You will use the arrows to get there. Good Luck!");
string maze = "maze.txt";
string[] mapRows = File.ReadAllLines(maze);
Console.Clear();
foreach (string row in mapRows)
{
    Console.WriteLine(row);
}
Console.SetCursorPosition(0, 0);

do
{
    var pressedKey = Console.ReadKey(true).Key;
    if (pressedKey == ConsoleKey.UpArrow)
    {
        Console.CursorTop--;


    }
    else if (pressedKey == ConsoleKey.DownArrow)
    {
        Console.CursorTop++;

    }
    else if (pressedKey == ConsoleKey.LeftArrow)
    {
        Console.CursorLeft--;

    }
    else if (pressedKey == ConsoleKey.RightArrow)
    {
        Console.CursorLeft++;

    }
    else if (pressedKey == ConsoleKey.Escape)
    {
        break;
    }
    TryMove(Console.CursorTop, Console.CursorLeft, mapRows);


}
while (true);

static void TryMove (int proposedTop, int proposedLeft, string[] mazeRows)
{

    
    if (proposedTop > 0 && proposedTop < mazeRows.Length)
    {
        if (proposedLeft > 0 && proposedLeft < mazeRows.Length)
        {
            Console.CursorTop = proposedTop;
            Console.CursorLeft = proposedTop;
        }
    }
}

