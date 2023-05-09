using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float MoveSpeed = 5;
    // Destroy the pipe when it goes off screen to the left
    //Cordinates of the left side of the screen
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe is off screen");
            Destroy(gameObject);
        }
    }
}
