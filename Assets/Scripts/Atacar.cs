using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    Animator animator;
    public GameObject puntaje;
    public float puntajeValor = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("este es un start");
         animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("este es un update");
        //animator.Play("");

        puntajeValor = (puntaje.GetComponent<Puntaje>()).puntaje;
        
    }

     void OnCollisionEnter(Collision col) {
         Debug.Log("ocurrio una colision");
         animator.SetBool("atacar", true);

         if(puntajeValor > 2){
             animator.SetBool("morir", true);
         }

         Debug.Log(puntajeValor);

    }
}
