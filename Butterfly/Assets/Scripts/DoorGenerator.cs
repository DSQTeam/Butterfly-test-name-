using UnityEngine;
using System.Collections.Generic;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] correctObjects; // Массив правильных объектов
    public GameObject[] incorrectObjects; // Массив неправильных объектов

    void Start()
    {
        // Создаем правильный объект на сцене
        GameObject correctObject = Instantiate(correctObjects[Random.Range(0, correctObjects.Length)], new Vector3(-6, 0, 0), Quaternion.identity);

        // Выбираем два различных неправильных объекта
        GameObject incorrectObject1 = Instantiate(incorrectObjects[Random.Range(0, incorrectObjects.Length)], new Vector3(0, 0, 0), Quaternion.identity);
        GameObject incorrectObject2;
        do
        {
            incorrectObject2 = Instantiate(incorrectObjects[Random.Range(0, incorrectObjects.Length)], new Vector3(6, 0, 0), Quaternion.identity);
        } while (incorrectObject2 == incorrectObject1); // Проверяем, что второй неправильный объект не равен первому

    }
}