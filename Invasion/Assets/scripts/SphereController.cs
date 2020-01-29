using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SphereController : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);  
    }

    private void OnCollisionStay(Collision collision)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionExit(Collision collision)
    {
        throw new NotImplementedException();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
