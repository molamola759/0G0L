using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region

    [Header("PlayerHealth")]
    public int Player_HP = 5;
    [Header("PlayerATK")]
    public int Player_ATK = 1;
    [Header("PlayerMoveSpeed")]
    public int Player_MoveSpeed = 5;
    [Header("PlayerJumpHeight")]
    public float Player_JumpHeigh = 250;
    [Header("Is Player Attacking")]
    [Tooltip("False P not Attack, Ture P Attacking")]
    public bool PlayerIsAttacking = false;
    [Header("Is Player Jumping")]
    [Tooltip("False on the Ground, True in the Air")]
    public bool PlayerisGround = false;
    [Header("Gizmos Circle Setting")]
    [Tooltip("Circle Radius")]
    public float CircleRadius = 0.25f;
    [Tooltip("Center of Circle")]
    public Vector3 CenterOfCircle;
    public LayerMask Ground;

    #endregion

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator animator;

    //#region method

    public void CheckGround()
    {
        Collider2D isGround = Physics2D.OverlapCircle(transform.position + CenterOfCircle, CircleRadius, Ground);
        PlayerisGround = isGround;
    }

    public void Player_Jumping()
    {
        if (PlayerisGround && Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector2(0, Player_JumpHeigh));
            animator.SetBool("Jump", true);
            print(animator.GetBool("Jump"));
            print("in air ");
        }
        if (PlayerisGround)
        {

            animator.SetBool("Jump", false);
        }


    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawSphere(transform.position + CenterOfCircle, CircleRadius);
    }

    public void Player_Move_Ctrl()
    {
        float Horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(Horizontal * Player_MoveSpeed * 2, rb.velocity.y);
            
        }
        else
        {
            rb.velocity = new Vector2(Horizontal * Player_MoveSpeed, rb.velocity.y);
                    
        }

        if (Horizontal < 0)
        {
            sr.flipX = true;
        }
        else if (Horizontal > 0)
        {
            sr.flipX = false;
        }

        if (Horizontal != 0)
        {
            animator.SetBool("WalkONOFF", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("RunONOFF", true);
            }
            else
            {
                animator.SetBool("RunONOFF", false);
            }
        }
        else
        {
            animator.SetBool("RunONOFF", false);
            animator.SetBool("WalkONOFF", false);
        }
    }

    private void FixedUpdate()
    {
        Player_Move_Ctrl();
        Player_Jumping();
        CheckGround();
    }

}