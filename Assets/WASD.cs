using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : Moveable
{
    public Vector2 speed = new Vector2(5f, 10f);
    private SpriteRenderer spriteRenderer;

    protected override void OnEnable() {
        base.OnEnable();

        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

    }

    protected override void ComputeVelocity()
    {
        var move = Vector3.zero;

        move.x = Input.GetAxis("Horizontal") * speed.x;
        move.z = Input.GetAxis("Vertical") * speed.y;

        // if (Input.GetButtonDown("Jump") && grounded) {
        //     velocity.y = jumpTakeOffSpeed;
        // } else if (Input.GetButtonUp("Jump")) {
        //     if (velocity.y > 0)
        //         velocity.y *= .5f;
        // }

        var shouldFlip = (spriteRenderer.flipX ? (move.x > .01f) : (move.x < .01f));
        if (shouldFlip)
            spriteRenderer.flipX = !spriteRenderer.flipX;

        // animator.SetFloat("speed", Mathf.Abs(velocity.x) / maxWalkSpeed);

        targetVelocity = move;
    }
}
