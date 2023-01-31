using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeCabin : MonoBehaviour
{
    public void DoSomething()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
