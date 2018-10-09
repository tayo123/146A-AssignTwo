using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public RectTransform healthBar;
    public int numPowerUps = 0;
    private int maxPowerUps = 3;
    public bool canBlast = false;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "PowerUp" && canBlast == false)
        {
            numPowerUps = numPowerUps + 1;
            healthBar.sizeDelta = new Vector2((100/maxPowerUps)*numPowerUps, healthBar.sizeDelta.y);
            Debug.Log("Hit Power Up");
            if (numPowerUps == maxPowerUps)
            {
                canBlast = true;
                Debug.Log("Can Blast");
            }
        }
        Destroy(colliderInfo.gameObject);
    }
}
