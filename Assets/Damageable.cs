using System;
using UnityEngine;

public class Damageable : MonoBehaviour {
    public float Health => health;

    public event Action<float> Damaged;

    [SerializeField] private float health;

    public void TakeDamage(float amount) {
        health -= amount;
    }
}
