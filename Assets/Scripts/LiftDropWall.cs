using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftDropWall : MonoBehaviour
{
    float upwardSpeed = 1f;
    float maxYPosition = 4.5f;
    float minYPosition = 1.5f;

    bool goingUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp)
        {
            transform.Translate(Vector3.up * upwardSpeed * Time.deltaTime);

            if (transform.position.y >= maxYPosition)
            {
                goingUp = false;
            }

        }
        else
        {
            transform.Translate(Vector3.down * upwardSpeed * Time.deltaTime);

            if (transform.position.y <= minYPosition)
            {
                goingUp = true;
            }
        }

    } 
}
