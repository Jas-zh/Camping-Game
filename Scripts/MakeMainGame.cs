using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeMainGame: MonoBehaviour
{
    public void DoSomething3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
