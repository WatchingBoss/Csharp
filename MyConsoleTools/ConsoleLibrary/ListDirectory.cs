using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleLibrary
{
    public class ListDirectory
    {
        private readonly string directory;
        private List<DirItem> listItems = new List<DirItem>();
        private List<AnotherDirItem> anotherListItems = new List<AnotherDirItem>();

        public ListDirectory( string dir ) {
            directory = dir;
            getInfo( );
            printDirectory( );
        }

        private void getInfo( ) {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);

            foreach ( FileInfo file in dirInfo.GetFiles( ) )
                anotherListItems.Add(new AnotherDirItem(file.FullName, file.Name, file.CreationTime, file.LastWriteTime, false));

            foreach ( DirectoryInfo file in dirInfo.GetDirectories( ) )
                anotherListItems.Add(new AnotherDirItem(file.FullName, file.Name, file.CreationTime, file.LastWriteTime, false));

            //foreach ( string subDir in Directory.GetDirectories( directory ) )
            //    listItems.Add( new DirItem(subDir, true) );

            //foreach ( string file in Directory.GetFiles( directory ) )
            //    listItems.Add( new DirItem( file, false ) );
        }

        private void printDirectory( ) {
            uint fileNumber = 1;

            //foreach ( DirItem item in listItems )
            //    print(item, fileNumber++);

            foreach ( AnotherDirItem item in anotherListItems )
                anotherPrint(item, fileNumber++);

            Console.WriteLine($"Files: {fileNumber}");
        }

        private void anotherPrint( AnotherDirItem item, uint number ) {
            Console.WriteLine($"----- {number} -----------------------");
            Console.WriteLine($"Created: { item.CreatedTime}");
            Console.WriteLine($"Last updated: { item.LastWrite}");
            string mode = item.IsDir ? "d -> " : "f -> ";
            Console.WriteLine($"{mode}{item.Name}");
        }

        private void print( DirItem item, uint number ) {
            Console.WriteLine($"----- {number} -----------------------");
            Console.WriteLine($"Created: { item.CreatedTime}");
            Console.WriteLine($"Last updated: { item.LastWrite}");
            string mode = item.IsDir ? "d -> " : "f -> ";
            Console.WriteLine($"{mode}{item.Name}");
        }
    }
}