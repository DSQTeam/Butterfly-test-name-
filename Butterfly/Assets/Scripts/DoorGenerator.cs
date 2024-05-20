using UnityEngine;
using System.Collections.Generic;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] correctObjects; // ������ ���������� ��������
    public GameObject[] incorrectObjects; // ������ ������������ ��������

    void Start()
    {
        // ������� ���������� ������ �� �����
        GameObject correctObject = Instantiate(correctObjects[Random.Range(0, correctObjects.Length)], new Vector3(-6, 0, 0), Quaternion.identity);

        // �������� ��� ��������� ������������ �������
        GameObject incorrectObject1 = Instantiate(incorrectObjects[Random.Range(0, incorrectObjects.Length)], new Vector3(0, 0, 0), Quaternion.identity);
        GameObject incorrectObject2;
        do
        {
            incorrectObject2 = Instantiate(incorrectObjects[Random.Range(0, incorrectObjects.Length)], new Vector3(6, 0, 0), Quaternion.identity);
        } while (incorrectObject2 == incorrectObject1); // ���������, ��� ������ ������������ ������ �� ����� �������

    }
}