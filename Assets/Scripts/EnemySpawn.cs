using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;

    private GameObject Player;
    private Vector3 EnemySpawnPoint;
    private float spawnTime = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
        EnemySpawnPoint = new Vector3(
            Player.transform.position.x + Random.Range(-15.0f, 15.0f),
            Player.transform.position.y,
            Player.transform.position.z + Random.Range(0.0f, 15.0f)
            );
        Instantiate (EnemyPrefab,EnemySpawnPoint,new Quaternion(0,180,0,0));

       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime)
        {
           EnemySpawnPoint = new Vector3(
              Player.transform.position.x + Random.Range(15.0f, -15.0f),
              Player.transform.position.y,
              Player.transform.position.z + Random.Range(0.0f,15.0f)
           );
            Instantiate(EnemyPrefab, EnemySpawnPoint, new Quaternion(0, 180, 0, 0));
            spawnTime = Time.time + Random.Range(0.5f, 2.5f);
        }
    }
}
