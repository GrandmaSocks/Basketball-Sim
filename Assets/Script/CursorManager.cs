using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D CursorTexture;
    public CursorMode CursorMode = CursorMode.Auto;
    public Vector2 HotSpot = Vector2.zero;
    void OnMouseEnter()
    {
        Cursor.SetCursor(CursorTexture, HotSpot, CursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(CursorTexture, HotSpot, CursorMode);
    }
}
