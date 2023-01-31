using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHub : MonoBehaviour
{
    public void Loadhub()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
