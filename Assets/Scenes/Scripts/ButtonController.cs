using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    GameObject BolaSpawner;
    // Start is called before the first frame update
    void Start()
    {
        BolaSpawner = GameObject.FindGameObjectWithTag("BolaSpawner");
        GetComponent<Collider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other){
        BolaSpawner.GetComponent<BolaSpawner>().Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
