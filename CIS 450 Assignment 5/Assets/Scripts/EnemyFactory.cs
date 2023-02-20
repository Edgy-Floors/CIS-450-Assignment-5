/*
 * EJ Flores
 * EnemyFactory.cs
 * Assignment 5
 * This code handles which enemy needs to spawn at any given point.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public static Enemy createEnemy()
    {
        int i = Random.Range(1, 5);

        if(i == 1)
        {
            return new AirEnemy();
        } else if(i == 2)
        {
            return new GroundEnemy();
        } else if(i == 3)
        {
            return new WalkingEnemy();
        } else if(i == 4)
        {
            return new FlyingEnemy();
        }
        return null;
    }
}
