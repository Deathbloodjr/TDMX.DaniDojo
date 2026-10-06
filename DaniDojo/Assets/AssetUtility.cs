using PlayFab.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DaniDojo.Assets
{
    internal class AssetUtility
    {
        static string _assetFilePath = string.Empty;
        static Dictionary<string, Sprite> LoadedSprites = new Dictionary<string, Sprite>();
        private static Sprite _fallbackSprite;
        private static Sprite FallbackSprite
        {
            get
            {
                if (_fallbackSprite == null)
                {
                    Texture2D tex = new Texture2D(1, 1, TextureFormat.ARGB32, false);
                    tex.SetPixel(0, 0, Color.clear);
                    tex.Apply();
                    _fallbackSprite = Sprite.Create(tex, new Rect(0, 0, 1, 1), Vector2.zero);
                }
                return _fallbackSprite;
            }
        }

        #region Path & Sprite Handling
        private static string GetAssetRootPath()
        {
            if (!string.IsNullOrEmpty(_assetFilePath))
                return _assetFilePath;

            string configPath = Plugin.Instance.ConfigDaniDojoAssetLocation.Value;
            _assetFilePath = configPath;

            if (Directory.Exists(configPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(configPath);
                string[] anchorFiles = { "README.txt", "danidojo.scene", "CustomGameModes.scene" };

                foreach (string anchor in anchorFiles)
                {
                    FileInfo[] files = dirInfo.GetFiles(anchor, SearchOption.AllDirectories);
                    if (files.Length > 0 && files[0].Directory != null)
                    {
                        _assetFilePath = files[0].Directory.FullName;
                        break;
                    }
                }
            }

            return _assetFilePath;
        }

        public static Sprite LoadSprite(string relativeOrAbsolutePath)
        {
            if (string.IsNullOrEmpty(relativeOrAbsolutePath))
                return FallbackSprite;

            if (LoadedSprites.TryGetValue(relativeOrAbsolutePath, out Sprite cachedSprite))
                return cachedSprite;

            string rootPath = GetAssetRootPath();
            string filePath = relativeOrAbsolutePath;

            if (!File.Exists(filePath) && !filePath.StartsWith(rootPath))
            {
                filePath = Path.Combine(rootPath, filePath);
            }

            if (!File.Exists(filePath) && !Path.HasExtension(filePath))
            {
                filePath += ".png";
            }

            if (File.Exists(filePath))
            {
                byte[] fileData = File.ReadAllBytes(filePath);
#if IL2CPP
                Texture2D tex = new Texture2D(2, 2, TextureFormat.ARGB32, 1, false, IntPtr.Zero);
                ImageConversion.LoadImage(tex, fileData);
#else
                Texture2D tex = new Texture2D(2, 2, TextureFormat.ARGB32, false);
                tex.LoadImage(fileData);
#endif
                Sprite loadedSprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                LoadedSprites[relativeOrAbsolutePath] = loadedSprite;
                return loadedSprite;
            }

            ModLogger.Log($"Could not find sprite at path: {relativeOrAbsolutePath} (Checked: {filePath})", LogType.Error);
            LoadedSprites[relativeOrAbsolutePath] = FallbackSprite;
            return FallbackSprite;
        }

        #endregion


        public static GameObject FindChild(GameObject parent, string name, bool recursive = false)
        {
            if (parent == null) return null;

            Transform directChild = parent.transform.Find(name);
            if (directChild != null) return directChild.gameObject;

            if (recursive)
            {
                foreach (Transform child in parent.transform)
                {
                    GameObject result = FindChild(child.gameObject, name, true);
                    if (result != null) return result;
                }
            }

            return null;
        }

        public static Canvas CreateRootCanvas(string name = "DaniDojoCanvas", int sortingOrder = 0)
        {
            GameObject canvasObj = new GameObject(name);

            Canvas canvas = canvasObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.overrideSorting = true;
            canvas.sortingOrder = sortingOrder;

            CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            scaler.matchWidthOrHeight = 0;

            canvasObj.AddComponent<GraphicRaycaster>();
            return canvas;
        }

        public static GameObject CreateUIContainer(GameObject parent, string name, Vector2 position = default, Vector2 size = default)
        {
            GameObject container = new GameObject(name);
            if (parent != null)
            {
                container.transform.SetParent(parent.transform, false);
            }

            RectTransform rect = container.GetOrAddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.pivot = new Vector2(0.5f, 0.5f);
            rect.anchoredPosition = position;
            rect.sizeDelta = size;
            rect.localScale = Vector3.one;

            return container;
        }

        public static TextMeshProUGUI CreateText(
            GameObject parent,
            string name,
            string text = "",
            Vector2 position = default,
            Vector2 size = default,
            float fontSize = 32f,
            Color? color = null,
            TextAlignmentOptions alignment = TextAlignmentOptions.Center,
            TMP_FontAsset font = null,
            Material fontMaterial = null)
        {
            GameObject container = CreateUIContainer(parent, name, position, size);
            TextMeshProUGUI tmp = container.AddComponent<TextMeshProUGUI>();

            tmp.text = text;
            tmp.fontSize = fontSize;
            tmp.color = color ?? Color.white;
            tmp.alignment = alignment;

            if (font != null)
                tmp.font = font;

            if (fontMaterial != null)
                tmp.fontSharedMaterial = fontMaterial;

            return tmp;
        }

        public static void SetText(GameObject target, string newText)
        {
            if (target == null) return;
            if (target.TryGetComponent<TextMeshProUGUI>(out var tmp))
            {
                tmp.text = newText;
            }
        }

        public static void SetText(TextMeshProUGUI tmpComponent, string newText)
        {
            if (tmpComponent != null)
            {
                tmpComponent.text = newText;
            }
        }

        public static void SetTextStyle(TextMeshProUGUI tmpComponent, TMP_FontAsset font, Material fontMaterial = null)
        {
            if (tmpComponent == null) return;
            if (font != null) tmpComponent.font = font;
            if (fontMaterial != null) tmpComponent.fontSharedMaterial = fontMaterial;
        }


        public static Image CreateImage(GameObject parent, string name, Sprite sprite, Vector2 position = default, bool useNativeSize = true)
        {
            GameObject container = CreateUIContainer(parent, name, position, Vector2.zero);
            Image img = container.AddComponent<Image>();
            img.sprite = sprite;

            if (useNativeSize && sprite != null)
            {
                img.SetNativeSize();
            }

            return img;
        }

        public static Image CreateImage(GameObject parent, string name, string spritePath, Vector2 position = default, bool useNativeSize = true)
        {
            Sprite sprite = LoadSprite(spritePath);
            return CreateImage(parent, name, sprite, position, useNativeSize);
        }

        public static Image CreateSolidPanel(GameObject parent, string name, Vector2 position, Vector2 size, Color color)
        {
            GameObject container = CreateUIContainer(parent, name, position, size);
            Image img = container.AddComponent<Image>();
            img.color = color;
            return img;
        }

        public static void SetSprite(Image image, Sprite sprite, bool resetNativeSize = false)
        {
            if (image == null) return;
            image.sprite = sprite;
            if (resetNativeSize && sprite != null)
            {
                image.SetNativeSize();
            }
        }

        public static void SetSprite(Image image, string spritePath, bool resetNativeSize = false)
        {
            SetSprite(image, LoadSprite(spritePath), resetNativeSize);
        }

        public static void SetImageColor(GameObject gameObject, Color color)
        {
            var image = gameObject.GetComponent<Image>();
            SetImageColor(image, color);
        }

        public static void SetImageColor(Image image, Color color)
        {
            if (image != null)
            {
                image.color = color;
            }
        }


        public static void SetPosition(GameObject target, Vector3 localPosition)
        {
            if (target != null)
            {
                target.transform.localPosition = localPosition;
            }
        }

        public static void SetSize(GameObject target, Vector2 sizeDelta)
        {
            if (target == null) return;
            if (target.TryGetComponent<RectTransform>(out var rect))
            {
                rect.sizeDelta = sizeDelta;
            }
        }

        public static void SetScale(GameObject target, Vector3 scale)
        {
            if (target != null)
            {
                target.transform.localScale = scale;
            }
        }

        public static void SetUniformScale(GameObject target, float scale)
        {
            if (target != null)
            {
                target.transform.localScale = new Vector3(scale, scale, scale);
            }
        }

        public static void FlipHorizontal(GameObject target)
        {
            if (target == null) return;
            Vector3 scale = target.transform.localScale;
            scale.x *= -1f; // Inverts current orientation
            target.transform.localScale = scale;
        }

        public static void SetAlpha(GameObject target, float alpha)
        {
            if (target == null) return;
            CanvasGroup group = target.GetOrAddComponent<CanvasGroup>();
            group.alpha = Mathf.Clamp01(alpha);
        }
    }

    public static class Extensions
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent<T>(out T t))
            {
                return t;
            }
            else
            {
                return gameObject.AddComponent<T>();
            }
        }
    }
}
