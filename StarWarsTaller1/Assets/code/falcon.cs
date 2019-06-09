using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falcon : MonoBehaviour{

    public Rigidbody2D body;
    public float speed = 10f;
    public meteorit meteorit;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        var x = Input.GetAxis("Horizontal"); 
        var y = Input.GetAxis("Vertical"); 
    	body.velocity =  new Vector2(speed*x,speed *y);
        /*
        if (Input.GetKey(KeyCode.Space)) {
         Instantiate(meteorit);
         Debug.Log("create");

        }*/
    }
}
