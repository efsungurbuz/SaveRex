using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadButtonControl : MonoBehaviour
{
    public Destroyer destroyer;


    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //destroyer.HideReloadButton();
    }
   
}
