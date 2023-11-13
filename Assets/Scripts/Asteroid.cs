using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 5f;

    void Start()
    {
        // Asteroit ozellikleri ve hareket kodlar�
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
        // Rastgele bir h�z belirleme kodlar�
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Asteroit carp�sma davran�slar�
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            // Asteroit patlama kodlar�
        }
        else if (collision.gameObject.tag == "Player")
        {
            // Oyuncu gemisine �arpma kodlar�
        }
    }
}
