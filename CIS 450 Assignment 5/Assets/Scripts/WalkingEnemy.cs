/*
 * EJ Flores
 * WalkingEnemy.cs
 * Assignment 5
 * This script handles the behavior of an enemy that can walk towards a player.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : Enemy
{
    public Transform player;
    public float speed = 3.0f;

    public override void attack()
    {
        attackText = "You have been attacked by a WalkingEnemy.";
        updateUi();
    }

    public override void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
