﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate(){
		if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey ("w")){
			transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * moveSpeed * 2.5f;
		}else if (Input.GetKey ("w") && !Input.GetKey(KeyCode.LeftShift)){
			transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * moveSpeed;
		} else if (Input.GetKey ("s")){
			transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * moveSpeed;
		}

		if (Input.GetKey ("a") && !Input.GetKey("d")){
			transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * moveSpeed;
		}else if (Input.GetKey ("d") && !Input.GetKey("a")){
			transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * moveSpeed;
		}
	}
}
