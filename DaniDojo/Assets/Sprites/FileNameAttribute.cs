using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class FileNameAttribute : Attribute
    {
        public string FileName { get; }
        public FileNameAttribute(string fileName) => FileName = fileName;
    }
}
