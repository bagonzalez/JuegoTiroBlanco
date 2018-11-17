using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour {

    public GameObject puntaje;

	// Use this for initialization
	void Start () {
        Debug.Log("inicio");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
        Debug.Log("Colision Objeto" + collision.gameObject.name);

        if(collision.gameObject.tag == "bola"){
			Puntaje puntajeScript = puntaje.GetComponent<Puntaje>();
			puntajeScript.addPuntaje();
            
        }
	}
}
