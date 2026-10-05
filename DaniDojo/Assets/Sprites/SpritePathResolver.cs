using DaniDojo.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    public static class SpritePathResolver
    {
        private static readonly ConcurrentDictionary<Enum, string> _pathCache = new();

        public static string GetPath<TEnum>(this TEnum spriteEnum) where TEnum : struct, Enum
        {
            return _pathCache.GetOrAdd(spriteEnum, BuildPathForEnum);
        }

        public static string GetPath(this Enum spriteEnum)
        {
            return _pathCache.GetOrAdd(spriteEnum, BuildPathForEnum);
        }

        private static string BuildPathForEnum(Enum spriteEnum)
        {
            Type enumType = spriteEnum.GetType();
            Type declaringType = enumType.DeclaringType;

            if (declaringType == null)
            {
                ModLogger.Log($"Enum '{enumType.Name}' is not inside a static class!", LogType.Warning);
                return string.Empty;
            }

            List<string> folderSegments = new();

            // Check if the Enum ITSELF has a [Folder("...")] attribute
            var enumFolderAttr = enumType.GetCustomAttribute<FolderAttribute>();
            if (enumFolderAttr != null)
            {
                folderSegments.Add(enumFolderAttr.FolderName);
            }

            // Walk up through parent static classes to gather their [Folder] attributes
            Type current = declaringType;
            while (current != null)
            {
                var folderAttr = current.GetCustomAttribute<FolderAttribute>();
                if (folderAttr != null)
                {
                    folderSegments.Add(folderAttr.FolderName);
                }

                current = current.DeclaringType;
            }

            folderSegments.Reverse();
            folderSegments.Insert(0, DaniSprites.RootFolder);

            string fullFolderPath = Path.Combine(folderSegments.ToArray());

            // Resolve File Name
            string fileName = GetFileNameFromEnum(enumType, spriteEnum);

            return Path.Combine(fullFolderPath, fileName);
        }

        private static string GetFileNameFromEnum(Type enumType, Enum value)
        {
            string name = value.ToString();
            MemberInfo[] member = enumType.GetMember(name);

            if (member.Length > 0)
            {
                var fileAttr = member[0].GetCustomAttribute<FileNameAttribute>();
                if (fileAttr != null) return fileAttr.FileName;
            }

            return $"{name}.png";
        }
    }
}
