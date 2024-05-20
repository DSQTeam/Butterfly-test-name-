using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomToLocation : MonoBehaviour
{
    public float zoomLevel = 5f; // Уровень масштабирования, который вы хотите установить
    public Vector3 targetPosition; // Позиция, к которой вы хотите приблизить экран
    private bool isZooming = false;

    public void ZoomToTarget()
    {
        if (!isZooming)
        {
            StartCoroutine(ZoomCoroutine());
        }
    }

    IEnumerator ZoomCoroutine()
    {
        isZooming = true;

        // Блокировка других кнопок или действий во время приближения
        // Например, вы можете отключить другие кнопки или управление

        float duration = 0.6f; // Продолжительность анимации приближения
        float timer = 0f;

        float startZoomLevel = Camera.main.orthographicSize;
        Vector3 startPosition = Camera.main.transform.position;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float t = timer / duration;

            Camera.main.orthographicSize = Mathf.Lerp(startZoomLevel, zoomLevel, t);
            Camera.main.transform.position = Vector3.Lerp(startPosition, new Vector3(targetPosition.x, targetPosition.y, Camera.main.transform.position.z), t);

            yield return null;
        }

        isZooming = false;

        // Разблокировка других кнопок или действий после завершения приближения
    }
}