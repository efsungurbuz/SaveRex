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
            Trigger.text = "Tebrikler, üçüncü turu tamamladýnýz! 500TL ve üzeri alýþveriþe 50TL kupon kazandýnýz. \r\nKupon Kodunuz: REX50 \r\n Sonraki tura geçmek için Space tuþuna basýnýz.";
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
