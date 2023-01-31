
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeOutdoors : MonoBehaviour
{
    public void DoSomething2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
