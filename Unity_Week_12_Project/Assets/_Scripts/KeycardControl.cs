using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardControl : MonoBehaviour
{
    //public GameObject keycard;
    public GameObject keycard;
    Rigidbody rb;
    private AudioSource audioSource;
    public AudioClip pickupSFX;

    // Start is called before the first frame update
    void Start()
    {
         rb = keycard.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }



    public void HoldKeycard()
    {
        rb.useGravity = false;
        rb.isKinematic = false;
        keycard.GetComponent<Rotator>().enabled = false;
        audioSource.PlayOneShot(pickupSFX);
    }

    public void DropKeycard()
    {
        /* This section if you want dropped object to not spin and fall to ground
         * rb.useGravity = true;
        rb.isKinematic = false;
        keycard.GetComponent<Rotator>().enabled = false; */

        rb.useGravity = false;
        rb.isKinematic = true;
        keycard.GetComponent<Rotator>().enabled = true;
        //Above section is for dropped object to float where dropped and continue spinning

    }

}
