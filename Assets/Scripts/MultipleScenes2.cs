using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultipleScenes2 : MonoBehaviour
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
            Trigger.text = "Tebrikler, ���nc� turu tamamlad�n�z! 500TL ve �zeri al��veri�e 50TL kupon kazand�n�z. \r\nKupon Kodunuz: REX50 \r\n Sonraki tura ge�mek i�in Space tu�una bas�n�z.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
