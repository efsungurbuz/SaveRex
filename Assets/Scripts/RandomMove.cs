using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public float speed = 2f; // hareket hýzý

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // objeyi ileri hareket ettirir
        transform.Translate(Vector3.back * Time.deltaTime * speed); // objeyi geri hareket ettirir
    }
}