using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Sample
{
    public class Bullet : MonoBehaviour
    {
        // �ʿ� �Ӽ��� �����մϴ�.
        [Header("�Ӽ�")]
        public float speed = 5;

        // ��� �ִ� ���ȿ��� ���
        private void Update()
        {
            // �ӵ� = ���� x �ӷ�
            // ���� : ����
            // �ӷ� : speed
            Vector3 dir = Vector3.up;

            transform.position += dir * speed * Time.deltaTime;

            
        }
        
    }

}