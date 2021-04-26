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

    public Image CoachPFP;

    public Sprite Coach0;
    public Sprite Coach1;

    public Sprite Coach2;
    public Sprite Coach3;

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

    }

    public void CoachLeft()
    {
        if (CoachSelection >= 1)
        {
            CoachSelection--;
            Debug.Log("Coach Selection: " + CoachSelection);

            if (CoachSelection == 0)
            {
                CoachPFP.sprite = Coach0;
            }

            if (CoachSelection == 1)
            {
                CoachPFP.sprite = Coach1;
            }

            if (CoachSelection == 2)
            {
                CoachPFP.sprite = Coach2;
            }

            if (CoachSelection == 3)
            {
                CoachPFP.sprite = Coach3;
            }
        }
    }

    public void CoachRight()
    {   
        if (CoachSelection <= 3)
        {
            CoachSelection++;
            Debug.Log("Coach Selection: " + CoachSelection);
            
            if (CoachSelection == 0)
            {
                CoachPFP.sprite = Coach0;
            }

            if (CoachSelection == 1)
            {
                CoachPFP.sprite = Coach1;
            }

            if (CoachSelection == 2)
            {
                CoachPFP.sprite = Coach2;
            }

            if (CoachSelection == 3)
            {
                CoachPFP.sprite = Coach3;
            }
        }
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
            CoachPFP.sprite = Coach0;
        }

        if (CoachSelection == 1)
        {
            CoachPFP.sprite = Coach1;
        }

        if (CoachSelection == 2)
        {
            CoachPFP.sprite = Coach2;
        }

        if (CoachSelection == 3)
        {
            CoachPFP.sprite = Coach3;
        }
    }
}