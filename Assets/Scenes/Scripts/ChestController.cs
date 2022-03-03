using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

    private Animator anim;
    // private BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        // collider = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        
    }

    // private void OnTriggerEnter(Collider other){
        
    //     if (anim != null && other.gameObject.transform.parent.name == "fingers") {
    //         anim.SetTrigger("TrOpen");
    //     }
    // }

    public void OpenChest() {
        Debug.Log("Open chest");
        anim.SetTrigger("TrOpen");
    }


    // Update is called once per frame
    void Update()
    {
    }
}
