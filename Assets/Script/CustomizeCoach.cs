using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeCoach : MonoBehaviour
{
    public InputField CoachNameInput;
    public static string CoachNameString;

    public InputField SchoolNameInput;
    public static string SchoolNameString;

    public static int CoachSelection = 0;
    public static int SchoolSelection = 0;

    public static Image CoachPFP;

    public Image PreviewImage;
    public Sprite Coach0;
    public Sprite Coach1;

    void Start()
    {
        if (CoachNameString != null)
        {
            CoachNameInput.text = "John Doe";
        }

        if (SchoolNameString != null)
        {
            SchoolNameInput.text = "Baller High";
        }

        PreviewImage = gameObject.GetComponent<Image>();

    }

    public void CoachLeft()
    {
        if (CoachSelection >= 1)
        {
            CoachSelection--;
            Debug.Log("Coach Selection: " + CoachSelection);
            ChangeCoachPreview();
        }
    }

    public void CoachRight()
    {   
        CoachSelection++;
        Debug.Log("Coach Selection: " + CoachSelection);
        ChangeCoachPreview();
    }

    public void SchoolLeft()
    {
        SchoolSelection--;
        Debug.Log("School Selection: " + SchoolSelection);
    }

    public void SchoolRight()
    {
        SchoolSelection++;
        Debug.Log("School Selection: " + SchoolSelection);
    }
    
    public void SaveSelections()
    {
        PlayerPrefs.SetInt("SchoolSelection", SchoolSelection);
        PlayerPrefs.SetInt("CoachSelection", CoachSelection);
        PlayerPrefs.SetString("CoachNameString", CoachNameInput.text);
        PlayerPrefs.SetString("SchoolNameString", SchoolNameInput.text);
    }

    public void ChangeCoachPreview()
    {
        if (CoachSelection == 0)
        {
            PreviewImage.sprite = Coach0;
        }

        if (CoachSelection == 1)
        {
            PreviewImage.sprite = Coach1;
        }
    }
}