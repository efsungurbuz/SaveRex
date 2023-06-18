using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControl : MonoBehaviour
{
    GameObject enemyPrefab;
    void Start()
    {
        Rigidbody2D myRigidBody2d = GetComponent<Rigidbody2D>();
        float randomX = UnityEngine.Random.Range(4f, 10f); // Random movement for X axis
        float randomY = UnityEngine.Random.Range(4f, 10f); // Random movement for Y axis
        myRigidBody2d.AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
    }



}