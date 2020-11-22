using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour, IMoveable
{
    protected Rigidbody rb;
    protected Vector3 velocity;
    protected Vector3 targetVelocity;
    private Vector3 delta;
    private Vector3 groundNormal = new Vector3(0f, 1f, 0f);

    protected virtual void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void FixedUpdate() {
        velocity.x = targetVelocity.x;
        velocity.z = targetVelocity.z;

        var deltaPosition = velocity * Time.deltaTime;
        var moveAlongGround = new Vector3(groundNormal.y, -groundNormal.x, groundNormal.y);
        moveAlongGround.x *= deltaPosition.x;
        moveAlongGround.z *= deltaPosition.z;

        var moveTo = moveAlongGround;
        Debug.DrawLine(transform.position, transform.position + moveAlongGround, Color.green);
        Move(moveTo);
    }

    protected virtual void Update()
    {
        Debug.DrawLine(transform.position, transform.position + groundNormal, Color.red);
        targetVelocity = Vector3.zero;
        ComputeVelocity();
    }

    protected virtual void ComputeVelocity() { }

    public void Move(Vector3 delta) {
        var distance = delta.magnitude;

        rb.position += delta.normalized * distance;
    }
}
