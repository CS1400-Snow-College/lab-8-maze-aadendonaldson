// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
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
        TryMove(Console.CursorTop - 1, Console.CursorLeft, mapRows);
    }
    else if (pressedKey == ConsoleKey.DownArrow)
    {
        TryMove(Console.CursorTop + 1, Console.CursorLeft, mapRows);
    }
    else if (pressedKey == ConsoleKey.LeftArrow)
    {
        TryMove(Console.CursorTop, Console.CursorLeft - 1, mapRows);
    }
    else if (pressedKey == ConsoleKey.RightArrow)
    {
        TryMove(Console.CursorTop, Console.CursorLeft + 1 , mapRows);
    }
    else if (pressedKey == ConsoleKey.Escape)
    {
        break;
    }

    if (mapRows[Console.CursorTop][Console.CursorLeft] == '*')
    {
        Console.Clear();
        Console.WriteLine("Hooray, you win! Go Home!");
        break;
    }


}
while (true);

static void TryMove(int proposedTop, int proposedLeft, string[] mazeRows)
{
    if (proposedTop >= 0 && proposedTop < mazeRows.Length )
    {
        if (proposedLeft >= 0 && proposedLeft < mazeRows[proposedTop].Length)
        {
            if ( mazeRows[proposedTop][proposedLeft] != '#')
            {
                Console.CursorTop = proposedTop;
                Console.CursorLeft = proposedLeft;
            }
        }
    }
}
