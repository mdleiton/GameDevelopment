using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class falcon : MonoBehaviour{

    public Rigidbody2D body;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start(){  
    }


    // Update is called once per frame
    void Update(){
        var x = Input.GetAxis("Horizontal"); 
        var y = Input.GetAxis("Vertical"); 
    	body.velocity =  new Vector2(speed*x,speed *y);
    }


    void OnCollisionEnter2D(Collision2D col){
        Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "meteoro"){
            Destroy(col.gameObject);
            Destroy(gameObject);

        }
    }

    void DestroyComponent(){
        // Removes the rigidbody from the game object
        Destroy(GetComponent<Rigidbody2D>());
    }
}
