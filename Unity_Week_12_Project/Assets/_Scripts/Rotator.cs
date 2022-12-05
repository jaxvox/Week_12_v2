using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public GameObject testing;

    [Header("Rotation Controls")]

    [Tooltip("Speed of rotation in degrees/frame")]
    [SerializeField] float rotationSpeed;

    [Tooltip("The axis around which the gameobject rotates")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.Self) ;
        
    }
}
