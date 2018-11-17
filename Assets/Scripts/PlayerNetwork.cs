using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerNetwork : NetworkBehaviour {

    public GameObject firstPersonCharacter;
    public GameObject[] characterModel;

    public override void OnStartLocalPlayer(){
        //base.OnStartLocalPlayer();

        GetComponent<FirstPersonController>().enabled = true;

    }
}
