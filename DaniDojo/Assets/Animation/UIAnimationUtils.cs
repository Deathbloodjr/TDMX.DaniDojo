using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

namespace DaniDojo.Assets.Animation
{
    public static class UIAnimationUtils
    {
        public static IEnumerator AnchorPosRoutine(this RectTransform rect, Vector2 targetPos, float duration, Func<float, float> easing = null)
        {
            easing ??= Easing.Linear;
            Vector2 startPos = rect.anchoredPosition;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = easing(Mathf.Clamp01(elapsed / duration));
                rect.anchoredPosition = Vector2.LerpUnclamped(startPos, targetPos, t);
                yield return null;
            }

            rect.anchoredPosition = targetPos;
        }

        public static IEnumerator ScaleRoutine(this Transform transform, Vector3 targetScale, float duration, Func<float, float> easing = null)
        {
            easing ??= Easing.Linear;
            Vector3 startScale = transform.localScale;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = easing(Mathf.Clamp01(elapsed / duration));
                transform.localScale = Vector3.LerpUnclamped(startScale, targetScale, t);
                yield return null;
            }

            transform.localScale = targetScale;
        }

        public static IEnumerator FadeRoutine(this CanvasGroup canvasGroup, float targetAlpha, float duration, Func<float, float> easing = null)
        {
            easing ??= Easing.Linear;
            float startAlpha = canvasGroup.alpha;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = easing(Mathf.Clamp01(elapsed / duration));
                canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, t);
                yield return null;
            }

            canvasGroup.alpha = targetAlpha;
        }

        public static IEnumerator FadeRoutine(this SpriteRenderer spriteRenderer, float targetAlpha, float duration, Func<float, float> easing = null)
        {
            easing ??= Easing.Linear;
            Color color = spriteRenderer.color;
            float startAlpha = color.a;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = easing(Mathf.Clamp01(elapsed / duration));
                color.a = Mathf.Lerp(startAlpha, targetAlpha, t);
                spriteRenderer.color = color;
                yield return null;
            }

            color.a = targetAlpha;
            spriteRenderer.color = color;
        }

        public static IEnumerator FadeRoutine(this Image image, float targetAlpha, float duration, Func<float, float> easing = null)
        {
            easing ??= Easing.Linear;
            Color color = image.color;
            float startAlpha = color.a;
            float elapsed = 0f;

            while (elapsed < duration)
            {
                elapsed += Time.deltaTime;
                float t = easing(Mathf.Clamp01(elapsed / duration));
                color.a = Mathf.Lerp(startAlpha, targetAlpha, t);
                image.color = color;
                yield return null;
            }

            color.a = targetAlpha;
            image.color = color;
        }
    }
}
