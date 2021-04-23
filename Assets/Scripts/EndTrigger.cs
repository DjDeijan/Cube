using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerCollision playerCollision;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
