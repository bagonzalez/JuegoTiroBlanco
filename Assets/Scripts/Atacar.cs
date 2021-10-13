using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    Animator animator;

    public GameObject puntaje;
    public Transform player;

    public float puntajeValor = 0.0f;

    public int vida = 10;

    public float velocidad = 10f;
    Rigidbody rig;
    public bool muerto = false;

    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("este es un start");
         animator = GetComponent<Animator>();
         rig = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("este es un update");

        puntajeValor = (puntaje.GetComponent<Puntaje>()).puntaje;

        if(!muerto){
            Vector3 pos = Vector3.MoveTowards(transform.position, player.position, velocidad * Time.fixedDeltaTime);
            rig.MovePosition(pos);
            transform.LookAt(player);
        }        
        
    }

     void OnCollisionEnter(Collision col) {
         Debug.Log("ocurrio una colision");
         animator.SetBool("atacar", true);

         if(col.gameObject.tag == "bola"){
            vida = vida - 1;

            if(vida <= 0){
                animator.SetBool("morir", true);
                this.muerto = true;
            }

			//Puntaje puntajeScript = puntaje.GetComponent<Puntaje>();
			//puntajeScript.addPuntaje();            
        }	

        /* if(puntajeValor > 2){
             animator.SetBool("morir", true);
         }*/

         Debug.Log(puntajeValor);

    }
}
