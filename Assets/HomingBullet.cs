using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBullet : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 10f);
    private Transform target;

    public void SetTarget(Transform target) {
        this.target = target;
    }

    private void Update()
    {
        var direction = target.position - transform.position;
        var move = direction.normalized;
        move.x *= speed.x;
        move.y *= speed.x;
        move.z *= speed.y;

        var deltaPosition = move * Time.deltaTime;
        var distance = deltaPosition.magnitude;
        transform.position += deltaPosition.normalized * distance;
    }
}
