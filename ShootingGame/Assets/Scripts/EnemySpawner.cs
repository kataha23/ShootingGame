using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("속성")]
    public float Spawntimer = 0f; // 시간
    private float time; // 적이 생성되는 간격
    public GameObject enemySpawner; // 적이 생산하는 공장

    [Header("적 스폰")]
    public float minTime = 0.5f; // 적이 생성되는 최소 간격
    public float maxTime = 7f; // 적이 생성되는 최대 간격
    

    private void Start()
    {
        Spawntimer = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    private void Update()
    {
        time += Time.deltaTime;

        if (time > Spawntimer)
        {
            GameObject enemy = Instantiate(enemySpawner); // 적 오브젝트 생성
            enemy.transform.position = transform.position;

            Spawntimer = UnityEngine.Random.Range(minTime, maxTime);
            time = 0f;
        }

        
    }
}
