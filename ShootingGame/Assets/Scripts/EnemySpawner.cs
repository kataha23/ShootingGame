using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("�Ӽ�")]
    public float Spawntimer = 0f; // �ð�
    private float time; // ���� �����Ǵ� ����
    public GameObject enemySpawner; // ���� �����ϴ� ����

    [Header("�� ����")]
    public float minTime = 0.5f; // ���� �����Ǵ� �ּ� ����
    public float maxTime = 7f; // ���� �����Ǵ� �ִ� ����
    

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
            GameObject enemy = Instantiate(enemySpawner); // �� ������Ʈ ����
            enemy.transform.position = transform.position;

            Spawntimer = UnityEngine.Random.Range(minTime, maxTime);
            time = 0f;
        }

        
    }
}
