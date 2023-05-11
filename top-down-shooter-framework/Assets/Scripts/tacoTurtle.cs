using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tacoTurtle : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    float angle = 0.0f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("character").transform;
    }

    
    void Update()
    {
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            angle = angle + 1.0f;/*Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;*/
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D crash)
    {
        if(crash.gameObject.tag == "Player")
        {
            Application.Quit();
        }
    }
}
