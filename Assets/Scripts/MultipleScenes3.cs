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
            Trigger.text = "Tebrikler, oyunu tamamlad�n�z ve b�y�k �d�l� kazand�n�z! REX kategorisinden al��veri�e %10 indirim kuponu kazand�n�z. \r\n  \r\nKupon Kodunuz: REXX10 \r\n Tekrar oynamak i�in Space tu�una bas�n�z.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}
