// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO;
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

