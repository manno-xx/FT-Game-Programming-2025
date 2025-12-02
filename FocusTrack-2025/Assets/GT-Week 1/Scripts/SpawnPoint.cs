using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject pickUpPrefab;

    [SerializeField] private int spawnAmount;

    [SerializeField] private float spawnAltitude = 5;
    [SerializeField] private int outerRadius = 20;
    [SerializeField] private int innerRadius = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Vector3 rnd = Random.insideUnitCircle;
            Vector3 pos = rnd.normalized * innerRadius + rnd * (outerRadius - innerRadius);
            GameObject gam = Instantiate(
                pickUpPrefab, 
                new Vector3(pos.x, spawnAltitude, pos.y), 
                Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)), 
                transform);
        }
    }
}
