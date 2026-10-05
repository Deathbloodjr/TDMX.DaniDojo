using DaniDojo.Assets;
using DaniDojo.Assets.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DaniDojo.DaniCourseSelect.Assets
{
    internal static class CourseSelectAssets
    {
        public static GameObject CreateDoor(GameObject parent, bool isLeftDoor)
        {
            string name = isLeftDoor ? "LeftDoor" : "RightDoor";
            GameObject door = AssetUtility.CreateImageChild(parent, name, DaniSprites.CourseSelect.Intro.Files.Cover.GetPath());
            if (isLeftDoor)
            {
                door.transform.localScale = new Vector2(door.transform.localScale.x * -1, door.transform.localScale.y);
            }
            return door;
        }
    }
}
