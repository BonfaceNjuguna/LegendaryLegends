using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -10) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -60, 0) * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
        }
    }
}
