using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultipleScenes3 : MonoBehaviour
{
    public string LevelName;
    public Text Trigger;


    private bool isTriggered = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isTriggered)
        {
            LoadNextLevel();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "rex" && !isTriggered)
        {
            isTriggered = true;
            Trigger.text = "Tebrikler, oyunu tamamladýnýz ve büyük ödülü kazandýnýz! REX kategorisinden alýþveriþe %10 indirim kuponu kazandýnýz. \r\n  \r\nKupon Kodunuz: REXX10 \r\n Tekrar oynamak için Space tuþuna basýnýz.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}
