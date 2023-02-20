/*
 * EJ Flores
 * FlyingEnemy.cs
 * Assignment 5
 * This script handles the behavior of a flying enemy that can track the player.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemy
{
    public Transform player;
    public float speed = 3.0f;

    public override void attack()
    {
        attackText = "You have been attacked by a Flying Enemy.";
        updateUi();
    }

    public override void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            attack();
        }
    }
}
