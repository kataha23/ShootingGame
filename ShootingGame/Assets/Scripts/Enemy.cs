using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("속성")]
    public float speed = 2f; // 적의 이동 속도
    public float FollowingChance = 3; // 플레이어를 따라올 확률
    private Vector3 dir; // 적의 이동 방향

    private void Start()
    {
        GetWhereToGo();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; // 적 이동
    }

    private void GetWhereToGo()
    {
        int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 사이의 값을 랜덤으로 생성
        Console.WriteLine(randValue);
        if (randValue <= FollowingChance)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // 플레이어를 향하는 방향
            dir.Normalize();
            return;
        }

        else { dir = Vector3.down; }
    }


    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("DestroyLine"))
        {
            Destroy(gameObject);       // 적 파괴
        }

        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // 총알, 파괴
            Destroy(gameObject);       // 적 파괴
        }
    }
}

