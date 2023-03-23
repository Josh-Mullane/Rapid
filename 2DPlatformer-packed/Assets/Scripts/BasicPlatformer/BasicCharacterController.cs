using UnityEngine;
using System.Collections;

//--------------------------------------------
/*Basic Character Controller Includes:  
    - Basic Jumping
    - Basic grounding with line traces
    - Basic horizontal movement
 */
//--------------------------------------------

public class BasicCharacterController : MonoBehaviour
{
    protected bool facingRight = true;
    protected bool jumped;
    protected bool dashed;

    public float speed = 5.0f;
    public float jumpForce = 1000;
    public float dashForce = 10000;

    private float horizInput;

    public Transform groundedCheckStart;
    public Transform groundedCheckEnd;
    public bool grounded;

    public Rigidbody2D rb;
    public Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    private void Update()
    {
         if (Input.GetButtonDown("Jump") && grounded == true)
        {
            jumped = true;
            Debug.Log("Should jump");
        }

        if (rb.velocity.x != 0f)
        {
            //Debug.Log("Running");
            anim.SetBool("Running", true);
        }

        //if (Input.GetButtonDown("Jump") && grounded == false && facingRight)
        //{
        //    dashed = true;
        //    rb.velocity = new Vector2(10, 10);
        //    Debug.Log("Should dash");
        //}
        
        if (Input.GetButtonDown("Jump") && grounded == false && facingRight)
        {
            dashed = true;
            rb.velocity = rb.velocity * 2;
            Debug.Log("Should dash");
        }
    }

    void FixedUpdate()
    {
        //Linecast to our groundcheck gameobject if we hit a layer called "Level" then we're grounded
        grounded = Physics2D.Linecast(groundedCheckStart.position, groundedCheckEnd.position, 1 << LayerMask.NameToLayer("Level"));
        Debug.DrawLine(groundedCheckStart.position, groundedCheckEnd.position, Color.red);

        //Get Player input 
        horizInput = Input.GetAxis("Horizontal");
        //Move Character
        rb.velocity = new Vector2(horizInput * speed * Time.fixedDeltaTime, rb.velocity.y);

       

        if (jumped == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            Debug.Log("Jumping!");

            jumped = false;
        }
       


        // Detect if character sprite needs flipping
        if (horizInput > 0 && !facingRight)
        {
            FlipSprite();
        }
        else if (horizInput < 0 && facingRight)
        {
            FlipSprite();
        }

      
    }

    // Flip Character Sprite
    void FlipSprite()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
