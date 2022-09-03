using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public float rotateAngle, difference = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rotateAngle += difference;
        // rotate propeller
        transform.Rotate(Vector3.forward, Time.deltaTime * rotateAngle);
    }
}
