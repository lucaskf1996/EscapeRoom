using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

    private Animator anim;
    private BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("AAAAAAAAAAAAAAAAA");
        collider = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log("Colidiu!");

        if (anim != null) {
            anim.SetTrigger("TrOpen");
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}
