﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huwahuwa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
        void Update () {
            transform.position = new Vector3(transform.position.x, 
                Mathf.PingPong(Time.time, 1), transform.position.z);
        }

    }

