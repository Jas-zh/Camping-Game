using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.StartGame();
    }
}
