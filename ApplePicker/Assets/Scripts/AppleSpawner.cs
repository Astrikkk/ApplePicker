using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public List<Transform> spawnPoints; 
    public float spawnTime = 2f;       
    public GameObject applePrefab;      
    public GameManager gameManager;  

    private void Start()
    {
        gameManager=GameObject.FindAnyObjectByType<GameManager>();
        StartCoroutine(SpawnApples());
    }

    private IEnumerator SpawnApples()
    {
        while (true)
        {
            if (!gameManager.IsEnded)
            {
                int randomIndex = Random.Range(0, spawnPoints.Count);
                Transform spawnPoint = spawnPoints[randomIndex];

                Instantiate(applePrefab, spawnPoint.position, Quaternion.identity);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
