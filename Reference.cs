/* 
Charles Quest Jones 
C# for Unity Reference Script

5 Main Coding Structures:
Comment
Statement (Every line of code is a statement)
Variables
Loops
Functions

*/

// Statements to import classes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    // Variable int i & n examples
    public int i = 1;
    int n = Random.Range(0,50);

    /*

    Array vs ArrayList

    */

    //int array
    int[] b = {1,2};
    // Matrix = array of arrays
    int[][] m1 = {{12,3}, {7,11}};
    // ArrayList
    List<int> L1 = {1,3,5,2,3};

    Vector3 a = new Vector3(0,0,0);



    

    // Start event function/method executes once at the beginning of the scene
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }

        // loops
        for(int i = 0; i < 7; i++)
        {
        
        }

        while (i < 10)
        {

        }

    }

    // Update happens once per frame approx 30-60 times/sec
    void Update()
    {

    }

    // Also has Over, Drag
    void OnMouseDown()
    {

    }

    // Also OT has Stay, Exit
    void OnTriggerEnter(Collider colliderFromEvent)
    {

    }

    // Also OC has Stay, Exit
    void OnCollisionEnter(Collision collisionFromEvent)
    {
        //Vector3 p = collisionFromEvent.gameObject.transform.position;
    }
}
