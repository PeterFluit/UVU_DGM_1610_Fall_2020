using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Set the target for the camera to follow
public GameObject player;
private Vector3 offset = new Vector3(0, 5,-10);

    // Update is called once per frame
    void Update()
    {
        //Makes the main camera follow the player position
        transform.position = player.transform.position + offset;
    }
}
