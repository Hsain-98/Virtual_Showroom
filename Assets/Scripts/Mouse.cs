using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D defaultCursor;
    public Texture2D handCursor;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpotMouse = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(defaultCursor, hotSpotMouse, cursorMode);
    }

    
    void OnMouseOver()
    {
        Cursor.SetCursor(handCursor, hotSpotMouse, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursor, hotSpotMouse, cursorMode);
    }
}
