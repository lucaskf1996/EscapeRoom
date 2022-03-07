using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cesta : MonoBehaviour
{

    private GameObject bau;
    private GameObject lockObj;
    private int contador;
    // Start is called before the first frame update
    void Start()
    {
        bau = GameObject.FindGameObjectWithTag("bau");
        lockObj = GameObject.FindGameObjectWithTag("lock");
        contador = 0;
    }


    private void OnTriggerEnter(Collider other){
        if (other.tag == "bola") {
            Debug.Log("Entrei no cesta on trigger");
            contador++;
            if (contador == 1){
                bau.GetComponent<ChestController>().OpenChest();
                bau.GetComponent<AudioSource>().Play();
                Destroy(lockObj);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
