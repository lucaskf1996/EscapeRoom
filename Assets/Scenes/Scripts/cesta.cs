using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cesta : MonoBehaviour
{

    GameObject bau;
    private int contador;
    // Start is called before the first frame update
    void Start()
    {
        bau = GameObject.FindGameObjectWithTag("bau");
        Debug.Log(bau);
        contador = 0;
    }


    private void OnTriggerEnter(Collider other){
        Debug.Log(other.name);
        if (other.tag == "bola") {
            Debug.Log("Entrei no cesta on trigger");
            contador++;
            if (contador == 1){
                bau.GetComponent<ChestController>().OpenChest();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
