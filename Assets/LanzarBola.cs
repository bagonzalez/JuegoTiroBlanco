using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBola : MonoBehaviour {

    public GameObject bola;
    public float velocidadBola;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))
		{
			GameObject playerCamera = GameObject.Find("FirstPersonCharacter");
		
			GameObject nuevaBola = Instantiate(bola);
			nuevaBola.transform.position = playerCamera.transform.position;
			nuevaBola.transform.rotation = new Quaternion(0.0f, playerCamera.transform.rotation.y, 0.0f, playerCamera.transform.rotation.w);
			Rigidbody nuevobody = nuevaBola.GetComponent<Rigidbody>();
			nuevobody.velocity = playerCamera.transform.forward * velocidadBola;

            GameObject disparo = GameObject.Find("Disparo");
            AudioSource audioSource = disparo.GetComponent<AudioSource>();
            audioSource.Play();
			GameObject bullets = GameObject.Find("bullets");
			AudioSource bulletsSource = bullets.GetComponent<AudioSource>();
			bulletsSource.Play();
			
        }	
		
	}
}
