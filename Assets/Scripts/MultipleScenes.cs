using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultipleScenes : MonoBehaviour
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
            Trigger.text = "Tebrikler, birinci turu tamamlad�n�z! 150TL ve �zeri al��veri�e 10TL kupon kazand�n�z. \r\nKupon Kodunuz: REX10  \r\n Sonraki tura ge�mek i�in Space tu�una bas�n�z.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
