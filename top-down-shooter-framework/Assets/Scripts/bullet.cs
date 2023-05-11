using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    //private Vector3 mousePos;
    //private Camera MainCam;
    //private Transform bulletSpawn;

    //float RotZ;

    //public GameObject projectileOne;

    void Start()
    {
        //MainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //bulletSpawn = GameObject.FindGameObjectWithTag("bulletSpawn").GetComponent<Transform>();
    }

    
    void Update()
    {
        //mousePos = MainCam.ScreenToWorldPoint(Input.mousePosition);

        //Vector3 Rotation = mousePos - transform.position;

        //RotZ = Mathf.Atan2(Rotation.y, Rotation.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0, 0, RotZ);

        //if(Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(projectileOne, bulletSpawn.position, Quaternion.Euler(0, 0, RotZ));
        //}
    }
}
