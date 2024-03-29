// For core movement, copy line 9 & 44-66 and add to Update function

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int speed = 5;
    int jump = 10;
    //int i = 0;
    string greeting;
  // Initialize Rigidbody variable 
    Rigidbody rb1;
    
    int jumps = 0;



    // Start is called before the first frame update
    void Start()
    {
      // Access physics component from object in scene
        rb1 = this.GetComponent<Rigidbody>();
        
        // Change Object Color to Black
        //var renderer =  this.GetComponent<Renderer>();
        //renderer.material.SetColor("_Color", Color.black);

        
    }
    


    // Update is called once per frame
    void Update()
    {
        UserInput();
    }

    // User input function to be called in update
    void UserInput()
    {
        // Bind A key to left movement
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("left");
            // Move left
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("right");
            // Comment here
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward* speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
          transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) & jumps < 2)
        {
            rb1.AddForce(Vector3.up * jump, ForceMode.Impulse);
            jumps = jumps + 1;
        }

    }

    //
    public int fun1()
    {
        return 3;
    }

    
    // Called on collisions with colliders
    void OnCollisionEnter(Collision collisionFromEvent)
    {    
       // Variable game object from collision
      GameObject o = collisionFromEvent.gameObject;
      // Check object tag
      if (o.tag == "Finish")
      {
        Debug.Log("works!");
        jumps = 0;
      }
    }




    void OnTriggerEnter(Collider colliderFromEvent)
    {
      GameObject o = colliderFromEvent.gameObject;
      if (o.tag == "Finish")
      {
        Debug.Log("works!");
      }
    }
}
