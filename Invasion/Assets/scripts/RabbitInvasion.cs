using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitInvasion : MonoBehaviour
{

    [SerializeField] private GameObject rabbit = default;
    [SerializeField] private Transform rabbitParentTransform = default;
    [SerializeField] private float time = 1;
    private Transform rabbitTransform;

    // Start is called before the first frame update
    private void Awake()
    {
        rabbitTransform = transform;
        StartCoroutine(routine: DoSpawnRabbit());
    }

    private IEnumerator DoSpawnRabbit()
   {
      while (true)
    {
      yield return new WaitForSeconds(time);
      // do stuff
    GameObject rabbitBis=Instantiate(rabbit, rabbitTransform.position,Quaternion.identity,rabbitParentTransform);
      rabbitBis.GetComponent<Rigidbody>().velocity = rabbitTransform.forward; 
      rabbitBis.GetComponent<Rigidbody>().AddForce(rabbitTransform.forward * 100);
   }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
