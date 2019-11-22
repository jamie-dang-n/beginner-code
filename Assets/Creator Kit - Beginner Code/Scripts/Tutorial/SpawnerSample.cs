using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    Vector3 spawnPosition;
    Vector3 direction;
    int angle;
    int distance;

    void Start()
    {
        LootAngle myLootAngle = new LootAngle(45);
        spawnPosition = transform.position;

        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());

    }

    void SpawnPotion(int angle)
    {
        angle = Random.Range(0, 360);
        distance = Random.Range(2, 15);
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * distance;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }


    public class LootAngle
    {
        int angle;
        int step;

       public LootAngle(int increment)
        {
            step = increment;
            angle = 0;
        }

        public int NextAngle()
        {
            int currentAngle = angle;
            angle = Helpers.WrapAngle(angle + step);

            return currentAngle;
        }
    }
}