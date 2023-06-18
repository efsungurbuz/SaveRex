using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab;
    [SerializeField]
    public GameObject button;
    Counter BossDestroyCounter;

    public float moveDistance = 10f; // Saða sola hareket edeceði mesafe
    public float moveSpeed = 2f; // Hareket hýzý

    private Vector3 initialPosition; // Baþlangýç pozisyonu
    private bool movementToTheRight = false; // Saða mý hareket ediyoruz?

    void Start()
    {
        button.SetActive(false);
        initialPosition = transform.position;
        BossDestroyCounter = gameObject.AddComponent<Counter>();
        BossDestroyCounter.TotalTime = 2;
        BossDestroyCounter.Start();
    }

    void Update()
    {
        // Random movement to the left or right
        if (movementToTheRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Distance control
        if (Mathf.Abs(transform.position.x - initialPosition.x) >= moveDistance)
        {
            movementToTheRight = !movementToTheRight;
        }
    }
  
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rex")
        {
            Destroy(collision.gameObject);
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            button.SetActive(true);
        }
        else if (collision.gameObject.tag == "MainCamera")
        {     
        }
    }

}
