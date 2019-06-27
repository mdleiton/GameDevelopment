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
    public int vidas = 2;

    private void Awake(){
        trans = this.transform;
    }

    // Start is called before the first frame update
    void Start(){  
        infoText.text = "Presione space : ";
    }

    // Update is called once per frame
    void Update(){
        SetCountText();
        var x = Input.GetAxis("Horizontal"); 
        var y = Input.GetAxis("Vertical"); 
    	body.velocity =  new Vector2(speed*x,speed *y);

        
        if(Input.GetKeyUp("space")){
            infoText.text = "";
            var position = body.position;
            GameObject obj = (GameObject) Instantiate(bala, new Vector3(position.x + 2.5f, position.y, -5), Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D col){       
        if(col.gameObject.tag == "meteoro"){
            infoText.text = "Perdiste una vida!!!!!";
            vidas--;
            Destroy(col.gameObject);
            if(vidas<=0){

                infoText.text = "Perdiste!!!!!";
                Destroy(gameObject);
            }
            SetCountText();
        }
    }

    void DestroyComponent(){
        Destroy(GetComponent<Rigidbody2D>());
    }

    void SetCountText (){
        puntajeText.text = "Puntaje: " + puntaje.ToString();
        vidaText.text = "Vidas: " + vidas.ToString();

        if (puntaje >= 10){
            infoText.text = "Ganaste!";
        }
    }
}
