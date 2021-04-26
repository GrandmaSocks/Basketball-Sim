using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public Image CoachClothes;
    public ColorPicker colorPicker;
    void Start()
    {
        CoachClothes = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        CoachClothes.color = colorPicker.color;
               PlayerPrefs.SetFloat("CustomColorR", colorPicker.color.r);
        PlayerPrefs.SetFloat("CustomColorG", colorPicker.color.g);
        PlayerPrefs.SetFloat("CustomColorB", colorPicker.color.b);
    }

    public void SaveColors()
    {
        PlayerPrefs.SetFloat("CustomColorR", colorPicker.color.r);
        PlayerPrefs.SetFloat("CustomColorG", colorPicker.color.g);
        PlayerPrefs.SetFloat("CustomColorB", colorPicker.color.b);
    }
}
