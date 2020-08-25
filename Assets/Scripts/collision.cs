using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject small_asteroid;
    public GameObject medium_asteroid;
    public GameObject big_asteroid;

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "big_asteroid")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("big_asteroidbig_asteroid");
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
