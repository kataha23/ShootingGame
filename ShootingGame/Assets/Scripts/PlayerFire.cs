using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    [Header("�Ӽ�")]
    public GameObject bulletSpawn; // �Ѿ��� �����ϴ� ����
    public Transform bulletPosition; // �Ѿ��� �߻�� ��ġ



    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // ���콺 ���� ��ư Ŭ�� �� (�Ǵ� Ctrl Ű)
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletSpawn); // �Ѿ� ������Ʈ ����
        bullet.transform.position = bulletPosition.transform.position; // �Ѿ��� ��ġ�� �߻� ��ġ�� ����
    }
}
