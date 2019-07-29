using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb; //rb component for rigidbody

    public float ForwardForce = 2000f; //assigning the forward force or the speed of the player
    public float SidewaysForce = 500f; //assigning force to left and right direction
    // Fixed update because messin with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);    //forwardforce can change the speed to go forward
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   //sidewaysforce can change speed to go to left and right
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   //sidewaysforce can change speed to go to left and right
        }
        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    

}
