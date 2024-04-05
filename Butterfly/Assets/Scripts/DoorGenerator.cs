using UnityEngine;
using System.Collections.Generic;


public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> objectsToSpawn = new List<GameObject>(); // Лист объектов, которые вы хотите спавнить 
    public List<Transform> spawnPoints = new List<Transform>();     // Лист точек спавна 
    private void Start()
    {
        SpawnRandomObject();
    }

    void SpawnRandomObject()
    {
        
        foreach (GameObject obj in objectsToSpawn )
        {
            // Выбираем случайную точку спавна 
             int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randomSpawnPointIndex];

            // Выбираем случайный объект для спавна 
             int randomObjectIndex = Random.Range(0, objectsToSpawn.Count);
            GameObject objectToSpawn = objectsToSpawn[randomObjectIndex];

            // Создаем объект на выбранной точке спавна 
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

            spawnPoints.Remove(spawnPoint);
            objectsToSpawn.Remove(objectToSpawn);
            
        }

    }

}