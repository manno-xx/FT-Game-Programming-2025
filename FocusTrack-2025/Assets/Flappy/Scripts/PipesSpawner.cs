using System.Collections;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1;

    [SerializeField] private Pipes pipesPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate(pipesPrefab, transform.position, Quaternion.identity, transform);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
