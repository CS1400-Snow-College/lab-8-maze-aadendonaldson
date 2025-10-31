// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO;
using System.Security.AccessControl;
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
        break;
    }
    else if (pressedKey == ConsoleKey.DownArrow)
    {
        Console.CursorTop++;
        break;
    }
    else if (pressedKey == ConsoleKey.LeftArrow)
    {
        Console.CursorLeft--;
        break;
    }
    else if (pressedKey == ConsoleKey.RightArrow)
    {
        Console.CursorLeft++;
        break;
    }
    else if (pressedKey == ConsoleKey.Escape)
    {
        break;
    }
    else
    {
        break;
    }
}
while (true);

