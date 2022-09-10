using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool EnteredHouse = false;

    public float restartDelay = 1f;

    public GameObject WalkingInUI;

    
    public void EnterCabin()
    {
        WalkingInUI.SetActive(true);
    }
    
   
}
