using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{

    public float cooldown = 1f;
    public float range = 5f;
    public float damage = 10f;
    public Damageable damageable;


    private float currentTime;

    void Update() {
        if (currentTime < 1f) {
            currentTime += Time.deltaTime;
            return;
        }

        var unit = GetDamageableInRange();
        if (unit == null)
            return;

        currentTime = 0f;

        Spawn(unit.transform);
    }

    Damageable GetDamageableInRange() {
        return damageable;
    }


    public Transform initialPosition;
    public GameObject prefab;

    public void Spawn(Transform target) {
        var bullet = Instantiate(prefab).GetComponent<HomingBullet>();
        bullet.transform.position = initialPosition.position;
        bullet.SetTarget(target);

        var towerBullet = bullet.GetComponent<TowerBullet>();
        towerBullet.SetTarget(target);
        towerBullet.SetDamage(damage);
    }
}
