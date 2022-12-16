using UnityEngine;

public class RunnerCollision : MonoBehaviour
{
    public RunnerMovement movement;

    // Method for collision
    void OnCollisionEnter(Collision c) {
        Debug.Log("COLLIDE with " + c.collider.name);
        Debug.Log("COLLIDE with " + c.collider.tag);

        if (c.collider.tag == "Obsticle") {
            movement.enabled = false;
            
            // Unity's way of accessing an outside script
            FindObjectOfType<GameManager>().EndGame();
            
        }

        // The player has landed on the ground, allowing for another jump.
        if (c.collider.tag == "Ground") {
            Debug.Log("movement.ground:");

            Debug.Log(movement.onTheGround);
            movement.onTheGround = true;
            Debug.Log(movement.onTheGround);

        }
    }
}
