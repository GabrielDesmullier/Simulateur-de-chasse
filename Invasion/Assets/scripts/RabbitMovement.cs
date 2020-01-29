using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform rabbitTransform;
    [SerializeField] float speed=0.01f;
    void Start()
    {
        rabbitTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1, 30);
        if (number == 1)
        {
            int angle = Random.Range(-30, 30);
            rabbitTransform.rotation = Quaternion.Euler(0,rabbitTransform.rotation.eulerAngles.y + angle,0);
        }
        else
        {
            rabbitTransform.position += rabbitTransform.forward * speed;
        }

    }
}
