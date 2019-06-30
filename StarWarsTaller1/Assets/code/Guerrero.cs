using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Guerrero : MonoBehaviour{
	System.Random rng = new System.Random();
	public Animator anim;
	public Rigidbody2D body;
	public Transform trans;
	public GameObject bala;
	int count = 0;
	bool derecha = false;
	float v_x = 0.0f;


	private void Awake(){
		trans = this.transform;
        anim = this.GetComponent<Animator>();
        body = this.GetComponent<Rigidbody2D>();
	}	

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        var v = body.velocity;
        v.x = v_x;
        body.velocity = v;
        try {
            falcon player = GameObject.FindWithTag("Player").GetComponent(typeof(falcon)) as falcon; 
        }catch (Exception e) {
            v.x = 0.0f;
            body.velocity = v;
            anim.SetBool("final", true);
            return;
        }     
    	
    	if(count == 0){
    		if(derecha){
    			transform.localScale = new Vector3(0.5f, 0.5f, 1);
	    		derecha = false;
	    		v_x = 2.0f;
	    	}else{
	    		transform.localScale = new Vector3(-0.5f, 0.5f, 1);
	    		derecha = true;
	    		v_x = -2.0f;
	    	}
            anim.SetBool("correr", true);
            v.x = v_x;
            body.velocity = v; 
    	}	
        count += 1;
        if(count==240){ // para que se genere uno nuevo cada 4 segundos.
        	anim.SetBool("correr", false);
        	v.x = 0.0f;
    		body.velocity = v;       
        	anim.SetBool("disparar", true);
        	var position = body.position;
        	GameObject obj = (GameObject) Instantiate(bala, new Vector3(position.x, position.y, -5), Quaternion.identity);
        	obj.GetComponent<Rigidbody2D>().velocity = new Vector3(v_x, +3, 0);
            obj.tag = "meteoro";
            if (v_x > 0.0){
        		obj.transform.localScale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y, 1);
        	}else{
        		obj.transform.localScale = new Vector3(-1 *obj.transform.localScale.x, obj.transform.localScale.y, 1);
        	}
        	v_x = 0.0f;
        	anim.SetBool("disparar", false);
        }
        if(count==300){ 
            anim.SetBool("correr", true);
        }
        
        if(count==360){ // para que se genere uno nuevo cada 4 segundos.
        	count = 0;

        }
    }
}
