using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopIcons : MonoBehaviour
{
    public GameObject Panel;
    public GameObject TaskbarPanel;

    public void OpenApp()
    {
        if (Panel != null)
        {
            bool IsActive = Panel.activeSelf;
            Panel.SetActive(!IsActive);
        }

        if (TaskbarPanel != null)
        {
            bool IsActive = TaskbarPanel.activeSelf;
            TaskbarPanel.SetActive(!IsActive);
        }
    }

    public void CloseApp()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
            TaskbarPanel.SetActive(false);
        }
    }

    public void Tab()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

}
