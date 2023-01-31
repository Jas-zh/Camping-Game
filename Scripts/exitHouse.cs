using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitHouse : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.EnterCabin();
    }
}
