using ConsoleLibrary;
using System;
using System.Text;

namespace MyConsoleTools
{
    internal class Program
    {
        private static void Main( string[] args ) {
            Console.OutputEncoding = Encoding.UTF8;

            //const string dirPath = @"F:\Downloads\";
            const string dirPath = @"F:\Pictures\Background\anime"; // 8334 files - 113 ms

            ListDirectory listDir = new ListDirectory(dirPath);
        }
    }
}