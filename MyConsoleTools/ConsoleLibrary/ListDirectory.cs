using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleLibrary
{
    public class ListDirectory
    {
        private readonly string directory;
        private List<DirItem> listItems = new List<DirItem>();

        public ListDirectory( string dir ) {
            directory = dir;
            getInfo( );
            printDirectory( );
        }

        private void getInfo( ) {
            var allSubDirs = Directory.GetDirectories(directory);
            foreach ( string subDir in allSubDirs )
                listItems.Add( new DirItem(subDir, true) );

            var allFiles = Directory.GetFiles(directory);
            foreach ( string file in allFiles )
                listItems.Add( new DirItem( file, false ) );
        }

        private void printDirectory( ) {
            uint fileNumber = 1;

            foreach ( DirItem item in listItems )
                print( item, fileNumber++ );
        }

        private void print( DirItem item, uint number ) {
            Console.WriteLine( $"----- {number++} -----------------------" );
            Console.WriteLine( $"Created: { item.CreatedTime}" );
            Console.WriteLine( $"Last updated: { item.LastWrite}" );
            string mode = item.IsDir ? "d -> " : "f -> ";
            Console.WriteLine( $"{mode}{item.Name}");
        }
    }
}