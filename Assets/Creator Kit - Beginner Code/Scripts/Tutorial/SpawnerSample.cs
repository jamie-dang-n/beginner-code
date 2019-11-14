using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {

        SpawnPotion(0);
        SpawnPotion(45);
        SpawnPotion(90);
        SpawnPotion(135);
    }

    void SpawnPotion(int angle)
    {
        int radius = 5;
        Vector3 spawnPosition = transform.position;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

