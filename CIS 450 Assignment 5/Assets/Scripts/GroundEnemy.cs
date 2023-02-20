/*
 * EJ Flores
 * GroundEnemy.cs
 * Assignment 5
 * This script handles the behavior of an enemy that is on the ground but cannot move.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : Enemy
{
    public override void attack()
    {
        attackText = "You have been attacked by a GroundEnemy.";
        updateUi();
    }

    public override void move()
    {

    }
}
