using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private float vertical;
    private float speed = 5f;
    private bool isLadder;
    public bool isClimbing = false;

    private Animator animator;

    [SerializeField] private Rigidbody2D rb;

   
    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
            //animator.SetBool("Climb", true);
       
        }
        else
        {
            rb.gravityScale = 1f;
            //animator.SetBool("Climb", false);

        }

    }

    public void Player_Climbing()
    {
        if (isClimbing && Input.GetButton("Vertical"))
        {
            animator.SetBool("Jump", false);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;

        }
            
    }
}
