using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "bola"){
            GameObject.FindGameObjectWithTag("button").GetComponent<Collider>().enabled = true;
            GameObject.FindGameObjectWithTag("button").GetComponent<AudioSource>().Play();
            Destroy(GameObject.FindGameObjectWithTag("cap"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
