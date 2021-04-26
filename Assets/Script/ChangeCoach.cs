using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCoach : MonoBehaviour
{

    public Image CoachPFP;

    public Sprite Coach0;
    public Sprite Coach1;

    public Sprite Coach2;
    public Sprite Coach3;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("CoachSelection") == 0)
        {
            CoachPFP.sprite = Coach0;
        }

        if (PlayerPrefs.GetInt("CoachSelection") == 1)
        {
            CoachPFP.sprite = Coach1;
        }

        if (PlayerPrefs.GetInt("CoachSelection") == 2)
        {
            CoachPFP.sprite = Coach2;
        }

        if (PlayerPrefs.GetInt("CoachSelection") == 3)
        {
            CoachPFP.sprite = Coach3;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
