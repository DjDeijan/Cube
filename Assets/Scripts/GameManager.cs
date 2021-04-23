using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject completeLevelUI;
    bool gameHasEnded = false;
    float restartDelay = 2f;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("LEVEL WON!");
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            if (rb.position.y < -1f || rb.position.x < -8f || rb.position.x > 8f)
            {
                restartDelay = 0.6f;
            }
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
