using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{

    private Camera MainCam;
    private Rigidbody2D RB;
    public float Force;

 

    void Start()
    {
        MainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = transform.right * Force;
        Invoke("destroyBullet", 10);
    }

   
    void Update()
    {
        
    }

    void destroyBullet()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D death)
    {
        if(death.gameObject.tag == "enemy")
        {
            Destroy(death.gameObject);
            destroyBullet();
            
        }
    }
}
