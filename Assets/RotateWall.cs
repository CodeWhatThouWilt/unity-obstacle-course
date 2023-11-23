using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWall : MonoBehaviour
{


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationSpeed = 30f;
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationThisFrame, 0);
    }
}
