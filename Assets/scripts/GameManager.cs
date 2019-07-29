using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; //logic

    public float RestartDelay = 1f; //inspector (attribute)

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false) //logic for displaying crashed once falling from -1
        {
            gameHasEnded = true;    
            Debug.Log("Crashed");
            Invoke("Restart", RestartDelay); //jumps to restart function
        }
    }
    void Restart()//restart the game 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //load the scene level01 that is the active scene
    }
}
