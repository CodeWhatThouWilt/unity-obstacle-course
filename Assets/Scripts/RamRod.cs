using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamRod : MonoBehaviour
{
    float startPosition = -22.7f;
    float endPosition = -9.66f;
    [SerializeField] float outSpeed = 20f;
    [SerializeField] float inSpeed = 5f;

    bool isOut = false;
    bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((int)Time.time);
        if ((int)Time.time % 10 == 0)
        {
            isMoving = true;
        }

        if (!isOut & isMoving)
        {
            transform.Translate(Vector3.up * outSpeed * Time.deltaTime);

            if (transform.position.z >= endPosition)
            {
                isOut = true;
            }
        }
        else if (isOut & isMoving)
        {
            transform.Translate(Vector3.down * inSpeed * Time.deltaTime);

            if (transform.position.z <= startPosition)
            {
                isOut = false;
                isMoving = false;
            }
        }
    }
}
