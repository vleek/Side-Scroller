﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Damage = 40;
    public float speed = 20f;
    public Rigidbody2D rb;
    private object hitInfo;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Damaging(Damage);
        }
        Destroy(gameObject);
    }
}

    
 
