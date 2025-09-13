using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("�Ӽ�")]
    public float speed = 2f; // ���� �̵� �ӵ�
    public float FollowingChance = 3; // �÷��̾ ����� Ȯ��
    private Vector3 dir; // ���� �̵� ����

    private void Start()
    {
        GetWhereToGo();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; // �� �̵�
    }

    private void GetWhereToGo()
    {
        int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 ������ ���� �������� ����
        Console.WriteLine(randValue);
        if (randValue <= FollowingChance)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // �÷��̾ ���ϴ� ����
            dir.Normalize();
            return;
        }

        else { dir = Vector3.down; }
    }


    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("DestroyLine"))
        {
            Destroy(gameObject);       // �� �ı�
        }

        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // �Ѿ�, �ı�
            Destroy(gameObject);       // �� �ı�
        }
    }
}

