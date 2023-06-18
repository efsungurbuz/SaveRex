using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CursorHover: MonoBehaviour
{

    /// <summary>
    /// This script is used for the setting the normal and hover cursor
    /// </summary>
    public Texture2D cursorNormal;
    public Vector2 normalCursorHotspot;

    public Texture2D cursorClicked;
    public Vector2 cursorClickedHotspot;
 
    public void OnButttonCursorEnter() {

        Cursor.SetCursor(cursorClicked, cursorClickedHotspot, CursorMode.Auto);
    }
    public void OnButttonCursorExit()
    {
        Cursor.SetCursor(cursorNormal, normalCursorHotspot, CursorMode.Auto);

    }
}
