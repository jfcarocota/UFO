using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    [SerializeField]
    int points;

    public int Points
    {
        get
        {
           return points;
        }

        set
        {
            points = value;
        }
    }
}
