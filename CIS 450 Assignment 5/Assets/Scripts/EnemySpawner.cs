/*
 * EJ Flores
 * EnemySpawner.cs
 * Assignment 5
 * This script spawns an enemy, calling the EnemyFactory method to create an enemy.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemySpawner; 

    public void spawnEnemy()
    {
        Enemy g = EnemyFactory.createEnemy();
        Instantiate(g, enemySpawner.transform);
    }
}
