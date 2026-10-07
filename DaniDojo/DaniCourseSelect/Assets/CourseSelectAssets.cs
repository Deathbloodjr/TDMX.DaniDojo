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
        public static GameObject CreateDoor(GameObject parent, Vector2 position, bool isLeftDoor)
        {
            string name = isLeftDoor ? "LeftDoor" : "RightDoor";
            GameObject door = AssetUtility.CreateImage(parent, name, DaniSprites.CourseSelect.Intro.Files.Cover.GetPath(), position).gameObject;
            if (isLeftDoor)
            {
                AssetUtility.FlipHorizontal(door);
            }
            AssetUtility.SetImageColor(door, new Color(0.5f, 0.5f, 0.5f));
            return door;
        }

        public static GameObject CreateIntroText(GameObject parent, Vector2 position, int textIndex)
        {
            if (textIndex < 0 || textIndex >= 4)
            {
                return null;
            }

            string spritePath = textIndex switch
            {
                0 => DaniSprites.CourseSelect.Intro.Text.TopLeft.GetPath(),
                1 => DaniSprites.CourseSelect.Intro.Text.TopRight.GetPath(), 
                2 => DaniSprites.CourseSelect.Intro.Text.BotLeft.GetPath(),
                3 => DaniSprites.CourseSelect.Intro.Text.BotRight.GetPath(),
            };
            string objName = textIndex switch
            {
                0 => "TopLeft",
                1 => "TopRight",
                2 => "BotLeft",
                3 => "BotRight",
            };

            GameObject textImage = AssetUtility.CreateImage(parent, objName, spritePath, position).gameObject;
            AssetUtility.SetAlpha(textImage, 0f);
            AssetUtility.SetUniformScale(textImage, 1.75f);
            return textImage;
        }

        public static GameObject CreateBackground(GameObject parent)
        {
            GameObject background = AssetUtility.CreateImage(parent, "Background", DaniSprites.CourseSelect.Intro.Files.BG.GetPath()).gameObject;
            AssetUtility.SetImageColor(background, new Color(0.5f, 0.5f, 0.5f));
            return background;
        }
    }
}
