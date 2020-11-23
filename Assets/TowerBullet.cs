using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    private Transform target;
    private float damage;

    public TowerBullet SetTarget(Transform target) {
        this.target = target;
        return this;
    }

    public TowerBullet SetDamage(float damage) {
        this.damage = damage;
        return this;
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.transform != target)
            return;

        var damageable = col.gameObject.GetComponent<Damageable>();
        damageable.TakeDamage(damage);

        Destroy(gameObject);
    }
}
