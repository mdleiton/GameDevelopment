using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class meteorit : MonoBehaviour
{
    public Rigidbody2D body;
    System.Random rng = new System.Random();
    public float speed;
    int count;

    // Start is called before the first frame update
    void Start(){
        count = 0;

    }

    // Update is called once per frame
    void Update(){
    	body.velocity = new Vector2(-5,0);
    }
    
    void OnBecameInvisible() {
        count = count + 1;
        if(count > 2){
            Destroy(this);
        }
    	body.position = new Vector2(9,rng.Next(-1,6));

     }
}
