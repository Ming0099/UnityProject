using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;

    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetButtonDown("Fire1"))
        {
            // Calculate the direction for the bullet to move
            Vector3 shootDirection = new Vector3(1f, 1f, 0f).normalized; // 오른쪽 위 대각선으로 발사

            // Instantiate a bullet prefab at the bullet spawn point
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Get the Rigidbody component of the bullet
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

            // Check if the Rigidbody component exists
            if (bulletRigidbody != null)
            {
                // Add force to the bullet to make it move forward
                bulletRigidbody.velocity = shootDirection * bulletSpeed;
            }
            else
            {
                Debug.LogError("Bullet prefab does not have a Rigidbody component!");
            }
        }
    }
}
