using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardManager : MonoBehaviour
{

    //public GameObject keycard;
    public GameObject keycard;


    // Start is called before the first frame update
    void Start()
    {
       // Rigidbody rb = keycard.GetComponent<Rigidbody>();
    }

  

    public void HoldKeycard()
    {
        Rigidbody rb = keycard.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
        keycard.GetComponent<Rotator>().enabled = false;
    }

    public void DropKeycard()
    {
        Rigidbody rb = keycard.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
        keycard.GetComponent<Rotator>().enabled = true;
    }


}
