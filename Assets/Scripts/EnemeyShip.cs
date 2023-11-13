using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyShip : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotationSpeed = 100f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start()
    {
        // Düsman gemisi ozellikleri ve hareket kodlarý
    }

    void Update()
    {
        // Düsman gemisi hareket ve ates etme kodlarý
        MoveEnemyShip();
        RotateEnemyShip();
        FireBullet();
    }

    void MoveEnemyShip()
    {
        // Düþman gemisi hareket kodlarý
    }

    void RotateEnemyShip()
    {
        // Düþman gemisi dönme kodlarý
    }

    void FireBullet()
    {
        // Düþman gemisi ateþ etme kodlarý
    }
}
