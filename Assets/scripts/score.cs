using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player; //attached player in unity
    public Text scoreText; //attached text from the canvas

    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //used 0 for avoiding float number
    }
}
