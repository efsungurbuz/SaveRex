using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    Counter counter;

    int enemyCounter = 0;  
    public int maxEnemyNumber = 3;

    void Start()
    {
        counter = gameObject.GetComponent<Counter>();
        counter.TotalTime = 1;
        counter.Start();
    }

    void Update()
    {
        if (counter.Over)
        {
            if (enemyCounter < maxEnemyNumber)
            {
                SpawnEnemy();
                enemyCounter++;
            }
            counter.Start();
        }
    }

    void SpawnEnemy()
    {
        // Declaring random position
        Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
