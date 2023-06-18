using UnityEngine;

public class AnimatorCreator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            animator.enabled = true; // Animator'� etkinle�tir
            // Di�er gerekli i�lemleri yapabilirsin
        }
        else
        {
            animator.enabled = false; // Animator'� devre d��� b�rak
            // Di�er gerekli i�lemleri yapabilirsin
        }
    }
}
