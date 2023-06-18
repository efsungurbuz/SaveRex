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
            Trigger.text = "Tebrikler, birinci turu tamamladýnýz! 150TL ve üzeri alýþveriþe 10TL kupon kazandýnýz. \r\nKupon Kodunuz: REX10  \r\n Sonraki tura geçmek için Space tuþuna basýnýz.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
