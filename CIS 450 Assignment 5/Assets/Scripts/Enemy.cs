/*
 * EJ Flores
 * Enemy.cs
 * Assignment 5
 * This script acts as the base abstract class for all of the enemies.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Enemy : MonoBehaviour
{
    public TextMeshPro p;
    public TextMeshPro a;
    public string text;
    public string attackText;

    public abstract void attack();

    public abstract void move();

    public void updateUi()
    {
        p.text = text;
        a.text = attackText;
    }
}
