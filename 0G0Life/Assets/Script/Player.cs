using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("PlayerHP"), Range(0, 100)]
    public int Player_HP = 100;

    [Header("PalyerDamage"), Range(0, 10)]
    public int Player_ATK = 5;

    [Header("PlayerMoveSpeed"), Range(0, 10)]
    public int Player_MoveSpeed = 5;

    [Header("IsPlayerAttacking")]
    public bool PlayerIsAttacking = false;

    [Header("IsPlayerJumping")]
    public bool PlayerIsJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
