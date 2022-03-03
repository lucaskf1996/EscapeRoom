using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DoorController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CircularDrive>().enabled = false;
    }

    private void OnTriggerEnter(Collider other){

        if (other.tag == "chave"){
            GetComponent<CircularDrive>().enabled = true;
            Destroy(GameObject.FindGameObjectWithTag(other.tag));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
