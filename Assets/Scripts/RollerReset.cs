using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerReset : MonoBehaviour
{

    Vector3 startPosition;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Ramp" & other.gameObject.tag != "Plane" & other.gameObject.tag != "Player")
        {
            transform.position = startPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
