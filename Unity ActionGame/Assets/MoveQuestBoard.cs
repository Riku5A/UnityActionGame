﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveQuestBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 2f, 0f, Space.World);
    }
}
