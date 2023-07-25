using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");

        //Deletes whatever collides with the object
        //collision.gameObject.SetActive(false);

        //Deletes the object the script is connected with
        //gameObject.SetActive(false);

        //Grabs component from another script on hit
        // collision.gameObject.GetComponent<PlayerMovement>().

        //Condition for when it hits an onject with 'player tag
        if (collision.gameObject.tag == "Player")
        {
           
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
