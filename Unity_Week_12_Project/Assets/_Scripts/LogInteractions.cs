using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{

    // This is NOT a built-in script

    // Start is called before the first frame update

    public void LogHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log(gameObject.name + " Hover Enter by: " + args.interactorObject);
    }

     public void LogHoverExit(HoverExitEventArgs args)
    {
        Debug.Log(gameObject.name + " Hover Exit by: " + args.interactorObject);
    }

    public void LogSelect(SelectEnterEventArgs args) //not called Select
    {
        Debug.Log(gameObject.name + " Selected by: " + args.interactorObject);
    }

    public void LogDeselect(SelectExitEventArgs args) //not called deselect
    {
        Debug.Log(gameObject.name + " Deselected by: " + args.interactorObject);

    }
    
     public void LogActivate(ActivateEventArgs args)
    {
        Debug.Log(gameObject.name + " Activated by: " + args.interactorObject);
    }


     public void LogDeactivate(DeactivateEventArgs args)
     {
            Debug.Log(gameObject.name + " Deactivated by: " + args.interactorObject);
     }
    

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
