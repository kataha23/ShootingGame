using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class PlayerMovement : MonoBehaviour
    {
        public float spped = 5f;
        void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, v, 0);
            transform.position = transform.position + dir * spped * Time.deltaTime;
        }

    }
    
}

