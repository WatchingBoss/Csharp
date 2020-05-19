using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleLibrary
{
    public class ListDirectory
    {
        private readonly string directory;
        private List<DirItem> ListItems = new List<DirItem>();

        public ListDirectory( string dir ) {
            directory = dir;
            getInfo( );
            printDirectory( );
        }

        private void getInfo( ) {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);

            foreach ( DirectoryInfo file in dirInfo.GetDirectories( ) )
                ListItems.Add(new DirItem(file.FullName, file.Name, file.CreationTime, file.LastWriteTime, true));

            foreach ( FileInfo file in dirInfo.GetFiles( ) )
                ListItems.Add(new DirItem(file.FullName, file.Name, file.CreationTime, file.LastWriteTime, false));
        }

        private void printDirectory( ) {
            foreach ( DirItem item in ListItems )
                print(item);

            Console.WriteLine($"Files: {ListItems.Count}");
        }

        private void print( DirItem item) {
            string mode = item.IsDir ? "d -> " : "f -> ";

            Console.WriteLine( $"{mode}\t{item.LastWrite}\t{item.Name}" );
        }
    }
}