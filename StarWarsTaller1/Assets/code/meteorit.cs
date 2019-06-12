using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class meteorit : MonoBehaviour{

    public Rigidbody2D body;
    public Transform trans;
    System.Random rng;
    int count;
    public int vida = 1;


    private void Awake(){
        trans = this.transform;
    }

    // Start is called before the first frame update
    void Start(){
        count = 0;
        rng = new System.Random();
    }

    // Update is called once per frame
    void Update(){
    	body.velocity = new Vector2(-3,0);
    }
    
    void OnBecameInvisible() {
        count = count + 1;
        if(count > 2){
            // solo una vez los reubicación a la derecha. para evitar que se mantengan demasiados en escena.
            Destroy(gameObject);
        }else{
            // le reduzco el tamaño al regresarlo a la escena.
            var scale = this.transform.localScale;
            scale.y /= 2;
            scale.x /= 2;
            this.transform.localScale = scale;
        }

    	body.position = new Vector2(9,rng.Next(-1,6));
     }

    // cuando lo impacto un disparo
    void OnCollisionEnter2D(Collision2D col){   
        Debug.Log(col.gameObject.tag);    
        if(col.gameObject.tag == "bala"){
            Destroy(col.gameObject);
            if(vida > 0){
                vida -= 1;
                var scale = this.transform.localScale;
                scale.y /= 2;
                scale.x /= 2;
                this.transform.localScale = scale;
            }else{
                Destroy(gameObject);
            }
            //col.gameObject.setActive(true);
        }
    }

}

