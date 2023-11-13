using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 5f;

    void Start()
    {
        // Asteroit ozellikleri ve hareket kodlarý
        SetRandomSpeed();
    }

    void Update()
    {
        MoveAsteroid();
    }

    void MoveAsteroid()
    {
        transform.Translate(Vector3.down * Random.Range(minSpeed, maxSpeed) * Time.deltaTime);
    }

    void SetRandomSpeed()
    {
        // Rastgele bir hýz belirleme kodlarý
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Asteroit carpýsma davranýslarý
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            // Asteroit patlama kodlarý
        }
        else if (collision.gameObject.tag == "Player")
        {
            // Oyuncu gemisine çarpma kodlarý
        }
    }
}
