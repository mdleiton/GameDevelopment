using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody2D body;
    public Transform trans;


    private void Awake(){
        trans = this.transform;
    }

    // Start is called before the first frame update
    void Start(){
        //body.velocity = new Vector2(3,0);
    }

    // Update is called once per frame
    void Update(){
    	
    }
    
    void OnBecameInvisible() {
        Destroy(gameObject);
     }

}
