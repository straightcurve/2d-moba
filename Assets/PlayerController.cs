using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ForwardBulletSpawner spawner;

    public Vector3 facingDirection;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            spawner.Spawn();

        // facingDirection
    }
}
