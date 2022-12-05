using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardTester : MonoBehaviour
{
    [Header("Text")] 
    public GameObject wrongKeyCardText;
    public bool wrongKeyCardAlertActive;
    public GameObject insertKeyCardText;

    [Header("Other")]
    public GameObject door;
    public GameObject doorlock;
    private MeshRenderer doorMesh;
    private MeshRenderer lockMesh;
    private BoxCollider doorCollider;
    private BoxCollider lockCollider;

    [Header("Audio")]
    private AudioSource audioSource;
    public AudioClip negativeSFX;
    public AudioClip positiveSFX;

    

    // Start is called before the first frame update
    void Start()
    {
        wrongKeyCardText.SetActive(false);
        wrongKeyCardAlertActive = false;
        audioSource = GetComponent<AudioSource>();
        doorMesh = door.GetComponent<MeshRenderer>();
        doorCollider = door.GetComponent<BoxCollider>();
        lockMesh = doorlock.GetComponent<MeshRenderer>();
        lockCollider = doorlock.GetComponent<BoxCollider>();

    }



    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("key_blue_yellow"))
        {
            if (!wrongKeyCardText.activeInHierarchy && !wrongKeyCardAlertActive)
            {
                insertKeyCardText.SetActive(false);
                wrongKeyCardText.SetActive(true);
                wrongKeyCardAlertActive = true;
                audioSource.PlayOneShot(negativeSFX);
                StartCoroutine("WaitAndHide");
            }
        }

        if (other.CompareTag("key_red"))
        {
            doorMesh.enabled = false;
            lockMesh.enabled = false;
            doorCollider.enabled = false;
            lockCollider.enabled = false;
            audioSource.PlayOneShot(positiveSFX);
        }

    }

    IEnumerator WaitAndHide()
    {
        yield return new WaitForSeconds(2);
        wrongKeyCardText.SetActive(false);
        wrongKeyCardAlertActive = false;

    }
    


}
