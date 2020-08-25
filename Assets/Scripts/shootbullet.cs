using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{

    public GameObject Bullet;
    public float Bullet_Forward_Force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //The Bullet instantiation happens here.
            GameObject Bullet_Handler;
            Bullet_Handler = Instantiate(Bullet) as GameObject;
            Bullet.transform.position = transform.position;
            Bullet.transform.rotation = transform.rotation;
            Destroy(Bullet_Handler, 8.0f);
        }
    }
}
