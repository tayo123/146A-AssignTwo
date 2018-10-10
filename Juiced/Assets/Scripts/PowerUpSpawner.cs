using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public Transform spawnPoint;
    public Transform platform;
    public GameObject powerUpPrefab;
    public Transform player;
    private float distanceToSpawn = 0f;
    public float distanceBetweenWaves = 50f;

    void Update()
    {
        if (player.position.z >= distanceToSpawn)
        {
            float xPos = Random.Range(-(platform.lossyScale.x / 2f) + 2f, (platform.lossyScale.x / 2f) - 2f);
            transform.position = new Vector3(xPos, transform.position.y, player.position.z + distanceBetweenWaves);
            SpawnPowerUp();
            distanceToSpawn = player.position.z + distanceBetweenWaves;
        }

    }


    void SpawnPowerUp()
    {
        var powerUp = (GameObject)Instantiate(powerUpPrefab, spawnPoint.position, Quaternion.identity);
        Destroy(powerUp, 5f);
    }

}
