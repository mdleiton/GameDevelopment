using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class meteorit : MonoBehaviour
{
    public Rigidbody2D body;
    System.Random rng = new System.Random();
    public float speed;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
    	body.velocity = new Vector2(-5,0);
    	/*
    	var v = body.velocity;    	
    	if (Input.GetKey(KeyCode.UpArrow)){ // x-axis movement
            Debug.Log("adad");
            v.x = speed;
		}else{
			v.x = 0f;
		}
		body.velocity = v;
		*/
        /*
        { // x-axis movement
            var v = body.velocity;
            var speed = 0f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed += -walkingSpeed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                speed += walkingSpeed;
            }
            v.x = speed;
            
        }*/
    }
    
    void OnBecameInvisible() {
    	body.position = new Vector2(1,rng.Next(-1,6));
     }
}
