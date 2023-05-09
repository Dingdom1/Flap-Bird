using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // Find the LogicScript component on the Logic game object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // When the player collides with the pipe, increase the score
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bird has collided with the gap 
        if (collision.gameObject.layer == 3)
        {
            // Increase the score by 1 can be changed
            logic.addScore(1);
        }
    }
}
