using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    [Header("속성")]
    public GameObject bulletSpawn; // 총알이 생산하는 공장
    public Transform bulletPosition; // 총알이 발사될 위치



    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // 마우스 왼쪽 버튼 클릭 시 (또는 Ctrl 키)
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletSpawn); // 총알 오브젝트 생성
        bullet.transform.position = bulletPosition.transform.position; // 총알의 위치를 발사 위치로 설정
    }
}
