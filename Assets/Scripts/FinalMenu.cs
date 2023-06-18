using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour
{

    public void EndGame()
    {
        SceneManager.LoadScene("Level1");

    }

}
