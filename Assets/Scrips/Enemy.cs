using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int Health = 100;

    private GameObject deatheffect;

    public void Damaging (int Damage)
    {
        Health -= Damage;

        if (Health <= 0)
        {
            Die ();
        }

    }
    void Die ()
    {
        Destroy(gameObject);
    }
}
