using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCounter : MonoBehaviour
{

    Counter counter;

    void Start()
    {
        counter = gameObject.AddComponent<Counter>();
        counter.TotalTime = 1;
        counter.Start();
    }
    void Update()
    {
        if (counter.Over)
        {
            Destroy(gameObject);
        }
    }
}
