using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelWakeAnimTrigger : MonoBehaviour
{

    public Animator Celimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
        // Destroy everything that leaves the trigger
        Celimator.SetBool("BackSleep", true);
        Celimator.SetBool("CelWake", false);
        }
    }
}