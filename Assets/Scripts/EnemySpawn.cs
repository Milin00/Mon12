using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private GameObject player;
    private Vector3 enemySpawnPoint;
    private float spawnTime = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("player");
        enemySpawnPoint = new Vector3(
            player.transform.position.x + Random.Range(-10.0f, 10.0f),
            player.transform.position.y,
            player.transform.position.z + Random.Range(-10.0f, 15.0f)
            );
        Instantiate (enemyPrefab,enemySpawnPoint,new Quaternion(0,180,0,0));    
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime)
        {
            enemySpawnPoint = new Vector3(
           player.transform.position.x + Random.Range(-10.0f, 10.0f),
           player.transform.position.y,
           player.transform.position.z + Random.Range(-10.0f, 15.0f)
           );
            Instantiate(enemyPrefab, enemySpawnPoint, new Quaternion(0, 180, 0, 0));
            spawnTime = Time.time + Random.Range(1.0f, 3.0f);
        }
    }
}
