using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorMaker : MonoBehaviour
{
    // Start is called before the first frame update
    public Image panel; 

    void Start()
    {
        panel.color = new Color(PlayerPrefs.GetFloat("CustomColorR"),PlayerPrefs.GetFloat("CustomColorG"),PlayerPrefs.GetFloat("CustomColorB"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
