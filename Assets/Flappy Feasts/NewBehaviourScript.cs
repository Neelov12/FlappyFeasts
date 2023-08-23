using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float flapStrength;
    
    public bool birdAlive = true;
    public GameObject gameOverObject;

    private LogicScript logic;
    private PATransButtonBehaviourScript play_again_script; 

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            myRigidBody2D.velocity = Vector2.up * flapStrength;
            //Console.Write(myRigidBody2D.GetPointVelocity); 
        }
        logic.changeWing();
        if (gameOverObject.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) == true && !birdAlive)
            {
                logic.restartGame(); 
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.gameOver();        
    }
}
