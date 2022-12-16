using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class for the main camera to follow the runner
public class FollowRunner : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // Set in the unity ui

    // Update is called once per frame
    void Update()
    {
        
        // Update the position of the camera
        transform.position = player.position + offset;
        
    }
}
