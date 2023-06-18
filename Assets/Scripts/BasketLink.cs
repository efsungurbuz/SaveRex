using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketLink : MonoBehaviour
{
    public string url = "https://www.robotistan.com/r-647";
    public GameObject textObject;

    public void OpenLink()
    {
        Application.OpenURL(url);
        textObject.SetActive(false);
    }

    public void ShowText()
    {
        // Text objesini etkinle�tir
        textObject.SetActive(true);
    }

}
