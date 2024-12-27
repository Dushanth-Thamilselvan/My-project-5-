using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab
    public Transform firePoint;     // Point from where the bullet is fired
    public float bulletSpeed = 10f; // Speed of the bullet
    public float fireRate = 2f;     // Time interval between shots

    private float nextFireTime = 0f;

    void Update()
    {
        // Check if it's time to shoot
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Instantiate the bullet and set its velocity
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.up * bulletSpeed; // Adjust direction if necessary
        }
    }
}
