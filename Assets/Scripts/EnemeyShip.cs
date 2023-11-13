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
        // D�sman gemisi ozellikleri ve hareket kodlar�
    }

    void Update()
    {
        // D�sman gemisi hareket ve ates etme kodlar�
        MoveEnemyShip();
        RotateEnemyShip();
        FireBullet();
    }

    void MoveEnemyShip()
    {
        // D��man gemisi hareket kodlar�
    }

    void RotateEnemyShip()
    {
        // D��man gemisi d�nme kodlar�
    }

    void FireBullet()
    {
        // D��man gemisi ate� etme kodlar�
    }
}
