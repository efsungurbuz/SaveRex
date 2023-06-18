using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{

    [SerializeField]
    GameObject patlamaPrefab;

    Counter destroyerCounter;
    public GameObject button;

    void Start()
    {

        button.SetActive(false);
        destroyerCounter = gameObject.AddComponent<Counter>();
        destroyerCounter.TotalTime = Random.Range(1, 5);
        destroyerCounter.Start();
        
       
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rex")
        {
            Destroy(collision.gameObject);
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Object.Destroy(gameObject, 1f);

            button.SetActive(true);
           
        }

    }

}



