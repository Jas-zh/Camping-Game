using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool EnteredHouse = false;

    bool EnteredGame = false;   

    public float rDelay = 1f;

    public GameObject WalkingInUI;

    public GameObject StartingGameUI;

    bool GameEnded = false;

    public float restartDelay = 2f;
    
    public void EnterCabin()
    {
        WalkingInUI.SetActive(true);
    }
    
    public void StartGame()
    {
        StartingGameUI.SetActive(true);
    }

    public void ExitGame()
    {
        StartingGameUI.SetActive(true);
    }

    public void EndGame()
    {
       if(GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("XD");
            Invoke("Restart", rDelay);
        }
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
