using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBullet : Moveable, IBullet
{
    public float speed = 10f;
    private Vector3 fwd;

    public void StartMovement(Vector3 direction) {
        fwd = direction;
    }

    protected override void ComputeVelocity()
    {
        var move = fwd * speed;
        targetVelocity = move;
    }
}
