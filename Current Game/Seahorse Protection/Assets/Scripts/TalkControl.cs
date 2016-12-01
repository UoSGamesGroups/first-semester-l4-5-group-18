using UnityEngine;
using System.Collections;

public class TalkControl : MonoBehaviour {
    public GUISkin theSkin;
    public Vector2 TextPos = new Vector2(Screen.width/2 -50, Screen.height-100);
    public string[,] Speach = new string[15, 3];


    public int Item =0, Next = 0;
    public bool Talking = false;
    public CharacterControl Char;
    public Barcontrol Comfort;
    public int SwitchValue;
    public LighteningControl Light;

    void Start() {
        Light = GetComponent<LighteningControl>();
        Speach[0, 0] = "Not everyone has one";
        Speach[0, 1] = "I used to be in a band";
        Speach[0, 2] = "It has a long neck";

        Speach[1, 0] = "Not everyone has one";
        Speach[1, 1] = "I used to be in a band";
        Speach[1, 2] = "I blow into it";

        Speach[2, 0] = "It is a bit of clothing";
        Speach[2, 1] = "I wear it on my head";
        Speach[2, 2] = "Boater hat Clue3";

        Speach[3, 0] = "It is a bit of clothing";
        Speach[3, 1] = "I wear it on my head";
        Speach[3, 2] = "It is big and black";

        Speach[4, 0] = "It is a bit of clothing";
        Speach[4, 1] = "It has a hole in it";
        Speach[4, 2] = "It is a long tie";

        Speach[5, 0] = "It is a bit of clothing";
        Speach[5, 1] = "It has a hole in it";
        Speach[5, 2] = "It is bright pink";

        Speach[6, 0] = "It is a bit of clothing";
        Speach[6, 1] = "It has a hole in it";
        Speach[6, 2] = "It goes on my feet";

        Speach[7, 0] = "It is a bit of clothing";
        Speach[7, 1] = "It has a hole in it";
        Speach[7, 2] = "It covers both of my eyes";
    
        Speach[8, 0] = "It is a bit of clothing";
        Speach[8, 1] = "It has a hole in it";
        Speach[8, 2] = "It only covers 1 eye";

        Speach[9, 0] = "It is a bit of clothing";
        Speach[9, 1] = "It has a hole in it";
        Speach[9, 2] = "It goes on my finger";

        Speach[10, 0] = "It is an odd colour";
        Speach[10, 1] = "It is food";
        Speach[10,2] = "It should be yellow on the outside";
    
        Speach[11, 0] = "It is an odd colour";
        Speach[11, 1] = "It is food";
        Speach[11, 2] = "They can be green or red";

        Speach[12, 0] = "It is an odd colour";
        Speach[12, 1] = "It is shiny";
        Speach[12, 2] = "It is white in colour";

        Speach[13, 0] = "It is an odd colour";
        Speach[13, 1] = "It is shiny";
        Speach[13, 2] = "It is very green";

        Speach[14, 0] = "It is an odd colour";
        Speach[14, 1] = "It is shiny";
        Speach[14, 2] = "Is has a deep blue colour";
    }
 
    void Update() {
        int test = Char.CurrentCharacter;
        Item = Char.Characters[test, 1] ;
        SwitchValue = (int) Comfort.ComfortLevel[Char.CurrentCharacter];
        if(Comfort.ComfortLevel[Char.CurrentCharacter]>0 && Comfort.ComfortLevel[Char.CurrentCharacter] < 3) { Next = 0; }
        else if (Comfort.ComfortLevel[Char.CurrentCharacter] > 3 && Comfort.ComfortLevel[Char.CurrentCharacter] < 6) { Next = 1; }
        else if (Comfort.ComfortLevel[Char.CurrentCharacter] > 6 && Comfort.ComfortLevel[Char.CurrentCharacter] < 8) { Next = 2; }
    }

    void OnGUI()
    {
        GUI.skin = theSkin;
        if (Talking)
        {
            GUI.Label(new Rect(TextPos.x, TextPos.y, 1000, 1000), Speach[Item, Next]);
        }
    }
}
