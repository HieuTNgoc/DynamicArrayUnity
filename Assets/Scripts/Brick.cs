using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour, IDamageable
{
    [SerializeField] private int _strength = 1;

    public void TakeDamage(int damage)
    {
        _strength -= damage;
        if (_strength <= 0) Destroy(gameObject);
    }
}