using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    public class FolderAttribute : Attribute
    {
        public string FolderName { get; }
        public FolderAttribute(string folderName) => FolderName = folderName;
    }
}
