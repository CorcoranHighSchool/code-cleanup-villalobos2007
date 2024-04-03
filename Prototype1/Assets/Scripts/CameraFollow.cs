﻿using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Vehicle game object to follow
    {Serializefield private GameObject player;
    //offset from the vehicle
    private Vector3 offset = new Vector3(0.0f, 12.0f, -10.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update just before the frame is rendered
    void LateUpdate()
    {
        //move the camera to the player + offset
        transform.position = player.transform.position + offset;
    }
}
