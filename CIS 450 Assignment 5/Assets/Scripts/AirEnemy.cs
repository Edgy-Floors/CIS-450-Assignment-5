/*
 * EJ Flores
 * AirEnemy.cs
 * Assignment 5
 * This script handles the behavior of a flying enemy that cannot move from its position.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemy : Enemy
{
    public override void attack()
    {
        attackText = "You have been attacked by an AirEnemy.";
        updateUi();
    }

    public override void move()
    {

    }
}
