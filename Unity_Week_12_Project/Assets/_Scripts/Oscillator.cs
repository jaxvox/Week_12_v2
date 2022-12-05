using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    //NOTE: The oscillating object will not follow the bounds if it is not oriented with its axes to match World Space! 


    [Header("Movement Parameters")]
    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;
    public bool active;

    [Header("Movement Posistions")]
    public Vector3 startingPosition;
    public Vector3 posEnd;
    public Vector3 negEnd;

    private Vector3 direction;
    private AudioSource audioSource;

    [Header("Audio")]
    public AudioClip enemySFX;


    // Start is called before the first frame update
    void Start()
    {
        //direction of movement
        direction = movementAxis.normalized;

        //precompute positions
        startingPosition = transform.position;
        posEnd = startingPosition + (direction * movementDistance);
        negEnd = startingPosition - (direction * movementDistance);

        //Deactivate Enemy Movement and initialize audio
        active = false;
        audioSource = GetComponent<AudioSource>();


    }


    public void MakeActive()
    {
        active = true;
        audioSource.PlayOneShot(enemySFX);
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {
        if (active == true)
        {
            transform.Translate(direction * movementSpeed * Time.deltaTime);
            

            if (Vector3.Distance(transform.position, posEnd) < 0.01f || Vector3.Distance(transform.position, negEnd) < 0.01f)
            {
                direction *= -1;
            }
        }
        /*
        if (gameObject.tag !="Oscillator Stack")
        {
            transform.Translate(direction * movementSpeed * Time.deltaTime);
        } */

        
        
        
    }
}
