using ConsoleLibrary;

namespace MyConsoleTools
{
    internal class Program
    {
        private static void Main( string[] args ) {
            //const string dirPath = @"F:\Downloads\";
            const string dirPath = @"F:\Pictures\Background\anime"; // 8334 files - 536 ms

            ListDirectory listDir = new ListDirectory(dirPath);
        }
    }
}