using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyCop : MonoBehaviour
{
    #region
    [Header("CheckTheChasingArea")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;

    [Header("EnemyCopHP"), Range(0, 20)]
    public int EnemyCop_HP = 10;

    [Header("EnemyCopDamage"), Range(0, 10)]
    public int EnemyCop_ATK = 5;

    [Header("EnemyCopMoveSpeed"), Range(0, 5)]
    public int EnemyCop_MoveSpeed = 3;

    [Header("IsEnemyCopAttacking")]
    public bool EnemyCopIsAttacking = false;

    [Header("IsEnemyCopJumping")]
    public bool EnemyCopIsJumping = false;

    [Header("TargetLayer")]
    public LayerMask layerTarget;
    #endregion

    
}
