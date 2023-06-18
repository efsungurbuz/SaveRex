using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rex")
        {
            Destroy(collision.gameObject);
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "MainCamera")
        {     
        }
    }
}
