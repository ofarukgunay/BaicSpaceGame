using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Mermi hareket ve carpýsma kodlarý
        MoveBullet();
    }

    void MoveBullet()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}
