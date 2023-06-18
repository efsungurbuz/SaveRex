using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rexControl : MonoBehaviour
{
    GameObject enemies;
    GameObject patlamaPrefab;
    GameObject enemyPrefab;
    const float movementPower = 10;

    void Update()
    {
        Vector3 position = transform.position; //Storing current position of the Player
     
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            position.x += horizontalInput * movementPower * Time.deltaTime;

        }
        if (verticalInput != 0)
        {
            position.y += verticalInput * movementPower * Time.deltaTime;
        }
        transform.position = position;
        transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}



