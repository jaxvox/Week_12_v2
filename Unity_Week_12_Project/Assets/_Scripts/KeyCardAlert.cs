using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardAlert : MonoBehaviour
{
    public GameObject insertKeyCardText;
    private bool insertKeyCardAlertPlayed;

    // Start is called before the first frame update
    void Start()
    {
        insertKeyCardText.SetActive(false);
        insertKeyCardAlertPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if (!insertKeyCardText.activeInHierarchy && !insertKeyCardAlertPlayed)
            {
                insertKeyCardText.SetActive(true);
                insertKeyCardAlertPlayed = true;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        insertKeyCardText.SetActive(false);
    }


}
