using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleLibrary
{
    class DirItem
    {
        protected string _path, _name;
        protected DateTime _createdTime, _lastWriteTime;
        protected bool _isDir;

        public string Name => _name;
        public DateTime CreatedTime => _createdTime;
        public DateTime LastWrite => _lastWriteTime;
        public bool IsDir => _isDir;

        public DirItem( string path, bool isDir) {
            _path = path;
            _name = Path.GetFileName( _path );
            _createdTime = Directory.GetCreationTime( path );
            _lastWriteTime = Directory.GetLastWriteTime( path );
            _isDir = isDir;
        }
    }
}
