using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody rb;
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float forwardForce = 5000f;
    public PlayerCollision collision;
    public RectTransform healthBar;


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && collision.canBlast)
        {
            Fire();
            collision.canBlast = false;
            collision.numPowerUps = 0;
            healthBar.sizeDelta = new Vector2(0, healthBar.sizeDelta.y);

        }
    }

    void Fire() {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            Quaternion.identity);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        rb.AddForce(0, 0, -20f, ForceMode.VelocityChange);

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);

    }
}
