using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 10f;

    public const string left = "a";
    public const string right = "d";

    public bool onTheGround = true;

    private int difficulty = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.difficulty = gameManager.getDifficulty();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // If they press "d"
        if ( Input.GetKey(right)) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        
        if (Input.GetKey(left)) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Prevent jumping on hard difficulty
        if (Input.GetKey(KeyCode.Space) && this.difficulty != 2) {
            if (onTheGround) {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            onTheGround = false;
        }

        // If they fall off the platform, end the game
        if (rb.position.y < -1) {
            FindObjectOfType<GameManager>().EndGame();
        }

        // If the runner falls down to the ground
        if (rb.position.y == 0) {
            onTheGround = true;
        }
    }
}

