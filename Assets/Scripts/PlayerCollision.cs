using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
