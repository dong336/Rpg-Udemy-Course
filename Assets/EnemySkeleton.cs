using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySkeleton : Entity
{
    [Header("Move info")]
    [SerializeField] private float moveSpeed;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();

        if (!isGrounded || isWallDetected) Flip();

        rb.velocity = new Vector2(moveSpeed * facingDir, rb.velocity.y);
    }
}
