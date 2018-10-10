using UnityEngine;

public class HitByBullet : MonoBehaviour {

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
