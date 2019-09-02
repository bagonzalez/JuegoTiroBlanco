using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public float puntaje = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addPuntaje(){
        this.puntaje++;
        GameObject canvas = GameObject.Find("Canvas");
        GameObject textobj = canvas.transform.Find("Text").gameObject; 
        Text texto = textobj.GetComponent<Text>();
        texto.text = "Puntos: "+this.puntaje;

	}



}
