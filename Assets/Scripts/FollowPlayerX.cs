﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3 (10,0,0);

    // Start is called before the first frame updateb
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // offset  the camera the beside player to the player's position
        transform.position = plane.transform.position + offset;
    }
}
