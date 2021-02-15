using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject doublePlatformPrefab;
    
    public int numberOfPlattforms = 1000;
    public float levelWidth = 0.02f;
    public float minY = .2f;
    public float maxY = 1.5f;
    
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        
        for (int i = 0; i < numberOfPlattforms; i++)
        {
            if (i > 50)
            {
                minY = 1f;
                maxY = 3f;
            }

            if (i > 100)
            {
                minY = 2f;
                maxY = 4f;
            }
            
            if (i > 200)
            {
                minY = 2f;
                maxY = 5f;
            }
            
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x += Random.Range(-levelWidth, +levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
        Vector3 spawnPositionDouble = new Vector3();
        
        for (int i = 0; i < numberOfPlattforms; i++)
        {
            if (i > 50)
            {
                minY = 4f;
                maxY = 8f;
            }

            if (i > 100)
            {
                minY = 2f;
                maxY = 4f;
            }
            
            if (i > 200)
            {
                minY = 2f;
                maxY = 5f;
            }

            if (i > 50)
            {
                spawnPositionDouble.y += Random.Range(minY, maxY);
                spawnPositionDouble.x += Random.Range(-levelWidth, +levelWidth);
                Instantiate(doublePlatformPrefab, spawnPositionDouble, Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
