using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    internal class DaniSpriteValidator
    {
        /// <summary>
        /// Finds all enums nested inside DaniSprites, resolves their paths, and checks if files exist on disk.
        /// </summary>
        public static void ValidateAllSprites()
        {
            // Get all nested enums inside the DaniSprites static class hierarchy
            List<Type> allSpriteEnums = GetAllNestedEnums(typeof(DaniSprites));

            int totalChecked = 0;
            int missingCount = 0;

            ModLogger.Log($"[DaniDojo Validator] Starting asset audit across {allSpriteEnums.Count} enum categories...", LogType.Debug);

            foreach (Type enumType in allSpriteEnums)
            {
                // Retrieve all enum values (e.g., Header.Starting, Header.Tenth, etc.)
                Array enumValues = Enum.GetValues(enumType);

                foreach (Enum enumValue in enumValues)
                {
                    totalChecked++;

                    // Resolve the relative path using SpritePathResolver extension
                    string fullPath = enumValue.GetPath();

                    // Check if file exists on disk
                    if (!File.Exists(fullPath))
                    {
                        missingCount++;
                        ModLogger.Log($"[DaniDojo Validator] MISSING FILE: {enumValue.GetType().Name}.{enumValue} -> '{fullPath}'", LogType.Warning);
                    }
                }
            }

            if (missingCount == 0)
            {
                ModLogger.Log($"[DaniDojo Validator] All {totalChecked} sprite assets verified successfully! No missing files found.", LogType.Debug);
            }
            else
            {
                ModLogger.Log($"[DaniDojo Validator] ⚠Audit completed with errors! {missingCount} out of {totalChecked} sprite files are missing on disk.", LogType.Warning);
            }
        }

        /// <summary>
        /// Recursively searches a container class to extract all nested Enum types.
        /// </summary>
        private static List<Type> GetAllNestedEnums(Type containerType)
        {
            List<Type> enumTypes = new();

            // Find any nested types directly inside this container
            Type[] nestedTypes = containerType.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach (Type type in nestedTypes)
            {
                if (type.IsEnum)
                {
                    enumTypes.Add(type);
                }
                else if (type.IsClass)
                {
                    // Recursively climb down through nested static classes (CourseInfo, Background, Borders, etc.)
                    enumTypes.AddRange(GetAllNestedEnums(type));
                }
            }

            return enumTypes;
        }
    }
}
