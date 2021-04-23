using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoachInfo : MonoBehaviour
{
    GameObject CoachNameTextUI;
    Text CoachNameComponent;
    
    GameObject SchoolNameTextUI;
    Text SchoolNameComponent;

    GameObject SchoolPrideNameTextUI;
    Text SchoolPrideNameComponent;

    // Start is called before the first frame update
    void Start()
    {
        CoachNameTextUI = GameObject.Find("Name Text");
        CoachNameComponent = CoachNameTextUI.GetComponent<Text>();

        SchoolNameTextUI = GameObject.Find("School Text");
        SchoolNameComponent = SchoolNameTextUI.GetComponent<Text>();

        SchoolPrideNameTextUI = GameObject.Find("School Pride Text");
        SchoolPrideNameComponent = SchoolNameTextUI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CoachNameComponent.text = "Name: " + PlayerPrefs.GetString("CoachNameString");

        SchoolNameComponent.text = "School: " + PlayerPrefs.GetString("SchoolNameString");

        SchoolPrideNameComponent.text = "School: " + PlayerPrefs.GetString("SchoolNameString");
    }
}
