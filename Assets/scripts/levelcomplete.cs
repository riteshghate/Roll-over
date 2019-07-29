using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour
{
    public void LoadNextlevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
