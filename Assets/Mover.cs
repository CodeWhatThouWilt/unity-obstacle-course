using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float yValue = 0.001f;
    // [SerializeField] float zValue = 0;

    [SerializeField] float moveSpeed = 7;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Allow for getting input via input manager in project settings
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Move the object
        transform.Translate(xValue, yValue, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use A and D keys to move side to side");
        Debug.Log("Use W and S keys to move forward and backward");
        Debug.Log("Don't hit the walls");
    }
}
