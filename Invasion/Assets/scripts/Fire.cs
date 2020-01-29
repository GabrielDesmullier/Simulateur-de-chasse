using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject ball = default;

    [SerializeField] private Transform ballsParentTransform = default;
    private Transform cameraTransform;
    [SerializeField] private float spawningForce = 1f;



    private void Awake()
    {
        cameraTransform = transform;
        
    }

    // Update is called once per frame

    public void fireBall()
    {

        GameObject projectile = Instantiate(ball, cameraTransform.position, Quaternion.identity, ballsParentTransform);
   
        projectile.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * spawningForce);

    }


}
