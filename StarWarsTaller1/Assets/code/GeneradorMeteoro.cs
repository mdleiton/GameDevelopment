using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GeneradorMeteoro : MonoBehaviour{
	public GameObject prefabs;
	System.Random rng = new System.Random();
	int count = 0;

    // Start is called before the first frame update
    void Start(){
        Instantiate(prefabs, new Vector3(1, rng.Next(-1,6), -5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update(){
        count += 1;
        if(count==240){
        	Instantiate(prefabs, new Vector3(1, rng.Next(-1,6), -5), Quaternion.identity);
        	count= 0;
        }
    }
}
