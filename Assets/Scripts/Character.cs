using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string health;  // Set this value to "High" or "Low"
    private string enemy_distance; // This can be "Close", or "Far"

    public Character(string health, string enemy_distance)
    {
        this.health = health;
        this.enemy_distance = enemy_distance;
    }

    public void MakeDecision()
    {
        if (enemy_distance == "Far")
        {
            Debug.Log("Attack");
        }
        else if (enemy_distance == "Close" && health == "High")
        {
            Debug.Log("Attack");
        }
        else if (enemy_distance == "Close" && health == "Low")
        {
            Debug.Log("Retreat");
        }
    }
}