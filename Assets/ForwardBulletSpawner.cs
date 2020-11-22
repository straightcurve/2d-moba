using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBulletSpawner : MonoBehaviour
{
    public Transform parent;
    public Transform initialPosition;
    public GameObject prefab;

    public void Spawn() {
        var bullet = Instantiate(prefab).GetComponent<IBullet>();

        bullet.transform.position = initialPosition.position;
        
        bullet.StartMovement(parent.right * -1);
    }
}
