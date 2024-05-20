using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomToLocation : MonoBehaviour
{
    public float zoomLevel = 5f; // ������� ���������������, ������� �� ������ ����������
    public Vector3 targetPosition; // �������, � ������� �� ������ ���������� �����
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

        // ���������� ������ ������ ��� �������� �� ����� �����������
        // ��������, �� ������ ��������� ������ ������ ��� ����������

        float duration = 0.6f; // ����������������� �������� �����������
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

        // ������������� ������ ������ ��� �������� ����� ���������� �����������
    }
}