using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnd_Detector : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            enemy.SendMessage("MakeActive");
        }

    }
}
