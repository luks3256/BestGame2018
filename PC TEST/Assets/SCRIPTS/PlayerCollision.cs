using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter( Collision collisioninfo )
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit :" + collisioninfo.collider.tag);
            movement.enabled = false;
            //Debug.Log("Thats why we stoped");
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
