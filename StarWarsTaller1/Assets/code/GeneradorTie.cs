using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTie : MonoBehaviour{
    public GameObject prefabs;
	System.Random rng = new System.Random();
	int count = 0;

    // Start is called before the first frame update
    void Start(){
        //Instantiate(prefabs, new Vector3(9, rng.Next(-1,6), -5), Quaternion.identity);
    }

    void Update(){
        count += 1;
        if(count==500){ // para que se genere uno nuevo cada 4 segundos.
        	//Instantiate(prefabs, new Vector3(9, rng.Next(-1,6), -5), Quaternion.identity);
        	count= 0;
        }
    }
}
