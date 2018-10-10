using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    public Transform player;
    private float timeToSpawn = 0f;
    public float timeBetweenWaves = 2f;
    public float distanceBetweenWaves = 20f;

    void Update()
    {
        if (Time.time >= timeToSpawn) {
            transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z + distanceBetweenWaves);
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }


    void SpawnBlocks() {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        //for (int i = 0; i < spawnPoints.Length; i++)
        //{
        //    if (i == randomIndex_1 || i == randomIndex_2 || i == randomIndex_3)
        //    {
        //        var obstacle = (GameObject)Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
        //        Destroy(obstacle, 5f);
        //    }
        //}

        var obstacle = (GameObject)Instantiate(obstaclePrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        Destroy(obstacle, 5f);

    }

}
