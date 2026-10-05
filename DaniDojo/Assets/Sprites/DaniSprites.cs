using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    internal class DaniSprites
    {
        public static string RootFolder = Plugin.Instance.ConfigDaniDojoAssetLocation.Value;

        [Folder("Common")]
        public static class Common
        {
            [Folder("CourseIcon")]
            public static class CourseIcon
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                    [FileName("Sousaku.png")]
                    Sousaku,
                    [FileName("Gaiden.png")]
                    Gaiden,
                }
            }
        }

        [Folder("CourseSelect")]
        public static class CourseSelect
        {

        }

        [Folder("Enso")]
        public static class Enso
        {

        }

        [Folder("Results")]
        public static class Results
        {

        }

        [Folder("SongSelect")]
        public static class SongSelect
        {

        }
    }

    
}
