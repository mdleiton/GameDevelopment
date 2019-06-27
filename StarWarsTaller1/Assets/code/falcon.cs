using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class falcon : MonoBehaviour{

    public Rigidbody2D body;
    public float speed = 10f;
    public GameObject bala;
    public Transform trans;
    public Text puntajeText;
    public Text vidaText;
    public Text infoText;
    public int puntaje = 0;

    private void Awake(){
        trans = this.transform;
    }


    // Start is called before the first frame update
    void Start(){  
        
    }

    // Update is called once per frame
    void Update(){
        var x = Input.GetAxis("Horizontal"); 
        var y = Input.GetAxis("Vertical"); 
    	body.velocity =  new Vector2(speed*x,speed *y);


        if(Input.GetKeyUp("space")){
            Debug.Log("presiono space");
            var position = body.position;
            GameObject obj = (GameObject) Instantiate(bala, new Vector3(position.x + 2.5f, position.y, -5), Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
        }
    }


    void OnCollisionEnter2D(Collision2D col){       
        if(col.gameObject.tag == "meteoro"){
            puntaje++;
            Destroy(col.gameObject);
            Destroy(gameObject);
            //SetCountText();
            //col.gameObject.setActive(true);
        }
    }

    void DestroyComponent(){
        // Removes the rigidbody from the game object
        Destroy(GetComponent<Rigidbody2D>());
    }

    void SetCountText (){
        puntajeText.text = "Puntaje: " + puntaje.ToString();
        if (puntaje >= 20){
            infoText.text = "Ganaste!";
        }
    }
}
