using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
{
    transform.Rotate (0, 50*Time.deltaTime,0); //rotates 50 degrees per second around y axis
}
}