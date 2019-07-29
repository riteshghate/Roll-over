using UnityEngine;

public class playercollision : MonoBehaviour  //create player collision as an enemy
{
    public playerMovement movement;//create to attach player playermovement to the enmey
    
    void OnCollisionEnter(Collision collisioninfo) //oncollisionenter for enemy
    {
        if (collisioninfo.collider.tag == "obstacle") //created tag in unity so "tag" 
        {
            movement.enabled = false; //false enables the player to stop when collide with obstacle
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
