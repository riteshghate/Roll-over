using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //offset for x,y,z 
   
    void Update()
    {
        transform.position = player.position + offset; //logic for camera following the player 
    }
}
