using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapforce;
    public LogicScript logic;
    public bool birdisAlive = true;
    public float lowerBound = -18;
    public float upperBound = 18;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Updating the BirdScript");
        if (Input.GetKeyDown(KeyCode.Space) && birdisAlive)
        {
            Debug.Log("Space key pressed");
            myRigidbody.velocity = Vector2.up * flapforce;
        }

         // If the bird falls off the screen or goes above the screen, game over
        if (transform.position.y < lowerBound || transform.position.y > upperBound)
        {
            logic.gameOver();
            //destroy the bird
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisAlive = false;
    }

}