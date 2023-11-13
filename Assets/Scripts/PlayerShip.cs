using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        // Uzay gemisinin hareket ve ates etme kodlarý
        MoveShip();
        RotateShip();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }

    void MoveShip()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void RotateShip()
    {
        float rotationInput = Input.GetAxis("Rotation");
        transform.Rotate(Vector3.forward, -rotationInput * rotationSpeed * Time.deltaTime);
    }

    void FireBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
