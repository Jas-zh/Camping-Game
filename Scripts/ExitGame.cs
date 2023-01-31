using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.ExitGame();
    }
}
