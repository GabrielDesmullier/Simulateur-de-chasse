using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RabbitDeath : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject blood;
    [SerializeField] private GameObject rabbitDeath;
    [SerializeField] private Transform bloodParent=default;
    private Transform rabbitTransform;
    


    private void Awake()
    {
        rabbitTransform = transform;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log(message: "Rabbit Killed!");
            
            for (int count = 0; count< 100; count++) {
                GameObject bloodEffect = Instantiate(blood, rabbitTransform.position, Quaternion.identity, bloodParent);
             
                //Essai explosif ? bloodEffect.GetComponent<Rigidbody>().AddExplosionForce(100000, gameObject.transform.position, 100);
            }
            Instantiate(rabbitDeath, rabbitTransform.position,Quaternion.Euler(5,Random.Range(0,360),85), bloodParent);
            Destroy(gameObject);
        }
    }


    void Update()
    {

    }
}
