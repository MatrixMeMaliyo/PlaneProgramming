using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float maxSpeed = 20.0f;
    public float rotateSpeed, verticalInput, horizontalInput;
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if(speed <= maxSpeed)
        {
            speed++;
        }

        //give the plane speed
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
    }
}
