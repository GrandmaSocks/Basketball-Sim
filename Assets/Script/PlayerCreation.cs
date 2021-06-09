using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreation : MonoBehaviour
{
    public Sprite PlayerClothing0;
    public Sprite PlayerClothing1;

    public Sprite PlayerClothing2;
    public Sprite PlayerClothing3;
    public Image PlayerImage;

    GameObject NameText;
    Text NameTextComp;

    GameObject AgeText;
    Text AgeTextComp;

    GameObject PositionText;
    Text PositionTextComp;
    
    GameObject OverallText;
    Text OverallTextComp;

    GameObject SkillsText;
    Text SkillsTextComp;

    void GenPlayerLook()
    {
        int RandNum = Random.Range(0, 3);
        Debug.Log(RandNum);

        if (RandNum == 0)
        {
            PlayerImage.sprite = PlayerClothing0;
        }

        if (RandNum == 1)
        {
            PlayerImage.sprite = PlayerClothing1;
        }

        if (RandNum == 2)
        {
            PlayerImage.sprite = PlayerClothing2;
        }

        if (RandNum == 3)
        {
            PlayerImage.sprite = PlayerClothing3;
        }
    }

    void GenPlayerStats()
    {
        // WARNING: Bad lazy random number generatation

        int ThreePointStat = 0;
        int MidRangeStat = 0;
        int FinishingStat = 0;
        int PlaymakingStat = 0;
        int DefenseStat = 0;
        int AthleticismStat = 0;

        int ThreeNum = Random.Range(40, 99);
        int MidRangeNum = Random.Range(40, 99);
        int FinishingNum = Random.Range(40, 99);
        int DefenseNum = Random.Range(40, 99);
        int PlaymakingNum = Random.Range(40, 99);
        int AthleticismNum = Random.Range(40, 99);

        ThreePointStat = ThreeNum;
        MidRangeStat = MidRangeNum;
        FinishingStat = FinishingNum;
        PlaymakingStat = PlaymakingNum;
        DefenseStat = DefenseNum;
        AthleticismStat = AthleticismNum;

        int PlayerOverall = (ThreePointStat + MidRangeStat + FinishingStat + PlaymakingStat + DefenseStat + AthleticismStat) / 5; // Only divide by 5 instead of 6 so there are less garbage players

        // END OF STAT GENERATION

        // Beginning of Name Generation

        string[] FirstNames =  new string[] { "Adam", "Alex", "Aaron", "Ben", "Carl", "Dan", "David", "Edward", "Fred", "Frank", "George", "Hal", "Hank", "Ike", "John", "Jack", "Joe", "Larry", "Monte", "Matthew", "Mark", "Nathan", "Otto", "Paul", "Peter", "Roger", "Roger", "Steve", "Thomas", "Tim", "Ty", "Victor", "Walter"};   
	
        string[] LastNames = new string[] { "Anderson", "Ashwoon", "Aikin", "Bateman", "Bongard", "Bowers", "Boyd", "Cannon", "Cast", "Deitz", "Dewalt", "Ebner", "Frick", "Hancock", "Haworth", "Hesch", "Hoffman", "Kassing", "Knutson", "Lawless", "Lawicki", "Mccord", "McCormack", "Miller", "Myers", "Nugent", "Ortiz", "Orwig", "Ory", "Paiser", "Pak", "Pettigrew", "Quinn", "Quizoz", "Ramachandran", "Resnick", "Sagar", "Schickowski", "Schiebel", "Sellon", "Severson", "Shaffer", "Solberg", "Soloman", "Sonderling", "Soukup", "Soulis", "Stahl", "Sweeney", "Tandy", "Trebil", "Trusela", "Trussel", "Turco", "Uddin", "Uflan", "Ulrich", "Upson", "Vader", "Vail", "Valente", "Van Zandt", "Vanderpoel", "Ventotla", "Vogal", "Wagle", "Wagner", "Wakefield", "Weinstein", "Weiss", "Woo", "Yang", "Yates", "Yocum", "Zeaser", "Zeller", "Ziegler", "Bauer", "Baxster", "Casal", "Cataldi", "Caswell", "Celedon", "Chambers", "Chapman", "Christensen", "Darnell", "Davidson", "Davis", "DeLorenzo", "Dinkins", "Doran", "Dugelman", "Dugan", "Duffman", "Eastman", "Ferro", "Ferry", "Fletcher", "Fietzer", "Hylan", "Hydinger", "Illingsworth", "Ingram", "Irwin", "Jagtap", "Jenson", "Johnson", "Johnsen", "Jones", "Jurgenson", "Kalleg", "Kaskel", "Keller", "Leisinger", "LePage", "Lewis", "Linde", "Lulloff", "Maki", "Martin", "McGinnis", "Mills", "Moody", "Moore", "Napier", "Nelson", "Norquist", "Nuttle", "Olson", "Ostrander", "Reamer", "Reardon", "Reyes", "Rice", "Ripka", "Roberts", "Rogers", "Root", "Sandstrom", "Sawyer", "Schlicht", "Schmitt", "Schwager", "Schutz", "Schuster", "Tapia", "Thompson", "Tiernan", "Tisler" };

        string[] Ages = new string[] { "14", "15", "16", "17", "18"};

        string[] Positions = new string[] { "Point Guard", "Shooting Guard", "Small Forward", "Power Forward", "Center" };

        string PlayerFirstName = "John";
        string PlayerLastName = "Doe";
        string PlayerAge = "21";
        string PlayerPosition = "Point Guard";

        PlayerFirstName = FirstNames[Random.Range(0, FirstNames.Length)];
        PlayerLastName = LastNames[Random.Range(0, LastNames.Length)];

        string PlayerFullName = PlayerFirstName + " " + PlayerLastName; 

        PlayerAge = Ages[Random.Range(0, Ages.Length)];
        PlayerPosition = Positions[Random.Range(0, Positions.Length)];

        NameTextComp.text = "Name: " + PlayerFullName;
        AgeTextComp.text = "Age: " + PlayerAge;
        PositionTextComp.text = "Position: " + PlayerPosition;
        OverallTextComp.text = "Overall: " + PlayerOverall;

        // Skills Indentification 

        string SkillsString = "";

        if (ThreePointStat > 85)
            SkillsString = SkillsString + " Three Point,";

        if (MidRangeStat > 85)
            SkillsString = SkillsString + " Mid Range,";

        if (FinishingStat > 85)
            SkillsString = SkillsString + " Finishing,";
        
        if (PlaymakingStat > 85)
            SkillsString = SkillsString + " Playmaking,";

        if (DefenseStat > 85)
            SkillsString = SkillsString + " Defense,";
        
        if (AthleticismStat > 85)
            SkillsString = SkillsString + " Athleticism,";

        if (SkillsString == "")
            SkillsString = "None";

        SkillsTextComp.text = "Skills: " + SkillsString;

    }

    void Start() 
    {
        NameText = GameObject.Find("Player Name Text");
        NameTextComp = NameText.GetComponent<Text>();

        AgeText = GameObject.Find("Age Text");
        AgeTextComp = AgeText.GetComponent<Text>();

        PositionText = GameObject.Find("Position Text");
        PositionTextComp = PositionText.GetComponent<Text>();

        OverallText = GameObject.Find("Overall Text");
        OverallTextComp = OverallText.GetComponent<Text>();

        SkillsText = GameObject.Find("Skills Text");
        SkillsTextComp = SkillsText.GetComponent<Text>();

        GenPlayerLook();
        GenPlayerStats();
    }

    void Update() 
    {
        
    }

}
