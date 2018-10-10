using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    public Transform player;
    private float distanceToSpawn = 0f;
    public float distanceBetweenWaves = 100f;

    void Update()
    {
        if (player.position.z >= distanceToSpawn) {
            transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z + distanceBetweenWaves);
            SpawnBlocks();
            distanceToSpawn = player.position.z + distanceBetweenWaves;
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
