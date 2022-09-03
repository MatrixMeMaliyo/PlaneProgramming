using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 initDistance;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        initDistance = this.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //follow player wherever he goes
        transform.position = player.transform.position + initDistance;
    }
}
