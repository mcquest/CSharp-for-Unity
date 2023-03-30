using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public int speed = 9;
    public int turnSpeed = 60;

    Rigidbody rb;

    public int jump = 1000;
    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back*(speed-4)*Time.deltaTime);
        }

         // Rotate cam around user
        // Clockwise
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            
            this.transform.RotateAround(transform.position, Vector3.up, -turnSpeed*Time.deltaTime);
            

     
        }

        // Counterclockwise 
        if(Input.GetKey(KeyCode.RightArrow))
        {
           
            this.transform.RotateAround(transform.position, Vector3.up, turnSpeed*Time.deltaTime);
            

        }
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Translate(Vector3.up*jump*Time.deltaTime);
             rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            
        }
        */
    }
}
