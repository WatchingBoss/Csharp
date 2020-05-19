using System;
using System.IO;

namespace ConsoleLibrary
{
    internal class DirItem
    {
        protected string _path, _name;
        protected string _createdTime, _lastWriteTime;
        protected bool _isDir;

        public string Name => _name;
        public string CreatedTime => _createdTime;
        public string LastWrite => _lastWriteTime;
        public bool IsDir => _isDir;

        public DirItem( string path, string name, DateTime create, DateTime write, bool isDir ) {
            _path = path;
            _name = name;
            _createdTime = $"{create:g}";
            _lastWriteTime = $"{write}";
            _isDir = isDir;
        }
    }
}