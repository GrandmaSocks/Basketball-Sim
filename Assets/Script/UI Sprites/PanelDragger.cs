using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
 
public class PanelDragger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    public Transform Target;
    private bool IsMouseDown = false;
    private Vector3 StartMousePosition;
    private Vector3 StartPosition;
    public bool ShouldReturn;
 
    public void OnPointerDown(PointerEventData dt) 
    {
        IsMouseDown = true;
 
        StartPosition = Target.position;
        StartMousePosition = Input.mousePosition;
    }
 
    public void OnPointerUp(PointerEventData dt)
     { 
        IsMouseDown = false;
 
        if (ShouldReturn) 
        {
            Target.position = StartPosition;
        }
    }
 
    // Update is called once per frame
    void Update ()
     {
        if (IsMouseDown)
         {
            Vector3 currentPosition = Input.mousePosition;
 
            Vector3 diff = currentPosition - StartMousePosition;
 
            Vector3 pos = StartPosition + diff;
 
            Target.position = pos;
        }
    }
}