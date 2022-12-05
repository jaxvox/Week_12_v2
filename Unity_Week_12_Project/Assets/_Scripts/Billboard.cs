using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void LateUpdate()
    {

        transform.LookAt(player.transform.position);
        
    }
}
