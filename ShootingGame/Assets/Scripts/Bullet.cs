using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position = transform.position + dir * speed * Time.deltaTime;

      
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("DestroyLine"))
        {
            Destroy(gameObject);       // ÆÄ±«
        }
    }
}
